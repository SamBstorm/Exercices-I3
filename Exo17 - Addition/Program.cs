using System;
using System.Collections.Generic;

namespace Exo17___Addition
{
    class Program
    {
        static void Main(string[] args)
        {
            string number_1;
            string number_2;
            do
            {
                Console.WriteLine("Veuillez introduire le premier nombre : ");
                number_1 = Console.ReadLine(); 
            } while (!int.TryParse(number_1, out _));
            do
            {
                Console.WriteLine("Veuillez introduire le second nombre : ");
                number_2 = Console.ReadLine();
            } while (!int.TryParse(number_2, out _));

            while (number_1.Length < number_2.Length)
            {
                number_1 = "0" + number_1;
            }
            while (number_2.Length < number_1.Length)
            {
                number_2 = "0" + number_2;
            }
            Console.WriteLine(number_1);
            Console.WriteLine(number_2);
            char[] char_1 = number_1.ToCharArray();
            char[] char_2 = number_2.ToCharArray();
            ushort report = 0;
            ushort[] result = new ushort[char_1.Length+1];
            for (int i = char_1.Length - 1; i >= 0 ; i--)
            {
                ushort nb_1 = ushort.Parse(char_1[i].ToString());
                ushort nb_2 = ushort.Parse(char_2[i].ToString());
                ushort temp = (ushort)(nb_1 + nb_2 + report);
                report = (ushort)(temp / 10);
                temp %= 10;
                result[i+1] = temp;
            }
            result[0] = report;
            foreach (ushort chiffre in result)
            {
                Console.Write(chiffre);
            }
        }
    }
}
