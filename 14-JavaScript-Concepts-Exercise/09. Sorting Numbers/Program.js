function sortingNumbers(data) {
    let arr = data.map((el) => Number(el));
    let result =[];
    arr.sort((a,b) => a-b); 
    let length = arr.length;

    while(arr.length !==0) {
        if (length % 2 !== 0 && arr.length ===1) {
            result.push(arr.shift());
        } else {
            result.push(arr.shift());
            result.push(arr.pop());
        }
    }
    
    return result.join("\n")
   
}
