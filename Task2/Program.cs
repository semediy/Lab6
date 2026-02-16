class Program
{
    static void Main(string[] args)
    {
        List<LightSource> lights = new List<LightSource>
        {
            new Lamp(800, "білим"),
            new Flashlight(300, "холодним білим"),
            new Candle(50, "теплим жовтим")
        };

        foreach (var light in lights)
        {
            light.EmitLight(); 
        }
    }
}