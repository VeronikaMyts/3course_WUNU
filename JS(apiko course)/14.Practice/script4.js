function findUser(initialObject) {
    if (typeof initialObject !== 'object' || initialObject === null) {
        console.error("Параметр не є об'єктом");
        return;
    }
    const userFromLondon = Object.entries(initialObject)
        .filter(([name, info]) => info.city === "London" && info.age > 18)
        .map(([name]) => name);
    
    console.log(userFromLondon);
}

findUser({ Max: { age: 23, city: "London" }, Mike: { age: 20, city: "NY" }});