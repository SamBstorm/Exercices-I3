using System;

namespace Exo03___InversionValeur
{
    class Program
    {
        /*
            Créez une application console permettant d'enregistrer 2 nombres,
            un que l'on nomme A, l'autre que l'on nomme B

            Faites en sorte que la valeur de A se retrouve dans B et inversément

            Exemple : 
            Veuillez entrer la valeur de A : 5
            Veuillez entrer la valeur de B : 7

            A vaut maintenant 7 et B vaut maintenant 5         
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Veuiller entrer le nombre A :");
            string input_nbA = Console.ReadLine();
            Console.WriteLine("Veuiller entrer le nombre B :");
            string input_nbB = Console.ReadLine();
            int nbA;
            bool is_int = int.TryParse(input_nbA, out nbA);
            int nbB;
            is_int = int.TryParse(input_nbB, out nbB);

            Console.WriteLine($"A vaut {nbA} et B vaut {nbB}.");

            #region Première méthode : Variable temporaire
            //int nbC;
            //nbC = nbA;      //A : 5 | B : 7 | C : 5
            //nbA = nbB;      //A : 7 | B : 7 | C : 5
            //nbB = nbC;      //A : 7 | B : 5 | C : 5
            #endregion

            #region Seconde méthode : Mathématique
            nbA = nbA + nbB;        //A : (5+7) => 12 | B : 7
            nbB = nbA - nbB;        //A : 12 | B : (12-7) => 5
            nbA = nbA - nbB;        //A : (12-5) => 7 | B : 5
            #endregion

            #region Troisième méthode : Tuple
            //(nbA, nbB) = (nbB, nbA);
            #endregion

            Console.WriteLine($"A vaut {nbA} et B vaut {nbB}.");
        }
    }
}
