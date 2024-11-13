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

        // Обробник кліку для відображення деталей фільму
        movieElement.addEventListener('click', () => {
            window.history.pushState({}, '', `/movies/${movie.id}`);
            renderMoviePage(movie.id);  // Завантажуємо подробиці фільму після кліку
        });

        const bookmarkBtn = movieElement.querySelector('.bookmark-btn');
        bookmarkBtn.addEventListener('click', (e) => {
            e.stopPropagation(); // Запобігаємо переходу на сторінку фільму
            toggleBookmark(movie, bookmarkBtn);
        });
    });
};

// Функція для додавання/видалення фільмів з закладок
const toggleBookmark = (movie, bookmarkBtn) => {
    let bookmarks = JSON.parse(localStorage.getItem('bookmarks')) || [];
    
    if (isBookmarked(movie.id)) {
        bookmarks = bookmarks.filter(item => item.id !== movie.id);  // Видаляємо фільм із закладок
    } else {
        bookmarks.push(movie);  // Додаємо фільм до закладок
    }

    // Оновлюємо закладки в localStorage
    localStorage.setItem('bookmarks', JSON.stringify(bookmarks));

    // Зміна іконки в залежності від того, чи є фільм у закладках
    bookmarkBtn.querySelector('i').classList.toggle('fas');
    bookmarkBtn.querySelector('i').classList.toggle('far');
};

// Перевірка, чи є фільм у закладках
const isBookmarked = (movieId) => {
    const bookmarks = JSON.parse(localStorage.getItem('bookmarks')) || [];
    return bookmarks.some(item => item.id === movieId);
};
