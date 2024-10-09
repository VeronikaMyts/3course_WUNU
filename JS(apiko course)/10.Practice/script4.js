function calculateWordsInString(string) {

    const words = string.trim().match(/\S+/g);

  
    const count = words ? words.length : 0;
    console.log(count);
}


calculateWordsInString("Easy string for count"); 
calculateWordsInString("Easy");                  
calculateWordsInString("Some string with a triple   space"); 
calculateWordsInString("Some?  string, with a triple   space"); 


