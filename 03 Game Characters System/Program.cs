public class Program
{
    static void Main(string[] args)
    {
        Warrior warrior1 = new Warrior ("tomato", 24, 56);
        Mage mage1 = new Mage ("potato", 34, 54);
        Enemy enemy1 = new Enemy ("bad dude", 34);

        List<Character> characters = new List<Character>();
        characters.Add(warrior1);
        characters.Add(mage1);

        foreach(Character character in characters)
        {
            character.Attack();
            enemy1.TakeDamage(character.GetDamage());
            Console.WriteLine($"Enemy health: {enemy1.Health}");
            if (!enemy1.IsAlive())
            {
                Console.WriteLine("Enemy defeated!");
                break;
            }
        }
    }
}