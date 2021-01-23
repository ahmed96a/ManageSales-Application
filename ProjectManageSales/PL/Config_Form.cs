using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectManageSales.PL
{
    public partial class Config_Form : Form
    {
        public Config_Form()
        {
            InitializeComponent();

            // Intialize Current setting in the configurtaion form

            txtServer.Text = Properties.Settings.Default.Server;
            txtDB.Text = Properties.Settings.Default.Database;
            if(Properties.Settings.Default.Mode == "SQL")
            {
                rdSql.Checked = true;
                txtUId.Text = Properties.Settings.Default.ID;
                txtPass.Text = Properties.Settings.Default.Password;
            }
            else
            {
                rdWindows.Checked = true;
                txtUId.Clear();
                txtPass.Clear();
                txtUId.ReadOnly = true;
                txtPass.ReadOnly = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Server = txtServer.Text;
            Properties.Settings.Default.Database = txtDB.Text;
            Properties.Settings.Default.Mode = rdSql.Checked == true ? "SQL" : "Windows";
            Properties.Settings.Default.ID = txtUId.Text;
            Properties.Settings.Default.Password = txtPass.Text;
        }

        private void rdSql_CheckedChanged(object sender, EventArgs e)
        {
            txtUId.ReadOnly = false;
            txtPass.ReadOnly = false;
        }

        private void rdWindows_CheckedChanged(object sender, EventArgs e)
        {
            txtUId.ReadOnly = true;
            txtPass.ReadOnly = true;
        }
    }
}
