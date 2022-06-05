using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quadratic_Equation_Solver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        private void buttonstart_Click(object sender, EventArgs e)
        {


            double a;
            if (double.TryParse(txtb1.Text, out a)==false)
            {
                MessageBox.Show("Incorrect input data (a)");
                return;
            }
            double b;
            if (double.TryParse(txtb2.Text, out b) == false)
            {
                MessageBox.Show("Incorrect input data (b)");
                return;
            }
            double c;
            if (double.TryParse(txtb3.Text, out c) ==false)
            {
                MessageBox.Show("Incorrect input data (c)");
                return;
            }
            

            double d = Math.Pow(b, 2)-4*a*c;

            if (d < 0)
            {
                txtb4.Visible = false;
                txtb5.Visible = false;
                return;
            }
            else
            {
                txtb4.Visible = true;
                txtb5.Visible = true;
            }

            double square_root = (-b + Math.Sqrt(d)) / (2 * a);
            double square_root2 = (-b - Math.Sqrt(d)) / (2 * a);

            if (square_root == square_root2)
            {
                txtb5.Visible = false;
            }
            else
            {
                txtb2.Visible = true;
            }


            txtb4.Text = square_root.ToString();
            txtb5.Text = square_root2.ToString();
        }
    }
}
