using System;
using System.Windows.Forms;

namespace Multiplication_table
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int j = 0; j < 10; j++)
            {
                for (int i = 0; i < 10; i++)
                {
                    Button b = new Button();
                    b.Height = 40;
                    b.Width = 40;
                    b.Left = i * 40;
                    b.Top = j * 40;

                    b.Text = (i * j).ToString();

                    Controls.Add(b);
                }
            }

        }
    }
}
