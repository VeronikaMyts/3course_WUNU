async function fetchSWAPI(resource, throwError = false) {
    const rootUrl = 'https://swapi.py4e.com/api/';
 
    try {
        const url = resource.startsWith('http') ? resource : `${rootUrl}${resource}`;

        const response = await fetch(url);
        
        if (!response.ok) {
            throw new Error(`Failed with status code: ${response.status}`);
        }
        return await response.json();
    } catch (error) {
        console.error(`${resource} fetchSWAPI error`, error);

        if (throwError) {
            throw error;
        }
        return undefined;
    }
}
async function getPersonFilms(name) {
    try {
        const searchResult = await fetchSWAPI(`people/?search=${name}`);

        if (searchResult.count === 0) {
            throw new Error(`Person with name ${name} not found`);
        }

        const person = searchResult.results[0]; 
        const filmUrls = person.films; 
        
        const filmPromises = filmUrls.map(filmUrl => fetchSWAPI(filmUrl));
        const films = await Promise.all(filmPromises);

        return {
            name: person.name,
            films: films.map(film => ({
                title: film.title,
                episode_id: film.episode_id,
                release_date: film.release_date,
                director: film.director,
                producer: film.producer
            }))
        };
    } catch (error) {
        console.error("Error in getPersonFilms: ", error);
        return undefined;
 }
}
 
async function testGetPersonFilms() {
 const lukeFilms = await getPersonFilms("Luke");
 console.log("lukeFilms ", lukeFilms);
 
 const kenobiFilms = await getPersonFilms("Kenobi");
 console.log("kenobiFilms ", kenobiFilms);
}
 
testGetPersonFilms();