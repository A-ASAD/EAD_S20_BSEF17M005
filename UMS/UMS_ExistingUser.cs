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
    public partial class UMS_ExistingUser : Form
    {
        public UMS_ExistingUser()
        {
            InitializeComponent();
        }

        private void resetPass_Click(object sender, EventArgs e)
        {
            UMS_ConfirmCode cc = new UMS_ConfirmCode();
            cc.Show();
            this.Hide();
        }

        private void login_Click(object sender, EventArgs e)
        {
            if (lgnTxt.Text.Trim() == "")
            {
                MessageBox.Show("Please enter a valid Login!", "Error");
                return;
            }
            if (passTxt.Text.Trim() == "")
            {
                MessageBox.Show("Please enter a valid password!", "Error");
                return;
            }
            string uName = UserBO.ValidateUser(lgnTxt.Text, passTxt.Text);
            if (uName != "")
            {
                UMS_LoggedIn loggedIn = new UMS_LoggedIn(uName);
                this.Hide();
                errMsg.Hide();
                loggedIn.Show();
            }
            else
                errMsg.Show();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UMS_ExistingUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(Application.OpenForms["Form1"] != null)
                Application.OpenForms["Form1"].Show();
        }
    }
}
