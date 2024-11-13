// router.js
import { renderPopularPage } from './pages/popular.js';
import { renderMoviePage } from './pages/movie.js';

export const routes = [
    {
        path: '/',
        match: (path) => path === '/', // Match exact path for homepage
        renderRoute: renderPopularPage
    },
    {
        path: '/movies/:movieId',
        match: (path) => {
            const regex = /^\/movies\/(\d+)$/; // Regex to match /movies/{movieId}
            const match = path.match(regex);
            if (match) {
                const movieId = match[1]; // Extract movieId from URL
                return movieId;
            }
            return null;
        },
        renderRoute: (movieId) => renderMoviePage(movieId) // Pass movieId to renderMoviePage
    }
];

export class Router {
    constructor(routes) {
        this._routes = routes;
        window.history.pushState = (data, title, url) => {
            History.prototype.pushState.apply(window.history, [data, title, url]);
            this.reroute();
        };

        window.onpopstate = () => {
            this.reroute();
        };

        // Force a reload on page load to handle the path
        this.reroute();
    }

    reroute() {
        const path = window.location.pathname;

        // Handle case where the path is '/index.html' and redirect to '/'
        if (path === '/index.html') {
            window.history.replaceState({}, '', '/'); // Replace index.html with base path '/'
            return renderPopularPage(); // Rerender popular movies page
        }

        console.log('Current path:', path); // Debugging log to see the current URL

        const matchedRoute = this._routes.find(route => route.match(path));

        if (matchedRoute) {
            const movieId = matchedRoute.match(path);
            if (movieId) {
                matchedRoute.renderRoute(movieId); // Call the corresponding render function with movieId
            } else {
                matchedRoute.renderRoute(); // Call for rendering popular page
            }
        } else {
            console.error('No route matched for', path); // Improved error message
        }
    }
}
document.getElementById('back-to-home').addEventListener('click', () => {
    // Зміна маршруту
    window.history.pushState({}, '', '/');
    // Оновлення сторінки через маршрутизатор
    router.reroute(); // Викликає reroute для оновлення контенту на основі нової адреси
});


// Initialize Router
const router = new Router(routes);



