import { renderMoviePage } from './movie.js';

export const renderBookmarksPage = () => {
    const app = document.getElementById('app');
    const bookmarks = JSON.parse(localStorage.getItem('bookmarks')) || [];

    app.innerHTML = '<h2>Your Bookmarks</h2>';
    if (bookmarks.length === 0) {
        app.innerHTML += '<p>No bookmarks yet.</p>';
        return;
    }

    bookmarks.forEach(movie => {
        const movieElement = document.createElement('div');
        movieElement.classList.add('movie');
        movieElement.dataset.movieId = movie.id;
        movieElement.innerHTML = `
            <img src="https://image.tmdb.org/t/p/w500${movie.poster_path}" alt="${movie.title}">
            <h3>${movie.title}</h3>
            <p>${movie.overview}</p>
            <button class="bookmark-btn">
                <i class="fas fa-heart"></i>
            </button>
        `;
        app.appendChild(movieElement);

        movieElement.addEventListener('click', () => {
            window.history.pushState({}, '', `/movies/${movie.id}`);
            renderMoviePage(movie.id);
        });

        const bookmarkBtn = movieElement.querySelector('.bookmark-btn');
        bookmarkBtn.addEventListener('click', (e) => {
            e.stopPropagation(); // Запобігаємо переходу на сторінку фільму
            toggleBookmark(movie.id);
            movieElement.remove(); // Видаляємо фільм зі сторінки
        });
    });
};

const toggleBookmark = (movieId) => {
    let bookmarks = JSON.parse(localStorage.getItem('bookmarks')) || [];
    bookmarks = bookmarks.filter(item => item.id !== movieId);
    localStorage.setItem('bookmarks', JSON.stringify(bookmarks));
};
