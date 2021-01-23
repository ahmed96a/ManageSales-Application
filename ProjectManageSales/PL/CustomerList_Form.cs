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
    public partial class CustomerList_Form : Form
    {
        public CustomerList_Form()
        {
            InitializeComponent();
            dataGridView1.DataSource = BL.Customer.GetCustomers();
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
