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
        public string input(int x)
        {
            for (int row = 0; row < x; row++)
            {
                for (int col = 0; col < x + 1; col++)
                {
                    inputText = inputText + "0      ";
                }
                inputText = inputText + "\n\n";
            }
            return inputText;
        }

        internal string input(bool v)
        {
            throw new NotImplementedException();
        }
    }
}
