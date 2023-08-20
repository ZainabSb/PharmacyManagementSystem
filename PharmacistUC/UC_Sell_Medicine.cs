using DGVPrinterHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Resources.ResXFileRef;
using static System.Windows.Forms.AxHost;
using System.Windows.Forms.DataVisualization.Charting;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Reflection;
using System.Xml.Linq;

namespace PharmacyManagementSystem.PharmacistUC
{
    public partial class UC_Sell_Medicine : UserControl
    {
        function fn = new function();
        String query;
        DataSet ds;
       
        public UC_Sell_Medicine()
        {
            InitializeComponent();
            

        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            UC_Sell_Medicine_Load(this, null);
            ClearAll();
            txtDiscount.Clear();
            DollarRate.Clear();
        }

        private void UC_Sell_Medicine_Load(object sender, EventArgs e)
        {
            listBoxMedecines.Items.Clear();

            query = "select mname from medicin where eDate >= getdate() and quantity >'0'";
            ds = fn.getData(query);


            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBoxMedecines.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }

            dataGridView1.AllowUserToAddRows = false;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            listBoxMedecines.Items.Clear();
            query = "select mname from medicin where mname like '" + txtSearch.Text + "%' and eDate >= getdate() and quantity > '0'";
            ds = fn.getData(query);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBoxMedecines.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void listBoxMedecines_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNoOfUnits.Clear();
            txtDiscount.Clear();

