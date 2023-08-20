using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PharmacyManagementSystem.AdministratorUC
{
    public partial class UC_Purchases : UserControl
    {
        function fn = new function();
        String query;

        public UC_Purchases()
        {
            InitializeComponent();
        }

        private void UC_Purchases_Load(object sender, EventArgs e)
        {
            query = "select * from totalPurchases";
            setDataGridView(query);
            dataGridView1.AllowUserToAddRows = false;
        }

        private void setDataGridView(String query)
        {
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void setDataGridView2(String query)
        {
            DataSet ds = fn.getData(query);
            dataGridView2.DataSource = ds.Tables[0];
        }


        String PhoneNb;
        String Date;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                PhoneNb = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                Date = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();

                query = "select * from meds_purchased where Date like '" + Date + "' and PhoneNb like '" + PhoneNb + "'";
                setDataGridView2(query);
                dataGridView2.AllowUserToAddRows = false;
            }
            catch(Exception) {
                MessageBox.Show("Click a purchase!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            UC_Purchases_Load(this, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Check if any cell is selected in the DataGridView
            if (dataGridView1.SelectedCells.Count > 0)
            {

                if (MessageBox.Show("Are you sure?", "Delete Confirmation!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        query = "delete from totalpurchases where CustomerPhoneNb like '" + PhoneNb + "' and PurchaseDate like '" + Date + "'";
                        fn.setData(query, "Invoice Deleted!");
                        UC_Purchases_Load(this, null);

                        query = "delete from meds_purchased where Date like '" + Date + "' and PhoneNb like '" + PhoneNb + "'";
                        fn.setMyData(query);
                        UC_Purchases_Load(this, null);

                        query = "UPDATE customerTab SET purNo = purNo - 1 WHERE CustomerMobile LIKE '" + PhoneNb + "'";
                        fn.setMyData(query);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error in Deleting!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            else
            {
                MessageBox.Show("No Purchase Selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Search_TextChanged(object sender, EventArgs e)
        {
            query = "select * from totalpurchases where CustomerPhoneNb like '" + Search.Text + "%'";
            setDataGridView(query);
        }
    }
}
