const baseUr1 = "https://jsonplaceholder.typicode.com";

function getUserAlbums() {
    fetch(`${baseUr1}/users/10/albums`)
        .then(response => {
            if (response.ok) {
                return response.json();
            } else {
                console.error("Помилка:", response.status);

            }
        })
        .then(albums => {
            console.log(albums);
        })
        .catch(error => {
            console.error("Щось не так:", error);
        });
    
}
getUserAlbums();
