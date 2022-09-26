//compiled languages are very good at telling you whats wrong with your code. 

// create a new loop that prints to 100
// void means not returning anything from the function
//int means returning integer
//string returns string
//etc

// void PrintNumbers()
// {
//     Console.WriteLine("test");
// }


 


//for loops

void PrintNumbers()
{
    for (int i = 1; i <= 100; i++)
    {
        bool isDivisableBy3 = i % 3 == 0;
        bool isDivisableBy5 = i % 5 == 0;

        //interpalated strings
        Console.WriteLine($"is {i} divisible by 3? {isDivisableBy3}");
        Console.WriteLine($"is {i} divisible by 5? {isDivisableBy5}");
    }
}
PrintNumbers();



//general naming conventions
    // variables, parameters, and fields are CamelCase "thisVariable"
    //everything else is PascalCode "ThisCode"