class Bicycle : Vehicle
{
    public Bicycle(string brand, double speed) : base(brand, speed) { }

    public override void Move()
    {
        Console.WriteLine($"Велосипед {Brand} рухається зі швидкістю {Speed} км/год.");
    }
}