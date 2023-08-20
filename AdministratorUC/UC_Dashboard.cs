using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagementSystem.AdministratorUC
{
    public partial class UC_Dashboard : UserControl
    {
        function fn = new function();
        String query;
        DataSet ds;
        Int64 count;

        public UC_Dashboard()
        {
            InitializeComponent();
        }

        private void setLabel(DataSet ds, Label lbl)
        {
            if (ds.Tables[0].Rows.Count != 0)
            {
                lbl.Text = ds.Tables[0].Rows[0][0].ToString();
            }
            else
            {
                lbl.Text = "0";
            }
        }

        private void UC_Dashboard_Load(object sender, EventArgs e)
        {
            loadChart();
            query = "select count(userRole) from users where userRole = 'Administrator'";
            ds = fn.getData(query);
            setLabel(ds, AdminLabel);

            query = "select count(userRole) from users where userRole = 'Pharmacist'";
            ds = fn.getData(query);
            setLabel(ds, PharmLabel);

            query = "select count(*) from suppliers";
            ds = fn.getData(query);
            setLabel(ds, SupLab);

            query = "select count(*) from MedsCategory";
            ds = fn.getData(query);
            setLabel(ds, Categories);

            query = "select count(*) from customerTab";
            ds = fn.getData(query);
            setLabel(ds, Customers);
        }

         public void loadChart()
         {
             query = "select count(mname) from medicin where eDate >= getdate()";
             ds = fn.getData(query);
             count = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
             this.chart1.Series["Valid Medicines"].Points.AddXY("Validity Chart", count);

             query = "select count(mname) from medicin where eDate <= getdate()";
             ds = fn.getData(query);
             count = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
             this.chart1.Series["Expired Medicines"].Points.AddXY("Validity Chart", count);

         }

         

        private void btnSync_Click(object sender, EventArgs e)
        {
            chart1.Series["Valid Medicines"].Points.Clear();
            chart1.Series["Expired Medicines"].Points.Clear();

            UC_Dashboard_Load(this, null);
        }
    }
}
