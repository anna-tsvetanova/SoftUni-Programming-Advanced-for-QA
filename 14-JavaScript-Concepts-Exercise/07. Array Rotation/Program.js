function arrayRotation([arg1, arg2]) {
    let myArr = arg1.substring(1,arg1.length-1).split(', ');
    let times = parseInt(arg2);
    for (let i = 0; i < times; i ++) {
        let elem = myArr.shift();
        myArr.push(elem);
    }
 
    console.log(myArr.join(' '));
}
