function solve(data){
  let start = Number(data[0]);
  let end = Number(data[1]);
    let sum = 0;
    let nums = [];
    for (let i = start; i <= end; i++){
        sum += i;
        nums.push(i);
    }
    let res = nums.join(" ");
    console.log(res);
    console.log(`Sum: ${sum}`);
}
