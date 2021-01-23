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
    public partial class AddUser_Form : Form
    {
        public AddUser_Form()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // For Add
            if (btnAdd.Text == "Add")
            {
                if (txtID.Text == "" || txtPass.Text == "" || txtPassCon.Text == "" || comboBox1.Text == "")
                    MessageBox.Show("Enter the Values", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    BL.Users.AddUser(txtID.Text, txtPass.Text, comboBox1.Text);
                    MessageBox.Show("The User Is Added", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtID.Clear();
                    txtPass.Clear();
                    txtPassCon.Clear();
                    txtID.Focus();
                    comboBox1.Text = "";
                }
            }
            // For Modify
            else
            {
                if (txtID.Text == "" || txtPass.Text == "" || txtPassCon.Text == "" || comboBox1.Text == "")
                    MessageBox.Show("Enter the Values", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    BL.Users.UpdateUser(txtID.Text, txtPass.Text, comboBox1.Text);
                    MessageBox.Show("The User Is Updated", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void txtPassCon_Validated(object sender, EventArgs e)
        {
            if(txtPassCon.Text != txtPass.Text)
            {
                label3.ForeColor = Color.Red;
                txtPassCon.SelectionStart = 0;
                txtPassCon.SelectionLength = txtPassCon.TextLength;
                txtPassCon.Focus();
            }
            else
            {
                label3.ForeColor = Color.Black;
            }
        }
    }
}
