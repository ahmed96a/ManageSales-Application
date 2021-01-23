namespace ProjectManageSales.PL
{
    partial class AddOrder_Form
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtSalesman = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOrdDesc = new System.Windows.Forms.TextBox();
            this.txtOrdId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnClr = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtCusId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAddBuy = new System.Windows.Forms.Button();
            this.btnProLoad = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.lblQty = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtProName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtProId = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modfyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNewOrd = new System.Windows.Forms.Button();
            this.btnSaveOrd = new System.Windows.Forms.Button();
            this.btnPrintOrd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.txtSalesman);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtOrdDesc);
            this.groupBox1.Controls.Add(this.txtOrdId);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 243);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order Details";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.dateTimePicker1.Location = new System.Drawing.Point(143, 163);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(163, 24);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // txtSalesman
            // 
            this.txtSalesman.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtSalesman.Location = new System.Drawing.Point(143, 204);
            this.txtSalesman.Name = "txtSalesman";
            this.txtSalesman.ReadOnly = true;
            this.txtSalesman.Size = new System.Drawing.Size(163, 24);
            this.txtSalesman.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label4.Location = new System.Drawing.Point(18, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Salesman :";
            // 
            // txtOrdDesc
            // 
            this.txtOrdDesc.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtOrdDesc.Location = new System.Drawing.Point(143, 73);
            this.txtOrdDesc.Multiline = true;
            this.txtOrdDesc.Name = "txtOrdDesc";
            this.txtOrdDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOrdDesc.Size = new System.Drawing.Size(163, 65);
            this.txtOrdDesc.TabIndex = 4;
            // 
            // txtOrdId
            // 
            this.txtOrdId.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtOrdId.Location = new System.Drawing.Point(143, 30);
            this.txtOrdId.Name = "txtOrdId";
            this.txtOrdId.ReadOnly = true;
            this.txtOrdId.Size = new System.Drawing.Size(163, 24);
            this.txtOrdId.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label3.Location = new System.Drawing.Point(18, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date of Sale :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label2.Location = new System.Drawing.Point(15, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Order Description :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.Location = new System.Drawing.Point(15, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order ID :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnClr);
            this.groupBox2.Controls.Add(this.btnLoad);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.txtTel);
            this.groupBox2.Controls.Add(this.txtLName);
            this.groupBox2.Controls.Add(this.txtFName);
            this.groupBox2.Controls.Add(this.txtCusId);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(345, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(445, 243);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Customer Informations";
            // 
            // btnClr
            // 
            this.btnClr.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnClr.Location = new System.Drawing.Point(249, 207);
            this.btnClr.Name = "btnClr";
            this.btnClr.Size = new System.Drawing.Size(87, 23);
            this.btnClr.TabIndex = 12;
            this.btnClr.Text = "Clear";
            this.btnClr.UseVisualStyleBackColor = true;
            this.btnClr.Click += new System.EventHandler(this.btnClr_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnLoad.Location = new System.Drawing.Point(84, 207);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(87, 23);
            this.btnLoad.TabIndex = 11;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(281, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 168);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtEmail.Location = new System.Drawing.Point(118, 170);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(148, 24);
            this.txtEmail.TabIndex = 9;
            // 
            // txtTel
            // 
            this.txtTel.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtTel.Location = new System.Drawing.Point(118, 133);
            this.txtTel.Name = "txtTel";
            this.txtTel.ReadOnly = true;
            this.txtTel.Size = new System.Drawing.Size(148, 24);
            this.txtTel.TabIndex = 8;
            // 
            // txtLName
            // 
            this.txtLName.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtLName.Location = new System.Drawing.Point(118, 95);
            this.txtLName.Name = "txtLName";
            this.txtLName.ReadOnly = true;
            this.txtLName.Size = new System.Drawing.Size(148, 24);
            this.txtLName.TabIndex = 7;
            // 
            // txtFName
            // 
            this.txtFName.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtFName.Location = new System.Drawing.Point(118, 60);
            this.txtFName.Name = "txtFName";
            this.txtFName.ReadOnly = true;
            this.txtFName.Size = new System.Drawing.Size(148, 24);
            this.txtFName.TabIndex = 6;
            // 
            // txtCusId
            // 
            this.txtCusId.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtCusId.Location = new System.Drawing.Point(118, 25);
            this.txtCusId.Name = "txtCusId";
            this.txtCusId.ReadOnly = true;
            this.txtCusId.Size = new System.Drawing.Size(148, 24);
            this.txtCusId.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label9.Location = new System.Drawing.Point(17, 173);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 17);
            this.label9.TabIndex = 4;
            this.label9.Text = "Email :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label8.Location = new System.Drawing.Point(17, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "Tel :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label7.Location = new System.Drawing.Point(17, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Last Name :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label6.Location = new System.Drawing.Point(17, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "First Name :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label5.Location = new System.Drawing.Point(17, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Customer ID :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAddBuy);
            this.groupBox3.Controls.Add(this.btnProLoad);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.txtTotalAmount);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.txtDiscount);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.txtAmount);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.txtQty);
            this.groupBox3.Controls.Add(this.lblQty);
            this.groupBox3.Controls.Add(this.txtPrice);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txtProName);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txtProId);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtTotal);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(12, 261);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(778, 216);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Products";
            // 
            // btnAddBuy
            // 
            this.btnAddBuy.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnAddBuy.Location = new System.Drawing.Point(333, 185);
            this.btnAddBuy.Name = "btnAddBuy";
            this.btnAddBuy.Size = new System.Drawing.Size(75, 29);
            this.btnAddBuy.TabIndex = 7;
            this.btnAddBuy.Text = "Add Buy";
            this.btnAddBuy.UseVisualStyleBackColor = true;
            this.btnAddBuy.Click += new System.EventHandler(this.btnAddBuy_Click);
            // 
            // btnProLoad
            // 
            this.btnProLoad.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnProLoad.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnProLoad.Location = new System.Drawing.Point(6, 43);
            this.btnProLoad.Name = "btnProLoad";
            this.btnProLoad.Size = new System.Drawing.Size(74, 26);
            this.btnProLoad.TabIndex = 19;
            this.btnProLoad.Text = "...";
            this.btnProLoad.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProLoad.UseVisualStyleBackColor = false;
            this.btnProLoad.Click += new System.EventHandler(this.btnProLoad_Click);
            // 
            // label18
            // 
            this.label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label18.Location = new System.Drawing.Point(6, 16);
            this.label18.Name = "label18";
            this.label18.Padding = new System.Windows.Forms.Padding(5);
            this.label18.Size = new System.Drawing.Size(75, 27);
            this.label18.TabIndex = 18;
            this.label18.Text = "Select";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalAmount.Location = new System.Drawing.Point(665, 43);
            this.txtTotalAmount.Multiline = true;
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(107, 26);
            this.txtTotalAmount.TabIndex = 17;
            this.txtTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label17
            // 
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label17.Location = new System.Drawing.Point(665, 16);
            this.label17.Name = "label17";
            this.label17.Padding = new System.Windows.Forms.Padding(5);
            this.label17.Size = new System.Drawing.Size(107, 27);
            this.label17.TabIndex = 16;
            this.label17.Text = "Total Amount";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDiscount
            // 
            this.txtDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiscount.Location = new System.Drawing.Point(564, 43);
            this.txtDiscount.MaxLength = 3;
            this.txtDiscount.Multiline = true;
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(102, 26);
            this.txtDiscount.TabIndex = 15;
            this.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDiscount.TextChanged += new System.EventHandler(this.txtDiscount_TextChanged);
            this.txtDiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiscount_KeyPress);
            // 
            // label16
            // 
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label16.Location = new System.Drawing.Point(564, 16);
            this.label16.Name = "label16";
            this.label16.Padding = new System.Windows.Forms.Padding(5);
            this.label16.Size = new System.Drawing.Size(101, 27);
            this.label16.TabIndex = 14;
            this.label16.Text = "Discount (%)";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAmount
            // 
            this.txtAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAmount.Location = new System.Drawing.Point(473, 43);
            this.txtAmount.Multiline = true;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.ReadOnly = true;
            this.txtAmount.Size = new System.Drawing.Size(91, 26);
            this.txtAmount.TabIndex = 13;
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label15.Location = new System.Drawing.Point(473, 16);
            this.label15.Name = "label15";
            this.label15.Padding = new System.Windows.Forms.Padding(5);
            this.label15.Size = new System.Drawing.Size(91, 27);
            this.label15.TabIndex = 12;
            this.label15.Text = "Amount";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtQty
            // 
            this.txtQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQty.Location = new System.Drawing.Point(353, 43);
            this.txtQty.MaxLength = 5;
            this.txtQty.Multiline = true;
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(120, 26);
            this.txtQty.TabIndex = 11;
            this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQty.TextChanged += new System.EventHandler(this.txtQty_TextChanged);
            this.txtQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQty_KeyPress);
            this.txtQty.Validated += new System.EventHandler(this.txtQty_Validated);
            // 
            // lblQty
            // 
            this.lblQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblQty.Location = new System.Drawing.Point(353, 16);
            this.lblQty.Name = "lblQty";
            this.lblQty.Padding = new System.Windows.Forms.Padding(5);
            this.lblQty.Size = new System.Drawing.Size(120, 27);
            this.lblQty.TabIndex = 10;
            this.lblQty.Text = "Quantity";
            // 
            // txtPrice
            // 
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrice.Location = new System.Drawing.Point(267, 43);
            this.txtPrice.MaxLength = 8;
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(87, 26);
            this.txtPrice.TabIndex = 9;
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // label13
            // 
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Location = new System.Drawing.Point(267, 16);
            this.label13.Name = "label13";
            this.label13.Padding = new System.Windows.Forms.Padding(5);
            this.label13.Size = new System.Drawing.Size(86, 27);
            this.label13.TabIndex = 8;
            this.label13.Text = "Price";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtProName
            // 
            this.txtProName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProName.Location = new System.Drawing.Point(152, 43);
            this.txtProName.Multiline = true;
            this.txtProName.Name = "txtProName";
            this.txtProName.ReadOnly = true;
            this.txtProName.Size = new System.Drawing.Size(116, 26);
            this.txtProName.TabIndex = 7;
            this.txtProName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Location = new System.Drawing.Point(152, 16);
            this.label12.Name = "label12";
            this.label12.Padding = new System.Windows.Forms.Padding(5);
            this.label12.Size = new System.Drawing.Size(115, 27);
            this.label12.TabIndex = 6;
            this.label12.Text = "Product Name";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtProId
            // 
            this.txtProId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProId.Location = new System.Drawing.Point(80, 43);
            this.txtProId.Multiline = true;
            this.txtProId.Name = "txtProId";
            this.txtProId.ReadOnly = true;
            this.txtProId.Size = new System.Drawing.Size(73, 26);
            this.txtProId.TabIndex = 5;
            this.txtProId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Location = new System.Drawing.Point(80, 16);
            this.label11.Name = "label11";
            this.label11.Padding = new System.Windows.Forms.Padding(5);
            this.label11.Size = new System.Drawing.Size(73, 27);
            this.label11.TabIndex = 4;
            this.label11.Text = "Product ID";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtTotal.Location = new System.Drawing.Point(88, 190);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(130, 24);
            this.txtTotal.TabIndex = 2;
            this.txtTotal.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label10.Location = new System.Drawing.Point(35, 192);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 17);
            this.label10.TabIndex = 1;
            this.label10.Text = "Total :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(7, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(765, 115);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modfyToolStripMenuItem,
            this.toolStripSeparator1,
            this.deleteRowToolStripMenuItem,
            this.deleteAllToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(134, 76);
            // 
            // modfyToolStripMenuItem
            // 
            this.modfyToolStripMenuItem.Name = "modfyToolStripMenuItem";
            this.modfyToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.modfyToolStripMenuItem.Text = "Modify";
            this.modfyToolStripMenuItem.Click += new System.EventHandler(this.modfyToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(130, 6);
            // 
            // deleteRowToolStripMenuItem
            // 
            this.deleteRowToolStripMenuItem.Name = "deleteRowToolStripMenuItem";
            this.deleteRowToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.deleteRowToolStripMenuItem.Text = "Delete Row";
            this.deleteRowToolStripMenuItem.Click += new System.EventHandler(this.deleteRowToolStripMenuItem_Click);
            // 
            // deleteAllToolStripMenuItem
            // 
            this.deleteAllToolStripMenuItem.Name = "deleteAllToolStripMenuItem";
            this.deleteAllToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.deleteAllToolStripMenuItem.Text = "Delete All";
            this.deleteAllToolStripMenuItem.Click += new System.EventHandler(this.deleteAllToolStripMenuItem_Click);
            // 
            // btnNewOrd
            // 
            this.btnNewOrd.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnNewOrd.Location = new System.Drawing.Point(144, 483);
            this.btnNewOrd.Name = "btnNewOrd";
            this.btnNewOrd.Size = new System.Drawing.Size(86, 23);
            this.btnNewOrd.TabIndex = 3;
            this.btnNewOrd.Text = "New Order";
            this.btnNewOrd.UseVisualStyleBackColor = true;
            this.btnNewOrd.Click += new System.EventHandler(this.btnNewOrd_Click);
            // 
            // btnSaveOrd
            // 
            this.btnSaveOrd.AutoSize = true;
            this.btnSaveOrd.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnSaveOrd.Location = new System.Drawing.Point(264, 483);
            this.btnSaveOrd.Name = "btnSaveOrd";
            this.btnSaveOrd.Size = new System.Drawing.Size(87, 27);
            this.btnSaveOrd.TabIndex = 4;
            this.btnSaveOrd.Text = "Save Order";
            this.btnSaveOrd.UseVisualStyleBackColor = true;
            this.btnSaveOrd.Click += new System.EventHandler(this.btnSaveOrd_Click);
            // 
            // btnPrintOrd
            // 
            this.btnPrintOrd.AutoSize = true;
            this.btnPrintOrd.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnPrintOrd.Location = new System.Drawing.Point(379, 483);
            this.btnPrintOrd.Name = "btnPrintOrd";
            this.btnPrintOrd.Size = new System.Drawing.Size(85, 27);
            this.btnPrintOrd.TabIndex = 5;
            this.btnPrintOrd.Text = "Print Order";
            this.btnPrintOrd.UseVisualStyleBackColor = true;
            this.btnPrintOrd.Click += new System.EventHandler(this.btnPrintOrd_Click);
            // 
            // btnClose
            // 
            this.btnClose.AutoSize = true;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnClose.Location = new System.Drawing.Point(501, 483);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(78, 27);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // AddOrder_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 518);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPrintOrd);
            this.Controls.Add(this.btnSaveOrd);
            this.Controls.Add(this.btnNewOrd);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddOrder_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Order";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtSalesman;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOrdDesc;
        private System.Windows.Forms.TextBox txtOrdId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TextBox txtCusId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnNewOrd;
        private System.Windows.Forms.Button btnSaveOrd;
        private System.Windows.Forms.Button btnPrintOrd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClr;
        private System.Windows.Forms.TextBox txtProId;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnProLoad;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtProName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnAddBuy;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem modfyToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem deleteRowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteAllToolStripMenuItem;
    }
}