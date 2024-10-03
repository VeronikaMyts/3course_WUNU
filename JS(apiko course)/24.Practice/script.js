
function Calculator() {
  
}


Calculator.prototype.sum = function(a, b) {
  return a + b;
};

Calculator.prototype.subtract = function(a, b) {
  return a - b;
};


function AdvancedCalculator() {
  Calculator.call(this); 
}


AdvancedCalculator.prototype = Object.create(Calculator.prototype);


AdvancedCalculator.prototype.constructor = AdvancedCalculator;


AdvancedCalculator.prototype.multiply = function(a, b) {
  return a * b;
};

AdvancedCalculator.prototype.divide = function(a, b) {
  if (b === 0) {
    console.log('Ділення на 0 неможливе');
    return null;
  }
  return a / b;
};


const basicCalc = new Calculator();
console.log(basicCalc.sum(3, 4));       
console.log(basicCalc.subtract(10, 3)); 


const advCalc = new AdvancedCalculator();
console.log(advCalc.sum(2, 3));        
console.log(advCalc.subtract(10, 4));   
console.log(advCalc.multiply(3, 5));    
console.log(advCalc.divide(10, 2));   
