using System;

namespace Exo06_DivisionModuloDivisionEntiere
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Entrer une valeur qui sera le dividende:");
            string input = Console.ReadLine();
            bool b_input = int.TryParse(input, out int dividende);
            Console.Clear();
            if (b_input)
            {
                Console.WriteLine("Entrer une valeur qui sera le diviseur:");
                input = Console.ReadLine();
                b_input = int.TryParse(input, out int diviseur);
                Console.Clear();
                if (b_input) {
                    Console.Write("Division entière : "+ dividende / diviseur);
                    Console.Write("\tModulo : "+ dividende % diviseur);
                    Console.Write("\tDivision : "+ (float) dividende / diviseur);
                }
            }
            if (!b_input) Console.WriteLine("Veux-tu bien laisser tes parents travailler?");
        }
    }
}
