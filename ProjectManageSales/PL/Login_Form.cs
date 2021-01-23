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
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        // Get the name of the UserName to use it in the Salesman textbox in order form
        public static String UserName;

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUserName.Text) && !string.IsNullOrEmpty(txtPassword.Text))
            {
                DataSet ds = BL.Login.LoginFn(txtUserName.Text, txtPassword.Text);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    MessageBox.Show("Login Succeed", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UserName = txtUserName.Text;
                    Close();
                    Main_Form.Mainob.EnableMenu();
                    if (ds.Tables[0].Rows[0][2].ToString() != "Admin")
                    {
                        Main_Form.Mainob.usersToolStripMenuItem.Enabled = false;
                    }
                }
                else
                {
                    MessageBox.Show("Login Failed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("You Should Enter Your Credentails", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
