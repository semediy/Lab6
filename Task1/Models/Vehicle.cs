abstract class Vehicle
{
    public string Brand { get; set; }
    public double Speed { get; set; }

    public Vehicle(string brand, double speed)
    {
        Brand = brand;
        Speed = speed;
    }
    public abstract void Move();
}