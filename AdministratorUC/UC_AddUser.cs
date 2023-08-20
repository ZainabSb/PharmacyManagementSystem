using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PharmacyManagementSystem.AdministratorUC
{
    public partial class UC_AddUser : UserControl
    {
        function fn = new function();
        String query;
        private string passcode;

        public UC_AddUser()
        {
            InitializeComponent();
        }

        private void UC_AddUser_Load(object sender, EventArgs e)
        {

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            String role = txtUserRole.Text;
            String dob = txtDob.Text;
            String mobileText = txtMobileNo.Text;
            String email = txtEmail.Text;
            String username = txtUsername.Text;
            String passcode = txtPassword.Text;

            try
            {

                if (string.IsNullOrEmpty(role) || string.IsNullOrEmpty(dob) ||
                    string.IsNullOrEmpty(email) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(passcode) || string.IsNullOrEmpty(username))
                {
                    // At least one field is empty
                    MessageBox.Show("Empty Credentials!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrEmpty(mobileText))
                {
                    // Mobile number is not filled
                    MessageBox.Show("Mobile number is required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Int64 mobile = Int64.Parse(mobileText);
                    query = "insert into users (userRole, dob, mobile, email, username, passcode) values ('" + role + "', '" + dob + "', '" + mobile + "', '" + email + "', '" + username + "', '" + passcode + "')";
                    fn.setData(query, "User added successfully!");
                }

            }

            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Redundant User!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            clearAll();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        public void clearAll()
        {
            txtDob.ResetText();
            txtMobileNo.Clear();
            txtEmail.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            txtUserRole.SelectedIndex = -1;
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            query = "select * from users where username='" + txtUsername.Text + "'";
            DataSet ds = fn.getData(query);

            if (ds.Tables[0].Rows.Count == 0)
            {
                pictureBox1.ImageLocation = @"C:\\Users\\zaina\\OneDrive\\Desktop\\files\\Pharmacy Management System in C#\yes.png";
            }
            else
            {
                pictureBox1.ImageLocation = @"C:\\Users\\zaina\\OneDrive\\Desktop\\files\\Pharmacy Management System in C#\no.png";
            }
        }
    }
}
