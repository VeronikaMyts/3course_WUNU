function isString(callback, value) {
    if (typeof callback === 'function' && typeof value === 'string') {
         callback(value);
    } else {
        console.error('Error: value must be a string and callback must be a function');
    }
       
}
isString((str) => console.log(`The string is: ${str}`), 'Hello, world!'); 
isString((str) => console.log(`The string is: ${str}`), 123); 
isString('not a function', 'Hello');