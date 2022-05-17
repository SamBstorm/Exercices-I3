using System;

namespace Exo18___421
{
    class Program
    {
        public static Random RNG = new Random();
        static void Main(string[] args)
        {
            do
            {
                ushort[] values_check = { 4, 2, 1 };
                ushort[] dices_thrice = new ushort[3];
                bool didWin = true;

                for (int i = 0; i < dices_thrice.Length; i++)
                {
                    dices_thrice[i] = (ushort)RNG.Next(1, 7);
                }

                foreach (ushort dice in dices_thrice)
                {
                    Console.Write($"{dice}\t");
                }
                Console.WriteLine();

                for (int i = 0; i < values_check.Length && didWin; i++)
                {
                    for (int j = 0; j < dices_thrice.Length; j++)
                    {
                        if (dices_thrice[j] == values_check[i]) values_check[i] = 0;
                    }
                    if (values_check[i] != 0) didWin = false;
                }

                if (didWin) Console.WriteLine("Bravo! Vous avez gagné!");
                else Console.WriteLine("Quel dommage...");
                Console.WriteLine("Appuyer sur 'Q' pour quitter, 'Enter' pour continuer...");
          //  } while (Console.ReadLine().ToUpper().Trim() != "Q" );
            } while (Console.ReadKey(true).Key != ConsoleKey.Q );
        }
    }
}
