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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PharmacyManagementSystem.AdministratorUC
{
    public partial class UC_Category : UserControl
    {
        function fn = new function();
        String query;

        public UC_Category()
        {
            InitializeComponent();
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            UC_Category_Load(this, null);
            txtCatID.Clear();
            txtCatName.Clear();
        }

        private void UC_Category_Load(object sender, EventArgs e)
        {
            query = "select * from MedsCategory";
            fn.getData(query);
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.AllowUserToAddRows = false;
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            String ID = txtCatID.Text;
            String name = txtCatName.Text;

            try
            {
                if (string.IsNullOrEmpty(ID) || string.IsNullOrEmpty(name))
                {
                    // At least one field is empty
                    MessageBox.Show("Empty Credentials!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    query = "insert into MedsCategory (CategoryNumber, name) values ('" + ID + "', '" + name + "')";
                    fn.setData(query, "Category added successfully!");
                    txtCatID.ResetText();
                    txtCatName.ResetText();

                    UC_Category_Load(this, null);
                }
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Category already in database!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            // Check if any cell is selected in the DataGridView
            if (dataGridView1.SelectedCells.Count > 0)
            {
                if (MessageBox.Show("Are you sure?", "Delete Confirmation!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    // Get the value from the selected cell
                    string userName = dataGridView1.SelectedCells[0].Value.ToString();
              
                    query = "delete from MedsCategory where CategoryNumber = '" + userName + "'";
                    fn.setData(query, "Category Record Deleted!");

                    // Refresh the DataGridView
                    UC_Category_Load(this, null);
                }
            }
            else
            {
                MessageBox.Show("Please select a cell before deleting.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void Search_TextChanged_1(object sender, EventArgs e)
        {
            query = "select * from MedsCategory where name like '" + Search.Text + "%'";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            String id = txtCatID.Text;
            String Name = txtCatName.Text;

            if (!string.IsNullOrEmpty(id) || !string.IsNullOrEmpty(Name))

            {

                try
                {
                    query = "update MedsCategory set name = '" + Name + "' where CategoryNumber = '" + id + "'";
                    fn.setData(query, "category Updated Successfully!");
                }
                catch (Exception)
                {
                    MessageBox.Show("Error, Try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Credentials!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtCatID.Text != "")
                {
                    query = "select * from MedsCategory where CategoryNumber = '" + txtCatID.Text + "'";
                    DataSet ds = fn.getData(query);
                    txtCatName.Text = ds.Tables[0].Rows[0][1].ToString();
                }
                else
                {
                    MessageBox.Show("Enter a valid ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No Category Found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
