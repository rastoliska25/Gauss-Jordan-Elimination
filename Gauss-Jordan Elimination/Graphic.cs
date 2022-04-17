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

        }

        private void btTest_Click(object sender, EventArgs e)
        {
            int sol;
            Calculation calculation = new Calculation();
            sol = calculation.calculate(10);
            textBox1.Text = sol.ToString();
        }
    }
}
