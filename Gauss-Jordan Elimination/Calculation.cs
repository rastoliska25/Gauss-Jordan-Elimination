using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gauss_Jordan_Elimination
{
    class Calculation
    {
        float[,] matrice;
        float[] arraySolution;
        string text;
        int col, row, valB;
        float con;
        float sum = 0;

        public Calculation(float[,] matrice)
        {
            this.matrice = matrice;
        }

        public string calculate(int n)
        {
            arraySolution = new float[10];

            for (col = 0; col < n; col++)
            {
                for (row = 0; row < n; row++)
                {
                    if (row > col)
                    {
                        con = matrice[row, col] / matrice[col, col];
                        for (valB = 0; valB < n + 1; valB++)
                        {
                            matrice[row, valB] = matrice[row, valB] - con * matrice[col, valB];
                        }
                    }
                }
            }

            arraySolution[n] = matrice[n - 1, n] / matrice[n - 1, n - 1];

            for (row = n - 1; row >= 1; row--)
            {
                sum = 0;
                for (col = row + 1; col <= n - 1; col++)
                {
                    sum = sum + matrice[row, col] * arraySolution[col];
                }
                arraySolution[row] = (matrice[row - 1, n] - sum) / matrice[row - 1, row - 1];
            }

            //solution string
            for (row = 1; row <= n; row++)
            {
                text = text + String.Format("{0}  ", arraySolution[row]);
            }
            return text;
        }
    }
}
