
class Api {
    constructor(apiKey) {
        this.apiKey = apiKey;
        this.baseUrl = 'https://api.themoviedb.org/3';
    }

    async fetchMoviesBySearchText(query, page = 1) {
        const url = `${this.baseUrl}/search/movie?api_key=${this.apiKey}&query=${query}&page=${page}&language=en-US`;
        const response = await fetch(url);
        const data = await response.json();
        return data;
    }
}


const apiKey = '21fd738a2ca8848ab6af33b0fb4b1d21'; 
const api = new Api(apiKey);


const renderMovies = (movies, container, append = false) => {
    if (!append) container.innerHTML = ''; 
    movies.forEach(movie => {
        const movieElement = document.createElement('div');
        movieElement.classList.add('movie');

        movieElement.innerHTML = `
            <img src="https://image.tmdb.org/t/p/w500${movie.poster_path}" alt="${movie.original_title}">
            <h3>${movie.original_title}</h3>
        `;
        container.appendChild(movieElement);
    });
};


const handleSearch = async (event) => {
    if (event.key === 'Enter') {
        const query = document.getElementById('search-input').value;
        if (query.trim() !== '') {
            const loadingElement = document.getElementById('movies-container');
            loadingElement.innerHTML = 'Loading...';

            const data = await api.fetchMoviesBySearchText(query);
            const moviesContainer = document.getElementById('movies-container');
            const totalResults = data.total_results;
            const totalPages = data.total_pages;

            if (totalResults > 0) {
                renderMovies(data.results, moviesContainer);
                moviesContainer.insertAdjacentHTML('beforebegin', `<h2>Results (${totalResults})</h2>`);
            } else {
                moviesContainer.innerHTML = `No results for "${query}"`;
            }

           
            if (totalPages > 1) {
                document.getElementById('load-more').style.display = 'block';
                document.getElementById('load-more').dataset.page = 2;
                document.getElementById('load-more').dataset.query = query; 
            } else {
                document.getElementById('load-more').style.display = 'none';
            }

            
            document.getElementById('search-input').value = '';
        }
    }
};


const loadMoreMovies = async () => {
    const query = document.getElementById('load-more').dataset.query;
    const page = parseInt(document.getElementById('load-more').dataset.page);

    const data = await api.fetchMoviesBySearchText(query, page);
    const moviesContainer = document.getElementById('movies-container');

    renderMovies(data.results, moviesContainer, true); 

 
    const nextPage = page + 1;
    document.getElementById('load-more').dataset.page = nextPage;

    
    if (nextPage > data.total_pages) {
        document.getElementById('load-more').style.display = 'none';
    }
};


document.getElementById('search-input').addEventListener('keydown', handleSearch);
document.getElementById('load-more').addEventListener('click', loadMoreMovies);

