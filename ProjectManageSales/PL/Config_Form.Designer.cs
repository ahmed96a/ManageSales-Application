namespace ProjectManageSales.PL
{
    partial class Config_Form
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
            this.txtServer = new System.Windows.Forms.TextBox();
            this.txtDB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rdWindows = new System.Windows.Forms.RadioButton();
            this.rdSql = new System.Windows.Forms.RadioButton();
            this.txtUId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server :";
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(135, 38);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(200, 24);
            this.txtServer.TabIndex = 1;
            // 
            // txtDB
            // 
            this.txtDB.Location = new System.Drawing.Point(135, 106);
            this.txtDB.Name = "txtDB";
            this.txtDB.Size = new System.Drawing.Size(200, 24);
            this.txtDB.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Database :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Login Type :";
            // 
            // rdWindows
            // 
            this.rdWindows.AutoSize = true;
            this.rdWindows.Location = new System.Drawing.Point(135, 166);
            this.rdWindows.Name = "rdWindows";
            this.rdWindows.Size = new System.Drawing.Size(174, 21);
            this.rdWindows.TabIndex = 5;
            this.rdWindows.Text = "Windows Authentication";
            this.rdWindows.UseVisualStyleBackColor = true;
            this.rdWindows.CheckedChanged += new System.EventHandler(this.rdWindows_CheckedChanged);
            // 
            // rdSql
            // 
            this.rdSql.AutoSize = true;
            this.rdSql.Checked = true;
            this.rdSql.Location = new System.Drawing.Point(135, 206);
            this.rdSql.Name = "rdSql";
            this.rdSql.Size = new System.Drawing.Size(136, 21);
            this.rdSql.TabIndex = 6;
            this.rdSql.TabStop = true;
            this.rdSql.Text = "Sql Authentication";
            this.rdSql.UseVisualStyleBackColor = true;
            this.rdSql.CheckedChanged += new System.EventHandler(this.rdSql_CheckedChanged);
            // 
            // txtUId
            // 
            this.txtUId.Location = new System.Drawing.Point(135, 257);
            this.txtUId.Name = "txtUId";
            this.txtUId.Size = new System.Drawing.Size(200, 24);
            this.txtUId.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "User ID :";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(135, 317);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(200, 24);
            this.txtPass.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Password :";
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.Location = new System.Drawing.Point(44, 397);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(101, 27);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save Settings";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.AutoSize = true;
            this.btnClose.Location = new System.Drawing.Point(194, 397);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(101, 27);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Config_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 496);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtUId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rdSql);
            this.Controls.Add(this.rdWindows);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Config_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.TextBox txtDB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdWindows;
        private System.Windows.Forms.RadioButton rdSql;
        private System.Windows.Forms.TextBox txtUId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
    }
}