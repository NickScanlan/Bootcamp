class Buffet
{
    public List<Food> Menu;
     
    //constructor
    public Buffet()
    // In the Buffet class, set Menu to a hard coded list of 7 or more Food objects you instantiate manually
    {
        Menu = new List<Food>()
        {
            new Food("Example", 1000, false, false)
        };
    }
     
    public Food Serve()
    {
    }
}





