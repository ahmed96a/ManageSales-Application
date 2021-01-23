namespace ProjectManageSales.PL
{
    partial class BackUp_Form
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
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnCreateBack = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Path to save BackUp :";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(164, 58);
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(338, 24);
            this.txtPath.TabIndex = 1;
            // 
            // btnLoad
            // 
            this.btnLoad.AutoSize = true;
            this.btnLoad.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLoad.Location = new System.Drawing.Point(517, 58);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(30, 27);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "...";
            this.btnLoad.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnCreateBack
            // 
            this.btnCreateBack.AutoSize = true;
            this.btnCreateBack.Location = new System.Drawing.Point(139, 139);
            this.btnCreateBack.Name = "btnCreateBack";
            this.btnCreateBack.Size = new System.Drawing.Size(108, 27);
            this.btnCreateBack.TabIndex = 3;
            this.btnCreateBack.Text = "Create BackUp";
            this.btnCreateBack.UseVisualStyleBackColor = true;
            this.btnCreateBack.Click += new System.EventHandler(this.btnCreateBack_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(326, 139);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // BackUp_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 192);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCreateBack);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "BackUp_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create BackUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnCreateBack;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}