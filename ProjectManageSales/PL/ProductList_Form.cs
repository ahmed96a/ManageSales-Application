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
    public partial class ProductList_Form : Form
    {
        public ProductList_Form()
        {
            InitializeComponent();
            dataGridView1.DataSource = BL.Products.GetProduct();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Close();
        }
    }
}
