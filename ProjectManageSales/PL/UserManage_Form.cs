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
    public partial class UserManage_Form : Form
    {
        public UserManage_Form()
        {
            InitializeComponent();
            dataGridView1.DataSource = BL.Users.GetUsers();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count<1)
            {
                MessageBox.Show("You Should select User to delete");
            }
            else
            {
                BL.Users.DeleteUser(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                dataGridView1.DataSource = BL.Users.GetUsers();
                MessageBox.Show("The User is deleted Sucessfully", "User Remove", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            AddUser_Form ob = new AddUser_Form();
            ob.ShowDialog();
            dataGridView1.DataSource = BL.Users.GetUsers();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            AddUser_Form ob = new AddUser_Form();
            ob.txtID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            ob.txtPass.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            ob.txtPassCon.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            ob.comboBox1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            ob.btnAdd.Text = "Modify";
            ob.txtID.ReadOnly = true;
            ob.ShowDialog();
            dataGridView1.DataSource = BL.Users.GetUsers();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BL.Users.SearchUsers(txtSearch.Text);
        }
    }
}
