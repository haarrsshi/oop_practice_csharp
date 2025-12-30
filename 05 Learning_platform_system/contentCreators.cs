using System.Reflection.Metadata;
public class Creators : User
{
    public Creators(string firstname, string lastname) : base(firstname, lastname)
    {
        CanCreateContent = true;
    }
}