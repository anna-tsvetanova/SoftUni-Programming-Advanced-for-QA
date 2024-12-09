function printEveryNElement(arg) {
    let data = arg.filter((el) => el !== ""); 
    let step = Number(data[data.length - 1]);

    for (let i=0; i < data.length - 1; i += step) {
        console.log(data[i]);
    }

}