            try
            {
                String name = listBoxMedecines.GetItemText(listBoxMedecines.SelectedItem);
                txtMediName.Text = name;
                query = "select mid, eDate, perUnit from medicin where mname = '" + name + "'";
                ds = fn.getData(query);
                txtMediID.Text = ds.Tables[0].Rows[0][0].ToString();
                txtPricePerUnit.Text = ds.Tables[0].Rows[0][2].ToString();
            }
            catch (System.IndexOutOfRangeException)
            {
                MessageBox.Show("Please enter a Medicine!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtNoOfUnits_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtNoOfUnits.Text != "")
                {
                    Int64 unitPrice = Int64.Parse(txtPricePerUnit.Text);
                    Int64 noOfUnits = Int64.Parse(txtNoOfUnits.Text);
                    Int64 pricebeforeDiscount = unitPrice * noOfUnits;

                    Int64 discount = Int64.Parse(txtDiscount.Text);
                    Int64 totalAmountD = pricebeforeDiscount - (pricebeforeDiscount * discount / 100);
                    txtTotalPriceD.Text = totalAmountD.ToString();

                    Int64 Rate = Int64.Parse(DollarRate.Text);
                    Int64 totalLB = Rate * totalAmountD;
                    txtTotalPriceLB.Text = totalLB.ToString();

                }

                else
                {
                    txtTotalPriceD.Clear();
                    txtTotalPriceLB.Clear();
                }
            }

            catch (System.FormatException)
            {
                MessageBox.Show("Please enter a Medicine!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public int n, totalAmount = 0;
        protected int totalAmountLB = 0;
        protected Int64 quantity, newQuantity;

        private void btnAddToCart_Click(object sender, EventArgs e)
        {

            String name = txtMediName.Text;
            String date = txtExpireDate.Text;
            String nb = PhoneNb.Text;
            String quan = txtNoOfUnits.Text;    

            if (txtMediName.Text != "" && txtNoOfUnits.Text != "" && txtPricePerUnit.Text != "" && txtNoOfUnits.Text != "" && txtDiscount.Text != "" && DollarRate.Text != "")
            {
                if (txtMediID.Text != "")
                {
                    // Check if the customer exists in the customers table based on the phone number
                    string phoneNb = PhoneNb.Text.Trim();
                    query = "SELECT COUNT(*) FROM customerTab WHERE CustomerMobile = '" + phoneNb + "'";
                    int customerCount = Convert.ToInt32(fn.getData(query).Tables[0].Rows[0][0]);

                    if (customerCount > 0)
                    {
                        // The customer exists in the table, proceed with adding the medicine to the cart
                        query = "select quantity from medicin where mid = '" + txtMediID.Text + "'";
                        ds = fn.getData(query);

                        quantity = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                        newQuantity = quantity - Int64.Parse(txtNoOfUnits.Text);        

                            n = dataGridView1.Rows.Add();
                            dataGridView1.Rows[n].Cells[0].Value = txtMediID.Text;
                            dataGridView1.Rows[n].Cells[1].Value = txtMediName.Text;
                            dataGridView1.Rows[n].Cells[2].Value = PhoneNb.Text;
                            dataGridView1.Rows[n].Cells[3].Value = txtPricePerUnit.Text;
                            dataGridView1.Rows[n].Cells[4].Value = txtNoOfUnits.Text;
                            dataGridView1.Rows[n].Cells[5].Value = txtTotalPriceD.Text;

                        query = "insert into meds_purchased (Medname, Quantity, Date, PhoneNb) values ('" + name + "', '"+quan+"', '" + date + "', '" + nb + "')";
                        fn.setMyData(query);

                        // Update the total and clear the input fields
                        totalAmount += int.Parse(txtTotalPriceD.Text);
                        totalLabelD.Text = totalAmount.ToString();

                        totalAmountLB = totalAmount * int.Parse(DollarRate.Text);
                        totalLabelLB.Text = totalAmountLB.ToString();

                        query = "update medicin set quantity = '" + newQuantity + "' where mid = '" + txtMediID.Text + "'";
                        fn.setData(query, "Medicine Added!");

                        //ClearAll();
                        UC_Sell_Medicine_Load(this, null);
                    }
                    else
                    {
                        // The customer does not exist in the table
                        MessageBox.Show("Customer with Phone Number " + phoneNb + " not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Select medicine First!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Empty Credentials!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearAll()
        {
            txtMediID.Clear();
            txtMediName.Clear();
            txtExpireDate.ResetText();
            txtPricePerUnit.Clear();
            txtNoOfUnits.Clear();
            PhoneNb.Clear();
        }

        int valueAmount;
        String valueID;
        int LBpay;
        protected Int64 noOfUnits;

        String medname;
        String PN;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                valueAmount = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
                valueID = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                noOfUnits = Int64.Parse(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());

                medname = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                PN = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();

            }
            catch (NullReferenceException)
            {
                MessageBox.Show("An error occurred while accessing the cell value","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.ArgumentOutOfRangeException)
            {
                MessageBox.Show("An error occurred while accessing the cell value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
                
           String date = txtExpireDate.Text;

            if (valueID != null && dataGridView1.Rows.Count != 0)
            {
                try
                {                    
                        dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
                        query = "delete from meds_purchased where Medname = '" + medname + "' and Date = '" + date + "' and PhoneNb = '" + PN + "'";
                        fn.setMyData(query);
                }
                catch (Exception)
                {
                    MessageBox.Show("Empty Credentials!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                finally
                {
                    query = "select quantity from medicin where mid = '" + valueID + "'";
                    ds = fn.getData(query);
                    quantity = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                    newQuantity = quantity + noOfUnits;

                    query = "update medicin set quantity = '" + newQuantity + "' where mid = '" + valueID + "'";
                    fn.setData(query, "Medicine Removed Successfully!");

                    totalAmount = totalAmount - valueAmount;
                    totalLabelD.Text = totalAmount.ToString();

                    LBpay = totalAmount * int.Parse(DollarRate.Text);
                    totalLabelLB.Text = LBpay.ToString();


                }
                UC_Sell_Medicine_Load(this, null);
            }
            else
            {
                MessageBox.Show("Add some Medicine First!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        String phoneNumberString;
        private void btnPurchase_Click(object sender, EventArgs e)
        {

            phoneNumberString = PhoneNb.Text;
            String date = txtExpireDate.Text;
            String total = totalLabelD.Text;

            if (dataGridView1.Rows.Count != 0 )
            {
                query = "UPDATE customerTab SET purNo = purNo + 1 WHERE CustomerMobile LIKE '" + phoneNumberString + "'";
                fn.setMyData(query);

                Int64 TotalPay = Int64.Parse(total);
                query = "insert into totalpurchases (CustomerPhoneNb, PurchaseDate, totalPay) values ('" + phoneNumberString + "', '" + date + "', '" + TotalPay + "')";
                fn.setMyData(query);

                DGVPrinter print = new DGVPrinter();
                print.Title = "Medicine Bill";
                print.SubTitleSpacing = 40;
                print.SubTitle = String.Format("Date:- {0}\nDollar Rate is " + DollarRate.Text, DateTime.Now.ToString());
                print.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                print.PageNumbers = false;
                print.PageNumberInHeader = false;
                print.PorportionalColumns = true;
                print.HeaderCellAlignment = StringAlignment.Near;
                print.Footer = "Total Pay Amount : " + totalLabelD.Text + "$ or " + totalLabelLB.Text + "L.L.";
                print.FooterSpacing = 15;
                print.PrintDataGridView(dataGridView1);

             
                totalAmount = 0;
                // totalAmountLB = 0;
                totalLabelD.Text = "0.0";
                totalLabelLB.Text = "0.0";
                // dataGridView1.DataSource = 0;
                dataGridView1.Rows.Clear();
            }
            else
            {
                MessageBox.Show("Add some Medicine First!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
