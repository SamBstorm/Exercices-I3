using System;

namespace Exo07_BBAN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Insérez le numéro BBAN (12 chiffres) :");
            string input = Console.ReadLine();
            if (input.Length == 12)
            {
                string first_ten = input.Substring(0, 10);
                string last_two = input.Substring(10, 2);
                bool isConverted10 = ulong.TryParse(first_ten, out ulong number10);
                bool isConverted2 = ushort.TryParse(last_two, out ushort number2);
                if (isConverted10 && isConverted2)
                {
                    if ((number10 % 97 == number2 && number2 != 0) || (number10 % 97 == 0 && number2 == 97)) Console.WriteLine("Ok!");
                    else Console.WriteLine("KO!");
                }
                else Console.WriteLine("Ceci n'est pas un numéro BBAN...");
            }
            else Console.WriteLine("Reviens quand tu sauras lire!");
        }
    }
}
