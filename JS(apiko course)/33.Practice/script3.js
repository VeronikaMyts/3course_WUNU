async function getSkywalkers() {
try {
        const response = await fetch('https://swapi.py4e.com/api/people/?search=Skywalker');

        if (!response.ok) {
            throw new Error(`Failed with status code: ${response.status}`);
        }

        const data = await response.json();

        console.log("Skywalkers:", data.results);
    } catch (error) {
        console.error("Request Error:", error);
    }
}
getSkywalkers();