// See https://aka.ms/new-console-template for more information
// for(int i = 1; i <= 255; i++){
//     Console.WriteLine(i);
// }

for(int i = 1; i <= 100; i++){
    if (i % 5 == 0 && i % 3 == 0){
        Console.WriteLine("fizzbuzz");
    }
    else if (i % 5  == 0){
        Console.WriteLine("fizz");
    }
    else if (i % 3 == 0){
        Console.WriteLine("buzz");
    }
    else{
        Console.WriteLine(i);
    }
}