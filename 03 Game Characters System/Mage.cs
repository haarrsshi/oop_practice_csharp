using System.Reflection.PortableExecutable;

public class Mage : Character
{
    protected int Mana {get;set;}
    public Mage (string name, int health, int mana) : base(name, health)
    {
        Mana = mana;
    }
    public override int GetDamage()
    {
        return Mana;
    }
    public override void Attack()
    {
        Console.WriteLine($"{Name} casts a spell with {GetDamage()} damage.");
    }
}