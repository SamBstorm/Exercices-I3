using System;

namespace Exo19___TableauPoint
{
    public struct Point
    {
        public int X, Y;
    }

    class Program
    {
        static void Main(string[] args)
        {
            const int SIZE = 5;
            //Nullable<Point>[,] tableau = new Nullable<Point>[SIZE,SIZE];
            Point?[,] tableau = new Point?[SIZE, SIZE];
            for (int i = 0; i < SIZE; i++)
            {
                //tableau[i, i] = new Point() { X = i + 1, Y = i + 1 };

                Point p;
                p.X = i + 1;
                p.Y = i + 1;
                tableau[i, i] = p;
            }

            //Boucle manipulant les lignes du tableau
            for (int i = 0; i < SIZE; i++)
            {
                //Boucle manipulant les cellules des lignes du tableau
                for (int j = 0; j < SIZE; j++)
                {
                    if (tableau[i, j] is null) Console.Write("\t");
                    else {
                        //Point p = (Point)tableau[i, j];
                        //Console.Write($"X : {p.X} - Y : {p.Y}");
                        //Console.Write($"X : {((Point)tableau[i, j]).X} - Y : {((Point)tableau[i, j]).Y}");
                        Console.Write($"X : {tableau[i, j]?.X} - Y : {tableau[i, j]?.Y}");
                    } 
                }
                Console.WriteLine();
            }
        }
    }
}
