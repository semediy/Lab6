class Candle : LightSource
{
    public Candle(int intensity, string color) : base(intensity, color) { }

    public override void EmitLight()
    {
        Console.WriteLine($"Свічка мерехтить {Color} світлом з інтенсивністю приблизно {Intensity} люмен.");
    }
}