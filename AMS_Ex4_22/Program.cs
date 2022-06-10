using System;

namespace AMS_Ex4_22
{
    class Program
    {
        static void Main(string[] args)
        {
            double grausCelsius = 32.5;
            double fahrenheit = (9 * grausCelsius + 160) / 5;

            Console.WriteLine("");
            Console.WriteLine("    ***CONVERSÃO DE GRAUS CELSIUS PARA FAHRENHEIT***      ");

            Console.WriteLine($"O valor equivalente a {grausCelsius} graus Celsius em Fahrenheit é {fahrenheit}");
            Console.WriteLine("");
        }
    }
}
