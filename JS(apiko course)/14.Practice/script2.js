function isEvenArray(initialArray) {
      if (!Array.isArray(initialArray)) {
        console.error("Параметр не є масивом");
        return;
    }

    const allEven = initialArray.every(num => num % 2 === 0);

    if (allEven) {
        console.log('Yes');
    } else {
        console.log('No');
    }
}

isEvenArray([1, 2, 3, 9]); //  NO
isEvenArray([2, 4, 6]);    //  YES