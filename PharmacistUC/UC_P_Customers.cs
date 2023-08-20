using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PharmacyManagementSystem.PharmacistUC
{
    public partial class UC_P_Customers : UserControl
    {
        function fn = new function();
        String query;

        public UC_P_Customers()
        {
            InitializeComponent();
        }

        private void UC_P_Customers_Load(object sender, EventArgs e)
        {
            query = "select * from customerTab";
            fn.getData(query);
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.AllowUserToAddRows = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        public void clearAll()
        {
            txtCustomerID.ResetText();
            txtCusName.Clear();
            txtCusNo.Clear();
            txtPurNo.Clear();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            String ID = txtCustomerID.Text;
            String name = txtCusName.Text;
            String mobile = txtCusNo.Text;
            String PurNo = txtPurNo.Text;
            String Status = txtStatus.Text;

            try
            {
                if (string.IsNullOrEmpty(ID) || string.IsNullOrEmpty(name) ||
                    string.IsNullOrEmpty(mobile) || string.IsNullOrEmpty(PurNo) || string.IsNullOrEmpty(Status))
                {
                    // At least one field is empty
                    MessageBox.Show("Empty Credentials!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else if (string.IsNullOrEmpty(mobile))
                {
                    // Mobile number is not filled
                    MessageBox.Show("Mobile number is required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Int32 Purchases = Int32.Parse(PurNo);
                    query = "insert into customerTab (CustomerID, CustomerMobile, CustomerName, purNo, Status) values ('" + ID + "', '" + mobile + "', '" + name + "', '" + Purchases + "', '" + Status + "')";
                    fn.setData(query, "Customer added successfully!");
                }
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Customer already in database!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCustomerID.Text != "")
                {
                    query = "select * from customerTab where CustomerID = '" + txtCustomerID.Text + "'";
                    DataSet ds = fn.getData(query);
                    txtCusNo.Text = ds.Tables[0].Rows[0][1].ToString();
                    txtCusName.Text = ds.Tables[0].Rows[0][2].ToString();
                    txtPurNo.Text = ds.Tables[0].Rows[0][3].ToString();
                    txtStatus.Text = ds.Tables[0].Rows[0][4].ToString();
                }
                else
                {
                    MessageBox.Show("Enter a valid ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No Customer Found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            UC_P_Customers_Load(this, null);
            clearAll();
        }

        private void Search_TextChanged(object sender, EventArgs e)
        {
            query = "select * from customerTab where CustomerName like '" + Search.Text + "%'";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        String userName;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                userName = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            catch
            {

            }
        }



        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {

            String id = txtCustomerID.Text;
            String Name = txtCusName.Text;
            String mobile = txtCusNo.Text;
            String status = txtStatus.Text;

            if (!string.IsNullOrEmpty(id) || !string.IsNullOrEmpty(Name) ||
                    !string.IsNullOrEmpty(mobile) || !string.IsNullOrEmpty(status))
            {
                try
                {
                    Int32 orders_No = Int32.Parse(txtPurNo.Text);
                    query = "update customerTab set CustomerMobile = '" + mobile + "', CustomerName = '" + Name + "', purNo = '" + orders_No + "', Status = '" + status + "' where CustomerID = '" + id + "'";
                    fn.setData(query, "Customer Updated Successfully!");
                }
                catch (Exception)
                {
                    MessageBox.Show("Error, Try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Credentials!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
    }
}
