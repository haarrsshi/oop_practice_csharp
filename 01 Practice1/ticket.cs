using System.Dynamic;

public abstract class Ticket
{
    protected int ID {get;set;}
    protected string Title{get;set;}
    protected string Description {get;set;}
    protected string Status {get;set;}
    protected Ticket(int id, string title, string description, string status)
    {
        ID = id;
        Title = title;
        Description = description;
        Status = status;
    }
    public abstract void Open();
    public abstract void Closed();
    
}

public class InternalTicket : Ticket
{
    public string Department {get;set;}
      public InternalTicket(int id, string title, string description, string status, string department) : base(id, title, description, status)
    {
        Department = department;
    }
    public override void Open()
    {
        Console.WriteLine("Internal tickets opened");
    }
    public override void Closed()
    {
        Console.WriteLine("Internal tickets closed");
    }

    public override string ToString()
    {
        return $"[Internal] {ID}: {Title} (Dept: {Department})";
    }
}
public class ExternalTicket : Ticket
{
    public string CusEmail {get;set;}
      public ExternalTicket(int id, string title, string description, string status, string cusEmail) : base(id, title, description, status)
    {
        CusEmail = cusEmail;
    }
    public override void Open()
    {
        Console.WriteLine("external tickets opened");
    }
    public override void Closed()
    {
        Console.WriteLine("external tickets closed");
    }

    public override string ToString()
    {
        return $"[external] {ID}: {Title} (Dept: {CusEmail})";
    }
}