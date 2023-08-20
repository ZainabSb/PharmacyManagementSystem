﻿using System;
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
    public partial class UC_P_Stock : UserControl
    {
        function fn = new function();
        String query;

        public UC_P_Stock()
        {
            InitializeComponent();
        }

        private void UC_P_Stock_Load(object sender, EventArgs e)
        {
            query = "select * from medicin";
            setDataGridView(query);
            dataGridView1.AllowUserToAddRows = false;

            // Subscribe to the CellFormatting event
            dataGridView1.CellFormatting += DataGridView1_CellFormatting;
        }

        private void DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["quantity"].Index && e.Value != null)
            {
                int quantity = Convert.ToInt32(e.Value);

                // Check if the quantity is less than 50
                if (quantity < 50)
                {
                    // Set the cell's background color to red
                    e.CellStyle.BackColor = Color.Red;
                }
            }
        }

        private void setDataGridView(String query)
        {
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            query = "select * from medicin where mname like '" + txtSearch.Text + "%'";
            setDataGridView(query);
        }

        String medicineID;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                medicineID = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            catch
            {

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                query = "delete from medicin where mid = '" + medicineID + "'";
                fn.setData(query, "Medicine Deleted Successfully!");
                UC_P_Stock_Load(this, null);
            }
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            UC_P_Stock_Load(this, null);
        }

        private void txtCheck_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtCheck.SelectedIndex == 0)
            {
                query = "select * from medicin where eDate >= getdate()";
                DataSet ds = fn.getData(query);
                dataGridView1.DataSource = ds.Tables[0];
            }
            else if (txtCheck.SelectedIndex == 1)
            {
                query = "select * from medicin where eDate <= getdate()";
                DataSet ds = fn.getData(query);
                dataGridView1.DataSource = ds.Tables[0];
            }
            else if (txtCheck.SelectedIndex == 2)
            {
                query = "select * from medicin";
                DataSet ds = fn.getData(query);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }
    }
}
