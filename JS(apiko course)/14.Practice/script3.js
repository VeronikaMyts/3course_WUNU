function filterArray(initialArray) {
    if (!Array.isArray(initialArray)) {
        console.error("Параметр не є масивом");
        return;
    }
    const stringArray = initialArray.filter(element => typeof element === 'string');

    console.log(stringArray);
}
filterArray([2, "string", 3, , , "test"]);
filterArray([]); //  []
filterArray("not an array"); // "Параметр не є масивом"