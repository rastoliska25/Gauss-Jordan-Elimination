using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gauss_Jordan_Elimination
{
    class Calculation
    {
        int row = 0;
        int q = 10;
        int col, i;


        public int calculate(int x)
        {
            for (int i = 1; i < q + 1; i++)
            {
                if (x % i == 0)
                {
                    row = 100;
                }
            }
            return row;
        }
    }
}
