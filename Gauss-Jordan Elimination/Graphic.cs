using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gauss_Jordan_Elimination
{
    public partial class Graphic : Form
    {
        int inputNumber, fillNumber, i, j;
        int row = 1;
        int col = 1;
        float[,] matriceDataInput;
        Matrice matrice;

        public Graphic()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox.ReadOnly = true;
            panelInputValues.Visible = false;
            btInsertData.Enabled = false;
            btCalculate.Enabled = false;
        }

        private void btClearRichTextBox_Click(object sender, EventArgs e)
        {
            richTextBox.Text = "";
            tbInputMatrice.Text = "";
            row = 1;
            col = 1;
        }

        private void btInput_Click(object sender, EventArgs e)
        {
            inputNumber = 0;

            Input input = new Input();

            if (int.TryParse(tbInputMatrice.Text, out inputNumber))
            {
                if (inputNumber > 10)
                {
                    MessageBox.Show("number cannot be grater than 10, please insert input again");
                    tbInputMatrice.Text = "";
                    return;
                }
                else
                {
                    richTextBox.Text = input.input(inputNumber);
                    btInsertData.Enabled = true;
                    inputData(inputNumber);
                    row = 1;
                    col = 1;
                }
            }
            else
            {
                MessageBox.Show("problem with parsing string to int - please load input again");
            }

        }

        private void tbInputMatrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool badInput = false;
            if ((!Char.IsNumber(e.KeyChar)) && (!(e.KeyChar == (char)8)) && (!(e.KeyChar == (char)13)))
            {
                badInput = true;
                e.Handled = true;
            }

            if (badInput)
            {
                MessageBox.Show("please insert number from 1 to 10");
                tbInputMatrice.Text = "";
                badInput = false;
            }
        }

        private void btInsertData_Click(object sender, EventArgs e)
        {
            if (richTextBox.Text == "")
            {
                MessageBox.Show("please insert matrice size at first");
            }
            else
            {
                panelInputValues.Visible = true;
                labelDataInputValue.Text = "Matrice [1][1]";
            }
        }

        private void btCancedlInputData_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("do you really want to stop entering values?", "Cancel", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                richTextBox.Text = "";
                panelInputValues.Visible = false;
                btInsertData.Enabled = false;
                tbInputMatrice.Text = "";
            }
        }

        private void tbInputData_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!Char.IsNumber(e.KeyChar)) && (!(e.KeyChar == (char)8)) && (!(e.KeyChar == (char)13)) && (!(e.KeyChar == (char)45)))
            {
                e.Handled = true;
                MessageBox.Show("please insert number from -100 to 100");
                tbInputMatrice.Text = "";
            }
        }

        private void btCalculate_Click(object sender, EventArgs e)
        {
            btCalculate.Enabled = false;
            Calculation calculation = new Calculation(matriceDataInput);
            richTextBox.Text = richTextBox.Text + "\n\n\n" + calculation.calculate(inputNumber);
        }

        private void btInsertInputData_Click(object sender, EventArgs e)
        {
            if (tbInputData.Text == "")
            {
                MessageBox.Show("please insert number");
            }
            else
            {
                if (int.TryParse(tbInputData.Text, out fillNumber))
                {
                    //data into matrice
                    matriceDataInput[row - 1, col - 1] = fillNumber;
                    col++;
                    if ((row == (inputNumber)) && (col == (inputNumber + 2)))
                    {
                        panelInputValues.Visible = false;
                        btInsertData.Enabled = false;
                        btCalculate.Enabled = true;
                        arrayListing();
                    }

                    if (col == (inputNumber + 2))
                    {
                        col = 1;
                        row++;
                    }
                    arrayListing();
                    tbInputData.Text = "";
                    this.ActiveControl = tbInputData;
                    labelDataInputValue.Text = String.Format("Matrice [{0}][{1}]", row, col);
                }
                else
                {
                    MessageBox.Show("problem with parsing string to int - please load input again");
                    return;
                }
            }
        }

        private void inputData(int x)
        {
            matriceDataInput = new float[x, x + 1];
        }

        private void arrayListing()
        {
            string inputText = "";
            for (i = 0; i < inputNumber; i++)
            {
                for (j = 0; j < inputNumber + 1; j++)
                {
                    inputText = inputText + String.Format("{0}      ", matriceDataInput[i, j]);
                }
                inputText = inputText + "\n\n";
            }
            richTextBox.Text = inputText;
        }
    }
}
