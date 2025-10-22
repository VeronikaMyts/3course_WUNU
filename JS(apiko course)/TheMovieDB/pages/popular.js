import { Api } from '../api.js';
import { renderMoviePage } from './movie.js';

const apiKey = '21fd738a2ca8848ab6af33b0fb4b1d21';
const api = new Api(apiKey);

export const renderPopularPage = async () => {
    const movies = await api.fetchPopularMovies();
    const app = document.getElementById('app');
    app.innerHTML = '<h2>Popular Movies</h2>';

    movies.forEach(movie => {
        const movieElement = document.createElement('div');
        movieElement.classList.add('movie');
        movieElement.dataset.movieId = movie.id;
        movieElement.innerHTML = `
            <img src="https://image.tmdb.org/t/p/w500${movie.poster_path}" alt="${movie.original_title}">
            <h3>${movie.original_title}</h3>
            <button class="bookmark-btn">
                <i class="${isBookmarked(movie.id) ? 'fas' : 'far'} fa-heart"></i>
            </button>
        `;
        app.appendChild(movieElement);

       
        movieElement.addEventListener('click', () => {
            window.history.pushState({}, '', `/movies/${movie.id}`);
            renderMoviePage(movie.id);  
        });

        const bookmarkBtn = movieElement.querySelector('.bookmark-btn');
        bookmarkBtn.addEventListener('click', (e) => {
            e.stopPropagation(); 
            toggleBookmark(movie, bookmarkBtn);
        });
    });
};


const toggleBookmark = (movie, bookmarkBtn) => {
    let bookmarks = JSON.parse(localStorage.getItem('bookmarks')) || [];
    
    if (isBookmarked(movie.id)) {
        bookmarks = bookmarks.filter(item => item.id !== movie.id);  
    } else {
        bookmarks.push(movie);  
    }

    
    localStorage.setItem('bookmarks', JSON.stringify(bookmarks));

   
    bookmarkBtn.querySelector('i').classList.toggle('fas');
    bookmarkBtn.querySelector('i').classList.toggle('far');
};


const isBookmarked = (movieId) => {
    const bookmarks = JSON.parse(localStorage.getItem('bookmarks')) || [];
    return bookmarks.some(item => item.id === movieId);
};
