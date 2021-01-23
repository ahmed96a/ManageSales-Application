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
    public partial class OrderList_Form : Form
    {
        public OrderList_Form()
        {
            InitializeComponent();
            dataGridView1.DataSource = BL.Order.GetOrders();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Close();
        }
    }
}
