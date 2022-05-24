using System;

namespace Exo22___Cartes
{
    class Program
    {
        static void Main(string[] args)
        {
            Carte[] deck = new Carte[52];

            int i = 0;
            foreach (string color_name in Enum.GetNames<Couleurs>())
            {
                foreach (string value_name in Enum.GetNames<Valeurs>())
                {
                    deck[i].couleur = Enum.Parse<Couleurs>(color_name);
                    deck[i].valeur = Enum.Parse<Valeurs>(value_name);
                    i++;
                }
            }

            foreach (Carte carte in deck)
            {
                Console.WriteLine($"{carte.couleur} - {carte.valeur}");
            }
        }
    }
}
