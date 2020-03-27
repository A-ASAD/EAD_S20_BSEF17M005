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
    public partial class UMS_LoggedIn : Form
    {
        private string UserName;
        public UMS_LoggedIn(string UName)
        {
            InitializeComponent();
            UserName = UName;
        }

        private void UMS_LoggedIn_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms["Form1"].Show();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UMS_LoggedIn_Load(object sender, EventArgs e)
        {
            UserWelcome.Text += UserName;
        }
    }
}
