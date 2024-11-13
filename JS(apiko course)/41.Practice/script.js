
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

const apiKey = '21fd738a2ca8848ab6af33b0fb4b1d21'; 
const api = new Api(apiKey);

const renderPopularMovies = (movies) => {
    const moviesContainer = document.getElementById('popular-movies');
    moviesContainer.innerHTML = '';

    movies.forEach(movie => {
        const movieElement = document.createElement('div');
        movieElement.classList.add('movie');

        movieElement.innerHTML = `
            <img src="https://image.tmdb.org/t/p/w500${movie.poster_path}" alt="${movie.original_title}">
            <h3>${movie.original_title}</h3>
        `;

        moviesContainer.appendChild(movieElement);
    });
};

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
