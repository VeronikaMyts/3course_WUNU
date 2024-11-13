// pages/movie.js
import { Api } from '../api.js';

const apiKey = '21fd738a2ca8848ab6af33b0fb4b1d21';
const api = new Api(apiKey);

export const renderMoviePage = async (movieId) => {
    if (!movieId) {
        console.error('Movie ID is missing');
        return;
    }

    try {
        console.log('Fetching movie details for ID:', movieId); // Log movieId
        const movieDetails = await api.fetchMovieDetails(movieId);
        const moviesContainer = document.getElementById('content');

        // Safely access genres and provide fallback if necessary
        const genres = movieDetails.genres && Array.isArray(movieDetails.genres)
            ? movieDetails.genres.map(genre => genre.name).join(', ')
            : 'N/A';

        moviesContainer.innerHTML = `
            <img src="https://image.tmdb.org/t/p/w500${movieDetails.poster_path}" alt="${movieDetails.original_title}">
            <h3>${movieDetails.original_title}</h3>
            <p>Rating: ${movieDetails.vote_average}</p>
            <p>${movieDetails.overview}</p>
            <p>Genres: ${genres}</p>
        `;
    } catch (error) {
        console.error('Error rendering movie page:', error);
        const moviesContainer = document.getElementById('content');
        moviesContainer.innerHTML = '<p>Sorry, there was an error loading the movie details.</p>';
    }
};



