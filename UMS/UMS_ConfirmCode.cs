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
    public partial class UMS_ConfirmCode : Form
    {
        private string Code;
        private string Login;
        private bool isClosed;
        public UMS_ConfirmCode(string code, string login)
        {
            InitializeComponent();
            Code = code;
            Login = login;
            isClosed = true;
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            if(CodeText.Text != Code)
            {
                MessageBox.Show("Code not Correct!", "Error");
                return;
            }
            isClosed = false;
            UMS_NewPassword nPass = new UMS_NewPassword(Login);
            this.Close();
            nPass.Show();
        }

        private void UMS_ConfirmCode_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isClosed && Application.OpenForms["Form1"] != null)
                Application.OpenForms["Form1"].Show();
        }
    }
}
