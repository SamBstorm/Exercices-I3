using System;

namespace Exo16_CodeCesar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine('\u1F60');
            Console.WriteLine("Quel message encoder?");
            string input = Console.ReadLine();
            char[] chars = input.ToCharArray();
            string number_input;
            short key;
            do
            {
                Console.WriteLine("Veuillez introduire la clé d'encryption :");
                number_input = Console.ReadLine();
            } while (!short.TryParse(number_input, out key));
            while (key < 0) {
                key += 128;
            }
            for (int i = 0; i < chars.Length; i++)
            {
                short code_char = (short)chars[i];
                code_char += key;
                chars[i] = (char)(code_char % 128);
                //chars[i] = (char)(((short)chars[i]) + key);
            }
            foreach (char encrypt_char in chars)
            {
                Console.Write(encrypt_char);
            }
        }
    }
}
