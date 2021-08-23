function sequence (){
    let numberArray = [1,1];
    while (numberArray.length< 200){
    let val = numberArray[numberArray.length-1]+numberArray[numberArray.length-2];
    numberArray.push(val);
    }
    return numberArray
    
}