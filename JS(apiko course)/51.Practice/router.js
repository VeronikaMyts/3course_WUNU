import { renderPopularPage } from './pages/popular.js';
import { renderBookmarksPage } from './pages/bookmarks.js';
import { renderSearchPage } from './pages/search.js';
import { renderMoviePage } from './pages/movie.js';

const routes = [
    {
        path: '/',
        render: renderPopularPage
    },
    {
        path: '/bookmarks',
        render: renderBookmarksPage
    },
    {
        path: '/search',
        render: renderSearchPage
    },
    {
        path: '/movies/:movieId',
        render: renderMoviePage
    }
];

class Router {
    constructor(routes) {
        this.routes = routes;
        window.onpopstate = () => this.reroute();
        this.initializeEventListeners();
        this.reroute();
    }

    initializeEventListeners() {
        document.getElementById('popular-btn').addEventListener('click', () => {
            window.history.pushState({}, '', '/');
            this.reroute();
        });

        document.getElementById('bookmarks-btn').addEventListener('click', () => {
            window.history.pushState({}, '', '/bookmarks');
            this.reroute();
        });

        document.getElementById('search-input').addEventListener('keypress', (event) => {
            if (event.key === 'Enter') {
                const query = event.target.value.trim();
                window.history.pushState({}, '', `/search?query=${encodeURIComponent(query)}`);
                this.reroute();
            }
        });
    }

    reroute() {
        const path = window.location.pathname;
        const route = this.routes.find(route => {
            if (route.path === path) return true;
            if (route.path.includes(':')) {
                const paramName = route.path.split('/:')[1];
                const regex = new RegExp(`^${route.path.split('/:')[0]}/(.+)$`);
                const match = path.match(regex);
                if (match) {
                    route.paramValue = match[1];
                    return true;
                }
            }
            return false;
        });

        if (route) {
            document.getElementById('app').innerHTML = '<p>Loading...</p>';
            if (route.paramValue) {
                route.render(route.paramValue);
            } else {
                route.render();
            }
        }
    }
}

new Router(routes);
