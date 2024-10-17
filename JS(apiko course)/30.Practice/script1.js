const baseUr1 = "https://jsonplaceholder.typicode.com";

function getUsers() {
    fetch(baseUr1 + "/users")
        .then(response => {
            if (response.ok) {
                return response.json();
            } else {
                console.error("Помилка:", response.status);
            }
        })
        .then(users => {
            console.log(users);
        })
        .catch(error => {
            console.error("Щось не так:", error);
        });
    
}

getUsers();