public class Program
{
    static void Main(string[] args)
    {
        Warrior warrior1 = new Warrior ("tomato", 24, 56);
        Mage mage1 = new Mage ("potato", 34, 54);

        List<Character> characters = new List<Character>();
        characters.Add(warrior1);
        characters.Add(mage1);

        foreach(Character character in characters)
        {
            character.Attack();
            character.TakeDamage(34);
            character.IsAlive();
        }
    }
}