static void RandomArray()
{   //Random class
    Random random = new Random();
    
    //created an arry that has 10 indices all with the value of 0
    int[] array = new int[10];
    // Console.WriteLine(array[0]);
    
    // int max = array[0];
    //loops through array 
    for(int i = 0; i < array.Length; i++){
     //gives each index a random number between 5 (inclusive) and 25 (26 exclusive)
        array[i] = random.Next(5,26);
     Console.WriteLine(array[i]); 

    
    
    }
    Console.WriteLine("max is " + array.Max());
    Console.WriteLine("min is " + array.Min());
    Console.WriteLine("sum is " + array.Sum());
}

RandomArray();


Console.WriteLine("===============================");

static int TossCoin()
{
    Console.WriteLine("Tossing a Coin");
    Random random = new Random();

    int results = random.Next(0, 2);
    if(results == 0)
    {
        Console.WriteLine("Heads");
    }
    else
    {
        Console.WriteLine("Tails");
    }
    return results;
}
TossCoin();



Console.WriteLine("==================================");


List<string> FilterToLongNames()
{
    List<string> names = new List<string>()
        {
            "Todd", "Tiffany", "Charlie", "Geneva", "Sydney"
        };

    List<string> longNames = new List<string>();

    foreach (string name in names)
    {
        if (name.Length > 5)
        {
            longNames.Add(name);
        }
    }

    return longNames;

}
List<string> namesMoreThan5Chars = FilterToLongNames();

Console.WriteLine(string.Join(", ", namesMoreThan5Chars));