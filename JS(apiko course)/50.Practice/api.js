// api.js
export class Api {
    constructor(apiKey) {
        this.apiKey = apiKey;
        this.baseUrl = 'https://api.themoviedb.org/3';
    }

    async fetchMovieDetails(movieId) {
        if (!movieId) {
            throw new Error('Movie ID is required');
        }
        const url = `${this.baseUrl}/movie/${movieId}?api_key=${this.apiKey}&language=en-US`;
        const response = await fetch(url);
        const data = await response.json();
        return data;
    }

    async fetchPopularMovies() {
        const url = `${this.baseUrl}/movie/popular?api_key=${this.apiKey}&language=en-US&page=1`;
        const response = await fetch(url);
        const data = await response.json();
        return data.results;
    }
}
