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
        private bool isClosed;
        public UMS_ExistingUser()
        {
            InitializeComponent();
            isClosed = true;
        }

        private void resetPass_Click(object sender, EventArgs e)
        {
            if(mail.Text.Trim() == "")
            {
                MessageBox.Show("Invalid Email Entered!", "Error");
                return;
            }
            try
            {
                string login = UserBO.VerifyEmail(mail.Text.Trim());
                if (login == null)
                {
                    MessageBox.Show("No User with this Email Exists!", "Error");
                    return;
                }
                string Code = UserBO.SendMail(mail.Text.Trim());
                UMS_ConfirmCode cc = new UMS_ConfirmCode(Code, login);
                isClosed = false;
                cc.Show();
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Invalid Email or Internet not Available!", "Error");
            }
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
            string login = UserBO.ValidateUser(lgnTxt.Text, passTxt.Text);
            if (login != "")
            {
                UMS_LoggedIn loggedIn = new UMS_LoggedIn(login);
                isClosed = false;
                this.Close();
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
            if (isClosed && Application.OpenForms["Form1"] != null)
                Application.OpenForms["Form1"].Show();
        }
    }
}
