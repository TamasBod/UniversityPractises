using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soduku_2022
{
    public partial class Form1 : Form
    {
        List<Sudoku> _sudokus = new List<Sudoku>();
        Random rng = new Random();
        Sudoku _currentquz;

        public Form1()
        {
            InitializeComponent();
            CreatePlayField();
            LoadSudoku();
            NewGame();
        }

        private void NewGame()
        {
            int counter = 0;
            _currentquz = GetRandomQuiz();
            foreach (var sf in mainpanel.Controls.OfType<SudokuField>())
            {
                sf.Value = int.Parse(_currentquz.Quiz[counter].ToString());
                sf.Active = sf.Value == 0;
                counter++;
            }
        }

        private Sudoku GetRandomQuiz()
        {
            int randomNumber = rng.Next(_sudokus.Count);
            return _sudokus[randomNumber];
        }

        private void LoadSudoku()
        {
            _sudokus.Clear();

            using (StreamReader sr = new StreamReader("sudoku.csv", Encoding.Default))
            {
                sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split(',');

                    Sudoku s = new Sudoku();
                    s.Quiz = line[0];
                    s.Solution = line[1];
                    _sudokus.Add(s);
                }
            }
        }

        void CreatePlayField()
        {
            int lineWidth = 10;

            for (int row = 0; row < 9; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    SudokuField sf = new SudokuField();
                    sf.MouseDown += Sf_MouseDown;
                    sf.Left = row * sf.Width + (int)(Math.Floor((double)(row / 3))) * lineWidth;
                    sf.Top = col * sf.Width + (int)(Math.Floor((double)(col / 3))) * lineWidth;

                    mainpanel.Controls.Add(sf);
                }
            }
        }

        private void Sf_MouseDown(object sender, MouseEventArgs e)
        {
            string s = "";
            foreach (var item in mainpanel.Controls)
            {
                s += ((SudokuField)item).Value.ToString();
            }
            if (s.Equals(_currentquz.Solution))
            {
                MessageBox.Show("You Win!");

                foreach (var item in mainpanel.Controls)
                {
                    ((SudokuField)item).Active = false;
                }
            }

        }
    }
    
}
