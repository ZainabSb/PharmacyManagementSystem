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
    public partial class Administrator : Form
    {
        String user = "";

        public Administrator()
        {
            InitializeComponent();
        }

        public String ID
        {
            get { return user.ToString(); }
        }


        public Administrator(String username)
        {
            InitializeComponent();
            UserNameLabel.Text = username;
            user = username;
            uC_ModifyUser1.ID = ID;
            //uC_Profile1.ID = ID;
        }

        private void Administrator_Load(object sender, EventArgs e)
        {
            //full screen mode
          //  int w = Screen.PrimaryScreen.Bounds.Width;
           // int h = Screen.PrimaryScreen.Bounds.Height;
           // this.Location = new Point(0, 0);
         //   this.Size = new Size(w, h);

            uC_Dashboard1.Visible = false;
            uC_AddUser1.Visible = false;
            uC_ModifyUser1.Visible = false;
            uC_AddSupplier1.Visible = false;
            uC_Orders1.Visible = false;
            uC_Stock1.Visible = false;
            uC_Customers1.Visible = false;
            uC_Category1.Visible = false;
            uC_UpdateOrder1.Visible = false;
            uC_Purchases1.Visible = false;
            btnDashboard.PerformClick();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            btnDashboard.BackColor = Color.White;
            btnDashboard.ForeColor = Color.Black;

            btnAddUser.BackColor = Color.FromArgb(64, 64, 64);
            btnAddUser.ForeColor = Color.White;

            btnModifyUser.BackColor = Color.FromArgb(64, 64, 64);
            btnModifyUser.ForeColor = Color.White;

            btnStock.BackColor = Color.FromArgb(64, 64, 64);
            btnStock.ForeColor = Color.White;

            btnOrders.BackColor = Color.FromArgb(64, 64, 64);
            btnOrders.ForeColor = Color.White;

            btnUpdateOrders.BackColor = Color.FromArgb(64, 64, 64);
            btnUpdateOrders.ForeColor = Color.White;

            btnCustomers.BackColor = Color.FromArgb(64, 64, 64);
            btnCustomers.ForeColor = Color.White;

            btnSuppliers.BackColor = Color.FromArgb(64, 64, 64);
            btnSuppliers.ForeColor = Color.White;

            btnCategories.BackColor = Color.FromArgb(64, 64, 64);
            btnCategories.ForeColor = Color.White;

            btnPurchases.BackColor = Color.FromArgb(64, 64, 64);
            btnPurchases.ForeColor = Color.White;


            uC_Dashboard1.Visible = true;
            uC_Dashboard1.BringToFront();
        }
   
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            btnAddUser.BackColor = Color.White;
            btnAddUser.ForeColor = Color.Black;

            btnOrders.BackColor = Color.FromArgb(64, 64, 64);
            btnOrders.ForeColor = Color.White;

            btnModifyUser.BackColor = Color.FromArgb(64, 64, 64);
            btnModifyUser.ForeColor = Color.White;

            btnStock.BackColor = Color.FromArgb(64, 64, 64);
            btnStock.ForeColor = Color.White;

            btnDashboard.BackColor = Color.FromArgb(64, 64, 64);
            btnDashboard.ForeColor = Color.White;

            btnUpdateOrders.BackColor = Color.FromArgb(64, 64, 64);
            btnUpdateOrders.ForeColor = Color.White;

            btnCustomers.BackColor = Color.FromArgb(64, 64, 64);
            btnCustomers.ForeColor = Color.White;


            btnSuppliers.BackColor = Color.FromArgb(64, 64, 64);
            btnSuppliers.ForeColor = Color.White;


            btnCategories.BackColor = Color.FromArgb(64, 64, 64);
            btnCategories.ForeColor = Color.White;

            btnPurchases.BackColor = Color.FromArgb(64, 64, 64);
            btnPurchases.ForeColor = Color.White;


            uC_AddUser1.Visible = true;
            uC_AddUser1.BringToFront();
        }

        private void btnModifyUser_Click(object sender, EventArgs e)
        {
            btnModifyUser.BackColor = Color.White;
            btnModifyUser.ForeColor = Color.Black;

            btnOrders.BackColor = Color.FromArgb(64, 64, 64);
            btnOrders.ForeColor = Color.White;

            btnAddUser.BackColor = Color.FromArgb(64, 64, 64);
            btnAddUser.ForeColor = Color.White;

            btnStock.BackColor = Color.FromArgb(64, 64, 64);
            btnStock.ForeColor = Color.White;

            btnDashboard.BackColor = Color.FromArgb(64, 64, 64);
            btnDashboard.ForeColor = Color.White;

            btnUpdateOrders.BackColor = Color.FromArgb(64, 64, 64);
            btnUpdateOrders.ForeColor = Color.White;

            btnCustomers.BackColor = Color.FromArgb(64, 64, 64);
            btnCustomers.ForeColor = Color.White;


            btnSuppliers.BackColor = Color.FromArgb(64, 64, 64);
            btnSuppliers.ForeColor = Color.White;

            btnCategories.BackColor = Color.FromArgb(64, 64, 64);
            btnCategories.ForeColor = Color.White;

            btnPurchases.BackColor = Color.FromArgb(64, 64, 64);
            btnPurchases.ForeColor = Color.White;

            uC_ModifyUser1.Visible = true;
            uC_ModifyUser1.BringToFront();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            btnStock.BackColor = Color.White;
            btnStock.ForeColor = Color.Black;

            btnOrders.BackColor = Color.FromArgb(64, 64, 64);
            btnOrders.ForeColor = Color.White;

            btnAddUser.BackColor = Color.FromArgb(64, 64, 64);
            btnAddUser.ForeColor = Color.White;

            btnModifyUser.BackColor = Color.FromArgb(64, 64, 64);
            btnModifyUser.ForeColor = Color.White;

            btnDashboard.BackColor = Color.FromArgb(64, 64, 64);
            btnDashboard.ForeColor = Color.White;

            btnUpdateOrders.BackColor = Color.FromArgb(64, 64, 64);
            btnUpdateOrders.ForeColor = Color.White;

            btnCustomers.BackColor = Color.FromArgb(64, 64, 64);
            btnCustomers.ForeColor = Color.White;


            btnSuppliers.BackColor = Color.FromArgb(64, 64, 64);
            btnSuppliers.ForeColor = Color.White;


            btnCategories.BackColor = Color.FromArgb(64, 64, 64);
            btnCategories.ForeColor = Color.White;

            btnPurchases.BackColor = Color.FromArgb(64, 64, 64);
            btnPurchases.ForeColor = Color.White;

            uC_Stock1.Visible = true;
            uC_Stock1.BringToFront();

        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            btnOrders.BackColor = Color.White;
            btnOrders.ForeColor = Color.Black;

            btnAddUser.BackColor = Color.FromArgb(64, 64, 64);
            btnAddUser.ForeColor = Color.White;

            btnModifyUser.BackColor = Color.FromArgb(64, 64, 64);
            btnModifyUser.ForeColor = Color.White;

            btnStock.BackColor = Color.FromArgb(64, 64, 64);
            btnStock.ForeColor = Color.White;

            btnDashboard.BackColor = Color.FromArgb(64, 64, 64);
            btnDashboard.ForeColor = Color.White;

            btnUpdateOrders.BackColor = Color.FromArgb(64, 64, 64);
            btnUpdateOrders.ForeColor = Color.White;

            btnCustomers.BackColor = Color.FromArgb(64, 64, 64);
            btnCustomers.ForeColor = Color.White;

            btnSuppliers.BackColor = Color.FromArgb(64, 64, 64);
            btnSuppliers.ForeColor = Color.White;

            btnCategories.BackColor = Color.FromArgb(64, 64, 64);
            btnCategories.ForeColor = Color.White;

            btnPurchases.BackColor = Color.FromArgb(64, 64, 64);
            btnPurchases.ForeColor = Color.White;

            uC_Orders1.Visible = true;
            uC_Orders1.BringToFront();
        }


        private void btnUpdateOrders_Click(object sender, EventArgs e)
        {
            btnUpdateOrders.BackColor = Color.White;
            btnUpdateOrders.ForeColor = Color.Black;

            btnOrders.BackColor = Color.FromArgb(64, 64, 64);
            btnOrders.ForeColor = Color.White;

            btnAddUser.BackColor = Color.FromArgb(64, 64, 64);
            btnAddUser.ForeColor = Color.White;

            btnModifyUser.BackColor = Color.FromArgb(64, 64, 64);
            btnModifyUser.ForeColor = Color.White;

            btnDashboard.BackColor = Color.FromArgb(64, 64, 64);
            btnDashboard.ForeColor = Color.White;

            btnStock.BackColor = Color.FromArgb(64, 64, 64);
            btnStock.ForeColor = Color.White;

            btnCustomers.BackColor = Color.FromArgb(64, 64, 64);
            btnCustomers.ForeColor = Color.White;


            btnSuppliers.BackColor = Color.FromArgb(64, 64, 64);
            btnSuppliers.ForeColor = Color.White;

            btnCategories.BackColor = Color.FromArgb(64, 64, 64);
            btnCategories.ForeColor = Color.White;

            btnPurchases.BackColor = Color.FromArgb(64, 64, 64);
            btnPurchases.ForeColor = Color.White;

            uC_UpdateOrder1.Visible = true;
            uC_UpdateOrder1.BringToFront();

        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            btnCustomers.BackColor = Color.White;
            btnCustomers.ForeColor = Color.Black;

            btnOrders.BackColor = Color.FromArgb(64, 64, 64);
            btnOrders.ForeColor = Color.White;

            btnAddUser.BackColor = Color.FromArgb(64, 64, 64);
            btnAddUser.ForeColor = Color.White;

            btnModifyUser.BackColor = Color.FromArgb(64, 64, 64);
            btnModifyUser.ForeColor = Color.White;

            btnDashboard.BackColor = Color.FromArgb(64, 64, 64);
            btnDashboard.ForeColor = Color.White;

            btnStock.BackColor = Color.FromArgb(64, 64, 64);
            btnStock.ForeColor = Color.White;

            btnUpdateOrders.BackColor = Color.FromArgb(64, 64, 64);
            btnUpdateOrders.ForeColor = Color.White;


            btnSuppliers.BackColor = Color.FromArgb(64, 64, 64);
            btnSuppliers.ForeColor = Color.White;


            btnCategories.BackColor = Color.FromArgb(64, 64, 64);
            btnCategories.ForeColor = Color.White;

            btnPurchases.BackColor = Color.FromArgb(64, 64, 64);
            btnPurchases.ForeColor = Color.White;

            uC_Customers1.Visible = true;
            uC_Customers1.BringToFront();

        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            btnSuppliers.BackColor = Color.White;
            btnSuppliers.ForeColor = Color.Black;

            btnOrders.BackColor = Color.FromArgb(64, 64, 64);
            btnOrders.ForeColor = Color.White;

            btnAddUser.BackColor = Color.FromArgb(64, 64, 64);
            btnAddUser.ForeColor = Color.White;

            btnModifyUser.BackColor = Color.FromArgb(64, 64, 64);
            btnModifyUser.ForeColor = Color.White;

            btnDashboard.BackColor = Color.FromArgb(64, 64, 64);
            btnDashboard.ForeColor = Color.White;

            btnStock.BackColor = Color.FromArgb(64, 64, 64);
            btnStock.ForeColor = Color.White;

            btnUpdateOrders.BackColor = Color.FromArgb(64, 64, 64);
            btnUpdateOrders.ForeColor = Color.White;

            btnCustomers.BackColor = Color.FromArgb(64, 64, 64);
            btnCustomers.ForeColor = Color.White;

            btnCategories.BackColor = Color.FromArgb(64, 64, 64);
            btnCategories.ForeColor = Color.White;

            btnPurchases.BackColor = Color.FromArgb(64, 64, 64);
            btnPurchases.ForeColor = Color.White;

            uC_AddSupplier1.Visible = true;
            uC_AddSupplier1.BringToFront();
        }


        private void btnCategories_Click(object sender, EventArgs e)
        {
            btnCategories.BackColor = Color.White;
            btnCategories.ForeColor = Color.Black;

            btnOrders.BackColor = Color.FromArgb(64, 64, 64);
            btnOrders.ForeColor = Color.White;

            btnAddUser.BackColor = Color.FromArgb(64, 64, 64);
            btnAddUser.ForeColor = Color.White;

            btnModifyUser.BackColor = Color.FromArgb(64, 64, 64);
            btnModifyUser.ForeColor = Color.White;

            btnDashboard.BackColor = Color.FromArgb(64, 64, 64);
            btnDashboard.ForeColor = Color.White;

            btnStock.BackColor = Color.FromArgb(64, 64, 64);
            btnStock.ForeColor = Color.White;

            btnUpdateOrders.BackColor = Color.FromArgb(64, 64, 64);
            btnUpdateOrders.ForeColor = Color.White;

            btnSuppliers.BackColor = Color.FromArgb(64, 64, 64);
            btnSuppliers.ForeColor = Color.White;

            btnCustomers.BackColor = Color.FromArgb(64, 64, 64);
            btnCustomers.ForeColor = Color.White;

            btnPurchases.BackColor = Color.FromArgb(64, 64, 64);
            btnPurchases.ForeColor = Color.White;

            uC_Category1.Visible = true;
            uC_Category1.BringToFront();
        }

        private void btnPurchases_Click(object sender, EventArgs e)
        {
            btnCategories.BackColor = Color.FromArgb(64, 64, 64);
            btnCategories.ForeColor = Color.White;

            btnOrders.BackColor = Color.FromArgb(64, 64, 64);
            btnOrders.ForeColor = Color.White;

            btnAddUser.BackColor = Color.FromArgb(64, 64, 64);
            btnAddUser.ForeColor = Color.White;

            btnModifyUser.BackColor = Color.FromArgb(64, 64, 64);
            btnModifyUser.ForeColor = Color.White;

            btnDashboard.BackColor = Color.FromArgb(64, 64, 64);
            btnDashboard.ForeColor = Color.White;

            btnStock.BackColor = Color.FromArgb(64, 64, 64);
            btnStock.ForeColor = Color.White;

            btnUpdateOrders.BackColor = Color.FromArgb(64, 64, 64);
            btnUpdateOrders.ForeColor = Color.White;

            btnSuppliers.BackColor = Color.FromArgb(64, 64, 64);
            btnSuppliers.ForeColor = Color.White;

            btnCustomers.BackColor = Color.FromArgb(64, 64, 64);
            btnCustomers.ForeColor = Color.White;

            btnPurchases.BackColor = Color.White;
            btnPurchases.ForeColor = Color.Black;

            uC_Purchases1.Visible = true;
            uC_Purchases1.BringToFront();
        }


        private void uC_AddUser1_Load(object sender, EventArgs e)
        {

        }

        private void uC_ModifyUser1_Load(object sender, EventArgs e)
        {

        }

        private void uC_AddSupplier1_Load(object sender, EventArgs e)
        {

        }

        private void uC_Orders1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       
    }
}
