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
    public partial class UC_P_AddMedicine : UserControl
    {
        function fn = new function();
        String query;

        public UC_P_AddMedicine()
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMediID.Text != "" && txtMediName.Text != "" && txtQuantity.Text != "" && ComboCat.Text != "" && txtPricePerUnit.Text != "")
                {
                    String mid = txtMediID.Text;
                    String mname = txtMediName.Text;
                    String cat = ComboCat.Text;
                    String mDate = txtManufacturingDate.Text;
                    String eDate = txtExpireDate.Text;
                    Int64 quantity = Int64.Parse(txtQuantity.Text);
                    Int64 perUnit = Int64.Parse(txtPricePerUnit.Text);

                    query = "insert into medicin (mid,mname,category, mDate,eDate,quantity,perUnit) values ('" + mid + "', '" + mname + "','" + cat + "', '" + mDate + "', '" + eDate + "', '" + quantity + "', '" + perUnit + "')";
                    fn.setData(query, "Medicine Registration Successful!");

                }
                else
                {
                    MessageBox.Show("Empty Credentials, Check again!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Medicine ID already Exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            clearAll();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

            clearAll();
        }
        public void clearAll()
        {
            txtMediID.Clear();
            txtMediName.Clear();
            txtQuantity.Clear();
            txtPricePerUnit.Clear();
            txtManufacturingDate.ResetText();
            txtExpireDate.ResetText();
        }

        private void UC_P_AddMedicine_Load(object sender, EventArgs e)
        {
            PopulateCategoryComboBox();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
