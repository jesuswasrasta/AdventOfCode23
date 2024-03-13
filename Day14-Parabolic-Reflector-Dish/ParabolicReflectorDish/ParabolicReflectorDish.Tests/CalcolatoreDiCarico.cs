using System.Collections;
using NUnit.Framework.Constraints;

public class CalcolatoreDelCarico
{
    private Configuration configuration;

    public CalcolatoreDelCarico()
    {
    }

    public int CalcolaCarico(string rocksConfiguration)
    {
        var configuration = new Configuration(rocksConfiguration);

        int carico = 0;
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                if (configuration.RockConfiguration[i][j] == 'O')
                {
                    int pesoRoccia = 10 - i;
                    carico += pesoRoccia;
                }
                
            }
        }
        
        return carico;
    }
}

internal class Configuration
{
    private char[][] configuration;

    public char[][] RockConfiguration => configuration;

    public Configuration(string stringConfiguration)
    {
        //char[,] configuration = new char[10,10];

        // var configurationLines = stringConfiguration.Split(Environment.NewLine);
        //
        // for (var index = 0; index < configurationLines.Length; index++)
        // {
        //     var coordY = 10 - index;
        //     for (int i = 1; i <= 10; i++)
        //     {
        //         var coordX = i;
        //         var rockOrNot = configurationLines[index][i].ToString();
        //         configuration[coordX,coordY] = rockOrNot;
        //     }
        // }
        configuration = stringConfiguration
            .Split(Environment.NewLine)
            .Select(line => line.ToCharArray())
            .ToArray();
    }
}