using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace ProjectManageSales.PL
{
    public partial class BackUp_Form : Form
    {
        SqlConnection Con = new SqlConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString);
        public BackUp_Form()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtPath.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnCreateBack_Click(object sender, EventArgs e)
        {
            if (txtPath.Text != "")
            {
                SqlCommand cmd = new SqlCommand("BackUp database ProjectManageSales to disk = @path", Con);
                SqlParameter para = new SqlParameter("@path", txtPath.Text + "\\ProjectManageSales - " + DateTime.Now.ToString().Replace('/', '-').Replace(':', '-') + ".bak");
                cmd.Parameters.Add(para);
                Con.Open();
                cmd.ExecuteNonQuery();
                Con.Close();
                MessageBox.Show("BackUp of Database is successfully created.", "BackUp", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
