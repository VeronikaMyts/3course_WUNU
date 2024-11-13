class Api {
    constructor(apiKey) {
        this.apiKey = apiKey;
        this.baseUrl = 'https://api.themoviedb.org/3';
    }

    async fetchPopularMovies() {
        const url = `${this.baseUrl}/movie/popular?api_key=${this.apiKey}&language=en-US&page=1`;
        const response = await fetch(url);
        const data = await response.json();
        return data.results;
    }
}

const apiKey = '21fd738a2ca8848ab6af33b0fb4b1d21'; // Заміни на свій API ключ
const api = new Api(apiKey);

const renderPopularMovies = (movies) => {
    const moviesContainer = document.getElementById('popular-movies');
    moviesContainer.innerHTML = '';

    movies.forEach(movie => {
        const movieElement = document.createElement('div');
        movieElement.classList.add('movie');

        const isBookmarked = isMovieBookmarked(movie.id);
        const heartClass = isBookmarked ? 'fas fa-heart active' : 'fas fa-heart';

        movieElement.innerHTML = `
            <img src="https://image.tmdb.org/t/p/w500${movie.poster_path}" alt="${movie.original_title}">
            <h3>${movie.original_title}</h3>
            <button class="heart-button ${heartClass}" data-id="${movie.id}"></button>
        `;

        // Додаємо обробник подій для серця
        const heartButton = movieElement.querySelector('.heart-button');
        heartButton.addEventListener('click', () => toggleBookmark(movie.id, heartButton));

        moviesContainer.appendChild(movieElement);
    });
};

const renderBookmarkedMovies = () => {
    const bookmarkedMovies = getBookmarkedMovies();
    const moviesContainer = document.getElementById('bookmarked-movies');
    moviesContainer.innerHTML = '';

    bookmarkedMovies.forEach(movie => {
        const movieElement = document.createElement('div');
        movieElement.classList.add('movie');

        movieElement.innerHTML = `
            <img src="https://image.tmdb.org/t/p/w500${movie.poster_path}" alt="${movie.original_title}">
            <h3>${movie.original_title}</h3>
            <button class="heart-button fas fa-heart active" data-id="${movie.id}"></button>
        `;

        // Додаємо обробник подій для серця
        const heartButton = movieElement.querySelector('.heart-button');
        heartButton.addEventListener('click', () => removeBookmark(movie.id));

        moviesContainer.appendChild(movieElement);
    });
};

const toggleBookmark = (movieId, heartButton) => {
    let bookmarkedMovies = getBookmarkedMovies();

    const movieIndex = bookmarkedMovies.findIndex(m => m.id === movieId);
    if (movieIndex !== -1) {
        // Якщо вже є в закладках, видаляємо
        bookmarkedMovies.splice(movieIndex, 1);
        heartButton.classList.remove('active');
    } else {
        // Додаємо до закладок
        const movieData = { 
            id: movieId, 
            original_title: document.querySelector(`[data-id="${movieId}"]`).closest('.movie').querySelector('h3').innerText, 
            poster_path: document.querySelector(`[data-id="${movieId}"]`).closest('.movie').querySelector('img').src 
        };
        bookmarkedMovies.push(movieData);
        heartButton.classList.add('active');
    }

    localStorage.setItem('bookmarkedMovies', JSON.stringify(bookmarkedMovies));

    // Оновлюємо відображення закладок
    renderPopularMovies(getPopularMovies());
    renderBookmarkedMovies();
};

const removeBookmark = (movieId) => {
    let bookmarkedMovies = getBookmarkedMovies();

    // Видаляємо фільм із закладок
    bookmarkedMovies = bookmarkedMovies.filter(movie => movie.id !== movieId);

    localStorage.setItem('bookmarkedMovies', JSON.stringify(bookmarkedMovies));

    // Оновлюємо відображення закладок
    renderBookmarkedMovies();
};

const getBookmarkedMovies = () => {
    return JSON.parse(localStorage.getItem('bookmarkedMovies')) || [];
};

const isMovieBookmarked = (movieId) => {
    const bookmarkedMovies = getBookmarkedMovies();
    return bookmarkedMovies.some(movie => movie.id === movieId);
};

const setActiveTab = (tab) => {
    document.getElementById('popular-btn').classList.remove('active');
    document.getElementById('bookmarks-btn').classList.remove('active');

    if (tab === 'popular') {
        document.getElementById('popular-btn').classList.add('active');
        document.getElementById('popular-movies').style.display = 'grid';
        document.getElementById('bookmarked-movies').style.display = 'none';
    } else {
        document.getElementById('bookmarks-btn').classList.add('active');
        document.getElementById('popular-movies').style.display = 'none';
        document.getElementById('bookmarked-movies').style.display = 'grid';
    }
};

document.getElementById('popular-btn').addEventListener('click', () => {
    setActiveTab('popular');
    fetchMovies();
});

document.getElementById('bookmarks-btn').addEventListener('click', () => {
    setActiveTab('bookmarks');
    renderBookmarkedMovies();
});

const fetchMovies = async () => {
    const loadingElement = document.getElementById('loading');
    loadingElement.style.display = 'block';

    try {
        const movies = await api.fetchPopularMovies();
        loadingElement.style.display = 'none';
        renderPopularMovies(movies);
    } catch (error) {
        loadingElement.innerHTML = 'Failed to load movies. Please try again later.';
    }
};

fetchMovies();




