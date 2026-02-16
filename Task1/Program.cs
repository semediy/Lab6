class Program
{
    static void Main(string[] args)
    {
        List<Vehicle> vehicles = new List<Vehicle>
        {
            new Car("Toyota", 120),
            new Bicycle("Trek", 25),
            new Airplane("Boeing 737", 850)
        };

        foreach (Vehicle vehicle in vehicles)
        {
            vehicle.Move();   
        }

        Console.WriteLine("Перевірка можливості заправки:");

        foreach (Vehicle vehicle in vehicles)
        {
            if (vehicle is Refuelable refuelableVehicle)
            {
                refuelableVehicle.Refill();
            }
        }
    }
}
