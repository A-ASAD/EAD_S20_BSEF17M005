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
    public partial class UMS_AdminLogin : Form
    {
        private bool isClosed;
        public UMS_AdminLogin()
        {
            InitializeComponent();
            isClosed = true;
        }

        private void lgn_Click(object sender, EventArgs e)
        {
            if(login.Text.Trim() == "")
            {
                MessageBox.Show("Invalid Login Entered!", "Invalid Input");
                return;
            }
            if (pass.Text.Trim() == "")
            {
                MessageBox.Show("Invalid Password Entered!", "Invalid Input");
                return;
            }
            if(UserBO.ValidateAdmin(login.Text.Trim(), pass.Text))
            {
                UMS_AdminHome admHome = new UMS_AdminHome();
                isClosed = false;
                admHome.Show();
                this.Close();
            }
            else
                errMsg.Show();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UMS_AdminLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isClosed && Application.OpenForms["Form1"] != null)
                Application.OpenForms["Form1"].Show();
        }
    }
}
