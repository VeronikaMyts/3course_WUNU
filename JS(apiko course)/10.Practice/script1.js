
function printPowsOf2(number) {
    if (typeof number !== 'number' || isNaN(number)) {
        console.log('incorrect type');
        return;
    }
    
    let result = [];
    let power = 1;

    while (power <= number) {
        result.push(power);
        power *= 2;
    }

    console.log(result.join(', '));
}

printPowsOf2("302");  
printPowsOf2(null);   
printPowsOf2(128);    
printPowsOf2(60);     
