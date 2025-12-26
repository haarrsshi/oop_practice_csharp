public class Enemy
{
    protected string Name {get;set;}
    public int Health {get;set;}
    public Enemy(string name, int health)
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
}