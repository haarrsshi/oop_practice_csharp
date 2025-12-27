public class Program
{
    static void Main(string[]args)
    {
        Car car1 = new Car ("Porche", 456.9m );
        Bike bike1 = new Bike ("Yamaha", 38.90m);

        List<Vehicle> vehicles = new List<Vehicle>();
        vehicles.Add(car1);
        vehicles.Add(bike1);

        foreach (Vehicle v in vehicles)
        {
            v.Rent();
            decimal price = v.CalculateRentalPrice(6);
            Console.WriteLine($"Price: {price}");
            v.Return();
        }

    }
}