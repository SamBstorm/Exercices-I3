using System;

namespace Exo04___PairImpair
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez indiquer un nombre entier : ");

            if (!int.TryParse(Console.ReadLine(), out int nb))
            {
                Console.WriteLine("La valeur n'est pas un nombre entier...");
            }
            else {
                if ((nb / 2) * 2 == nb)
                {
                    Console.WriteLine($"Le nombre {nb} est pair.");
                }
                else
                {
                    Console.WriteLine($"Le nombre {nb} est impair.");
                }
            }
        }
    }
}
