using System;
using System.Collections.Generic;

namespace Exo14___Nombres_premiers_Optimise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<uint> primes = new List<uint>(); 
            int operation = 0;
            uint number;
            do
            {
                Console.WriteLine("Combien de nombres premiers voulez-vous?");
            } while (!uint.TryParse(Console.ReadLine(), out number));
            for (uint count = 0, nbTest = 2; count < number; nbTest++)
            {
                bool isPrime = true;
                for (int i = 0; i < primes.Count && isPrime; i++)
                {
                    if (nbTest % primes[i] == 0) isPrime = false;
                    operation++;
                }
                if (isPrime)
                {
                    count++;
                    primes.Add(nbTest);
                }
            }
            foreach (uint prime in primes)
            {
                Console.WriteLine(prime);
            }

            Console.WriteLine(operation);
        }
    }
}
