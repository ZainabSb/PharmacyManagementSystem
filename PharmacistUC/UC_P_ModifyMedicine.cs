using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagementSystem.PharmacistUC
{
    public partial class UC_P_ModifyMedicine : UserControl
    {
        function fn = new function();
        String query;

        public UC_P_ModifyMedicine()
        {
            InitializeComponent();
        }

        private void PopulateCategoryComboBox()
        {
            try
            {
                string query = "SELECT name FROM MedsCategory";
                function fn = new function();
                DataSet ds = fn.getData(query);

                // Clear existing items in the ComboBox
                ComboCat.Items.Clear();

                // Add category names to the ComboBox
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    string categoryName = row["name"].ToString();
                    ComboCat.Items.Add(categoryName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving category names: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtMediID.Text != "")
            {
                query = "select * from medicin where mid = '" + txtMediID.Text + "'";
                DataSet ds = fn.getData(query);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    txtMediName.Text = ds.Tables[0].Rows[0][1].ToString();
                    ComboCat.Text = ds.Tables[0].Rows[0][2].ToString();
                    txtMDate.Text = ds.Tables[0].Rows[0][3].ToString();
                    txtEDate.Text = ds.Tables[0].Rows[0][4].ToString();
                    txtAvailableQuantity.Text = ds.Tables[0].Rows[0][5].ToString();
                    txtPricePerUnit.Text = ds.Tables[0].Rows[0][6].ToString();
                }
                else
                {
                    MessageBox.Show("No Medicine with such ID: " + txtMediID.Text + " exists.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Enter an ID.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                clearAll();
            }
        }

        private void clearAll()
        {
            txtMediID.Clear();
            txtMediName.Clear();
            txtMDate.ResetText();
            txtEDate.ResetText();
            txtAvailableQuantity.ResetText();
            txtPricePerUnit.Clear();

            if (txtAddQuantity.Text != "0")
            {
                txtAddQuantity.Text = "0";
            }
            else
            {
                txtAddQuantity.Text = "0";
            }
        }

        Int64 totalQuantity;
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String mname = txtMediName.Text;
            String cat = ComboCat.Text;
            String mdate = txtMDate.Text;
            String edate = txtEDate.Text;
         
            if (txtMediID.Text != "" && txtMediName.Text != "" && txtPricePerUnit.Text != "" && txtAvailableQuantity.Text != "")
            {
                try
                {
                    Int64 quantity = Int64.Parse(txtAvailableQuantity.Text);
                    Int64 addQuantity = Int64.Parse(txtAddQuantity.Text);
                    Int64 unitprice = Int64.Parse(txtPricePerUnit.Text);

                    totalQuantity = quantity + addQuantity;

                    /*mid,mname,mnumber,mDate,eDate,quantity,perUnit*/
                    query = "update medicin set mname = '" + mname + "', category = '" + cat + "', mDate = '" + mdate + "', eDate = '" + edate + "', quantity = '" + totalQuantity + "', perUnit = '" + unitprice + "' where mid = '" + txtMediID.Text + "'";
                    fn.setData(query, "Update Successful!");
                    clearAll();
                }
                catch
                {
                    MessageBox.Show("Error in Updating!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("Enter an ID", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void UC_P_ModifyMedicine_Load(object sender, EventArgs e)
        {
            PopulateCategoryComboBox();
        }
    }
}
