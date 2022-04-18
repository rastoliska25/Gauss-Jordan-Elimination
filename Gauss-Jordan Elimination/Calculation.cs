using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gauss_Jordan_Elimination
{
    class Calculation
    {
        int[,] matrice;
        string text;
        int row = 0;
        int col = 0;

        public Calculation(int[,] matrice)
        {
            this.matrice = matrice;
        }

        public string calculate()
        {
            text = String.Format("{0}  ", matrice[1, 1]);

            return text;
        }
    }
}
