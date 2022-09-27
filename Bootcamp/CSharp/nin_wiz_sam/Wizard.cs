public class Wizard : Human
{
    public Wizard(string name) : base(name, 3, 25, 3, 50){}

    
    public override int Attack(Human target)
    {
        int dmg = Intelligence * 3;
        target.Health -= dmg;
        this.Health += dmg;

        if(target.Health < Intelligence * 3)
        {
            target.Health = 0;
        }

        Console.WriteLine($"{Name} stole {target.Name}'s health. {Name}'s health is at {this.Health}, {target.Name} is at {target.Health} health.");
        return target.Health;
    } 


    public int Heal()
    {


        Console.WriteLine($"{Name} healed themselves. {Name} is now at {Health} health.");
        return Health;
    }
}
