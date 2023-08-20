namespace PharmacyManagementSystem
{
    partial class Administrator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administrator));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPurchases = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button8 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCategories = new System.Windows.Forms.Button();
            this.btnSuppliers = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnUpdateOrders = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnModifyUser = new System.Windows.Forms.Button();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse2 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse3 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse4 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse5 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse6 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse7 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaCat = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse10 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse11 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.uC_UpdateOrder1 = new PharmacyManagementSystem.AdministratorUC.UC_UpdateOrder();
            this.uC_Category1 = new PharmacyManagementSystem.AdministratorUC.UC_Category();
            this.uC_Customers1 = new PharmacyManagementSystem.AdministratorUC.UC_Customers();
            this.uC_Stock1 = new PharmacyManagementSystem.AdministratorUC.UC_Stock();
            this.uC_Orders1 = new PharmacyManagementSystem.AdministratorUC.UC_Orders();
            this.uC_AddSupplier1 = new PharmacyManagementSystem.AdministratorUC.UC_AddSupplier();
            this.uC_ModifyUser1 = new PharmacyManagementSystem.AdministratorUC.UC_ModifyUser();
            this.uC_AddUser1 = new PharmacyManagementSystem.AdministratorUC.UC_AddUser();
            this.uC_Dashboard1 = new PharmacyManagementSystem.AdministratorUC.UC_Dashboard();
            this.uC_Purchases1 = new PharmacyManagementSystem.AdministratorUC.UC_Purchases();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btnPurchases);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnCategories);
            this.panel1.Controls.Add(this.btnSuppliers);
            this.panel1.Controls.Add(this.btnCustomers);
            this.panel1.Controls.Add(this.btnUpdateOrders);
            this.panel1.Controls.Add(this.btnOrders);
            this.panel1.Controls.Add(this.btnStock);
            this.panel1.Controls.Add(this.UserNameLabel);
            this.panel1.Controls.Add(this.btnAddUser);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.btnModifyUser);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 923);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnPurchases
            // 
            this.btnPurchases.FlatAppearance.BorderSize = 0;
            this.btnPurchases.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPurchases.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurchases.ForeColor = System.Drawing.Color.White;
            this.btnPurchases.Location = new System.Drawing.Point(-6, 733);
            this.btnPurchases.Name = "btnPurchases";
            this.btnPurchases.Size = new System.Drawing.Size(362, 61);
            this.btnPurchases.TabIndex = 25;
            this.btnPurchases.Text = "Purchases";
            this.btnPurchases.UseVisualStyleBackColor = true;
            this.btnPurchases.Click += new System.EventHandler(this.btnPurchases_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // button8
            // 
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.Location = new System.Drawing.Point(12, 829);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(49, 47);
            this.button8.TabIndex = 7;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(361, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1159, 1118);
            this.panel2.TabIndex = 1;
            // 
            // btnCategories
            // 
            this.btnCategories.FlatAppearance.BorderSize = 0;
            this.btnCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategories.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategories.ForeColor = System.Drawing.Color.White;
            this.btnCategories.Location = new System.Drawing.Point(-5, 670);
            this.btnCategories.Name = "btnCategories";
            this.btnCategories.Size = new System.Drawing.Size(362, 61);
            this.btnCategories.TabIndex = 22;
            this.btnCategories.Text = "Categories";
            this.btnCategories.UseVisualStyleBackColor = true;
            this.btnCategories.Click += new System.EventHandler(this.btnCategories_Click);
            // 
            // btnSuppliers
            // 
            this.btnSuppliers.FlatAppearance.BorderSize = 0;
            this.btnSuppliers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuppliers.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuppliers.ForeColor = System.Drawing.Color.White;
            this.btnSuppliers.Location = new System.Drawing.Point(-1, 601);
            this.btnSuppliers.Name = "btnSuppliers";
            this.btnSuppliers.Size = new System.Drawing.Size(362, 61);
            this.btnSuppliers.TabIndex = 20;
            this.btnSuppliers.Text = "Suppliers";
            this.btnSuppliers.UseVisualStyleBackColor = true;
            this.btnSuppliers.Click += new System.EventHandler(this.btnSuppliers_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.FlatAppearance.BorderSize = 0;
            this.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomers.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomers.ForeColor = System.Drawing.Color.White;
            this.btnCustomers.Location = new System.Drawing.Point(-1, 534);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(363, 65);
            this.btnCustomers.TabIndex = 18;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.UseVisualStyleBackColor = true;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnUpdateOrders
            // 
            this.btnUpdateOrders.FlatAppearance.BorderSize = 0;
            this.btnUpdateOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateOrders.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateOrders.ForeColor = System.Drawing.Color.White;
            this.btnUpdateOrders.Location = new System.Drawing.Point(-1, 478);
            this.btnUpdateOrders.Name = "btnUpdateOrders";
            this.btnUpdateOrders.Size = new System.Drawing.Size(365, 61);
            this.btnUpdateOrders.TabIndex = 17;
            this.btnUpdateOrders.Text = "Modify Orders";
            this.btnUpdateOrders.UseVisualStyleBackColor = true;
            this.btnUpdateOrders.Click += new System.EventHandler(this.btnUpdateOrders_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.FlatAppearance.BorderSize = 0;
            this.btnOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrders.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrders.ForeColor = System.Drawing.Color.White;
            this.btnOrders.Location = new System.Drawing.Point(-1, 418);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(361, 61);
            this.btnOrders.TabIndex = 16;
            this.btnOrders.Text = "Orders";
            this.btnOrders.UseVisualStyleBackColor = true;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // btnStock
            // 
            this.btnStock.FlatAppearance.BorderSize = 0;
            this.btnStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStock.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStock.ForeColor = System.Drawing.Color.White;
            this.btnStock.Location = new System.Drawing.Point(-1, 353);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(365, 61);
            this.btnStock.TabIndex = 15;
            this.btnStock.Text = "Stock";
            this.btnStock.UseVisualStyleBackColor = true;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameLabel.ForeColor = System.Drawing.Color.White;
            this.UserNameLabel.Location = new System.Drawing.Point(3, 82);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(359, 51);
            this.UserNameLabel.TabIndex = 14;
            this.UserNameLabel.Text = "Name";
            this.UserNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddUser
            // 
            this.btnAddUser.FlatAppearance.BorderSize = 0;
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.ForeColor = System.Drawing.Color.White;
            this.btnAddUser.Location = new System.Drawing.Point(0, 225);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(362, 61);
            this.btnAddUser.TabIndex = 11;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Location = new System.Drawing.Point(-1, 161);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(363, 61);
            this.btnDashboard.TabIndex = 10;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnModifyUser
            // 
            this.btnModifyUser.FlatAppearance.BorderSize = 0;
            this.btnModifyUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifyUser.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifyUser.ForeColor = System.Drawing.Color.White;
            this.btnModifyUser.Location = new System.Drawing.Point(0, 289);
            this.btnModifyUser.Name = "btnModifyUser";
            this.btnModifyUser.Size = new System.Drawing.Size(364, 61);
            this.btnModifyUser.TabIndex = 12;
            this.btnModifyUser.Text = "Modify User";
            this.btnModifyUser.UseVisualStyleBackColor = true;
            this.btnModifyUser.Click += new System.EventHandler(this.btnModifyUser_Click);
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this.panel2;
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
            // gunaCat
            // 
            this.gunaCat.TargetControl = this.panel2;
            // 
            // gunaElipse10
            // 
            this.gunaElipse10.TargetControl = this.panel2;
            // 
            // gunaElipse11
            // 
            this.gunaElipse11.TargetControl = this.panel2;
            // 
            // uC_UpdateOrder1
            // 
            this.uC_UpdateOrder1.BackColor = System.Drawing.Color.White;
            this.uC_UpdateOrder1.Location = new System.Drawing.Point(354, -2);
            this.uC_UpdateOrder1.Name = "uC_UpdateOrder1";
            this.uC_UpdateOrder1.Size = new System.Drawing.Size(1089, 921);
            this.uC_UpdateOrder1.TabIndex = 9;
            // 
            // uC_Category1
            // 
            this.uC_Category1.BackColor = System.Drawing.Color.White;
            this.uC_Category1.Location = new System.Drawing.Point(359, 1);
            this.uC_Category1.Name = "uC_Category1";
            this.uC_Category1.Size = new System.Drawing.Size(1089, 921);
            this.uC_Category1.TabIndex = 8;
            // 
            // uC_Customers1
            // 
            this.uC_Customers1.BackColor = System.Drawing.Color.White;
            this.uC_Customers1.Location = new System.Drawing.Point(357, -2);
            this.uC_Customers1.Name = "uC_Customers1";
            this.uC_Customers1.Size = new System.Drawing.Size(1089, 921);
            this.uC_Customers1.TabIndex = 7;
            // 
            // uC_Stock1
            // 
            this.uC_Stock1.BackColor = System.Drawing.Color.White;
            this.uC_Stock1.Location = new System.Drawing.Point(360, -4);
            this.uC_Stock1.Name = "uC_Stock1";
            this.uC_Stock1.Size = new System.Drawing.Size(1083, 899);
            this.uC_Stock1.TabIndex = 6;
            // 
            // uC_Orders1
            // 
            this.uC_Orders1.BackColor = System.Drawing.Color.White;
            this.uC_Orders1.Location = new System.Drawing.Point(357, -2);
            this.uC_Orders1.Name = "uC_Orders1";
            this.uC_Orders1.Size = new System.Drawing.Size(1089, 921);
            this.uC_Orders1.TabIndex = 5;
            this.uC_Orders1.Load += new System.EventHandler(this.uC_Orders1_Load);
            // 
            // uC_AddSupplier1
            // 
            this.uC_AddSupplier1.BackColor = System.Drawing.Color.White;
            this.uC_AddSupplier1.Location = new System.Drawing.Point(357, -2);
            this.uC_AddSupplier1.Name = "uC_AddSupplier1";
            this.uC_AddSupplier1.Size = new System.Drawing.Size(1089, 921);
            this.uC_AddSupplier1.TabIndex = 4;
            this.uC_AddSupplier1.Load += new System.EventHandler(this.uC_AddSupplier1_Load);
            // 
            // uC_ModifyUser1
            // 
            this.uC_ModifyUser1.BackColor = System.Drawing.Color.White;
            this.uC_ModifyUser1.Location = new System.Drawing.Point(357, -2);
            this.uC_ModifyUser1.Name = "uC_ModifyUser1";
            this.uC_ModifyUser1.Size = new System.Drawing.Size(1089, 921);
            this.uC_ModifyUser1.TabIndex = 3;
            this.uC_ModifyUser1.Load += new System.EventHandler(this.uC_ModifyUser1_Load);
            // 
            // uC_AddUser1
            // 
            this.uC_AddUser1.BackColor = System.Drawing.Color.White;
            this.uC_AddUser1.Location = new System.Drawing.Point(357, -2);
            this.uC_AddUser1.Name = "uC_AddUser1";
            this.uC_AddUser1.Size = new System.Drawing.Size(1160, 921);
            this.uC_AddUser1.TabIndex = 2;
            this.uC_AddUser1.Load += new System.EventHandler(this.uC_AddUser1_Load);
            // 
            // uC_Dashboard1
            // 
            this.uC_Dashboard1.BackColor = System.Drawing.Color.White;
            this.uC_Dashboard1.Location = new System.Drawing.Point(360, -2);
            this.uC_Dashboard1.Name = "uC_Dashboard1";
            this.uC_Dashboard1.Size = new System.Drawing.Size(1160, 921);
            this.uC_Dashboard1.TabIndex = 1;
            // 
            // uC_Purchases1
            // 
            this.uC_Purchases1.BackColor = System.Drawing.Color.White;
            this.uC_Purchases1.Location = new System.Drawing.Point(354, -2);
            this.uC_Purchases1.Name = "uC_Purchases1";
            this.uC_Purchases1.Size = new System.Drawing.Size(1089, 921);
            this.uC_Purchases1.TabIndex = 10;
            // 
            // Administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1420, 888);
            this.Controls.Add(this.uC_Purchases1);
            this.Controls.Add(this.uC_UpdateOrder1);
            this.Controls.Add(this.uC_Category1);
            this.Controls.Add(this.uC_Customers1);
            this.Controls.Add(this.uC_Stock1);
            this.Controls.Add(this.uC_Orders1);
            this.Controls.Add(this.uC_AddSupplier1);
            this.Controls.Add(this.uC_ModifyUser1);
            this.Controls.Add(this.uC_AddUser1);
            this.Controls.Add(this.uC_Dashboard1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Administrator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrator";
            this.Load += new System.EventHandler(this.Administrator_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCategories;
        private System.Windows.Forms.Button btnSuppliers;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnUpdateOrders;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnModifyUser;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private AdministratorUC.UC_Dashboard uC_Dashboard1;
        private Guna.UI.WinForms.GunaElipse gunaElipse2;
        private AdministratorUC.UC_AddUser uC_AddUser1;
        private Guna.UI.WinForms.GunaElipse gunaElipse3;
        private AdministratorUC.UC_ModifyUser uC_ModifyUser1;
        private Guna.UI.WinForms.GunaElipse gunaElipse4;
        private AdministratorUC.UC_AddSupplier uC_AddSupplier1;
        private Guna.UI.WinForms.GunaElipse gunaElipse5;
        private AdministratorUC.UC_Orders uC_Orders1;
        private Guna.UI.WinForms.GunaElipse gunaElipse6;
        private AdministratorUC.UC_Stock uC_Stock1;
        private Guna.UI.WinForms.GunaElipse gunaElipse7;
        private AdministratorUC.UC_Customers uC_Customers1;
        private Guna.UI.WinForms.GunaElipse gunaCat;
        private AdministratorUC.UC_Category uC_Category1;
        private Guna.UI.WinForms.GunaElipse gunaElipse10;
        private AdministratorUC.UC_UpdateOrder uC_UpdateOrder1;
        private System.Windows.Forms.Button btnPurchases;
        private Guna.UI.WinForms.GunaElipse gunaElipse11;
        private AdministratorUC.UC_Purchases uC_Purchases1;
    }
}