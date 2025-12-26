public class BankTransferPayment : Payment
{
    protected int IBAN {get;set;}
    public BankTransferPayment (int amount, int iban) : base(amount)
    {
        IBAN = iban;
    }
    public override void ProcessPayment()
    {
        Console.WriteLine("Your bank transfer is processing, please wait");
    }
    public override void ShowDetails()
    {
        Console.WriteLine($"{Amount}, {IBAN}");
    }
}