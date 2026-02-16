abstract class LightSource
{
    public int Intensity { get; set; }   
    public string Color { get; set; }    

    public LightSource(int intensity, string color)
    {
        Intensity = intensity;
        Color = color;
    }

    public abstract void EmitLight();
}
