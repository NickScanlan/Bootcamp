var fruit1 = "appeles";
var fruit1 = "oranges";


//one way to swap variables
// var temp = fruit2; //saving fruit2 into a temp variable so we dont lose oranges
// fruit2 = fruit1;
// fruit1 = fruit2;

//destructure swap

[fruit1, fruit2] = [fruit2, fruit1]



// console.log("fruit 1 is", fruit1);
// console.log("fruit2 is", fruit2)



//for loop

// for(let i = 0; i <= 12; i++){
//     console.log(i)
// }


//while loop
// let  i = 0;
// while(i<=12){
//     console.log(i);
//     i++;
// }

var start = 0;
var end = 12;


while(start < end){
    console.log("start: " + start + ", end: " + end);
    start += 2;
    end -= 2;
}




