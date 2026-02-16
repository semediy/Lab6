class Lamp : LightSource
{
    public Lamp(int intensity, string color) : base(intensity, color) { }

    public override void EmitLight()
    {
        Console.WriteLine($"Лампа світить рівномірним {Color} світлом з інтенсивністю {Intensity} люмен.");
    }
}

