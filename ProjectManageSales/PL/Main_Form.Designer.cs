namespace ProjectManageSales.PL
{
    partial class Main_Form
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createBackUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restoreBackUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurationSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productManageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.categoryManageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerManageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.addOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saleManageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userManageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.productsToolStripMenuItem,
            this.customersToolStripMenuItem,
            this.usersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(590, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logInToolStripMenuItem,
            this.createBackUpToolStripMenuItem,
            this.restoreBackUpToolStripMenuItem,
            this.configurationSettingToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // logInToolStripMenuItem
            // 
            this.logInToolStripMenuItem.Name = "logInToolStripMenuItem";
            this.logInToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.logInToolStripMenuItem.Text = "Log in";
            this.logInToolStripMenuItem.Click += new System.EventHandler(this.logInToolStripMenuItem_Click);
            // 
            // createBackUpToolStripMenuItem
            // 
            this.createBackUpToolStripMenuItem.Name = "createBackUpToolStripMenuItem";
            this.createBackUpToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.createBackUpToolStripMenuItem.Text = "Create BackUp";
            this.createBackUpToolStripMenuItem.Click += new System.EventHandler(this.createBackUpToolStripMenuItem_Click);
            // 
            // restoreBackUpToolStripMenuItem
            // 
            this.restoreBackUpToolStripMenuItem.Name = "restoreBackUpToolStripMenuItem";
            this.restoreBackUpToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.restoreBackUpToolStripMenuItem.Text = "Restore BackUp";
            this.restoreBackUpToolStripMenuItem.Click += new System.EventHandler(this.restoreBackUpToolStripMenuItem_Click);
            // 
            // configurationSettingToolStripMenuItem
            // 
            this.configurationSettingToolStripMenuItem.Name = "configurationSettingToolStripMenuItem";
            this.configurationSettingToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.configurationSettingToolStripMenuItem.Text = "Configuration Setting";
            this.configurationSettingToolStripMenuItem.Click += new System.EventHandler(this.configurationSettingToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.logOutToolStripMenuItem.Text = "Log out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addProductToolStripMenuItem,
            this.productManageToolStripMenuItem,
            this.toolStripSeparator1,
            this.categoryManageToolStripMenuItem});
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.productsToolStripMenuItem.Text = "Products";
            // 
            // addProductToolStripMenuItem
            // 
            this.addProductToolStripMenuItem.Name = "addProductToolStripMenuItem";
            this.addProductToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.addProductToolStripMenuItem.Text = "Add Product";
            this.addProductToolStripMenuItem.Click += new System.EventHandler(this.addProductToolStripMenuItem_Click);
            // 
            // productManageToolStripMenuItem
            // 
            this.productManageToolStripMenuItem.Name = "productManageToolStripMenuItem";
            this.productManageToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.productManageToolStripMenuItem.Text = "Product Manage";
            this.productManageToolStripMenuItem.Click += new System.EventHandler(this.productManageToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(165, 6);
            // 
            // categoryManageToolStripMenuItem
            // 
            this.categoryManageToolStripMenuItem.Name = "categoryManageToolStripMenuItem";
            this.categoryManageToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.categoryManageToolStripMenuItem.Text = "Category Manage";
            this.categoryManageToolStripMenuItem.Click += new System.EventHandler(this.categoryManageToolStripMenuItem_Click);
            // 
            // customersToolStripMenuItem
            // 
            this.customersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerManageToolStripMenuItem,
            this.toolStripSeparator2,
            this.addOrderToolStripMenuItem,
            this.saleManageToolStripMenuItem});
            this.customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            this.customersToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.customersToolStripMenuItem.Text = "Customers";
            // 
            // customerManageToolStripMenuItem
            // 
            this.customerManageToolStripMenuItem.Name = "customerManageToolStripMenuItem";
            this.customerManageToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.customerManageToolStripMenuItem.Text = "Customer Manage";
            this.customerManageToolStripMenuItem.Click += new System.EventHandler(this.customerManageToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(169, 6);
            // 
            // addOrderToolStripMenuItem
            // 
            this.addOrderToolStripMenuItem.Name = "addOrderToolStripMenuItem";
            this.addOrderToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.addOrderToolStripMenuItem.Text = "Add Order";
            this.addOrderToolStripMenuItem.Click += new System.EventHandler(this.addOrderToolStripMenuItem_Click);
            // 
            // saleManageToolStripMenuItem
            // 
            this.saleManageToolStripMenuItem.Name = "saleManageToolStripMenuItem";
            this.saleManageToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.saleManageToolStripMenuItem.Text = "Sale Manage";
            this.saleManageToolStripMenuItem.Click += new System.EventHandler(this.saleManageToolStripMenuItem_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUserToolStripMenuItem,
            this.userManageToolStripMenuItem});
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.usersToolStripMenuItem.Text = "Users";
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addUserToolStripMenuItem.Text = "Add User";
            this.addUserToolStripMenuItem.Click += new System.EventHandler(this.addUserToolStripMenuItem_Click);
            // 
            // userManageToolStripMenuItem
            // 
            this.userManageToolStripMenuItem.Name = "userManageToolStripMenuItem";
            this.userManageToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.userManageToolStripMenuItem.Text = "User Manage";
            this.userManageToolStripMenuItem.Click += new System.EventHandler(this.userManageToolStripMenuItem_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(590, 409);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createBackUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restoreBackUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productManageToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem categoryManageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerManageToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem addOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saleManageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userManageToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurationSettingToolStripMenuItem;

    }
}