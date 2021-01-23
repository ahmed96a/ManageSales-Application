using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace ProjectManageSales.PL
{
    public partial class CategoryManage_Form : Form
    {
        // BindingManagerBase is the same as CurrencyManager
        // the difference between them 1-cm.AddNew() it add a new row to underlyinglist so dt.count = 5 , cm.count = 5
        // b.AddNew() it add a new row to underlyinglist but it ddidn't commit in the datasource until we call b.EndCurrentEdit() or anew list operation is made
        //so dt.count = 4 , cm.count = 5

        CurrencyManager cm;
        DataTable dt;
        public CategoryManage_Form()
        {
            InitializeComponent();
            
            dt = BL.Category.getCategory();
            txtCatId.DataBindings.Add("Text",dt,"ID_Category");
            txtCatName.DataBindings.Add("Text", dt, dt.Columns[1].ToString()); // will get the name of the column
            cm = (CurrencyManager)BindingContext[dt];
            lblPos.Text = cm.Position + 1 + "/" + cm.Count;
            dataGridView1.DataSource = dt;
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            cm.Position = cm.Count - 1;
            lblPos.Text = (cm.Position + 1) +"/" + cm.Count;
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            cm.Position = 0;
            lblPos.Text = (cm.Position + 1) + "/" + cm.Count;
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            cm.Position -= 1;
            lblPos.Text = (cm.Position + 1) + "/" + cm.Count;
        }

        private void btnNex_Click(object sender, EventArgs e)
        {
            cm.Position += 1;
            lblPos.Text = (cm.Position + 1) + "/" + cm.Count; 
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            // some important notes
            // 1- when we use cm.AddNew() anew row is inserted and that will be shown in the datagridview so
            // cm.count will be increase by 1;
            // 2- cm.EndCurrentEdit(); // the category is modified to the source dt
            // the cm.EndCurrentEdit() is used to perform the add or the modify in the source which in that case dt


            int t = cm.Count;
            int h = cm.Position;
            cm.AddNew();
            cm.Position = cm.Count-1;
            lblPos.Text = (cm.Position + 1) + "/" + cm.Count;
            btnNew.Enabled = false;
            btnDel.Enabled = false;
            btnModify.Enabled = false;
            btnAdd.Enabled = true;
            btnCancel.Enabled = true;

            // we want the index of the last row in the dt (source) after we call cm.AddNew() the count of
            // cm will be increased by 1 and the source of cm which is dt also will be increased so we subtract by 2
            // and at that point is the difference between BindingManagerBase and CurrencyManager

            int ind = Convert.ToInt32(dt.Rows[dt.Rows.Count - 2][0]) + 1; // - 2 it will be - 1 if we use b {look up}
            txtCatId.Text = ind.ToString();
            txtCatName.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtCatName.Text))
            {
                cm.EndCurrentEdit(); // the new category is added to the source dt // if we comment that line the add will not be performed
                BL.Category.AUDCategory(dt);
                MessageBox.Show("The Product is Added Successfully", "Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnNew.Enabled = true; btnAdd.Enabled = false; btnCancel.Enabled = false;
                btnDel.Enabled = true; btnModify.Enabled = true;
            }
            else
            {
                MessageBox.Show("You Should enter valid values", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            cm.EndCurrentEdit(); // the category is modified to the source dt
            BL.Category.AUDCategory(dt);
            MessageBox.Show("The Product is Updated Successfully", "Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cm.CancelCurrentEdit();
            cm.RemoveAt(cm.Position);
            lblPos.Text = (cm.Position + 1) + "/" + cm.Count;
            MessageBox.Show("Adding New Item Cancelled");
            btnNew.Enabled = true; btnAdd.Enabled = false; btnCancel.Enabled = false;
            btnDel.Enabled = true; btnModify.Enabled = true;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            cm.RemoveAt(cm.Position); // when we remove row in the cm that also reflected in the source dt
            BL.Category.AUDCategory(dt);
            lblPos.Text = (cm.Position + 1) + "/" + cm.Count;
            MessageBox.Show("The Product is Deleted Successfully", "Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPrintAll_Click(object sender, EventArgs e)
        {
            RPT.rpt_all_categories rpt = new RPT.rpt_all_categories();
            RPT.RPT_Form frm = new RPT.RPT_Form();
            rpt.Refresh();
            frm.crystalReportViewer1.ReportSource = rpt;
            frm.ShowDialog();
        }

        private void btnPrintCat_Click(object sender, EventArgs e)
        {
            // here print the category with its product in that report we use save data to report checked and also we didn't call Refresh()
            // although the report is changeable but he work will because the sub report that we use in it is call Refresh()

            RPT.rpt_single_category rpt = new RPT.rpt_single_category();
            RPT.RPT_Form frm = new RPT.RPT_Form();
            rpt.SetParameterValue("@id", Convert.ToInt32(txtCatId.Text));
            frm.Refresh();
            frm.crystalReportViewer1.ReportSource = rpt;
            frm.ShowDialog();
        }

        private void btnSaveCat_Click(object sender, EventArgs e)
        {
            RPT.rpt_single_category rpt = new RPT.rpt_single_category();
            rpt.SetParameterValue("@id", Int32.Parse(txtCatId.Text));
            ExportOptions export = new ExportOptions();
            
            export = rpt.ExportOptions;

            DiskFileDestinationOptions dfoptions = new DiskFileDestinationOptions();
            string PdfReportsPath = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10)) + @"\PdfReports\";
            dfoptions.DiskFileName = PdfReportsPath + "CategoryList-" + DateTime.Now.ToString("dddd, dd MMMM yyyy") + ".pdf";
            export.ExportDestinationOptions = dfoptions;
            export.ExportDestinationType = ExportDestinationType.DiskFile;

            PdfFormatOptions pdf = new PdfFormatOptions();
            export.ExportFormatOptions = pdf;
            export.ExportFormatType = ExportFormatType.PortableDocFormat;

            rpt.Export();
            MessageBox.Show("Category Product List Exported Successfully", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSaveAll_Click(object sender, EventArgs e)
        {
            RPT.rpt_all_categories rpt = new RPT.rpt_all_categories();
            ExportOptions export = new ExportOptions();

            export = rpt.ExportOptions;

            DiskFileDestinationOptions dfoptions = new DiskFileDestinationOptions();
            string PdfReportsPath = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10)) + @"\PdfReports\";
            dfoptions.DiskFileName = PdfReportsPath + "AllCategoryList-" + DateTime.Now.ToString("dddd, dd MMMM yyyy") + ".pdf";            
            export.ExportDestinationOptions = dfoptions;
            export.ExportDestinationType = ExportDestinationType.DiskFile;

            PdfFormatOptions pdf = new PdfFormatOptions();
            export.ExportFormatOptions = pdf;
            export.ExportFormatType = ExportFormatType.PortableDocFormat;
            rpt.Refresh();
            rpt.Export();
            MessageBox.Show("All Category List Exported Successfully", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}