class MyClass{
    constructor(name) {
        this.name = name;
        this.timeoutId = setTimeout(() => {
            this.name = null;
            console.log('Name has been set to null');
        }, 5000);
    }

    cancelNullification() {
        clearTimeout(this.timeoutId);
        console.log('Nullification has been canceled');
    }
}

const myObject = new MyClass('John Doe');

console.log(myObject.name);

setTimeout(() => {
    myObject.cancelNullification();
}, 2000);

setTimeout(() => {
    console.log(myObject.name);
}, 6000);