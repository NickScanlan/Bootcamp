List<Eruption> eruptions = new List<Eruption>()
{
    new Eruption("La Palma", 2021, "Canary Is", 2426, "Stratovolcano"),
    new Eruption("Villarrica", 1963, "Chile", 2847, "Stratovolcano"),
    new Eruption("Chaiten", 2008, "Chile", 1122, "Caldera"),
    new Eruption("Kilauea", 2018, "Hawaiian Is", 1122, "Shield Volcano"),
    new Eruption("Hekla", 1206, "Iceland", 1490, "Stratovolcano"),
    new Eruption("Taupo", 1910, "New Zealand", 760, "Caldera"),
    new Eruption("Lengai, Ol Doinyo", 1927, "Tanzania", 2962, "Stratovolcano"),
    new Eruption("Santorini", 46,"Greece", 367, "Shield Volcano"),
    new Eruption("Katla", 950, "Iceland", 1490, "Subglacial Volcano"),
    new Eruption("Aira", 766, "Japan", 1117, "Stratovolcano"),
    new Eruption("Ceboruco", 930, "Mexico", 2280, "Stratovolcano"),
    new Eruption("Etna", 1329, "Italy", 3320, "Stratovolcano"),
    new Eruption("Bardarbunga", 1477, "Iceland", 2000, "Stratovolcano")
};

// Execute Assignment Tasks here!


// Use LINQ to find the first eruption that is in Chile and print the result.
Eruption? chileEruptions = eruptions.FirstOrDefault(v => v.Location == "Chile");
Console.WriteLine("info for oldest eruption in Chile " + chileEruptions);

Console.WriteLine("--------------------------");
// Find the first eruption from the "Hawaiian Is" location and print it. If none is found, print "No Hawaiian Is Eruption found."
Eruption? hawaiiEruptions = eruptions.FirstOrDefault(v => v.Location == "Hawaiian Is");

if(hawaiiEruptions != null)
{
    Console.WriteLine("info for oldest eruption in Hawaii " + hawaiiEruptions);
}
else
{
    Console.WriteLine("No Hawaiian Is Eruption found.");
}
Console.WriteLine("--------------------------");

// Find the first eruption that is after the year 1900 AND in "New Zealand", then print it.


Eruption? newZealandEruptions = eruptions.FirstOrDefault(e => e.Location == "New Zealand");

Eruption? after1900 = eruptions.FirstOrDefault(v => v.Year >= 1900);

if(newZealandEruptions != null && newZealandEruptions.Year > 1900)
{
    Console.WriteLine($"{newZealandEruptions.Volcano}s eruption was after 1900");
}
Console.WriteLine("--------------------------");

// Find all eruptions where the volcano's elevation is over 2000m and print them.
bool? tallVolcano = eruptions.Any(v => v.ElevationInMeters >= 2000);

foreach (var Eruption in eruptions)
{
    if(Eruption.ElevationInMeters >= 2000)
    {
        Console.WriteLine($"{Eruption.Volcano} is taller than 2000 meters");
    }
    

}
Console.WriteLine("--------------------------");
int Lcount = 0;
foreach (var Eruption in eruptions)
{
    if (Eruption.Volcano.Substring(0,1) == "L")  
    {
        Console.WriteLine(Eruption.Volcano);
        Lcount++;
    }
} 
Console.WriteLine($"{Lcount} volcanos start with the letter L");
Console.WriteLine("--------------------------");

// Find the highest elevation, and print only that integer (Hint: Look up how to use LINQ to find the max!)
Eruption? tallestVolcano = eruptions.FirstOrDefault(m => m.ElevationInMeters == eruptions.Max(eruptions => eruptions.ElevationInMeters));

Console.WriteLine(tallestVolcano);

// Use the highest elevation variable to find a print the name of the Volcano with that elevation.
Console.WriteLine($"the tallest volcano in the list is {tallestVolcano.Volcano} at {tallestVolcano.ElevationInMeters} meters");
Console.WriteLine("--------------------------");


// Print all Volcano names alphabetically.
List<Eruption>? alphaVolcanos = eruptions.OrderBy(v => v.Volcano).ToList();
PrintEach(alphaVolcanos);
Console.WriteLine("=========================");

// Print all the eruptions that happened before the year 1000 CE alphabetically according to Volcano name.
foreach( var Eruption in alphaVolcanos )
{
    if (Eruption.Year < 1000)
    {
        Console.WriteLine(Eruption);
    }
}
Console.WriteLine("-------------------");

// Helper method to print each item in a List or IEnumerable.This should remain at the bottom of your class!
static void PrintEach(IEnumerable<dynamic> items, string msg = "")
{
    Console.WriteLine("\n" + msg);
    foreach (var item in items)
    {
        Console.WriteLine(item.ToString());
    }
}
