public abstract class Vehicle
{
    protected string Brand {get;set;}
    protected bool IsRented {get;set;}
    public Vehicle (string brand)
    {
        Brand = brand;
        IsRented = false;
    }
    public void Rent()
    {
        IsRented = true;
        Console.WriteLine("Your Vehicle is rented!");
    }
    public void Return()
    {
        IsRented = false;
        Console.WriteLine("Your vehicle is returned to us");
    }
    public abstract decimal CalculateRentalPrice(int days);

}