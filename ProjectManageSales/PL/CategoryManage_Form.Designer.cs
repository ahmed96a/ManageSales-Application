namespace ProjectManageSales.PL
{
    partial class CategoryManage_Form
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNex = new System.Windows.Forms.Button();
            this.btnPre = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.lblPos = new System.Windows.Forms.Label();
            this.txtCatName = new System.Windows.Forms.TextBox();
            this.txtCatId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSaveAll = new System.Windows.Forms.Button();
            this.btnSaveCat = new System.Windows.Forms.Button();
            this.btnPrintCat = new System.Windows.Forms.Button();
            this.btnPrintAll = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.btnNex);
            this.groupBox1.Controls.Add(this.btnPre);
            this.groupBox1.Controls.Add(this.btnLast);
            this.groupBox1.Controls.Add(this.btnFirst);
            this.groupBox1.Controls.Add(this.lblPos);
            this.groupBox1.Controls.Add(this.txtCatName);
            this.groupBox1.Controls.Add(this.txtCatId);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(346, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 209);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Category";
            // 
            // btnNex
            // 
            this.btnNex.AutoSize = true;
            this.btnNex.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNex.Location = new System.Drawing.Point(259, 153);
            this.btnNex.Name = "btnNex";
            this.btnNex.Size = new System.Drawing.Size(33, 23);
            this.btnNex.TabIndex = 7;
            this.btnNex.Text = ">>";
            this.btnNex.UseVisualStyleBackColor = true;
            this.btnNex.Click += new System.EventHandler(this.btnNex_Click);
            // 
            // btnPre
            // 
            this.btnPre.AutoSize = true;
            this.btnPre.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPre.Location = new System.Drawing.Point(96, 153);
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(33, 23);
            this.btnPre.TabIndex = 6;
            this.btnPre.Text = "<<";
            this.btnPre.UseVisualStyleBackColor = true;
            this.btnPre.Click += new System.EventHandler(this.btnPre_Click);
            // 
            // btnLast
            // 
            this.btnLast.AutoSize = true;
            this.btnLast.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLast.Location = new System.Drawing.Point(307, 153);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(41, 23);
            this.btnLast.TabIndex = 6;
            this.btnLast.Text = ">>||";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.AutoSize = true;
            this.btnFirst.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFirst.Location = new System.Drawing.Point(39, 153);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(41, 23);
            this.btnFirst.TabIndex = 5;
            this.btnFirst.Text = "||<<";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // lblPos
            // 
            this.lblPos.AutoSize = true;
            this.lblPos.Location = new System.Drawing.Point(174, 158);
            this.lblPos.Name = "lblPos";
            this.lblPos.Size = new System.Drawing.Size(34, 13);
            this.lblPos.TabIndex = 4;
            this.lblPos.Text = "lblPos";
            // 
            // txtCatName
            // 
            this.txtCatName.Location = new System.Drawing.Point(155, 78);
            this.txtCatName.Multiline = true;
            this.txtCatName.Name = "txtCatName";
            this.txtCatName.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCatName.Size = new System.Drawing.Size(181, 43);
            this.txtCatName.TabIndex = 3;
            // 
            // txtCatId
            // 
            this.txtCatId.Location = new System.Drawing.Point(155, 33);
            this.txtCatId.Name = "txtCatId";
            this.txtCatId.ReadOnly = true;
            this.txtCatId.Size = new System.Drawing.Size(181, 20);
            this.txtCatId.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category ID :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnClose);
            this.groupBox2.Controls.Add(this.btnSaveAll);
            this.groupBox2.Controls.Add(this.btnSaveCat);
            this.groupBox2.Controls.Add(this.btnPrintCat);
            this.groupBox2.Controls.Add(this.btnPrintAll);
            this.groupBox2.Controls.Add(this.btnCancel);
            this.groupBox2.Controls.Add(this.btnDel);
            this.groupBox2.Controls.Add(this.btnModify);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.btnNew);
            this.groupBox2.Location = new System.Drawing.Point(18, 263);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(710, 114);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Options";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(325, 85);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSaveAll
            // 
            this.btnSaveAll.AutoSize = true;
            this.btnSaveAll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSaveAll.Location = new System.Drawing.Point(505, 48);
            this.btnSaveAll.Name = "btnSaveAll";
            this.btnSaveAll.Size = new System.Drawing.Size(138, 23);
            this.btnSaveAll.TabIndex = 8;
            this.btnSaveAll.Text = "Save All Category to PDF";
            this.btnSaveAll.UseVisualStyleBackColor = true;
            this.btnSaveAll.Click += new System.EventHandler(this.btnSaveAll_Click);
            // 
            // btnSaveCat
            // 
            this.btnSaveCat.AutoSize = true;
            this.btnSaveCat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSaveCat.Location = new System.Drawing.Point(347, 49);
            this.btnSaveCat.Name = "btnSaveCat";
            this.btnSaveCat.Size = new System.Drawing.Size(124, 23);
            this.btnSaveCat.TabIndex = 7;
            this.btnSaveCat.Text = "Save Category to PDF";
            this.btnSaveCat.UseVisualStyleBackColor = true;
            this.btnSaveCat.Click += new System.EventHandler(this.btnSaveCat_Click);
            // 
            // btnPrintCat
            // 
            this.btnPrintCat.AutoSize = true;
            this.btnPrintCat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPrintCat.Location = new System.Drawing.Point(194, 49);
            this.btnPrintCat.Name = "btnPrintCat";
            this.btnPrintCat.Size = new System.Drawing.Size(87, 23);
            this.btnPrintCat.TabIndex = 6;
            this.btnPrintCat.Text = "Print Category";
            this.btnPrintCat.UseVisualStyleBackColor = true;
            this.btnPrintCat.Click += new System.EventHandler(this.btnPrintCat_Click);
            // 
            // btnPrintAll
            // 
            this.btnPrintAll.AutoSize = true;
            this.btnPrintAll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPrintAll.Location = new System.Drawing.Point(56, 48);
            this.btnPrintAll.Name = "btnPrintAll";
            this.btnPrintAll.Size = new System.Drawing.Size(101, 23);
            this.btnPrintAll.TabIndex = 5;
            this.btnPrintAll.Text = "Print All Category";
            this.btnPrintAll.UseVisualStyleBackColor = true;
            this.btnPrintAll.Click += new System.EventHandler(this.btnPrintAll_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(587, 19);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(461, 19);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 3;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(313, 19);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 2;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(172, 19);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(35, 20);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(12, 24);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(324, 209);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Categories Details";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(312, 184);
            this.dataGridView1.TabIndex = 0;
            // 
            // CategoryManage_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 391);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CategoryManage_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CategoryManage_Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNex;
        private System.Windows.Forms.Button btnPre;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Label lblPos;
        private System.Windows.Forms.TextBox txtCatName;
        private System.Windows.Forms.TextBox txtCatId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSaveAll;
        private System.Windows.Forms.Button btnSaveCat;
        private System.Windows.Forms.Button btnPrintCat;
        private System.Windows.Forms.Button btnPrintAll;
        private System.Windows.Forms.Button btnClose;
    }
}