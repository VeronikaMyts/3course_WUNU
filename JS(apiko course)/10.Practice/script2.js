function calculateSumOfArray() {
    const initialArray = [3, 2, "2", null, 1.5, 9.5, undefined];
    
    const sum = initialArray.reduce((accumulator, current) => {
        if (typeof current === 'number') {
            return accumulator + current;
        }
        return accumulator;
    }, 0);
    console.log(sum);
}
calculateSumOfArray();