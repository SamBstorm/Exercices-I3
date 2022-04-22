using System;

namespace Exo02___UtilisateurAge
{
    class Program
    {
        /*
            Créez une application console permettant d'enregistrer
            le nom d'un utilisateur, ainsi que son année de naissance.

            Effacez le contenu, et affichez : 
            "Bienvenu Utilisateur, vous êtes âgé de ## ans!"

            Vous êtes obligé d'utiliser le TryParse()
         */
        static void Main(string[] args)
        {
            //Récupération de la date du système
            DateTime aujourdhui = DateTime.Now;
            //Récupération de l'information d'année dans la date
            int annee_courante = aujourdhui.Year;
            Console.WriteLine("Veuillez indiquer votre nom : ");
            string nom_utilisateur = Console.ReadLine();
            Console.WriteLine("Veuillez indiquer votre année de naissance : ");
            string input = Console.ReadLine();
            int annee_utilisateur;
            bool si_age = int.TryParse(input, out annee_utilisateur);
            Console.Clear();
            Console.WriteLine($"Bienvenu {nom_utilisateur}, vous avez {annee_courante - annee_utilisateur} ans.");
            //Simplification, plus besoin de variable pour l'année:
            //Console.WriteLine($"Bienvenu {nom_utilisateur}, vous avez {DateTime.Now.Year - annee_utilisateur} ans.");
        }
    }
}
