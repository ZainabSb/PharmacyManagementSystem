using Microsoft.VisualBasic.ApplicationServices;
using PharmacyManagementSystem.AdministratorUC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagementSystem
{
    public partial class Pharmacist : Form
    {
        String user = "";

        public Pharmacist()
        {
            InitializeComponent();
        }
        public String ID
        {
            get { return user.ToString(); }
        }

        public Pharmacist(String username)
        { 
            InitializeComponent();
            //UserNameLabel.Text = username;
            user = username;
            uC_P_Orders1.ID = ID;
        }


        private void button6_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            btnDashboard.BackColor = Color.White;
            btnDashboard.ForeColor = Color.Black;

            AddMed.BackColor = Color.FromArgb(0, 150, 215);
            AddMed.ForeColor = Color.White;

            Stock.BackColor = Color.FromArgb(0, 150, 215);
            Stock.ForeColor = Color.White;

            ModMed.BackColor = Color.FromArgb(0, 150, 215);
            ModMed.ForeColor = Color.White;

            btnOrders.BackColor = Color.FromArgb(0, 150, 215);
            btnOrders.ForeColor = Color.White;

            btnCustomers.BackColor = Color.FromArgb(0, 150, 215);
            btnCustomers.ForeColor = Color.White;

            SellMed.BackColor = Color.FromArgb(0, 150, 215);
            SellMed.ForeColor = Color.White;

            uC_P_Dashboard1.Visible = true;
            uC_P_Dashboard1.BringToFront();
        }

        private void ViewMed_Click(object sender, EventArgs e)
        {
            Stock.BackColor = Color.White;
            Stock.ForeColor = Color.Black;

            AddMed.BackColor = Color.FromArgb(0, 150, 215);
            AddMed.ForeColor = Color.White;

            btnDashboard.BackColor = Color.FromArgb(0, 150, 215);
            btnDashboard.ForeColor = Color.White;

            ModMed.BackColor = Color.FromArgb(0, 150, 215);
            ModMed.ForeColor = Color.White;

            btnOrders.BackColor = Color.FromArgb(0, 150, 215);
            btnOrders.ForeColor = Color.White;


            btnCustomers.BackColor = Color.FromArgb(0, 150, 215);
            btnCustomers.ForeColor = Color.White;

            SellMed.BackColor = Color.FromArgb(0, 150, 215);
            SellMed.ForeColor = Color.White;

            uC_P_Stock1.Visible = true;
            uC_P_Stock1.BringToFront();
        }

        private void AddMed_Click(object sender, EventArgs e)
        {
            AddMed.BackColor = Color.White;
            AddMed.ForeColor = Color.Black;

            btnDashboard.BackColor = Color.FromArgb(0, 150, 215);
            btnDashboard.ForeColor = Color.White;

            Stock.BackColor = Color.FromArgb(0, 150, 215);
            Stock.ForeColor = Color.White;

            ModMed.BackColor = Color.FromArgb(0, 150, 215);
            ModMed.ForeColor = Color.White;

            btnOrders.BackColor = Color.FromArgb(0, 150, 215);
            btnOrders.ForeColor = Color.White;

            btnCustomers.BackColor = Color.FromArgb(0, 150, 215);
            btnCustomers.ForeColor = Color.White;

            SellMed.BackColor = Color.FromArgb(0, 150, 215);
            SellMed.ForeColor = Color.White;

            uC_P_AddMedicine1.Visible = true;
            uC_P_AddMedicine1.BringToFront();
        }

        private void ModMed_Click(object sender, EventArgs e)
        {
            ModMed.BackColor = Color.White;
            ModMed.ForeColor = Color.Black;

            AddMed.BackColor = Color.FromArgb(0, 150, 215);
            AddMed.ForeColor = Color.White;

            Stock.BackColor = Color.FromArgb(0, 150, 215);
            Stock.ForeColor = Color.White;

            btnDashboard.BackColor = Color.FromArgb(0, 150, 215);
            btnDashboard.ForeColor = Color.White;

            btnOrders.BackColor = Color.FromArgb(0, 150, 215);
            btnOrders.ForeColor = Color.White;

            btnCustomers.BackColor = Color.FromArgb(0, 150, 215);
            btnCustomers.ForeColor = Color.White;

            SellMed.BackColor = Color.FromArgb(0, 150, 215);
            SellMed.ForeColor = Color.White;

            uC_P_ModifyMedicine1.Visible = true;
            uC_P_ModifyMedicine1.BringToFront();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            btnOrders.BackColor = Color.White;
            btnOrders.ForeColor = Color.Black;

            AddMed.BackColor = Color.FromArgb(0, 150, 215);
            AddMed.ForeColor = Color.White;

            Stock.BackColor = Color.FromArgb(0, 150, 215);
            Stock.ForeColor = Color.White;

            btnDashboard.BackColor = Color.FromArgb(0, 150, 215);
            btnDashboard.ForeColor = Color.White;

            ModMed.BackColor = Color.FromArgb(0, 150, 215);
            ModMed.ForeColor = Color.White;

            btnCustomers.BackColor = Color.FromArgb(0, 150, 215);
            btnCustomers.ForeColor = Color.White;

            SellMed.BackColor = Color.FromArgb(0, 150, 215);
            SellMed.ForeColor = Color.White;

            uC_P_Orders1.Visible = true;
            uC_P_Orders1.BringToFront();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            btnCustomers.BackColor = Color.White;
            btnCustomers.ForeColor = Color.Black;

            AddMed.BackColor = Color.FromArgb(0, 150, 215);
            AddMed.ForeColor = Color.White;

            Stock.BackColor = Color.FromArgb(0, 150, 215);
            Stock.ForeColor = Color.White;

            ModMed.BackColor = Color.FromArgb(0, 150, 215);
            ModMed.ForeColor = Color.White;

            btnOrders.BackColor = Color.FromArgb(0, 150, 215);
            btnOrders.ForeColor = Color.White;

            btnDashboard.BackColor = Color.FromArgb(0, 150, 215);
            btnDashboard.ForeColor = Color.White;

            SellMed.BackColor = Color.FromArgb(0, 150, 215);
            SellMed.ForeColor = Color.White;

            uC_P_Customers1.Visible = true;
            uC_P_Customers1.BringToFront();
        }

        private void SellMed_Click(object sender, EventArgs e)
        {
            SellMed.BackColor = Color.White;
            SellMed.ForeColor = Color.Black;

            AddMed.BackColor = Color.FromArgb(0, 150, 215);
            AddMed.ForeColor = Color.White;

            Stock.BackColor = Color.FromArgb(0, 150, 215);
            Stock.ForeColor = Color.White;

            ModMed.BackColor = Color.FromArgb(0, 150, 215);
            ModMed.ForeColor = Color.White;

            btnOrders.BackColor = Color.FromArgb(0, 150, 215);
            btnOrders.ForeColor = Color.White;

            btnCustomers.BackColor = Color.FromArgb(0, 150, 215);
            btnCustomers.ForeColor = Color.White;

            btnDashboard.BackColor = Color.FromArgb(0, 150, 215);
            btnDashboard.ForeColor = Color.White;

            uC_Sell_Medicine1.Visible = true;
            uC_Sell_Medicine1.BringToFront();
        }

        private void uC_P_Dashboard1_Load(object sender, EventArgs e)
        {
            uC_P_Dashboard1.Visible = false;
            uC_P_AddMedicine1.Visible = false;
            uC_P_Stock1.Visible = false;
            uC_P_ModifyMedicine1.Visible = false;
            uC_Sell_Medicine1.Visible = false;
            uC_P_Customers1.Visible = false;
            uC_P_Orders1.Visible = false;
            btnDashboard.PerformClick();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void uC_P_Orders1_Load(object sender, EventArgs e)
        {

        }
    }
}
