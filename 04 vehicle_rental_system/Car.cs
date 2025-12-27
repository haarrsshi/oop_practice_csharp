using System.Reflection;

public class Car : Vehicle
{
    protected decimal DailyRate {get;set;}
    public Car (string brand, decimal dailyrate) : base(brand)
    {
        DailyRate = dailyrate;
    }
    public override decimal CalculateRentalPrice(int days)
    {
        decimal RentalPrice = DailyRate * days;
        return RentalPrice;
    }
}