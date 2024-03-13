namespace ParabolicReflectorDish.Tests;

public class Dish
{
    private string rocksConfiguration;
    private CalcolatoreDelCarico calcolatoreDelCarico;

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

    public Dish(string initialRocksConfiguration) : this(initialRocksConfiguration, new CalcolatoreDelCarico())
    {
       
    }

    public Dish(string initialRocksConfiguration, CalcolatoreDelCarico calcolatoreDelCarico)
    {
        this.calcolatoreDelCarico = calcolatoreDelCarico;
        rocksConfiguration = initialRocksConfiguration;
    }

    public int TotalLoad => calcolatoreDelCarico.CalcolaCarico(rocksConfiguration);


    public void ShowConfiguration()
    {
        Console.Write(rocksConfiguration);
    }

}