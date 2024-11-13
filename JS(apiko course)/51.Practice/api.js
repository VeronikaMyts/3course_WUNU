export class Api {
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

    async fetchMovieDetails(movieId) {
        const url = `${this.baseUrl}/movie/${movieId}?api_key=${this.apiKey}&language=en-US`;
        const response = await fetch(url);
        return await response.json();
    }

    async fetchMovieRecommendations(movieId) {
        const url = `${this.baseUrl}/movie/${movieId}/recommendations?api_key=${this.apiKey}&language=en-US`;
        const response = await fetch(url);
        const data = await response.json();
        return data.results;
    }

  async fetchSearchResults(query) {
        const url = `${this.baseUrl}/search/movie?api_key=${this.apiKey}&query=${query}&language=en-US&page=1`;
        const response = await fetch(url);
        const data = await response.json();
        return data.results;
    }
}

