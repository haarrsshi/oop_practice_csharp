using System.Reflection.Metadata;

public class Program
{
    static void Main(string[]args)
    {
        User creator1 = new Creators("Harshita", "Karthikeyan");
        User consumer1 = new Consumers("Ananya", "Pandey");

        Content unit1 = new UnitContent (500);
        Content percent1 = new PercentContent();

        List<User>users = new List<User>();
        users.Add(creator1);
        users.Add(consumer1);

        List<Content>contents = new List<Content>();
        contents.Add(unit1);
        contents.Add(percent1);

        foreach(User u in users)
        {
            foreach(Content c in contents)
            {
                u.AccessContent(c);               
            }

        }
    }
}