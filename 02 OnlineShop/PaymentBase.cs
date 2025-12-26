using System.Runtime;
using System.Security.Cryptography;
public abstract class Payment
{
    protected decimal Amount {get; set;}
    public Payment(decimal amount)
    {
        Amount = amount;
    }
    public abstract void ProcessPayment();
    public virtual void ShowDetails(){}
}