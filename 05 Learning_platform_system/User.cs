public abstract class User
{
    protected string firstName {get;set;}
    protected string lastName {get;set;}
    public User(string firstname, string lastname)
    {
        firstName = firstname;
        lastName = lastname;
    }
    public void AccessContent(Content content) // "Content content" means any kind of content, can be Percent or Units. 
    {
        content.UpdateProgress();
        content.ProgressInfo();
    }
}