const baseUrl = "https://jsonplaceholder.typicode.com";


function getAlbum(id) {
  return fetch(`${baseUrl}/albums/${id}`)
    .then(response => {
     
      if (response.ok) {
        return response.json(); 
      } else {
        throw new Error(`Помилка при отриманні альбому з id ${id}: ${response.status}`);
      }
    })
    .catch(error => {
      console.error(error);
    });
}


function getSpecifiedAlbums(ids = []) {
  
  const albumPromises = ids.map(id => getAlbum(id));


  return Promise.all(albumPromises)
    .then(albums => {
      return albums;
    })
    .catch(error => {
      console.error("Помилка при отриманні альбомів:", error);
    });
}


getSpecifiedAlbums([1, 15])
  .then(results => {
    console.log("Results:", results); 
  })
  .catch(error => {
    console.log("Error:", error);
  });
