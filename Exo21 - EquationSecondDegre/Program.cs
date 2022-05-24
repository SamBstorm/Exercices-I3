using System;

namespace Exo21___EquationSecondDegre
{
    class Program
    {
        static void Main(string[] args)
        {
            Equation eq;
            eq.A = 1;
            eq.B = 1;
            eq.C = 1;
            if(eq.Resoudre(out double? reponse1, out double? reponse2))
            {
                if(reponse1 == reponse2)  Console.WriteLine($"{eq.A} X² + {eq.B} X + {eq.C} , X peut être {reponse1}.");
                else Console.WriteLine($"{eq.A} X² + {eq.B} X + {eq.C} , X peut être {reponse1} ou {reponse2}.");
            }
            else
            {
                Console.WriteLine($"{eq.A} X² + {eq.B} X + {eq.C} , n'est pas résolvable...");
            }
        }
    }
}
