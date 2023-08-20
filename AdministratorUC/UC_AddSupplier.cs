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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PharmacyManagementSystem.AdministratorUC
{
    public partial class UC_AddSupplier : UserControl
    {
        function fn = new function();
        String query;

        public UC_AddSupplier()
        {
            InitializeComponent();
        }



        private void btnReset_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        public void clearAll()
        {
            txtSupplierID.ResetText();
            txtSupplierName.Clear();
            txtSupplierNo.Clear();
            txtnoOfOrders.Clear();
        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            String ID = txtSupplierID.Text;
            String name = txtSupplierName.Text;
            String mobile = txtSupplierNo.Text;
            String ordersnb = txtnoOfOrders.Text;

            try
            {

                if (string.IsNullOrEmpty(ID) || string.IsNullOrEmpty(name) ||
                    string.IsNullOrEmpty(mobile) || string.IsNullOrEmpty(ordersnb))
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
                    Int32 orders = Int32.Parse(ordersnb);
                    query = "insert into suppliers (SupplierID, SupplierName, mobile, NumberOfOrders) values ('" + ID + "', '" + name + "', '" + mobile + "', '" + ordersnb + "')";
                    fn.setData(query, "Supplier added successfully!");
                    clearAll();
                    UC_AddSupplier_Load(this, null);
                }
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Redundant User!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            UC_AddSupplier_Load(this, null);
            clearAll();
        }

        private void UC_AddSupplier_Load(object sender, EventArgs e)
        {
            query = "select * from suppliers";
            fn.getData(query);
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.AllowUserToAddRows = false;
        }

        private void Search_TextChanged(object sender, EventArgs e)
        {
            query = "select * from suppliers where SupplierName like '" + Search.Text + "%'";
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

        private void btnDeleteSupplier_Click(object sender, EventArgs e)
        {
            // Check if any cell is selected in the DataGridView
            if (dataGridView1.SelectedCells.Count > 0)
            {
                if (MessageBox.Show("Are you sure?", "Delete Confirmation!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    query = "delete from suppliers where   SupplierID = '" + userName + "'";
                    fn.setData(query, "User Record Deleted!");
                    UC_AddSupplier_Load(this, null);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSupplierID.Text != "")
                {
                    query = "select * from suppliers where SupplierID = '" + txtSupplierID.Text + "'";
                    DataSet ds = fn.getData(query);
                    txtSupplierName.Text = ds.Tables[0].Rows[0][1].ToString();
                    txtSupplierNo.Text = ds.Tables[0].Rows[0][2].ToString();
                    txtnoOfOrders.Text = ds.Tables[0].Rows[0][3].ToString();
                }
                else
                {
                    MessageBox.Show("Enter a valid ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No Supplier Found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateSupplier_Click(object sender, EventArgs e)
        {
            String id = txtSupplierID.Text;
            String Name = txtSupplierName.Text;
            String mobile = txtSupplierNo.Text;

            if (!string.IsNullOrEmpty(id) || !string.IsNullOrEmpty(Name) ||
                    !string.IsNullOrEmpty(mobile))
            {

                try
                {
                    Int32 orders_No = Int32.Parse(txtnoOfOrders.Text);
                    query = "update suppliers set SupplierName = '" + Name + "', mobile = '" + mobile + "', NumberOfOrders = '" + orders_No + "' where SupplierID = '" + id + "'";
                    fn.setData(query, "Supplier Updated Successfully!");
                }
                catch (Exception)
                {
                    MessageBox.Show("Error, Try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                clearAll();
            }
            else
            {
                MessageBox.Show("Empty Credentials!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
