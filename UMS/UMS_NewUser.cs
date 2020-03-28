using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UMS_BAL;

namespace UMS
{
    public partial class NewUser : Form
    {
        private Boolean isNew;
        private string login;
        private string email;
        private string photo;
        private bool isClosed;
        public NewUser()
        {
            InitializeComponent();
            isNew = true;
            isClosed = true;
        }

        private void NewUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isClosed && Application.OpenForms["Form1"] != null)
                Application.OpenForms["Form1"].Show();
        }

        private void NewUser_Load(object sender, EventArgs e)
        {
            if(isNew)
                gender.SelectedIndex = 0;
            UserBO.CreateImageFolder(System.IO.Path.GetDirectoryName(Application.ExecutablePath));
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
            try  // validating email
            {
                MailAddress m = new MailAddress(mail.Text.Trim());
            }
            catch (FormatException)
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
            //if((int)age.Value >)
            //{

            //}
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
            if (isNew)
            {
                if (UserBO.CreateUser(nam.Text.Trim(), lgn.Text.Trim(), pass.Text, mail.Text.Trim(),
                  Gender, address.Text.Trim(), (int)age.Value, nic.Text.Trim(), dob.Value,
                  cricket.Checked, hockey.Checked, chess.Checked, choosePic.FileName))
                {
                    isClosed = false;
                    UMS_LoggedIn eu = new UMS_LoggedIn(lgn.Text.Trim());
                    this.Close();
                    eu.Show();
                }
                else
                    MessageBox.Show("User already exists", "Error");
            }
            else
            {
                bool imageChanged = false;
                if (pictureBox1.ImageLocation != photo)  //delete previous image if image changed
                {
                    imageChanged = true;
                    File.Delete(photo);
                }
                if (lgn.Text.Trim() == login && mail.Text.Trim() == email)
                {
                    UserBO.UpdateUser(nam.Text.Trim(), lgn.Text.Trim(), login, pass.Text, mail.Text.Trim(),
                    Gender, address.Text.Trim(), (int)age.Value, nic.Text.Trim(), dob.Value,
                    cricket.Checked, hockey.Checked, chess.Checked, Path.GetFileName(pictureBox1.ImageLocation), false, imageChanged);
                    isClosed = false;
                    UMS_LoggedIn eu = new UMS_LoggedIn(lgn.Text.Trim());
                    this.Close();
                    eu.Show();
                }
                else
                {
                    if(UserBO.UpdateUser(nam.Text.Trim(), lgn.Text.Trim(),login, pass.Text, mail.Text.Trim(),
                    Gender, address.Text.Trim(), (int)age.Value, nic.Text.Trim(), dob.Value,
                    cricket.Checked, hockey.Checked, chess.Checked, Path.GetFileName(pictureBox1.ImageLocation), true, imageChanged))
                    {
                        isClosed = false;
                        UMS_LoggedIn eu = new UMS_LoggedIn(lgn.Text.Trim());
                        this.Close();
                        eu.Show();
                    }
                    else
                        MessageBox.Show("User already exists", "Error");
                }
            }
        }

        public void LoadUserData(DataTable User)
        {
            isNew = false;
            nam.Text = User.Rows[0]["Name"].ToString();
            lgn.Text = login = User.Rows[0]["Login"].ToString();
            pass.Text = User.Rows[0]["Password"].ToString();
            mail.Text = email = User.Rows[0]["Email"].ToString();
            switch (User.Rows[0]["Gender"].ToString())
            {
                case "m":
                    gender.SelectedItem = "Male";
                    break;
                case "f":
                    gender.SelectedItem = "Female";
                    break;
                case "o":
                    gender.SelectedItem = "Others";
                    break;
            }
            address.Text = User.Rows[0]["Address"].ToString();
            age.Value = (int)User.Rows[0]["Age"];
            nic.Text = User.Rows[0]["NIC"].ToString();
            dob.Value = (DateTime)User.Rows[0]["DOB"];
            if ((bool)User.Rows[0]["isCricket"])
                cricket.Checked = true;
            if ((bool)User.Rows[0]["Hockey"])
                hockey.Checked = true;
            if ((bool)User.Rows[0]["Chess"])
                chess.Checked = true;
            photo = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\images\\"
                + User.Rows[0]["ImageName"].ToString();
            pictureBox1.Load(photo);
        }
    }
}
