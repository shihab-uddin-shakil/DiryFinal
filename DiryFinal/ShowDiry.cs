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
    public partial class ShowDiry : Form
    {
        public ShowDiry()
        {
            InitializeComponent();
        }

        private void AddEvent_Click(object sender, EventArgs e)
        {

        }

        private void ShowDiry_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
