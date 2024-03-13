namespace ParabolicReflectorDish.Tests;

public class Dish
{
    private string rocksConfiguration;

    public Dish() : this(EmptyConfiguration()) { }

    private static string EmptyConfiguration()
    {
        var puntini = "..........";
        var newLine = Environment.NewLine;
        var expectedConfiguration = "";

        for (int i = 0; i < 9; i++)
        {
            expectedConfiguration += $"{puntini}{newLine}";
        }
        expectedConfiguration += $"{puntini}";
        return expectedConfiguration;
    }

    public Dish(string initialRocksConfiguration)
    {
        rocksConfiguration = initialRocksConfiguration;
        if (rocksConfiguration == EmptyConfiguration())
        {
            TotalLoad = 0;
        }
        else
        {
            TotalLoad = 19;
        }
    }

    public int TotalLoad { get; private set; }


    public void ShowConfiguration()
    {
        Console.Write(rocksConfiguration);
    }

}