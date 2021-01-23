using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProjectManageSales.PL
{
    public partial class AddProduct_Form : Form
    {
        // The default picture in picturebox1 is present in Resources floder

        // we use static variable to identify the when the AddProduct_Form used to add and when used to update
        // we could use the text of the btnAdd to identify how the form will work we used that way in the other forms

        public string type = "add";
        public AddProduct_Form()
        {
            InitializeComponent();
            DataTable dt = BL.Products.getCategory();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "Name_Category";
            comboBox1.ValueMember = "ID_Category";
            
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (type == "add") // btnAdd.Text == "Add"
            {
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                byte[] byteimage = ms.ToArray();

                int num; // is used in tryparse() to insure that the text in the textboxes Qty , Price is num we used other way (Key Press Event) to insure numbers in thre other forms

                if (!string.IsNullOrEmpty(txtProId.Text) && !string.IsNullOrEmpty(txtProName.Text) && int.TryParse(txtProQty.Text, out num) && int.TryParse(txtProPrice.Text, out num))
                {
                    BL.Products.insertProduct(txtProId.Text, txtProName.Text, int.Parse(txtProQty.Text), txtProPrice.Text, byteimage, (int)comboBox1.SelectedValue);
                    MessageBox.Show("The Product is Added Successfully", "Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("You Should enter valid values", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                byte[] byteimage = ms.ToArray();

                int num;

                if (!string.IsNullOrEmpty(txtProId.Text) && !string.IsNullOrEmpty(txtProName.Text) && int.TryParse(txtProQty.Text, out num) && int.TryParse(txtProPrice.Text, out num))
                {
                    BL.Products.UpdateProduct(txtProId.Text, txtProName.Text, int.Parse(txtProQty.Text), txtProPrice.Text, byteimage, (int)comboBox1.SelectedValue);
                    MessageBox.Show("The Product is Updated Successfully", "Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("You Should enter valid values", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        // we stopped the validate event in the modify of the product but we should disable the txtProId textbox it is not allowed to be modified.
        private void txtProId_Validated(object sender, EventArgs e)
        {
            if (BL.Products.validateProId(txtProId.Text) == 1 && type == "add") // btnAdd.Text == "Add"
            {
                txtProId.ForeColor = Color.Red;
                MessageBox.Show("Error The Product Id is Already Exist", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProId.Focus();
                txtProId.SelectionStart = 0;
                txtProId.SelectionLength = txtProId.TextLength;
            }
            else
            {
                txtProId.ForeColor = Color.Black;
            }
            
        }
        
    }
}
