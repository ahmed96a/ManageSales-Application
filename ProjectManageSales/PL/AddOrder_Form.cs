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
    public partial class AddOrder_Form : Form
    {
        // Datatable to be the source of datagridview1

        DataTable dt = new DataTable();
        public AddOrder_Form()
        {
            InitializeComponent();

            //Order Details GroupBox

            txtOrdId.Text = BL.Order.GetIdOrder();
            txtSalesman.Text = Login_Form.UserName;

            // Call functions

            dataGVTable();
            ResizeDGV();   // AutoSizeColumnsMode Property should be none or it will throw Exception

            
            /*Add Button Column to datagridview
            
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "Select Product";
            btn.Text = "Search";
            btn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Insert(0, btn);*/
            
        }

        // Build Columns of Dt DataTable of the GridView and assign it datagridview1 DataSource
        public void dataGVTable()
        {
            dt.Columns.Add("Product ID");
            dt.Columns.Add("Product Name");
            dt.Columns.Add("Price");
            dt.Columns.Add("Quantity");
            dt.Columns.Add("Amount");
            dt.Columns.Add("Discount");
            dt.Columns.Add("Total Amount");

            dataGridView1.DataSource = dt;
        }

        // Adjust Cell Width to be compatible with the textboxes ,,, AutoSizeColumnsMode Property should be none or it will throw Exception
        public void ResizeDGV()
        {
            dataGridView1.RowHeadersWidth = 73;
            dataGridView1.Columns[0].Width = 72;
            dataGridView1.Columns[1].Width = 115;
            dataGridView1.Columns[2].Width = 86;
            dataGridView1.Columns[3].Width = 120;
            dataGridView1.Columns[4].Width = 89;
            dataGridView1.Columns[5].Width = 102;
            dataGridView1.Columns[6].Width = 107;
        }

        // Function to clear Customer GroupBox
        private void ClearCustomer()
        {
            txtCusId.Clear();
            txtFName.Clear();
            txtLName.Clear();
            txtTel.Clear();
            txtEmail.Clear();
            pictureBox1.Image = null;
        }

        // Function to clear Products GroupBox
        private void ClearProduct()
        {
            txtProId.Clear();
            txtProName.Clear();
            txtQty.Clear();
            txtPrice.Clear();
            txtAmount.Clear();
            txtDiscount.Clear();
            lblQty.Text = "Quantity";

            dt.Clear(); // to clear the datagridview
            txtTotal.Text = "0";
        }

        // Function to clear TextBoxes
        private void ClearTextBoxes()
        {
            txtProId.Clear();
            txtProName.Clear();
            txtQty.Clear();
            txtPrice.Clear();
            txtAmount.Clear();
            txtDiscount.Clear();
            lblQty.Text = "Quantity";
        }

        // Function to Clear OrderDetails GroupBox
        private void ClearOrderDetails()
        {
            txtOrdId.Text = BL.Order.GetIdOrder();
            txtOrdDesc.Clear();
            dateTimePicker1.Value = DateTime.Now;
        }

        //Function to Clear Full Order Informations
        private void ClearFullOrder()
        {
            ClearOrderDetails();
            ClearCustomer();
            ClearProduct();
        }

        private void btnNewOrd_Click(object sender, EventArgs e)
        {
            ClearFullOrder();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            CustomerList_Form ob = new CustomerList_Form();
            ob.ShowDialog();
            if(ob.dataGridView1.SelectedRows.Count>0)
            {
                txtCusId.Text = ob.dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                txtFName.Text = ob.dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                txtLName.Text = ob.dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                txtTel.Text = ob.dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                txtEmail.Text = ob.dataGridView1.SelectedRows[0].Cells[4].Value.ToString();

                string ResourcesPath = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10)) + @"\Resources\";
                pictureBox1.Image = Image.FromFile(ResourcesPath + ob.dataGridView1.SelectedRows[0].Cells[5].Value.ToString());
            }
        }

        private void btnClr_Click(object sender, EventArgs e)
        {
            ClearCustomer();
        }

        private void btnProLoad_Click(object sender, EventArgs e)
        {
            lblQty.Text = "Quantity";
            ProductList_Form ob = new ProductList_Form();
            ob.ShowDialog();
            txtProId.Text = ob.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtProName.Text = ob.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtPrice.Text = ob.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            lblQty.Text += " - " + ob.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtQty.Focus();
        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char DecimalSeperator = Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator);
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != DecimalSeperator)
            {
                e.Handled = true;
            }
        }

        private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            char DecimalSeperator = Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator);
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != DecimalSeperator)
            {
                e.Handled = true;
            }
        }

        // Function to calculate Amount
        private void CalculateAmount()
        {
            int qty;
            double price;

            if (int.TryParse(txtQty.Text, out qty) && double.TryParse(txtPrice.Text, out price))
            {
                txtAmount.Text = (price * qty).ToString();
            }
            else
            {
                txtAmount.Text = "";
            }
        }

        // Function to calculate TotalAmount
        private void CalculateTotalAmount()
        {
            double dis, amo;
            if (double.TryParse(txtDiscount.Text, out dis) && double.TryParse(txtAmount.Text, out amo))
            {
                txtTotalAmount.Text = (amo - dis / 100 * amo).ToString();
            }
            else
            {
                txtTotalAmount.Text = txtAmount.Text;
            }
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            CalculateAmount();
            CalculateTotalAmount();
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            CalculateAmount();
            CalculateTotalAmount();
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            CalculateTotalAmount();
        }

        private void btnAddBuy_Click(object sender, EventArgs e)
        {
            if(txtAmount.Text != "" && txtProId.Text != "")
            {
                // to insure that the row that we will insert in the datagridview isn't duplicated
                int c = dataGridView1.Rows.Count;
                c -= 1;
                while (c >= 0)
                {
                    if(dataGridView1.Rows[c--].Cells[0].Value.ToString() == txtProId.Text)
                    {
                        MessageBox.Show("Error duplicated Rows", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                DataRow dr = dt.NewRow();
                dr[0] = txtProId.Text;
                dr[1] = txtProName.Text;
                dr[2] = txtPrice.Text;
                dr[3] = txtQty.Text;
                dr[4] = txtAmount.Text;
                dr[5] = txtDiscount.Text == string.Empty ? "0" : txtDiscount.Text;
                dr[6] = txtTotalAmount.Text;
                dt.Rows.Add(dr);
                txtTotal.Text = (int.Parse(txtTotal.Text) + int.Parse(txtTotalAmount.Text)).ToString();
                ClearTextBoxes();
            }
            else
            {
                MessageBox.Show("Error Enter Values", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtProId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtProName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtPrice.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtQty.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtAmount.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtDiscount.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtTotalAmount.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtTotal.Text = (double.Parse(txtTotal.Text) - double.Parse(txtTotalAmount.Text)).ToString();
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);

        }

        private void modfyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                txtProId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtProName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtPrice.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtQty.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtAmount.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                txtDiscount.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                txtTotalAmount.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                txtTotal.Text = (double.Parse(txtTotal.Text) - double.Parse(txtTotalAmount.Text)).ToString();

                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            }
        }

        private void deleteRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtTotal.Text = (double.Parse(txtTotal.Text) - double.Parse(dataGridView1.CurrentRow.Cells[6].Value.ToString())).ToString();
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
        }

        private void deleteAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int c = 0; c < dataGridView1.Rows.Count; c++)
            {
                dataGridView1.Rows.RemoveAt(c);
            }
            txtTotal.Text = "0";
        }

        private void btnSaveOrd_Click(object sender, EventArgs e)
        {
            // Check the exsitence of the all informaions

            if (txtCusId.Text == string.Empty || dataGridView1.Rows.Count < 1 || txtOrdId.Text == string.Empty)
            {
                MessageBox.Show("You should enter values", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {

                BL.Order.InsertOrder(int.Parse(txtOrdId.Text), dateTimePicker1.Value, int.Parse(txtCusId.Text), txtOrdDesc.Text, txtSalesman.Text);

                for (int c = 0; c < dataGridView1.Rows.Count; c++)
                {
                    int ordid = int.Parse(txtOrdId.Text);
                    string proid = dataGridView1.Rows[c].Cells[0].Value.ToString();
                    int qty = int.Parse(dataGridView1.Rows[c].Cells[3].Value.ToString());
                    string price = dataGridView1.Rows[c].Cells[2].Value.ToString();
                    float discount = float.Parse(dataGridView1.Rows[c].Cells[5].Value.ToString());
                    string amount = dataGridView1.Rows[c].Cells[4].Value.ToString();
                    string totalamount = dataGridView1.Rows[c].Cells[6].Value.ToString();

                    BL.Order.InsertOrderDetails(ordid, proid, qty, price, discount, amount, totalamount);
                }

                MessageBox.Show("Order is Added", "Order", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear All Values
                ClearFullOrder();  
            }
        }

        private void txtQty_Validated(object sender, EventArgs e)
        {
            // to get the Qty Number
            string txt = lblQty.Text;
            txt = txt.Substring(txt.IndexOf("-") + 2);
            if (!string.IsNullOrEmpty(txtQty.Text) && int.Parse(txtQty.Text) > int.Parse(txt))
            {
                MessageBox.Show("Qty Error", "Quantity", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtQty.SelectionStart = 0;
                txtQty.SelectionLength = txtQty.TextLength;
                txtQty.Focus();
            }
        }

        private void btnPrintOrd_Click(object sender, EventArgs e)
        {
            OrderList_Form ob = new OrderList_Form();
            ob.ShowDialog();
            if(ob.dataGridView1.SelectedRows.Count>0)
            {
                RPT.RPT_Form obj = new RPT.RPT_Form();
                RPT.rpt_order rpt= new RPT.rpt_order();
                rpt.SetParameterValue("@ID_Order", int.Parse(ob.dataGridView1.SelectedRows[0].Cells[0].Value.ToString()));
                obj.crystalReportViewer1.ReportSource = rpt;
                obj.ShowDialog();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}