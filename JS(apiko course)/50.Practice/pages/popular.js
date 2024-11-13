
import { Api } from '../api.js';
import { renderMoviePage } from './movie.js';

const apiKey = '21fd738a2ca8848ab6af33b0fb4b1d21'; 
const api = new Api(apiKey);

export const renderPopularPage = async () => {
    const movies = await api.fetchPopularMovies();
    const moviesContainer = document.getElementById('content');
    moviesContainer.innerHTML = '';

    movies.forEach(movie => {
        const movieElement = document.createElement('div');
        movieElement.classList.add('movie');
        movieElement.dataset.movieId = movie.id; 
        movieElement.innerHTML = `
            <img src="https://image.tmdb.org/t/p/w500${movie.poster_path}" alt="${movie.original_title}">
            <h3>${movie.original_title}</h3>
        `;

       
        movieElement.addEventListener('click', () => {
            console.log('Movie ID:', movie.id); 
            if (movie.id) {
                window.history.pushState({}, '', `/movies/${movie.id}`); 
                renderMoviePage(movie.id);
            }
        });

        moviesContainer.appendChild(movieElement);
    });
};

document.getElementById('back-to-home').addEventListener('click', () => {
   
    window.history.pushState({}, '', '/');
   
    window.location.reload(); 
});




