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
    public partial class UMS_NewPassword : Form
    {
        public UMS_NewPassword()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void UMS_NewPassword_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            Application.OpenForms["Form1"].Show();
        }
    }
}
