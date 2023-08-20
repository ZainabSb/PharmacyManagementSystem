using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PharmacyManagementSystem.AdministratorUC
{
    public partial class UC_Orders : UserControl
    {
        function fn = new function();
        String query = "";

        public UC_Orders()
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

        private void setDataGridView(String query)
        {
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
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

        private void UC_Orders_Load(object sender, EventArgs e)
        {
            PopulateSupplierComboBox();
            PopulateMedCategoryComboBox();
            PopulateUserComboBox();

            query = "select * from orderMed";
            setDataGridView(query);
            dataGridView1.AllowUserToAddRows = false;


            // Subscribe to the CellFormatting event
            dataGridView1.CellPainting += DataGridView1_CellPainting;
            txtDob.ValueChanged += txtDob_ValueChanged;
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearAll();
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

        private void btnSync_Click(object sender, EventArgs e)
        {
            UC_Orders_Load(this, null);
        }

        private void btnAddOrder_Click_1(object sender, EventArgs e)
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
                if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(Employee) 
                    || string.IsNullOrEmpty(Medname) || string.IsNullOrEmpty(supplier)
                    || string.IsNullOrEmpty(quantity) || string.IsNullOrEmpty(status))

                {
                    // At least one field is empty
                    MessageBox.Show("Empty Credentials!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Int64 quan = Int64.Parse(quantity);
                    query = "insert into orderMed (OrderID, EmployeeName, OrderDate, MedName, SupName, quantity, Status) values ('" + id + "', '" + Employee + "','" + date + "', '" + Medname + "', '" + supplier + "', '" + quan + "', '" + status + "')";
                    fn.setData(query, "Order added successfully!");

                    // Update the ordersCovered for the supplier in the suppliers table
                    //query = "UPDATE suppliers SET NumberOfOrders = NumberOfOrders + 1 WHERE SupplierName = '" + supplier + "'";
                    //fn.setMyData(query);

                    // Clear the form fields
                    clearAll();
                    UC_Orders_Load(this, null);
                }
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Redundant User!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
