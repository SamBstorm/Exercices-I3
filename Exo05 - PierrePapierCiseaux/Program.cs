using System;

namespace Exo05___PierrePapierCiseaux
{
    class Program
    {
        static Random RNG = new Random();
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Write("PIERRE - PAPIER - CISEAUX");
            
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine(@"Veuillez choisir une des propositions:
    1) Pierre
    2) Papier
    3) Ciseaux");
            string input = Console.ReadLine();
            bool isConverted = int.TryParse(input, out int user_choice);
            if (isConverted && user_choice >= 1 && user_choice <= 3)
            {
                //jeu
                int cpu_choice = RNG.Next(1,4);
                string message = "";
                switch (cpu_choice)
                {
                    case 1:
                        message = "Cpu : PIERRE - ";
                        break;
                    case 2:
                        message = "Cpu : PAPIER - ";
                        break;
                    default:
                        message = "Cpu : CISEAUX - ";
                        break;
                }
                switch (user_choice)
                {
                    case 1:
                        message += "User : PIERRE";
                        break;
                    case 2:
                        message += "User : PAPIER";
                        break;
                    default:
                        message = message + "User : CISEAUX";
                        break;
                }
                Console.WriteLine(message);
                if (cpu_choice == user_choice)
                {
                    Console.WriteLine("Égalité...");
                }
                else if (
                    (user_choice == 1 && cpu_choice == 3) ||
                    (user_choice == 2 && cpu_choice == 1) ||
                    (user_choice == 3 && cpu_choice == 2)
                    )
                {
                    Console.WriteLine("Féliciation! La force est avec toi!");
                }
                else {
                    Console.WriteLine("Quel dommage, vous avez perdu... C'est triste...");
                }
            }
            else {
                Console.Clear();
                Console.WriteLine("Apprends à lire avant de venir jouer!");
            }
        }
    }
}
