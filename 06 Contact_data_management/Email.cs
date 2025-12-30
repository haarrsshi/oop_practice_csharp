public class EmailAddress : ContactData
{
    public string Email {get;set;}
    public EmailAddress(string email)
    {
        Email = email;
    }
    public override string ToString() => $"--- {Email}";
}