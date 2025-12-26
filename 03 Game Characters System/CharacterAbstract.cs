public abstract class Character
{
    protected string Name {get;set;}
    protected int Health {get;set;}
    public Character (string name, int health)
    {
        Name = name;
        Health = health;
    }
    public void TakeDamage(int amount)
    {
        Health -= amount;
    }
    public bool IsAlive ()
    {
        if(Health > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public abstract void Attack();
}