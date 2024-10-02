
let globalVar = 'I am in global scope';

function showGlobalVar() {
    console.log(globalVar); 
}

showGlobalVar();

function functionScopeExample() {
    let functionVar = 'I am inside functoin scope';
    console.log(functionVar);
}

functionScopeExample();
console.log(functionVar);

// закоментовуємо верхній код і працює нижній
function blockScopeExample() {
    {
        let blockVar = 'I am inside block scope';
        console.log(blockVar); 
    }
    console.log(blockVar); 
}

blockScopeExample();