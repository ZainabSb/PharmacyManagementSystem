namespace PharmacyManagementSystem
{
    partial class Pharmacist
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pharmacist));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ModMed = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.SellMed = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.Stock = new System.Windows.Forms.Button();
            this.AddMed = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uC_P_Orders1 = new PharmacyManagementSystem.PharmacistUC.UC_P_Orders();
            this.uC_P_Customers1 = new PharmacyManagementSystem.PharmacistUC.UC_P_Customers();
            this.uC_Sell_Medicine1 = new PharmacyManagementSystem.PharmacistUC.UC_Sell_Medicine();
            this.uC_P_ModifyMedicine1 = new PharmacyManagementSystem.PharmacistUC.UC_P_ModifyMedicine();
            this.uC_P_Stock1 = new PharmacyManagementSystem.PharmacistUC.UC_P_Stock();
            this.uC_P_AddMedicine1 = new PharmacyManagementSystem.PharmacistUC.UC_P_AddMedicine();
            this.uC_P_Dashboard1 = new PharmacyManagementSystem.PharmacistUC.UC_P_Dashboard();
            this.gunaElipse = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse2 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse3 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse4 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse5 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse6 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse7 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(215)))));
            this.panel1.Controls.Add(this.ModMed);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.btnCustomers);
            this.panel1.Controls.Add(this.SellMed);
            this.panel1.Controls.Add(this.btnOrders);
            this.panel1.Controls.Add(this.Stock);
            this.panel1.Controls.Add(this.AddMed);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(359, 902);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // ModMed
            // 
            this.ModMed.FlatAppearance.BorderSize = 0;
            this.ModMed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModMed.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModMed.ForeColor = System.Drawing.Color.White;
            this.ModMed.Location = new System.Drawing.Point(0, 486);
            this.ModMed.Name = "ModMed";
            this.ModMed.Size = new System.Drawing.Size(359, 48);
            this.ModMed.TabIndex = 11;
            this.ModMed.Text = "Modify Medicine";
            this.ModMed.UseVisualStyleBackColor = true;
            this.ModMed.Click += new System.EventHandler(this.ModMed_Click);
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(12, 832);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(61, 56);
            this.button6.TabIndex = 7;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.FlatAppearance.BorderSize = 0;
            this.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomers.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomers.ForeColor = System.Drawing.Color.White;
            this.btnCustomers.Location = new System.Drawing.Point(0, 601);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(359, 48);
            this.btnCustomers.TabIndex = 9;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.UseVisualStyleBackColor = true;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // SellMed
            // 
            this.SellMed.FlatAppearance.BorderSize = 0;
            this.SellMed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SellMed.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellMed.ForeColor = System.Drawing.Color.White;
            this.SellMed.Location = new System.Drawing.Point(1, 659);
            this.SellMed.Name = "SellMed";
            this.SellMed.Size = new System.Drawing.Size(359, 48);
            this.SellMed.TabIndex = 4;
            this.SellMed.Text = "Sell Medicine";
            this.SellMed.UseVisualStyleBackColor = true;
            this.SellMed.Click += new System.EventHandler(this.SellMed_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.FlatAppearance.BorderSize = 0;
            this.btnOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrders.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrders.ForeColor = System.Drawing.Color.White;
            this.btnOrders.Location = new System.Drawing.Point(0, 545);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(359, 48);
            this.btnOrders.TabIndex = 8;
            this.btnOrders.Text = "Orders";
            this.btnOrders.UseVisualStyleBackColor = true;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // Stock
            // 
            this.Stock.FlatAppearance.BorderSize = 0;
            this.Stock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Stock.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stock.ForeColor = System.Drawing.Color.White;
            this.Stock.Location = new System.Drawing.Point(-1, 363);
            this.Stock.Name = "Stock";
            this.Stock.Size = new System.Drawing.Size(359, 48);
            this.Stock.TabIndex = 5;
            this.Stock.Text = "Stock";
            this.Stock.UseVisualStyleBackColor = true;
            this.Stock.Click += new System.EventHandler(this.ViewMed_Click);
            // 
            // AddMed
            // 
            this.AddMed.FlatAppearance.BorderSize = 0;
            this.AddMed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddMed.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddMed.ForeColor = System.Drawing.Color.White;
            this.AddMed.Location = new System.Drawing.Point(0, 425);
            this.AddMed.Name = "AddMed";
            this.AddMed.Size = new System.Drawing.Size(359, 48);
            this.AddMed.TabIndex = 4;
            this.AddMed.Text = "Add Medicine";
            this.AddMed.UseVisualStyleBackColor = true;
            this.AddMed.Click += new System.EventHandler(this.AddMed_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Location = new System.Drawing.Point(0, 302);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(359, 48);
            this.btnDashboard.TabIndex = 3;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 49);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pharmacist";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(92, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.uC_P_Orders1);
            this.panel2.Controls.Add(this.uC_P_Customers1);
            this.panel2.Controls.Add(this.uC_Sell_Medicine1);
            this.panel2.Controls.Add(this.uC_P_ModifyMedicine1);
            this.panel2.Controls.Add(this.uC_P_Stock1);
            this.panel2.Controls.Add(this.uC_P_AddMedicine1);
            this.panel2.Controls.Add(this.uC_P_Dashboard1);
            this.panel2.Location = new System.Drawing.Point(358, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1083, 899);
            this.panel2.TabIndex = 2;
            // 
            // uC_P_Orders1
            // 
            this.uC_P_Orders1.BackColor = System.Drawing.Color.White;
            this.uC_P_Orders1.Location = new System.Drawing.Point(0, -1);
            this.uC_P_Orders1.Name = "uC_P_Orders1";
            this.uC_P_Orders1.Size = new System.Drawing.Size(1083, 899);
            this.uC_P_Orders1.TabIndex = 6;
            this.uC_P_Orders1.Load += new System.EventHandler(this.uC_P_Orders1_Load);
            // 
            // uC_P_Customers1
            // 
            this.uC_P_Customers1.BackColor = System.Drawing.Color.White;
            this.uC_P_Customers1.Location = new System.Drawing.Point(-4, -2);
            this.uC_P_Customers1.Name = "uC_P_Customers1";
            this.uC_P_Customers1.Size = new System.Drawing.Size(1083, 899);
            this.uC_P_Customers1.TabIndex = 5;
            // 
            // uC_Sell_Medicine1
            // 
            this.uC_Sell_Medicine1.BackColor = System.Drawing.Color.White;
            this.uC_Sell_Medicine1.Location = new System.Drawing.Point(1, -4);
            this.uC_Sell_Medicine1.Name = "uC_Sell_Medicine1";
            this.uC_Sell_Medicine1.Size = new System.Drawing.Size(1083, 899);
            this.uC_Sell_Medicine1.TabIndex = 4;
            // 
            // uC_P_ModifyMedicine1
            // 
            this.uC_P_ModifyMedicine1.BackColor = System.Drawing.Color.White;
            this.uC_P_ModifyMedicine1.Location = new System.Drawing.Point(0, 0);
            this.uC_P_ModifyMedicine1.Name = "uC_P_ModifyMedicine1";
            this.uC_P_ModifyMedicine1.Size = new System.Drawing.Size(1083, 899);
            this.uC_P_ModifyMedicine1.TabIndex = 3;
            // 
            // uC_P_Stock1
            // 
            this.uC_P_Stock1.BackColor = System.Drawing.Color.White;
            this.uC_P_Stock1.Location = new System.Drawing.Point(3, -1);
            this.uC_P_Stock1.Name = "uC_P_Stock1";
            this.uC_P_Stock1.Size = new System.Drawing.Size(1083, 899);
            this.uC_P_Stock1.TabIndex = 2;
            // 
            // uC_P_AddMedicine1
            // 
            this.uC_P_AddMedicine1.BackColor = System.Drawing.Color.White;
            this.uC_P_AddMedicine1.Location = new System.Drawing.Point(-3, 0);
            this.uC_P_AddMedicine1.Name = "uC_P_AddMedicine1";
            this.uC_P_AddMedicine1.Size = new System.Drawing.Size(1083, 899);
            this.uC_P_AddMedicine1.TabIndex = 1;
            // 
            // uC_P_Dashboard1
            // 
            this.uC_P_Dashboard1.BackColor = System.Drawing.Color.White;
            this.uC_P_Dashboard1.Location = new System.Drawing.Point(-3, 0);
            this.uC_P_Dashboard1.Name = "uC_P_Dashboard1";
            this.uC_P_Dashboard1.Size = new System.Drawing.Size(1083, 899);
            this.uC_P_Dashboard1.TabIndex = 0;
            this.uC_P_Dashboard1.Load += new System.EventHandler(this.uC_P_Dashboard1_Load);
            // 
            // gunaElipse
            // 
            this.gunaElipse.TargetControl = this.panel2;
            // 
            // gunaElipse2
            // 
            this.gunaElipse2.TargetControl = this.panel2;
            // 
            // gunaElipse3
            // 
            this.gunaElipse3.TargetControl = this.panel2;
            // 
            // gunaElipse4
            // 
            this.gunaElipse4.TargetControl = this.panel2;
            // 
            // gunaElipse5
            // 
            this.gunaElipse5.TargetControl = this.panel2;
            // 
            // gunaElipse6
            // 
            this.gunaElipse6.TargetControl = this.panel2;
            // 
            // gunaElipse7
            // 
            this.gunaElipse7.TargetControl = this.panel2;
            // 
            // Pharmacist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1440, 900);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pharmacist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pharmacist";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button SellMed;
        private System.Windows.Forms.Button Stock;
        private System.Windows.Forms.Button AddMed;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ModMed;
        private Guna.UI.WinForms.GunaElipse gunaElipse;
        private PharmacistUC.UC_P_Dashboard uC_P_Dashboard1;
        private Guna.UI.WinForms.GunaElipse gunaElipse2;
        private PharmacistUC.UC_P_AddMedicine uC_P_AddMedicine1;
        private Guna.UI.WinForms.GunaElipse gunaElipse3;
        private PharmacistUC.UC_P_Stock uC_P_Stock1;
        private Guna.UI.WinForms.GunaElipse gunaElipse4;
        private PharmacistUC.UC_P_ModifyMedicine uC_P_ModifyMedicine1;
        private Guna.UI.WinForms.GunaElipse gunaElipse5;
        private PharmacistUC.UC_Sell_Medicine uC_Sell_Medicine1;
        private Guna.UI.WinForms.GunaElipse gunaElipse6;
        private PharmacistUC.UC_P_Customers uC_P_Customers1;
        private Guna.UI.WinForms.GunaElipse gunaElipse7;
        private PharmacistUC.UC_P_Orders uC_P_Orders1;
    }
}