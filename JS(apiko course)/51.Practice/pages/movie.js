import { Api } from '../api.js';

const apiKey = '21fd738a2ca8848ab6af33b0fb4b1d21';
const api = new Api(apiKey);

export const renderMoviePage = async (movieId) => {
    const movieDetails = await api.fetchMovieDetails(movieId);
    const recommendations = await api.fetchMovieRecommendations(movieId);
    const app = document.getElementById('app');
    
   
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

       
        movieElement.addEventListener('click', () => {
            window.history.pushState({}, '', `/movies/${movie.id}`);
            renderMoviePage(movie.id);
        });
    });

    
    const bookmarkBtn = document.querySelector('.bookmark-btn');
    bookmarkBtn.addEventListener('click', (e) => {
        e.stopPropagation();  
        toggleBookmark(movieDetails, bookmarkBtn);
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
    bookmarkBtn.textContent = isBookmarked(movie.id) ? 'Remove from bookmarks' : 'Add to bookmarks';
};


const isBookmarked = (movieId) => {
    const bookmarks = JSON.parse(localStorage.getItem('bookmarks')) || [];
    return bookmarks.some(item => item.id === movieId);
};
