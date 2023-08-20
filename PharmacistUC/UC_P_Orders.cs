using Guna.UI2.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PharmacyManagementSystem.PharmacistUC
{
    public partial class UC_P_Orders : UserControl
    {
        function fn = new function();
        String query = "";
        String currentUser = "";

        public UC_P_Orders()
        {
            InitializeComponent();
        }

        public string ID
        {
            set { currentUser = value; }
        }

        private void setDataGridView(String query)
        {
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            UC_P_Orders_Load(this, null);
          
        }

        private void UC_P_Orders_Load(object sender, EventArgs e)
        {
   

            query = "select * from orderMed where EmployeeName = '"+currentUser+"'";
            setDataGridView(query);
            dataGridView1.AllowUserToAddRows = false;

            // Subscribe to the CellFormatting event
            dataGridView1.CellPainting += DataGridView1_CellPainting;
            txtDob.ValueChanged += txtDob_ValueChanged;
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

        String click;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                click = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            catch
            {

            }
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            try
            {
                    query = "SELECT Status, MedName, quantity FROM orderMed WHERE OrderID = '" + click + "'";
                    DataSet ds = fn.getData(query);

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        string currentStatus = ds.Tables[0].Rows[0]["Status"].ToString();

                        if (currentStatus == "received")
                        {
                            MessageBox.Show("Order is already received.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string medName = ds.Tables[0].Rows[0]["MedName"].ToString();
                            int orderQuantity = Convert.ToInt32(ds.Tables[0].Rows[0]["Quantity"]);

                            // Update the status to "received"
                            query = "UPDATE orderMed SET Status = 'received' WHERE OrderID = '" + click + "'";
                            fn.setData(query, "Order Received!");

                            // Update the quantity in the "med" table
                            query = "UPDATE medicin SET quantity = quantity + " + orderQuantity + " WHERE mname = '" + medName + "'";
                            fn.setMyData(query);
                           
                        }
                    }
                    else
                    {
                        MessageBox.Show("No Order Found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    } 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating order status and quantity: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        
        private void btnReset_Click(object sender, EventArgs e)
        {
           
        }

        private void txtDob_ValueChanged(object sender, EventArgs e)
        {
            // Get the selected date from the DateTimePicker
            DateTime selectedDate = txtDob.Value;

            // Format the selected date to match the date format in the database (M/d/yyyy)
            string formattedDate = selectedDate.ToString("M/d/yyyy");

            // Assuming your database table has a column named "OrderDate" that stores the order date.

            // Construct the query to filter orders based on the selected date
            query = "SELECT * FROM orderMed WHERE EmployeeName = '" + currentUser + "' AND OrderDate = '" + formattedDate + "'";

            // Update the DataGridView with the filtered data
            setDataGridView(query);
        }

        private void txtDob_ValueChanged_1(object sender, EventArgs e)
        {

        }
    }
}
