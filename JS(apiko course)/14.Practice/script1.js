function unicFn(initialArray) {
      if (!Array.isArray(initialArray)) {
        console.error("Параметр не є масивом");
        return;
    }
    const uniqueArray = initialArray.filter((value, index, self) => {
        return self.indexOf(value) === index;
    });
    
    console.log(uniqueArray);
}


unicFn([2, 3, 1, 3, 3, 7]); 
