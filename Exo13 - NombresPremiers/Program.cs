using System;

namespace Exo13___NombresPremiers
{
    class Program
    {
        static void Main(string[] args)
        {
            uint number;
            do {
                Console.WriteLine("Combien de nombres premiers voulez-vous?");   
            }   while (!uint.TryParse(Console.ReadLine(), out  number));
            for (int count = 0, nbTest = 2; count < number; nbTest++)
            {
                int div_count = 0; 
                for (int diviseur = 2; diviseur < nbTest; diviseur++) {
                    if (nbTest % diviseur == 0) div_count++;
                }
                if (div_count == 0) {
                    count++;
                    Console.WriteLine(nbTest);
                }
            }
        }
    }
}
