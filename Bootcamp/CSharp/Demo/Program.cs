
string word = "bye bye python, hello C#";
int number = 32;
double pi = 3.1212121;
bool is_lie = false;

Console.WriteLine(pi);

int[] arr = new int[7];
int count = 0; 
for( int i = 0; i < arr.Length; i ++){
    arr[i] = count;
    count++;
    Console.WriteLine(arr[i]);
}

List<string> name = new List<string>();
name.Add("Colin");
name.Add("Nick");
name.Add("Toni Montana");


Console.WriteLine(name[1]);


Dictionary<int, string> candies = new Dictionary<int, string>();
candies.Add(1,"Snickers Peanut");
candies.Add(2, "KitKat");
candies.Add(3, "Reese's");

Console.WriteLine("Candy #2 " + candies[2]);

foreach(KeyValuePair<int, string> entry in candies){
    Console.WriteLine(entry.Key + " : " + entry.Value); 
}

static void hello(){
    Console.WriteLine("hello, C#!");
    
}

hello();