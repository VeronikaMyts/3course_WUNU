
const compose = (...fns) => val => 
  fns.reduceRight((result, f) => f(result), val);


const modifyArray = (modifyCondition) => (data) => {
  return data.map(modifyCondition); 
};


const toLowerCase = str => str.toLowerCase();


const capitalizeFirst = str => str.charAt(0).toUpperCase() + str.slice(1).toLowerCase();

const allToLower = compose(
  arr => arr.join(' - '), 
  modifyArray(toLowerCase) 
);


const capitalizeAllFirst = compose(
  arr => arr.join('-'),
  modifyArray(capitalizeFirst) 
);


const arr = ["CusTom", "Web", "aNd", "MoBile", "PlaTfoRms"];

console.log(`Result: ${allToLower(arr)} length: ${allToLower(arr).length}`);
console.log(`Result: ${capitalizeAllFirst(arr)} length: ${capitalizeAllFirst(arr).length}`);
