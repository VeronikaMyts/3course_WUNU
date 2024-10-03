function timer(seconds) {
    let remainingTime = seconds;

    const intervalId = setInterval(() => {
        if (remainingTime > 0) {
            console.log(`Timer: ${remainingTime}`);
            remainingTime--; 
        } else {
            console.log('Timer finished!'); 
            clearInterval(intervalId); 
        }
    }, 1000); 
}


timer(5);
