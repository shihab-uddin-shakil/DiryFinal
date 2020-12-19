using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiryFinal
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LoginDiry_Click(object sender, EventArgs e)
        {
            if (UsertextBox.Text == "shakil" && PasswordtextBox.Text == "123")
            {
                ShowDiry diry = new ShowDiry();
                diry.Show();
                this.Hide();
            }
            else
                MessageBox.Show("invalid username or pasword!!");
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
