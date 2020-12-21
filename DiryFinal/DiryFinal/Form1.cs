using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiryFinal;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {

        public static string setName = "";
        public static string setUserName="";
        public static string setPassword= "";
        public static string setDOB= "";
        public static string setEmail = "";
        public static string setBlood = "";
        public static string setGender = "";

        public Form1()
        {
            InitializeComponent();
        }
      

        private void submit_Click(object sender, EventArgs e)
        {
            setName = nameT.Text;
            setUserName = unameT.Text;
            setEmail = emailT.Text;
            setDOB = dobT.Text;
            setBlood = bloodT.Text;
            setPassword = passwordT.Text;

           
           

            DateTime dataB = dobT.Value;
            if (nameT.Text == "" )
            {
                MessageBox.Show(" Name is empty..");
            }
            else if (unameT.Text == "")
            {
                MessageBox.Show("User Name is empty..");
            }
            else if (passwordT.Text == "")
            {
                MessageBox.Show("Password is empty..");
            }
            else if (cPasswordT.Text == "")
            {
                MessageBox.Show(" Confirm Password is empty..");
            }
            else if (passwordT.Text != cPasswordT.Text)
            {
                MessageBox.Show("Password not Match!!");
            }
            else if (emailT.Text == "")
            {
                MessageBox.Show("Email is empty..");
            }
            else if (!emailT.Text.Contains("@"))
            {
                MessageBox.Show("Invalid Email");
            }
            else if (!emailT.Text.Contains(".com"))
            {
                MessageBox.Show("Invalid Email");
            }
            else if (dobT.Text == "")
            {
                MessageBox.Show("date of birth is empty..");
            }
            else if (dataB > DateTime.Now)
            {
                MessageBox.Show("Invalid date Of Birth");

            }
            else if (male.Checked == false && female.Checked == false)
            {
                MessageBox.Show("gender not selected");
            }

            else if ( bloodT.Text == "")
            {
                MessageBox.Show("Blood group is empty..");
            }

            //bloodT.SelectedItem = "";

            else if (condition.Checked == false)
            {
                MessageBox.Show("Condition not selected");
            }
            else
            {
                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Task1"].ConnectionString);
                connection.Open();
                string gend = null;
                if (female.Checked)
                {
                    gend = female.Text;
                }
                else
                    gend = male.Text;

                string sql = "INSERT INTO Users(Name,UserName,Password,Email,DateOfBirth,Gender,BloodGroup) VALUES ('" + nameT.Text + "','" + unameT.Text + "','" + passwordT.Text + "','" + emailT.Text + "','" + dobT.Text + "','" + gend + "','" + bloodT.Text + "')";

                SqlCommand comand = new SqlCommand(sql, connection);
                int result = comand.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("User Added Succesfully");

                }
                else
                {
                    MessageBox.Show("Error in adding user");
                }

                Login info1 = new Login();

                 info1.Show();
               // Login l =new  Login();
                //l.Show();
                connection.Close();

                this.Hide();
               
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void female_CheckedChanged(object sender, EventArgs e)
        {
            if (female.Checked==true)
            {
                setGender = female.Text;
            }
        }

        private void male_CheckedChanged(object sender, EventArgs e)
        {
            if (male.Checked == true)
            {
                setGender = male.Text;
            }
        }

        private void dobT_ValueChanged(object sender, EventArgs e)
        {
            DateTime dateb = dobT.Value;
            if (dobT.Checked == true)
            {
                   if (dateb> DateTime.Now)
                {
                    MessageBox.Show("Invalid date Of Birth");

                }
            }
        }

        private void loginR_Click(object sender, EventArgs e)
        {
            Login l2 = new Login();
            l2.Show();
            this.Hide();
        }
    }
}
