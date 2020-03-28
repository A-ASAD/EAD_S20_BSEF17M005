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
    public partial class UMS_LoggedIn : Form
    {
        private DataTable User;
        private bool isClosed;
        public UMS_LoggedIn(string Login)
        {
            InitializeComponent();
            User = UserBO.LoadUser(Login);
            isClosed = true;
        }

        private void UMS_LoggedIn_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isClosed && Application.OpenForms["Form1"] != null)
                Application.OpenForms["Form1"].Show();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UMS_LoggedIn_Load(object sender, EventArgs e)
        {
            UserWelcome.Text += User.Rows[0]["Name"].ToString();
            pictureBox1.Load(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\images\\"
                +User.Rows[0]["ImageName"].ToString());
        }

        private void editProf_Click(object sender, EventArgs e)
        {
            isClosed = false;
            NewUser edit = new NewUser();
            edit.LoadUserData(User);
            this.Close();
            edit.Show();
        }
    }
}
