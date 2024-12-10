function piccolo(input) {
    let parkingLot = new Set();

    for (let entry of input) {
        let [direction, carNumber] = entry.split(", ");

        if (direction === "IN") {
            parkingLot.add(carNumber);
        } else if (direction === "OUT") {
            parkingLot.delete(carNumber);
        }
    }

    let sortedCars = Array.from(parkingLot).sort();

    if (sortedCars.length === 0) {
        console.log("Parking Lot is Empty");
    } else {
        console.log(sortedCars.join("\n"));
    }
}


