// function greetSean(){
//     //inside the body of the function
//     console.log("hello Sean!");
// }


// invoking (or calling/executing) the function greetSomeone
// function greetSomeone(person_name){
//     console.log("Hello " + person_name + "!");
// }


//the info that we feed to the functio when we call the function the is call an ARGUMENT
// greetSomeone("Colin");
// greetSomeone("Lazaro");
// greetSomeone("Robert");
// greetSomeone("Sean");

// var x = 5;

// function setX(newValue){
//     x = newValue
// }

// console.log(x);
// setX(15)
// console.log(x)



//function called isPal which will accept an array as an input (arr is the parameter)

function isPal(arr) {
    for(var left=0; left<arr.length/2; left++) {
        var right = arr.length-1-left;
        if(arr[left] != arr[right]) {
            return "Not a pal-indrome!";
        }
    }
    return "Pal-indrome!";
}
    
var result1 = isPal( [1, 1, 2, 2, 1] );
console.log(result1);
    
var result2 = isPal( [3, 2, 1, 1, 2, 3] );
console.log(result2);
