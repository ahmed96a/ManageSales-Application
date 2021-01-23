namespace ProjectManageSales.PL
{
    partial class ProductManage_Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDelMul = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPrintAllPro = new System.Windows.Forms.Button();
            this.btnPrintPro = new System.Windows.Forms.Button();
            this.btnImagePro = new System.Windows.Forms.Button();
            this.btnModifyPro = new System.Windows.Forms.Button();
            this.btnDelPro = new System.Windows.Forms.Button();
            this.btnAddPro = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.Location = new System.Drawing.Point(29, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter word to search : ";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(214, 25);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(322, 20);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(13, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(601, 285);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Products";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(589, 260);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDelMul);
            this.groupBox2.Controls.Add(this.btnClose);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.btnPrintAllPro);
            this.groupBox2.Controls.Add(this.btnPrintPro);
            this.groupBox2.Controls.Add(this.btnImagePro);
            this.groupBox2.Controls.Add(this.btnModifyPro);
            this.groupBox2.Controls.Add(this.btnDelPro);
            this.groupBox2.Controls.Add(this.btnAddPro);
            this.groupBox2.Location = new System.Drawing.Point(13, 360);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(601, 81);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Controls";
            // 
            // btnDelMul
            // 
            this.btnDelMul.AutoSize = true;
            this.btnDelMul.Location = new System.Drawing.Point(471, 49);
            this.btnDelMul.Name = "btnDelMul";
            this.btnDelMul.Size = new System.Drawing.Size(87, 23);
            this.btnDelMul.TabIndex = 8;
            this.btnDelMul.Text = "Delete Multiple";
            this.btnDelMul.UseVisualStyleBackColor = true;
            this.btnDelMul.Click += new System.EventHandler(this.btnDelMul_Click);
            // 
            // btnClose
            // 
            this.btnClose.AutoSize = true;
            this.btnClose.Location = new System.Drawing.Point(365, 49);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(76, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.Location = new System.Drawing.Point(224, 49);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(103, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save List To Excel";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPrintAllPro
            // 
            this.btnPrintAllPro.AutoSize = true;
            this.btnPrintAllPro.Location = new System.Drawing.Point(87, 49);
            this.btnPrintAllPro.Name = "btnPrintAllPro";
            this.btnPrintAllPro.Size = new System.Drawing.Size(98, 23);
            this.btnPrintAllPro.TabIndex = 5;
            this.btnPrintAllPro.Text = "Print All Products";
            this.btnPrintAllPro.UseVisualStyleBackColor = true;
            this.btnPrintAllPro.Click += new System.EventHandler(this.btnPrintAllPro_Click);
            // 
            // btnPrintPro
            // 
            this.btnPrintPro.AutoSize = true;
            this.btnPrintPro.Location = new System.Drawing.Point(504, 20);
            this.btnPrintPro.Name = "btnPrintPro";
            this.btnPrintPro.Size = new System.Drawing.Size(79, 23);
            this.btnPrintPro.TabIndex = 4;
            this.btnPrintPro.Text = "Print Product";
            this.btnPrintPro.UseVisualStyleBackColor = true;
            this.btnPrintPro.Click += new System.EventHandler(this.btnPrintPro_Click);
            // 
            // btnImagePro
            // 
            this.btnImagePro.AutoSize = true;
            this.btnImagePro.Location = new System.Drawing.Point(398, 20);
            this.btnImagePro.Name = "btnImagePro";
            this.btnImagePro.Size = new System.Drawing.Size(87, 23);
            this.btnImagePro.TabIndex = 3;
            this.btnImagePro.Text = "Product Image";
            this.btnImagePro.UseVisualStyleBackColor = true;
            this.btnImagePro.Click += new System.EventHandler(this.btnImagePro_Click);
            // 
            // btnModifyPro
            // 
            this.btnModifyPro.AutoSize = true;
            this.btnModifyPro.Location = new System.Drawing.Point(261, 19);
            this.btnModifyPro.Name = "btnModifyPro";
            this.btnModifyPro.Size = new System.Drawing.Size(89, 23);
            this.btnModifyPro.TabIndex = 2;
            this.btnModifyPro.Text = "Modify Product";
            this.btnModifyPro.UseVisualStyleBackColor = true;
            this.btnModifyPro.Click += new System.EventHandler(this.btnModifyPro_Click);
            // 
            // btnDelPro
            // 
            this.btnDelPro.AutoSize = true;
            this.btnDelPro.Location = new System.Drawing.Point(132, 19);
            this.btnDelPro.Name = "btnDelPro";
            this.btnDelPro.Size = new System.Drawing.Size(88, 23);
            this.btnDelPro.TabIndex = 1;
            this.btnDelPro.Text = "Delete Product";
            this.btnDelPro.UseVisualStyleBackColor = true;
            this.btnDelPro.Click += new System.EventHandler(this.btnDelPro_Click);
            // 
            // btnAddPro
            // 
            this.btnAddPro.AutoSize = true;
            this.btnAddPro.Location = new System.Drawing.Point(36, 20);
            this.btnAddPro.Name = "btnAddPro";
            this.btnAddPro.Size = new System.Drawing.Size(76, 23);
            this.btnAddPro.TabIndex = 0;
            this.btnAddPro.Text = "Add Product";
            this.btnAddPro.UseVisualStyleBackColor = true;
            this.btnAddPro.Click += new System.EventHandler(this.btnAddPro_Click);
            // 
            // ProductManage_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 453);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Name = "ProductManage_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductManage_Form";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnPrintAllPro;
        private System.Windows.Forms.Button btnPrintPro;
        private System.Windows.Forms.Button btnImagePro;
        private System.Windows.Forms.Button btnModifyPro;
        private System.Windows.Forms.Button btnDelPro;
        private System.Windows.Forms.Button btnAddPro;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDelMul;
    }
}