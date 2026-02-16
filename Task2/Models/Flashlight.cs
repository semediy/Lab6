class Flashlight : LightSource
{
    public Flashlight(int intensity, string color) : base(intensity, color) { }

    public override void EmitLight()
    {
        Console.WriteLine($"Ліхтарик світить спрямованим {Color} променем з інтенсивністю {Intensity} люмен.");
    }
}