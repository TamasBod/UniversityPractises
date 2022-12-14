using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VAR_2022.Entities;

namespace VAR_2022
{
    public partial class Form1 : Form
    {
        PortfolioEntities context = new PortfolioEntities();
        List<Tick> Ticks
        List<PortfolioItem> Portfolio;

        public Form1()
        {
            InitializeComponent();
            Ticks = context.Ticks.ToList();
            dGw.DataSource = Ticks;
            CreatePortfolio();


        }

        private void CreatePortfolio()
        {
            Portfolio.Add(new PortfolioItem() { Index = "OTP", Volume = 10 });
            Portfolio.Add(new PortfolioItem() { Index = "ZWACK", Volume = 10 });
            Portfolio.Add(new PortfolioItem() { Index = "ELMU", Volume = 10 });

            dGW2.DataSource = Portfolio;
        }
    }
}
