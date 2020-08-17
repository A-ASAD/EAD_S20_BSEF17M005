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
    public partial class UMS_AdminHome : Form
    {
        private DataTable Users;
        public UMS_AdminHome()
        {
            InitializeComponent();
            userGrid.AutoGenerateColumns = false;
            LoadAllUsers();
        }

        public void LoadAllUsers()
        {
            userGrid.DataSource = Users = UserBO.LoadAllUsers();
        }

        private void UMS_AdminHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["Form1"] != null)
                Application.OpenForms["Form1"].Show();
        }

        private void lgout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void userGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 5)
            {
                NewUser nu = new NewUser();
                DataTable user = Users.Clone();
                user.Rows.Add(Users.Rows[userGrid.CurrentCell.RowIndex].ItemArray);
                nu.LoadUserData(user, true);
                this.Hide();
                nu.Show();
            }
        }
    }
}
