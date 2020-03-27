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
    public partial class NewUser : Form
    {
        public NewUser()
        {
            InitializeComponent();
        }

        private void NewUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(Application.OpenForms["Form1"] != null)
                Application.OpenForms["Form1"].Show();
        }

        private void NewUser_Load(object sender, EventArgs e)
        {
            gender.SelectedIndex = 0;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (choosePic.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                pictureBox1.Load(choosePic.FileName);
        }

        private void create_Click(object sender, EventArgs e)
        {
            if(nam.Text.Trim() == "")
            {
                MessageBox.Show("Invalid Name Entered!", "Invalid Input");
                return;
            }
            if (lgn.Text.Trim() == "")
            {
                MessageBox.Show("Invalid Login Entered!", "Invalid Input");
                return;
            }
            if (pass.Text.Trim() == "")
            {
                MessageBox.Show("Invalid Password Entered!", "Invalid Input");
                return;
            }
            if (mail.Text.Trim() == "")
            {
                MessageBox.Show("Invalid Email Entered!", "Invalid Input");
                return;
            }
            if (gender.Text == "--Select--")
            {
                MessageBox.Show("Invalid Gender Selected!", "Invalid Input");
                return;
            }
            if (address.Text.Trim() == "")
            {
                MessageBox.Show("Invalid Address Entered!", "Invalid Input");
                return;
            }
            if (!nic.MaskCompleted)
            {
                MessageBox.Show("Invalid NIC Entered!", "Invalid Input");
                return;
            }
            if (dob.Value.Year >= DateTime.Today.Year)
            {
                MessageBox.Show("Invalid Date Entered!", "Invalid Input");
                return;
            }
            if (!cricket.Checked && !hockey.Checked && !chess.Checked )
            {
                MessageBox.Show("Please select atleast one Sport!", "Invalid Input");
                return;
            }
            if(pictureBox1.Image == null)
            {
                MessageBox.Show("Please upload photo", "Error");
                return;
            }
            char Gender = 'm';
            switch (gender.Text)
            {
                case "Male":
                    Gender = 'm';
                    break;
                case "Female":
                    Gender = 'f';
                    break;
                case "Others":
                    Gender = 'o';
                    break;
            }
            UserBO.CreateUser(nam.Text.Trim(), lgn.Text.Trim(), pass.Text.Trim(), mail.Text.Trim(),
                Gender, address.Text.Trim(), (int)age.Value, nic.Text.Trim(), dob.Value,
                cricket.Checked, hockey.Checked, chess.Checked, choosePic.FileName);
        }
    }
}
