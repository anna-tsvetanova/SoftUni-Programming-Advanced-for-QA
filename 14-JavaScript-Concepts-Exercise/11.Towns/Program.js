function towns(data) {
    let store = [];
    for(let el of data) {
        let [town, latitude, longitude] = el.split(" | ");
        latitude = Number(latitude).toFixed(2);
        longitude = Number(longitude).toFixed(2);
        let obj = {
            town, 
            latitude,
            longitude
        };

        store.push(obj);
    }

    for (let el of store) {
        console.log(el)
    }
}
