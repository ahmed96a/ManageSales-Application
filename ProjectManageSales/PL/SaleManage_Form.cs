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
    public partial class SaleManage_Form : Form
    {
        public SaleManage_Form()
        {
            InitializeComponent();
            dataGridView1.DataSource = BL.Order.SearchSales("");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BL.Order.SearchSales(txtSearch.Text);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            RPT.RPT_Form obj = new RPT.RPT_Form();
            RPT.rpt_order rpt = new RPT.rpt_order();
            rpt.SetParameterValue("@ID_Order", int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()));
            obj.crystalReportViewer1.ReportSource = rpt;
            obj.ShowDialog();
        }
    }
}
