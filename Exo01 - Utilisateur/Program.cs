using System;

namespace Exo01___Utilisateur
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Veuillez introduire le nom d'utilisateur : ");
            string name_user = Console.ReadLine();
            Console.Clear();
            Console.Write("Veuillez indiquer votre année de naissance : ");
            string year_user = Console.ReadLine();
            Console.Clear();
            Console.Write("Quel mois : ");
            string month_user = Console.ReadLine();
            Console.Clear();
            Console.Write("Quel jour : ");
            string day_user = Console.ReadLine();
            Console.Clear();
            //Console.WriteLine("Bienvenu {0}, vous êtes né un  {1}-{2}-{3}!",name_user,day_user,month_user,year_user);
            Console.WriteLine($"Bienvenu {name_user}, vous êtes né un  {day_user}-{month_user}-{year_user}!");
        }
    }
}
