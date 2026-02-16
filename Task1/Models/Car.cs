class Car : Vehicle, Refuelable
{
    public Car(string brand, double speed) : base(brand, speed) { }

    public override void Move()
    {
        Console.WriteLine($"Автомобіль {Brand} їде зі швидкістю {Speed} км/год.");
    }

    public void Refill()
    {
        Console.WriteLine($"Автомобіль {Brand} заправляється пальним.");
    }
}