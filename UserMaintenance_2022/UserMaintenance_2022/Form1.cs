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
            lbllastname.Text = Resource1.LastName;
            lblfirstname.Text = Resource1.FirstName;
            AddBtn.Text = Resource1.Add;

            listUsers.DataSource = users;
            listUsers.ValueMember = "ID";
            listUsers.DisplayMember = "FullName";

            var u = new User()
            {
                LastName = lastnametxt.Text,
                FirstName = firstnametxt.Text
            };
            users.Add(u);

        }
    }
}
