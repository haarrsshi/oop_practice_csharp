public abstract class User
{
    protected string firstName {get;set;}
    protected string lastName {get;set;}
    protected bool CanCreateContent {get;set;}
    public User(string firstname, string lastname)
    {
        firstName = firstname;
        lastName = lastname;
    }

}