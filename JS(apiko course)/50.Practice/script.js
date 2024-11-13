// script.js
import { Router } from './router.js';
import { renderPopular } from './pages/popular.js';

const routes = [
    {
        path: '/',
        match: (url) => url === '/' || url === '/index.html',
        renderRoute: renderPopular
    },
    {
        path: '/movies/:movie_id',
        match: (url) => url.startsWith('/movies/'),
        renderRoute: () => {
            const movieId = window.location.pathname.split('/')[2];
            renderMovie(movieId);  // Render movie details for the clicked movie
        }
    }
];

// Initialize the router
const router = new Router(routes);
router.reroute();


