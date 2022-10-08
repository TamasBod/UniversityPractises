using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserMaintenance_2022.Entities;

namespace UserMaintenance_2022
{
    public partial class Form1 : Form
    {
        BindingList<User> users = new BindingList<User>();
        public Form1()
        {
            InitializeComponent();
            lblfullname.Text = Resource1.FullName;
            AddBtn.Text = Resource1.Add;
            btnsavetofile.Text = Resource1.btnsavetofile;

            listUsers.DataSource = users;
            listUsers.ValueMember = "ID";
            listUsers.DisplayMember = "FullName";



        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            var u = new User()
            {
                FullName = fullnametxt.Text
            };
            users.Add(u);
            fullnametxt.Text = "";
        }

        private void btnsavetofile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            //if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            //{
            //    if ((myStream = saveFileDialog1.OpenFile()) != null)
            //    {
            //        myStream.Close();
            //    }
            //}

            saveFileDialog1.ShowDialog();
        }
    }
}
