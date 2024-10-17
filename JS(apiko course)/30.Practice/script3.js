const baseUrl = "https://jsonplaceholder.typicode.com";

const newUser = {
    name: "JON",
    username: "Mal",
    email: "usermail@gmail.com"
};

fetch(`${baseUrl}/users`, {
    method: "POST",
    headers: {
        "Content-type": "application/json"
    },
    body: JSON.stringify(newUser)
})
    .then(response => {
        if (response.ok) {
            return response.json();
        } else {
            console.error("Помилка:", response.status);
        }
    })
    .then(createdUser => {
        console.log("Новий користувач створений:", createdUser);

    })
    .catch(error => {
        console.error("Щось не так:", error);
    });