using System;

namespace Exo08___Factoriel
{
    class Program
    {
        static void Main(string[] args)
        {
            uint input;
            do Console.WriteLine("Veuillez introduire un nombre :");
            while (!uint.TryParse(Console.ReadLine(), out input));
            //int factorial = 1;
            //for (int i = 2; i <= input; i ++)
            //{
            //    factorial *= i;
            //}
            //Console.WriteLine($"La factoriel de {input} est {factorial}");
            ulong factorial = 1;
            for (uint i = input; i > 1; i--)
            {
                checked
                {
                    factorial *= i;
                }
            }
            Console.WriteLine($"La factoriel de {input} est {factorial}");
        }
    }
}
