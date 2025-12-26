public class Program
{
    static void Main(string[]args)
    {
        CreditCardPayment payment1 = new CreditCardPayment (234029348,2345376 );
        BankTransferPayment payment2 = new BankTransferPayment (547389045, 34224);

        List<Payment> payments = new List<Payment>();
        payments.Add(payment1);
        payments.Add(payment2);

        foreach(Payment payment in payments)
        {
            payment.ShowDetails();
            payment.ProcessPayment();
        }
    }
}