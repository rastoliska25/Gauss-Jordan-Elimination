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
        public Graphic()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox.ReadOnly = true;
            panelInputValues.Visible = false;
        }

        private void btTest_Click(object sender, EventArgs e)
        {
            int sol;
            Calculation calculation = new Calculation();
            sol = calculation.calculate(10);
            textBox1.Text = sol.ToString();
        }

        private void btClearRichTextBox_Click(object sender, EventArgs e)
        {
            richTextBox.Text = "";
        }

        private void btInput_Click(object sender, EventArgs e)
        {
            int inputNumber = 0;

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
    }
}
