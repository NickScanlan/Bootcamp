public class Samurai : Human
{
    
    public Samurai(string name) : base(name, 3, 3, 3, 200){}

    public override int Attack(Human target)
    {
        int dmg = Strength * 3;
        
        target.Health -= dmg;
        
        Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage! {target.Name} has {target.Health} health.");
        
        if(target.Health <= 50)
        {
            target.Health = 0;
            
            Console.WriteLine($"{target.Name} has been critically hit!");
        }
        return target.Health;
    }

    public int Meditate()
    {
        this.Health = 200;
        
        Console.WriteLine($"{Name} healed to {Health} health!");
        
        return this.Health;
    }
}