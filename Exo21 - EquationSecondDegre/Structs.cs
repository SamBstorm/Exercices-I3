using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo21___EquationSecondDegre
{
    public struct Equation
    {
        #region Champs/Variables membres

        public double A;
        public double B;
        public double C;

        #endregion
        #region Méthodes
        public bool Resoudre(out double? X1, out double? X2)
        {
            double delta = Math.Pow(B,2) - (4 * A * C);
            if(delta < 0)
            {
                X1 = X2 = null;
                return false;
            }
            X1 = (-B - Math.Sqrt(delta)) / (2 * A);
            X2 = (-B + Math.Sqrt(delta)) / (2 * A);            
            return true;
        }
        #endregion
    }
}
