using System;

namespace Exo22___Cartes
{
    class Program
    {
        static void Main(string[] args)
        {
            Carte[] deck = new Carte[52];

            #region Avec Foreach (comme dans l'énoncé)
            //int i = 0;
            //foreach (string color_name in Enum.GetNames<Couleurs>())
            //{
            //    foreach (string value_name in Enum.GetNames<Valeurs>())
            //    {
            //        deck[i].couleur = Enum.Parse<Couleurs>(color_name);
            //        deck[i].valeur = Enum.Parse<Valeurs>(value_name);
            //        i++;
            //    }
            //} 
            #endregion
            #region Avec For, mais avec une astuce grace aux ids
            for (int i = 0; i < deck.Length; i++)
            {
                deck[i].couleur = (Couleurs) (i % 4);
                deck[i].valeur = (Valeurs) ((i%13) + 2);
            }
            #endregion


            foreach (Carte carte in deck)
            {
                Console.WriteLine($"{carte.couleur} - {carte.valeur}");
            }
        }
    }
}
