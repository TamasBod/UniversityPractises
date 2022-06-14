using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku
{
    internal class SudokuField: Button
    {
        private int _Value;

        public int Value
        {
            get { return _Value; }
            set 
            { 
                _Value = value;
                if (_Value < 0) _Value = 9;
                if (_Value > 9) _Value = 0;
                if (_Value == 0) Text = "";
                else Text = _Value.ToString();
            }
        }

        public SudokuField()
        {
        Height= 30;
        Width = 30;
        BackColor = Color.White;
        Value = 0;
        MouseDown += SudokuField_MouseDown;
        }

        private void SudokuField_MouseDown(object sender, MouseEventArgs e)
        {
            if (!Active) return;
            if (e.Button == MouseButtons.Left) Value++;
           if (e.Button == MouseButtons.Right)Value = Value -1;
        }

        private bool _Active;

        public bool Active
        {
            get { return _Active; }
            set
            {
                _Active = value;
                if (_Active)
                    Font = new Font(FontFamily.GenericSansSerif, 12);
                else
                    Font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold);
            }
        }

    }
}
