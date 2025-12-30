public abstract class Person
{
    protected string FirstName {get;set;}
    protected string LastName{get;set;}
    protected DateOnly DoB {get;set;}
    protected string Sex {get;set;}

    // private  List<ContactData> _contactData;
    /*public Person(List<ContactData>? contactData = null)
    {
        _contactData = contactData ?? new List<ContactData>();
    }*/
}