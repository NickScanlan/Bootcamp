// Create an array to hold integer values 0 through 9
int[] arr = {0,1,2,3,4,5,6,7,8,9};
Console.WriteLine(arr[1]);

Console.WriteLine("---------------------------------------------------");
// Create an array of the names "Tim", "Martin", "Nikki", & "Sara"
string[] arrName = {"Tim", "Martin", "Nikki", "Sara"};
Console.WriteLine(arrName[2]);

Console.WriteLine("----------------------------------------------");

// Create an array of length 10 that alternates between true and false values, starting with true

int[] arr2 = {0,1,2,3,4,5,6,7,8,9};
    foreach (int i in arr2)
    
    {
        // Console.WriteLine(arr2[i]);
        if(i % 2 == 0)
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
    }


Console.WriteLine("----------------------------------------------");


// Create a list of ice cream flavors that holds at least 5 different flavors (feel free to add more than 5!)
List<string> flavors = new List<string>();
flavors.Add("chocolate");
flavors.Add("vanilla");
flavors.Add("strawberry");
flavors.Add("oreo");
flavors.Add("mint");


// Output the length of this list after building it
Console.WriteLine(flavors.Count);


// Output the third flavor in the list, then remove this value
Console.WriteLine($"removing {flavors[2]}");
flavors.Remove(flavors[2]);

// Output the new length of the list (It should just be one fewer!)
Console.WriteLine(flavors.Count);

Console.WriteLine("------------------------------------------------");



// Create a dictionary that will store both string keys as well as string values
Dictionary<string,string> profile = new Dictionary<string, string>();

// Add key/value pairs to this dictionary where:
    //  each key is a name from your names array
    //  each value is a randomly selected flavor from your flavors list.
    Random random = new Random();

    profile.Add(arrName[0], flavors[random.Next(0,4)]);
    profile.Add(arrName[1], flavors[random.Next(0,4)]);
    profile.Add(arrName[2], flavors[random.Next(0,4)]);
    profile.Add(arrName[3], flavors[random.Next(0,4)]);


// Loop through the dictionary and print out each user's name and their associated ice cream flavor

foreach (KeyValuePair<string, string> entry in profile) 
{
    Console.WriteLine(entry.Key + " likes " + entry.Value);
}