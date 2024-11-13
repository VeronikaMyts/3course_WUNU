import { Api } from '../api.js';

const apiKey = '21fd738a2ca8848ab6af33b0fb4b1d21';
const api = new Api(apiKey);

export const renderMoviePage = async (movieId) => {
    const movieDetails = await api.fetchMovieDetails(movieId);
    const recommendations = await api.fetchMovieRecommendations(movieId);
    const app = document.getElementById('app');
    
    // Виводимо інформацію про фільм
    app.innerHTML = `
        <h2>${movieDetails.title}</h2>
        <img src="https://image.tmdb.org/t/p/w500${movieDetails.poster_path}" alt="${movieDetails.title}">
        <p>${movieDetails.overview}</p>
        <button class="bookmark-btn">
            <i class="${isBookmarked(movieDetails.id) ? 'fas' : 'far'} fa-heart"></i> 
            ${isBookmarked(movieDetails.id) ? 'Remove from bookmarks' : 'Add to bookmarks'}
        </button>
        <h3>Recommendations:</h3>
        <div id="recommendations"></div>
    `;

    // Додаємо рекомендації
    const recommendationsContainer = document.getElementById('recommendations');
    recommendations.forEach(movie => {
        const movieElement = document.createElement('div');
        movieElement.classList.add('movie');
        movieElement.dataset.movieId = movie.id;
        movieElement.innerHTML = `
            <img src="https://image.tmdb.org/t/p/w500${movie.poster_path}" alt="${movie.original_title}">
            <h3>${movie.original_title}</h3>
        `;
        recommendationsContainer.appendChild(movieElement);

        // Обробник кліку для відображення деталей фільму
        movieElement.addEventListener('click', () => {
            window.history.pushState({}, '', `/movies/${movie.id}`);
            renderMoviePage(movie.id);
        });
    });

    // Обробник натискання на кнопку закладок
    const bookmarkBtn = document.querySelector('.bookmark-btn');
    bookmarkBtn.addEventListener('click', (e) => {
        e.stopPropagation();  // Запобігаємо переходу на іншу сторінку
        toggleBookmark(movieDetails, bookmarkBtn);
    });
};

// Функція для додавання/видалення фільмів із закладок
const toggleBookmark = (movie, bookmarkBtn) => {
    let bookmarks = JSON.parse(localStorage.getItem('bookmarks')) || [];
    
    if (isBookmarked(movie.id)) {
        bookmarks = bookmarks.filter(item => item.id !== movie.id);  // Видаляємо фільм із закладок
    } else {
        bookmarks.push(movie);  // Додаємо фільм до закладок
    }

    // Оновлюємо закладки в localStorage
    localStorage.setItem('bookmarks', JSON.stringify(bookmarks));

    // Оновлюємо клас і текст кнопки
    bookmarkBtn.querySelector('i').classList.toggle('fas');
    bookmarkBtn.querySelector('i').classList.toggle('far');
    bookmarkBtn.textContent = isBookmarked(movie.id) ? 'Remove from bookmarks' : 'Add to bookmarks';
};

// Перевірка, чи є фільм у закладках
const isBookmarked = (movieId) => {
    const bookmarks = JSON.parse(localStorage.getItem('bookmarks')) || [];
    return bookmarks.some(item => item.id === movieId);
};
