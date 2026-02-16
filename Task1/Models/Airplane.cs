class Airplane : Vehicle, Refuelable
{
    public Airplane(string brand, double speed) : base(brand, speed) { }

    public override void Move()
    {
        Console.WriteLine($"Літак {Brand} літає зі швидкістю {Speed} км/год.");
    }

    public void Refill()
    {
        Console.WriteLine($"Літак {Brand} заправляється паливом.");
    }
}