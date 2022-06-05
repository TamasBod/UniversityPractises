using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Functions_Controlers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        int Fibonacci(int n)
        {
            if (n == 0 || n==1) return 1;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Put();
        }

        private void Put()
        {
            for (int i = 0; i < 10; i++)
            {
                Button b = new Button();
                b.Top = 40 * i;
                b.Height = 40;
                b.Width = 40;

                b.Text = Fibonacci(i).ToString();

                Controls.Add(b);

            }
        }
    }
}
