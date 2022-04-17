using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gauss_Jordan_Elimination
{
    class Input
    {
        string inputText;
        int row, col;
        public string input(int x)
        {
            for (int row = 1; row < x + 1; row++)
            {
                for (int col = 1; col < x + 1; col++)
                {
                    inputText = inputText + "0";
                }
                inputText = inputText + "\n";
            }
            return inputText;
        }

        internal string input(bool v)
        {
            throw new NotImplementedException();
        }
    }
}
