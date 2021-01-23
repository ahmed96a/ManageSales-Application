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
using System.ComponentModel.DataAnnotations;

namespace ProjectManageSales.PL
{
    public partial class CutomerManage_Form : Form
    {
        private string ResourcesPath = "";
        public CutomerManage_Form()
        {
            InitializeComponent();
            ResourcesPath = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10)) + @"\Resources\";

            // DataGridView
            dataGridView1.DataSource = BL.Customer.GetCustomers();
            if (dataGridView1.RowCount > 0)
            {
                txtId.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
                txtFName.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
                txtLName.Text = dataGridView1.Rows[0].Cells[2].Value.ToString();
                txtPhone.Text = dataGridView1.Rows[0].Cells[3].Value.ToString();
                txtEmail.Text = dataGridView1.Rows[0].Cells[4].Value.ToString();
                pictureBox1.Image = Image.FromFile(ResourcesPath + dataGridView1.Rows[0].Cells[5].Value.ToString());
            }
            lblPos.Text = "1 / " + dataGridView1.Rows.Count;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFName.Text) && !string.IsNullOrEmpty(txtLName.Text) && !string.IsNullOrEmpty(txtPhone.Text) && !string.IsNullOrEmpty(txtEmail.Text))
            {
                int index;
                // 1- get the id of the customer from the number of the rows in the datagridview
                //index = dataGridView1.RowCount + 1;

                // 2- get the id of the customer from the Database
                index = BL.Customer.GetIdCustomer() + 1;

                string img = "unknownCustomer.jpg";
                if (!string.IsNullOrEmpty(openFileDialog1.FileName))
                {
                    img = Guid.NewGuid() + openFileDialog1.SafeFileName;
                    System.IO.File.Copy(openFileDialog1.FileName, ResourcesPath + img);                    
                }                

                BL.Customer.AddCustomer(index, txtFName.Text, txtLName.Text, txtPhone.Text, txtEmail.Text, img);
                MessageBox.Show("The Customer is Added Successfully", "Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = BL.Customer.GetCustomers();
                btnNew.Enabled = true; btnModify.Enabled = true; btnDel.Enabled = true;
                btnAdd.Enabled = false; btnCancel.Enabled = false;

                dataGridView1.CurrentCell = dataGridView1[0, index-1];
            }
            else
            {
                MessageBox.Show("You Should enter The Values", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                //e.Handled = true;
            }
        }

        // that is used to validate the phone when we add anew record
        private void txtPhone_Validated(object sender, EventArgs e)
        {
            // we can perform vAlidate on the number of digits by MaxLength property we set it to 15
            // we insure that the number is unique (not used by another customer) by ValidateCusTel()
            
            // the last validate thing that we insure that what will be written in that txtbox is only numbers
            // by using KeyPress event

            if ((txtPhone.TextLength > 15 || !BL.Customer.ValidateCusTel(txtPhone.Text)) && btnNew.Enabled == false)
            {
                txtPhone.ForeColor = Color.Red;
                MessageBox.Show("Error The Tel is not valid", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhone.SelectionStart = 0;
                txtPhone.SelectionLength = txtPhone.TextLength;
                txtPhone.Focus();
            }
            else
            {
                txtPhone.ForeColor = Color.Black;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtEmail_Validated(object sender, EventArgs e)
        {
            EmailAddressAttribute x = new EmailAddressAttribute();
            if (!x.IsValid(txtEmail.Text) || !BL.Customer.ValidateCusEmail(txtEmail.Text))
            {
                txtEmail.ForeColor = Color.Red;
                MessageBox.Show("Error The Email is not valid", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.SelectionStart = 0;
                txtEmail.SelectionLength = txtEmail.TextLength;
                txtEmail.Focus();
            }
            else
            {
                txtEmail.ForeColor = Color.Black;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtFName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtLName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtPhone.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            pictureBox1.Image = Image.FromFile(ResourcesPath + dataGridView1.CurrentRow.Cells[5].Value.ToString());
            
            lblPos.Text = (dataGridView1.CurrentRow.Index + 1) + " / " + dataGridView1.Rows.Count;

            if(btnAdd.Enabled == true)
            {
                btnAdd.Enabled = false; btnCancel.Enabled = false;
                btnNew.Enabled = true; btnModify.Enabled = true; btnDel.Enabled = true;
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string img = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            BL.Customer.DelCustomer(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));            
            MessageBox.Show("The Customer is Deleted Successfully", "Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridView1.DataSource = BL.Customer.GetCustomers();

            //if (System.IO.File.Exists(ResourcesPath + img) && img != "unknownCustomer.jpg")
            //{
            //    System.IO.File.Delete(ResourcesPath + img);
            //}

            lblPos.Text = (dataGridView1.CurrentRow.Index + 1) + " / " + dataGridView1.Rows.Count;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtFName.Text = ""; txtLName.Text = ""; txtPhone.Text = ""; txtEmail.Text = "";
            pictureBox1.Image = Image.FromFile(ResourcesPath + "unknownCustomer.jpg");
            lblPos.Text = (dataGridView1.Rows.Count + 1) + " / " + (dataGridView1.Rows.Count + 1);
            dataGridView1.CurrentCell = null;

            btnAdd.Enabled = true; btnCancel.Enabled = true;
            btnNew.Enabled = false; btnModify.Enabled = false; btnDel.Enabled = false;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtId.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
            txtFName.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
            txtLName.Text = dataGridView1.Rows[0].Cells[2].Value.ToString();
            txtPhone.Text = dataGridView1.Rows[0].Cells[3].Value.ToString();
            txtEmail.Text = dataGridView1.Rows[0].Cells[4].Value.ToString();
            pictureBox1.Image = Image.FromFile(ResourcesPath + dataGridView1.Rows[0].Cells[5].Value.ToString());

            lblPos.Text = "1 / " + dataGridView1.Rows.Count;

            btnAdd.Enabled = false; btnCancel.Enabled = false;
            btnNew.Enabled = true; btnModify.Enabled = true; btnDel.Enabled = true;
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            int row = dataGridView1.CurrentRow.Index;
            string img = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            string oldImg = "";

            if (!string.IsNullOrEmpty(openFileDialog1.FileName))
            {
                var Newimg = Guid.NewGuid() + openFileDialog1.SafeFileName;
                oldImg = img;
                System.IO.File.Copy(openFileDialog1.FileName, ResourcesPath + Newimg);                
                img = Newimg;
            }

            BL.Customer.UpdateCustomer(int.Parse(txtId.Text), txtFName.Text, txtLName.Text, txtPhone.Text, txtEmail.Text, img);            
            MessageBox.Show("The Customer is Updated Successfully", "Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridView1.DataSource = BL.Customer.GetCustomers();            

            dataGridView1.CurrentCell = dataGridView1[0, row];
                        
            //if (!string.IsNullOrEmpty(oldImg) && System.IO.File.Exists(ResourcesPath + oldImg) && oldImg != "unknownCustomer.jpg")
            //{
            //    System.IO.File.Delete(ResourcesPath + oldImg);
            //}

            //dataGridView1_CellClick(this, new DataGridViewCellEventArgs(0, row));
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            // to know why when we write in the search text then delete all we write all the customers retrived from DB because
            // look to sql server DB
            dataGridView1.DataSource = BL.Customer.SearchCustomer(txtSearch.Text);
        }

        private void btnNex_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;

            if (++index < dataGridView1.Rows.Count)
            {
                lblPos.Text = (index + 1) + " / " + dataGridView1.Rows.Count;

                // add the values of the selected row in the datagridview to the textboxes
                txtId.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
                txtFName.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
                txtLName.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
                txtPhone.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
                txtEmail.Text = dataGridView1.Rows[index].Cells[4].Value.ToString();
                pictureBox1.Image = Image.FromFile(ResourcesPath + dataGridView1.Rows[0].Cells[5].Value.ToString());

                dataGridView1.CurrentCell = dataGridView1[0, index]; //to change the current row we should do this through current cell Property
                
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.Rows.Count - 1;
            lblPos.Text = (index + 1) + " / " + dataGridView1.Rows.Count;

            // add the values of the selected row in the datagridview to the textboxes
            txtId.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
            txtFName.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            txtLName.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
            txtPhone.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
            txtEmail.Text = dataGridView1.Rows[index].Cells[4].Value.ToString();
            pictureBox1.Image = Image.FromFile(ResourcesPath + dataGridView1.Rows[0].Cells[5].Value.ToString());

            dataGridView1.CurrentCell = dataGridView1[0, index]; //to change the current row we should do this through current cell Property
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            int index = 0;
            lblPos.Text = (index + 1) + " / " + dataGridView1.Rows.Count;

            // add the values of the selected row in the datagridview to the textboxes
            txtId.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
            txtFName.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            txtLName.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
            txtPhone.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
            txtEmail.Text = dataGridView1.Rows[index].Cells[4].Value.ToString();
            pictureBox1.Image = Image.FromFile(ResourcesPath + dataGridView1.Rows[0].Cells[5].Value.ToString());

            dataGridView1.CurrentCell = dataGridView1[0, index]; //to change the current row we should do this through current cell Property
                                                     //col , row
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;

            if (index-- > 0)
            {
                lblPos.Text = (index + 1) + " / " + dataGridView1.Rows.Count;

                // add the values of the selected row in the datagridview to the textboxes
                txtId.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
                txtFName.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
                txtLName.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
                txtPhone.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
                txtEmail.Text = dataGridView1.Rows[index].Cells[4].Value.ToString();
                pictureBox1.Image = Image.FromFile(ResourcesPath + dataGridView1.Rows[0].Cells[5].Value.ToString());

                dataGridView1.CurrentCell = dataGridView1[0, index]; //to change the current row we should do this through current cell Property
            }
        }
    }
}
