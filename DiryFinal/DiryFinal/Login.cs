using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp5;

namespace DiryFinal
{
    public partial class Login : Form
    {
        DataAccesscs DataAccesscs;

        public Login()
        {
            InitializeComponent();
            this.DataAccesscs = new DataAccesscs();
        }

        private void LoginDiry_Click(object sender, EventArgs e)
        {
            if (UsertextBox.Text == "" || PasswordtextBox.Text == "")
            {
                MessageBox.Show("Username or Password can not be empty");
            }
            else
            {
                UserDataServices userService = new UserDataServices();
                bool result = userService.LoginValidation(UsertextBox.Text, PasswordtextBox.Text);
                if (result)
                {
                    ShowDiry diary = new ShowDiry();
                    diary.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("Invalid Username or Password");
            }

        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void registerLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();

        }
    }
}
