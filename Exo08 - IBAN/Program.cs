using System;

namespace Exo08___IBAN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez introduire votre numéro BBAN (12 chiffres) : ");
            string bban = Console.ReadLine();
            Console.Clear();
            if (bban.Length == 12)
            {
                if (ulong.TryParse(bban, out _))
                {
                    string last_two = bban.Substring(10, 2);
                    string code_str = last_two + last_two + 111400;
                    ulong code = ulong.Parse(code_str);
                    ushort first_two = (ushort)(98 - (code % 97));
                    if (first_two < 10) Console.WriteLine($"BE0{first_two + bban}");
                    else Console.WriteLine($"BE{first_two + bban}");
                }
                else {
                    Console.WriteLine("Ceci n'est pas un BBAN valide : Paysan!");
                }
            }
            else
            {
                Console.WriteLine("Shaila a dit que tu devais apprendre à lire!");
            }
        }
    }
}
