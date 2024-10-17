async function getPlanets() {
    try {
        const response = await fetch('https://swapi.py4e.com/api/planets/');

        if (!response.ok) {
            throw new Error(`Failed with status code: ${response.status}`);
        }

        const data = await response.json();

        console.log("Planets:", data.results);
    } catch (error) {
        console.error("Request Error:", error);
    }
    
}
getPlanets();