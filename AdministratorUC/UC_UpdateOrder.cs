using System;
using System.Collections;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PharmacyManagementSystem.AdministratorUC
{
    public partial class UC_UpdateOrder : UserControl
    {
        function fn = new function();
        String query = "";

        public UC_UpdateOrder()
        {
            InitializeComponent();
        }

        private void PopulateSupplierComboBox()
        {
            try
            {
                query = "SELECT SupplierName FROM suppliers";
                function fn = new function();
                DataSet ds = fn.getData(query);

                // Clear existing items in the ComboBox
                ComboSup.Items.Clear();

                // Add supplier names to the ComboBox
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    string supplierid = row["SupplierName"].ToString();
                    ComboSup.Items.Add(supplierid);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving supplier names: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulateUserComboBox()
        {
            try
            {
                string query = "SELECT username FROM users where userRole = 'Pharmacist'";
                function fn = new function();
                DataSet ds = fn.getData(query);

                // Clear existing items in the ComboBox
                ComboEmloyee.Items.Clear();

                // Add category names to the ComboBox
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    string userName = row["username"].ToString();
                    ComboEmloyee.Items.Add(userName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving category names: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulateMedCategoryComboBox()
        {
            try
            {
                string query = "SELECT mname FROM medicin";
                function fn = new function();
                DataSet ds = fn.getData(query);

                // Clear existing items in the ComboBox
                ComboMed.Items.Clear();

                // Add category names to the ComboBox
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    string medname = row["mname"].ToString();
                    ComboMed.Items.Add(medname);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving category names: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void clearAll()
        {
            ComboEmloyee.ResetText();
            ComboMed.ResetText();
            txtOrderID.Clear();
            ComboStatus.ResetText();
            ComboSup.ResetText();
            txtQuantity.Clear();
        }

        private void setDataGridView(String query)
        {
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void UC_UpdateOrder_Load(object sender, EventArgs e)
        {
            PopulateSupplierComboBox();
            PopulateMedCategoryComboBox();
            PopulateUserComboBox();

            query = "select * from orderMed";
            setDataGridView(query);
            dataGridView1.AllowUserToAddRows = false;

            // Subscribe to the CellFormatting event
            dataGridView1.CellPainting += DataGridView1_CellPainting;
        }

        private void DataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["Status"].Index)
            {
                string status = dataGridView1.Rows[e.RowIndex].Cells["Status"].Value.ToString();

                // Check if the status is "pending"
                if (string.Equals(status, "pending", StringComparison.OrdinalIgnoreCase))
                {
                    e.CellStyle.BackColor = Color.Red;
                }
            }
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            UC_UpdateOrder_Load(this, null);
            clearAll();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtOrderID.Text != "")
                {
                    query = "select * from orderMed where OrderID = '" + txtOrderID.Text + "'";
                    DataSet ds = fn.getData(query);
                    ComboEmloyee.Text = ds.Tables[0].Rows[0][1].ToString();
                    txtOrderDate.Text = ds.Tables[0].Rows[0][2].ToString();
                    ComboMed.Text = ds.Tables[0].Rows[0][3].ToString();
                    ComboSup.Text = ds.Tables[0].Rows[0][4].ToString();
                    txtQuantity.Text = ds.Tables[0].Rows[0][5].ToString();
                    ComboStatus.Text = ds.Tables[0].Rows[0][6].ToString();
                }
                else
                {
                    MessageBox.Show("Enter a valid Order ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No Order Found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetPreviousSupplier(string orderId)
        {
            string query = "SELECT SupName FROM orderMed WHERE OrderID = '" + orderId + "'";
            DataSet ds = fn.getData(query);
            string previousSupplier = string.Empty;

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                previousSupplier = ds.Tables[0].Rows[0]["SupName"].ToString();
            }

            return previousSupplier;
        }

        private void DecrementOrderCount(string supplier)
        {
            try
            {
                string query = "SELECT NumberOfOrders FROM suppliers WHERE SupplierName = '" + supplier + "'";
                DataSet ds = fn.getData(query);

                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    int orderCount = Convert.ToInt32(ds.Tables[0].Rows[0]["NumberOfOrders"]);
                    orderCount--;

                    string updateQuery = "UPDATE suppliers SET NumberOfOrders = " + orderCount + " WHERE SupplierName = '" + supplier + "'";
                    fn.setMyData(updateQuery);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error decrementing order count: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void IncrementOrderCount(string supplier)
        {
            try
            {
                string query = "SELECT NumberOfOrders FROM suppliers WHERE SupplierName = '" + supplier + "'";
                DataSet ds = fn.getData(query);

                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    int orderCount = Convert.ToInt32(ds.Tables[0].Rows[0]["NumberOfOrders"]);
                    orderCount++;

                    string updateQuery = "UPDATE suppliers SET NumberOfOrders = " + orderCount + " WHERE SupplierName = '" + supplier + "'";
                    fn.setMyData(updateQuery);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error incrementing order count: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String id = txtOrderID.Text;
            String Employee = ComboEmloyee.Text;
            String date = txtOrderDate.Text;
            String Medname = ComboMed.Text;
            String supplier = ComboSup.Text;
            String quantity = txtQuantity.Text;
            String status = ComboStatus.Text;

            try
            {
                string previousSupplier = GetPreviousSupplier(id);

                Int64 quan = Int64.Parse(quantity);
                query = "update orderMed set EmployeeName = '" + Employee + "', OrderDate = '" + date + "', Medname = '" + Medname + "', SupName = '" + supplier + "', quantity = '" + quan + "', Status = '" + status + "' where OrderID = '" + id + "'";
                fn.setData(query, "Order Updated Successfully!");

                // Update the number of orders for the previous supplier
                DecrementOrderCount(previousSupplier);

                // Update the number of orders for the new supplier
                //IncrementOrderCount(supplier);
                UC_UpdateOrder_Load(this, null);
            }
            catch (Exception)
            {
                MessageBox.Show("Error in updating!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        String ID;

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ID = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            catch
            {

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            string previousSupplier = GetPreviousSupplier(ID);
            // Check if any cell is selected in the DataGridView
            if (dataGridView1.SelectedCells.Count > 0)
            {
                if (MessageBox.Show("Are you sure?", "Delete Confirmation!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        query = "delete from orderMed where orderID = '" + ID + "'";
                        fn.setData(query, "Order Deleted!");
                        UC_UpdateOrder_Load(this, null);

                        // Update the number of orders for the previous supplier
                        DecrementOrderCount(previousSupplier);

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error in Deleting!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void txtDob_ValueChanged(object sender, EventArgs e)
        {
            // Get the selected date from the DateTimePicker
            DateTime selectedDate = txtDob.Value;

            // Format the selected date to match the date format in the database (M/d/yyyy)
            string formattedDate = selectedDate.ToString("M/d/yyyy");

            // Assuming your database table has a column named "OrderDate" that stores the order date.

            // Construct the query to filter orders based on the selected date
            query = "SELECT * FROM orderMed WHERE OrderDate = '" + formattedDate + "'";

            // Update the DataGridView with the filtered data
            setDataGridView(query);
        }
    }
}
