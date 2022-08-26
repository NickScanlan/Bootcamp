// var favFood = ["Calamari", "Pho", "Pizza"] //elements are the values in the array

// indexs             0         1       2

//print each and every value in this arraay of food 


//     //if the current food item (favFoods[i]) is Calamari print "inflation tho" but be able to print the other foods
//     if(favFood[i] == "Calamari"){
//         console.log("inflation tho " + favFood[i])
//     }
//     else if(favFood[i] == "Pizza"){
//         console.log("get the 3 meat for the " + favFood[i])
//     }
    
//     else{
//     console.log(favFood[i]);
//     }
// }

// var isSunny = true;
// var temperature = 45; // let's assume degrees Fahrenheit
// var isRaining = false;
// var whatToBring = "I should bring: ";

// if(isSunny == true) {
//     whatToBring += "sunglasses, ";
// }
// if(temperature < 50) {
//     whatToBring += "a coat, ";
// }
// if(isRaining == true) {
//     whatToBring += "an umbrella, ";
// }
// whatToBring += "and a smile!";

// console.log(whatToBring);


var countPositives = 0;
var numbers = [3, 4, -2, 7, 16, -8, 0];
    
for(i = 0; i <= numbers.length; i++){
    if(numbers[i] > 0){
        countPositives += 1 
    }
}
    
console.log("there are " + countPositives + " positive values");

