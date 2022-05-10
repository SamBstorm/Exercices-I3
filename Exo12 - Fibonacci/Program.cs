using System;

namespace Exo12___Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int nb1 = 0, nb2 = 1, nb3;
            Console.WriteLine($"F0 : {nb1}");
            Console.WriteLine($"F1 : {nb2}");
            for (int i = 2; i <= 25; i++)
            {
                nb3 = nb1 + nb2;
                Console.WriteLine($"F{i} : {nb3}");
                nb1 = nb2;
                nb2 = nb3;
            }
        }
    }
}
