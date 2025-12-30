using System.Dynamic;

public abstract class ContactData
{
    public static readonly Type[]Types =
    [
        typeof(EmailAddress),
        typeof(PhoneNumber),
        typeof(PostalAddress),
    ];

    public void Print(bool isPrimary)
    {
        string primarySuffix = isPrimary ? " (⭐️)" : "";
        Console.WriteLine(this + primarySuffix); // this: die objekt das aus der Methode aufgerufen wird. 
    }
}