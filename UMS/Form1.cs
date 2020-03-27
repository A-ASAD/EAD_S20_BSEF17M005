using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Ex_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void EU_Click(object sender, EventArgs e)
        {
            UMS_ExistingUser eu = new UMS_ExistingUser();
            eu.Show();
            this.Hide();
        }

        private void NU_Click(object sender, EventArgs e)
        {
            NewUser nu = new NewUser();
            nu.Show();
            this.Hide();
        }

        private void Adm_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
