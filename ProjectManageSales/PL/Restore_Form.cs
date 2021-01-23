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

namespace ProjectManageSales.PL
{
    public partial class Restore_Form : Form
    {
        SqlConnection Con = new SqlConnection("data source=.;database=master;Integrated Security = SSPI");
        public Restore_Form()
        {
            InitializeComponent();

            openFileDialog1.Filter = "DB | *.bak";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtPath.Text = openFileDialog1.FileName;
            }
        }

        private void btnLoadBack_Click(object sender, EventArgs e)
        {
            if(txtPath.Text != "")
            {
                SqlCommand cmd = new SqlCommand("Alter Database ProjectManageSales set offline with rollback immediate;Restore Database ProjectManageSales from Disk = '" + txtPath.Text + "'", Con);
                Con.Open();
                cmd.ExecuteNonQuery();
                Con.Close();
                MessageBox.Show("Restore of the Database is successfully.", "BackUp", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
