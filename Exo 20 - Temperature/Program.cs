using System;

namespace Exo_20___Temperature
{
    class Program
    {
        static void Main(string[] args)
        {
            Celsius c;
            c.temperature = 0;
            Fahrenheit f = c.Convert();
            Console.WriteLine(f.temperature); //32
            f.temperature = 114;
            c = f.Convert();
            Console.WriteLine(c.temperature);
        }
    }
}
