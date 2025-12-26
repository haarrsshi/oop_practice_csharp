public class Warrior : Character
{
    protected int Strength;
    public Warrior (string name, int health, int strength) : base(name, health)
    {
        Strength = strength;
    }
    public override void Attack()
    {
        Console.WriteLine($"{Name} attacks with {Strength} damage.");
    }

}