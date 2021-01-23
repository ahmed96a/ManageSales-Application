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
using CrystalDecisions.CrystalReports;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace ProjectManageSales.PL
{
    public partial class ProductManage_Form : Form
    {
        public ProductManage_Form()
        {
            InitializeComponent();
            dataGridView1.DataSource = BL.Products.GetProduct();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BL.Products.GetProductSearched(txtSearch.Text);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddPro_Click(object sender, EventArgs e)
        {
            AddProduct_Form ob = new AddProduct_Form();
            ob.ShowDialog();
            dataGridView1.DataSource = BL.Products.GetProduct();
        }

        private void btnDelPro_Click(object sender, EventArgs e)
        {
            BL.Products.DelProduct(dataGridView1.SelectedCells[0].Value.ToString());
            MessageBox.Show("The Product is Deleted Successfully", "Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridView1.DataSource = BL.Products.GetProduct();
        }

        private void btnModifyPro_Click(object sender, EventArgs e)
        {
            AddProduct_Form ob = new AddProduct_Form();
            
            ob.txtProId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            ob.txtProName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            ob.txtProQty.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            ob.txtProPrice.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            // the value of the combobox doesn't change beacause it was overriten by the values that we give to it in the form load event in addproduct form
            // so we solve that issue by moving that values to the form constructor
            ob.comboBox1.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString(); // to use the selectedRow property we should make the selectionMode = FullRowSelect

            byte[] img = (byte[])BL.Products.GetImage(ob.txtProId.Text).Rows[0][0];
            MemoryStream ms = new MemoryStream(img);
            ob.pictureBox1.Image = Image.FromStream(ms);

            ob.Text = "Update Product (" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + ")";
            ob.btnAdd.Text = "Update";
            ob.type = "update";
            ob.lblModify.Text = "No Modify";
            ob.ShowDialog();
            dataGridView1.DataSource = BL.Products.GetProduct();
        }

        private void btnImagePro_Click(object sender, EventArgs e)
        {
            Preview_Form ob = new Preview_Form();
            byte[] img = (byte[])BL.Products.GetImage(dataGridView1.CurrentRow.Cells[0].Value.ToString()).Rows[0][0];
            MemoryStream ms = new MemoryStream(img);
            ob.pictureBox1.Image = Image.FromStream(ms);
            ob.ShowDialog();
        }

        private void btnPrintPro_Click(object sender, EventArgs e)
        {
            RPT.rpt_single_product myReport = new RPT.rpt_single_product();
            myReport.SetParameterValue("@id", dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            RPT.RPT_Form frm = new RPT.RPT_Form();
            myReport.Refresh(); // in the Main Report view if save data in the report is checked and the report is changeable we should call Refresh()
            frm.crystalReportViewer1.ReportSource = myReport;
            frm.ShowDialog();
        }

        private void btnPrintAllPro_Click(object sender, EventArgs e)
        {
            RPT.rpt_all_products rpt = new RPT.rpt_all_products();
            RPT.RPT_Form frm = new RPT.RPT_Form();
            rpt.Refresh();
            frm.crystalReportViewer1.ReportSource = rpt;
            frm.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            RPT.rpt_all_products rpt = new RPT.rpt_all_products();


            ExportOptions export = new ExportOptions();
            export = rpt.ExportOptions;

            ExcelFormatOptions excelformat = new ExcelFormatOptions();
            export.ExportFormatOptions = excelformat;
            export.ExportFormatType = ExportFormatType.Excel;
            

            DiskFileDestinationOptions dfoptions = new DiskFileDestinationOptions();
            string ExcelReportsPath = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10)) + @"\ExcelReports\";
            dfoptions.DiskFileName = ExcelReportsPath + "\\ProductsList-" + DateTime.Now.ToString("dddd, dd MMMM yyyy") + ".xls";
            export.ExportDestinationOptions = dfoptions;
            export.ExportDestinationType = ExportDestinationType.DiskFile;

            rpt.Export();
            MessageBox.Show("Products List Exported Successfully", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelMul_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("id");

            //add the selected row's id to the dt
            for (int c = 0; c < dataGridView1.SelectedRows.Count; c++)
            {
                dt.Rows.Add(dataGridView1.SelectedRows[c].Cells[0].Value.ToString());
            }
            BL.Products.DelMProduct(dt);
            MessageBox.Show("The Selected Products is Deleted Successfully", "Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridView1.DataSource = BL.Products.GetProduct();
        }

        

    }
}
