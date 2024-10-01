function unicFn(initialArray) {
    
    if (!Array.isArray(initialArray)) {
        console.error("Параметр не є масивом");
        return;
    }

    
    const uniqueValues = [...new Set(initialArray)];

    
    return uniqueValues;
}


const arr = [2, 3, 1, 3, 3, 7];
console.log(unicFn(arr)); 
