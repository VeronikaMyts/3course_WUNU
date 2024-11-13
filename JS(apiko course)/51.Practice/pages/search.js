import { Api } from '../api.js';
import { renderMoviePage } from './movie.js';

const apiKey = '21fd738a2ca8848ab6af33b0fb4b1d21';
const api = new Api(apiKey);

export const renderSearchPage = async () => {
    const app = document.getElementById('app');
    const query = new URLSearchParams(window.location.search).get('query');
    const searchInput = document.getElementById('search-input'); 

    if (!query) {
        app.innerHTML = '<p>Please enter a search term.</p>';
        return;
    }

    app.innerHTML = '<p>Loading search results...</p>';

    try {
        const results = await api.fetchSearchResults(query);
        app.innerHTML = `<h2>Search results for "${query}"</h2>`;

        results.forEach(movie => {
            const movieElement = document.createElement('div');
            movieElement.classList.add('movie');
            movieElement.dataset.movieId = movie.id;
            movieElement.innerHTML = `
                <img src="https://image.tmdb.org/t/p/w500${movie.poster_path}" alt="${movie.title}">
                <h3>${movie.title}</h3>
                <button class="bookmark-btn">
                    <i class="${isBookmarked(movie.id) ? 'fas' : 'far'} fa-heart"></i>
                </button>
            `;
            app.appendChild(movieElement);

            movieElement.addEventListener('click', () => {
               
                app.innerHTML = '<p>Loading movie details...</p>';
               
                renderMoviePage(movie.id);
            });

            const bookmarkBtn = movieElement.querySelector('.bookmark-btn');
            bookmarkBtn.addEventListener('click', (e) => {
                e.stopPropagation();
                toggleBookmark(movie, bookmarkBtn);
            });
        });

        
        searchInput.value = ''; 

    } catch (error) {
        app.innerHTML = '<p>Error loading search results.</p>';
        console.error(error);
    }
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


