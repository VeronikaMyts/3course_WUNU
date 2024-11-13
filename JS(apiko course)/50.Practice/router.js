
import { renderPopularPage } from './pages/popular.js';
import { renderMoviePage } from './pages/movie.js';

export const routes = [
    {
        path: '/',
        match: (path) => path === '/', 
        renderRoute: renderPopularPage
    },
    {
        path: '/movies/:movieId',
        match: (path) => {
            const regex = /^\/movies\/(\d+)$/; 
            const match = path.match(regex);
            if (match) {
                const movieId = match[1]; 
                return movieId;
            }
            return null;
        },
        renderRoute: (movieId) => renderMoviePage(movieId) 
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

        
        this.reroute();
    }

    reroute() {
        const path = window.location.pathname;

       
        if (path === '/index.html') {
            window.history.replaceState({}, '', '/'); 
            return renderPopularPage(); 
        }

        console.log('Current path:', path); 

        const matchedRoute = this._routes.find(route => route.match(path));

        if (matchedRoute) {
            const movieId = matchedRoute.match(path);
            if (movieId) {
                matchedRoute.renderRoute(movieId); 
            } else {
                matchedRoute.renderRoute();
            }
        } else {
            console.error('No route matched for', path); 
        }
    }
}
document.getElementById('back-to-home').addEventListener('click', () => {
    
    window.history.pushState({}, '', '/');
   
    router.reroute(); 
});



const router = new Router(routes);



