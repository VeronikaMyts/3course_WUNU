// pages/popular.js
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
        movieElement.dataset.movieId = movie.id; // Add data-attribute with movieId
        movieElement.innerHTML = `
            <img src="https://image.tmdb.org/t/p/w500${movie.poster_path}" alt="${movie.original_title}">
            <h3>${movie.original_title}</h3>
        `;

        // Add click listener to navigate to the movie detail page
        movieElement.addEventListener('click', () => {
            console.log('Movie ID:', movie.id); // Log movie ID to check its value
            if (movie.id) {
                window.history.pushState({}, '', `/movies/${movie.id}`); // Update the URL with movieId
                renderMoviePage(movie.id); // Render movie details for the clicked movie
            }
        });

        moviesContainer.appendChild(movieElement);
    });
};

document.getElementById('back-to-home').addEventListener('click', () => {
    // Використовуємо window.history.pushState для зміни URL
    window.history.pushState({}, '', '/');
    // Оновлюємо сторінку (можна викликати reroute або перезавантажити сторінку)
    window.location.reload(); // Або ви можете викликати router.reroute() якщо використовуєте маршрутизатор
});




