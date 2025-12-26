public class CreditCardPayment : Payment
{
    protected int CardNumber {get;set;}

    public CreditCardPayment(decimal amount, int cardnumber) : base(amount)
    {
        CardNumber = cardnumber;
    }
    public override void ProcessPayment()
    {
        Console.WriteLine("Your credit card payment is processing");
    }
    public override void ShowDetails()
    {
        Console.WriteLine($"{Amount}, {CardNumber}");
    }
}