using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PharmacyManagementSystem.AdministratorUC
{
    public partial class UC_ModifyUser : UserControl
    {
        function fn = new function();
        String query;
        String currentUser = "";

        public UC_ModifyUser()
        {
            InitializeComponent();
        }

        public string ID
        {
            set { currentUser = value; }
        }

        private void Search_TextChanged(object sender, EventArgs e)
        {
            query = "select * from users where username like '" + Search.Text + "%'";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        String userName;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                userName = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Check if any cell is selected in the DataGridView
            if (dataGridView1.SelectedCells.Count > 0)
            {
                if (MessageBox.Show("Are you sure?", "Delete Confirmation!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (currentUser != userName)
                    {
                        query = "delete from users where username = '" + userName + "'";
                        fn.setData(query, "User Record Deleted!");
                        UC_ModifyUser_Load(this, null);
                    }

                    else if (currentUser == userName)
                    {
                        MessageBox.Show("You are not allowed to delete \n your credentials!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            UC_ModifyUser_Load(this, null);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsername.Text != "") {
                    query = "select * from users where username = '" + txtUsername.Text + "'";
                    DataSet ds = fn.getData(query);
                    txtUserRole.Text = ds.Tables[0].Rows[0][1].ToString();
                    txtDob.Text = ds.Tables[0].Rows[0][2].ToString();
                    txtMobileNo.Text = ds.Tables[0].Rows[0][3].ToString();
                    txtEmail.Text = ds.Tables[0].Rows[0][4].ToString();
                    txtPassword.Text = ds.Tables[0].Rows[0][6].ToString();
                }
                else
                {
                    MessageBox.Show("Enter a valid Username!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception) {
                MessageBox.Show("No User Found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            String role = txtUserRole.Text;
            String dob = txtDob.Text;
            String email = txtEmail.Text;
            String username = txtUsername.Text;
            String passcode = txtPassword.Text;

            if (!string.IsNullOrEmpty(role) || !string.IsNullOrEmpty(dob) ||
                    !string.IsNullOrEmpty(email) || !string.IsNullOrEmpty(username) || !string.IsNullOrEmpty(passcode)) {
                try
                {
                    Int64 mobile = Int64.Parse(txtMobileNo.Text);
                    query = "update users set userRole = '" + role + "', dob = '" + dob + "', mobile = '" + mobile + "', email = '" + email + "', passcode = '" + passcode + "' where username = '" + username + "'";
                    fn.setData(query, "User Updated Successfully!");
                    
                }
                catch {
                    MessageBox.Show("Error in updating!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Credentials!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            clearAll();
        }

        private void UC_ModifyUser_Load(object sender, EventArgs e)
        {
            query = "select * from users";
            fn.getData(query);
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.AllowUserToAddRows = false;
        }
        public void clearAll()
        {
            txtDob.ResetText();
            txtMobileNo.Clear();
            txtEmail.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            Search.Clear();
            txtUserRole.SelectedIndex = -1;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}
