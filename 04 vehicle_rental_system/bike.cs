public class Bike : Vehicle
{
    protected decimal HourlyRate {get;set;}
    public Bike (string brand, decimal hourlyrate) : base(brand)
    {
        HourlyRate = hourlyrate;
    }
    public override decimal CalculateRentalPrice(int days)
    {
        decimal RentalPrice = HourlyRate * days * 24;
        return RentalPrice;
    }
}