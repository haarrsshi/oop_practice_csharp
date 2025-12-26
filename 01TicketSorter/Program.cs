using System.Collections.Generic;
public class Program
{
    static void Main(string[] args)
    {
        InternalTicket intTicket1 = new InternalTicket (1, "CoolTicket", "Super Cool", "Open", "IT");
        ExternalTicket extTicket1 = new ExternalTicket (2, "FunTicket", "Fun Ticket", "In progress", "example@email.com");
        
        List<Ticket> tickets = new List<Ticket>();
        tickets.Add(intTicket1);
        tickets.Add(extTicket1);
        foreach (Ticket ticket in tickets)
        {
            Console.WriteLine(ticket);
            ticket.Open();
            ticket.Closed();
        }   
    }
}