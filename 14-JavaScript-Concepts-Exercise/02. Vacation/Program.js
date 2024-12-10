function solve(data){
  let countPeople = Number(data[0]);
  let type = data[1];
  let day = data[2];
    let pricePerson;
    let discount = 0;
    let totalPrice = 0;
    let freeStay = 0;
 
    switch(type){
        case "Students":{
            switch (day){
                case "Friday": pricePerson = 8.45; break;
                case "Saturday": pricePerson = 9.80; break;
                case "Sunday": pricePerson = 10.46; break;
            }
            if (countPeople >= 30) discount = 0.15;
        }; break;
        case "Business":{
            switch (day){
                case "Friday": pricePerson = 10.90; break;
                case "Saturday": pricePerson = 15.60; break;
                case "Sunday": pricePerson = 16; break;
            }
            if (countPeople >= 100) freeStay = 10;
        }; break;
        case "Regular":{
            switch (day){
                case "Friday": pricePerson = 15; break;
                case "Saturday": pricePerson = 20; break;
                case "Sunday": pricePerson = 22.50; break;
            }
            if (countPeople >= 10 && countPeople <=20) discount = 0.05;
        }; break;
    }
    countPeople -= freeStay;
    totalPrice += pricePerson * countPeople;
    totalPrice -= totalPrice * discount;
 
    console.log(`Total price: ${totalPrice.toFixed(2)}`)
 
}
