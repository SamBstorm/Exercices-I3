using System;

namespace Exo10___Tables
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int table = 1; table <= 5; table++)
            {
                for (int multiplicateur = 1; multiplicateur <= 20; multiplicateur++)
                {
                    Console.Write($"{table} X {multiplicateur} = {table * multiplicateur} ; ");
                }
                Console.WriteLine();
            }
        }
    }
}
