using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UMS_BAL;

namespace UMS
{
    public partial class UMS_NewPassword : Form
    {
        private string Login;
        private bool isClosed;
        public UMS_NewPassword(String login)
        {
            InitializeComponent();
            Login = login;
            isClosed = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(pass.Text.Trim() == "")
            {
                MessageBox.Show("Invalid Password Entered!", "Error");
                return;
            }
            isClosed = false;
            UserBO.UpdatePassword(Login, pass.Text);
            UMS_LoggedIn lggdIn = new UMS_LoggedIn(Login);
            this.Close();
            lggdIn.Show();
        }

        private void UMS_NewPassword_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(isClosed && Application.OpenForms["Form1"] != null)
                Application.OpenForms["Form1"].Show();
        }
    }
}
