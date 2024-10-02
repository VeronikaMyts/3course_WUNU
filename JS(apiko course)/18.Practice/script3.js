const cat = {
    sound: 'meow',
    greet: function () {
        setTimeout(() => {
            console.log(this.sound);
        }, 0);
    }
};
cat.greet();