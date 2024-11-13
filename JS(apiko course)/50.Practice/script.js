
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
            renderMovie(movieId);  
        }
    }
];


const router = new Router(routes);
router.reroute();


