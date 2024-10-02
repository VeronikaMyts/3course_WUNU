const Person = {
    firstName: 'John',
    lastName: 'Doe',
    getFullName: function () {
        const fullName = this.firstName + ' ' + this.lastName;
        return fullName;
    }
};

const testArgs = ['sushi', 'hiking'];

let logPersonNameAndInterests = function (...interests) {
    const fullName = this.getFullName();
    console.log(`${fullName} loves: ${interests.join(', ')}`);

};

logPersonNameAndInterests.call(Person, ...testArgs);