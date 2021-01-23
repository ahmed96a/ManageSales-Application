using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


// 1- DataAccessLayer waits the name of the procedure and the sqlparameters
// 2- BusinessLayer send the name of the procedure and the sqlparameters to DataAccessLayer
// 3- PersentationLayer send the values of the sqlparameters to BusinessLayer

namespace ProjectManageSales.PL
{
    public partial class Main_Form : Form
    {
        // Static Object from Main_Form to use in other forms to control Main_Form from there
        public static Main_Form Mainob;

        // كود شرح خطا
        // because frm make anew instance of Form_Main so the actions will not affect the original form AND
        // we couldn't use frm=this with static

        /*
        public static Form_Main getMainForm
        {
            get
            {
                if (frm == null)
                {
                    frm = new Form_Main();
                    frm.FormClosed += new FormClosedEventHandler(frm_FromClosed);
                }
                return frm;
            }
        }
        */

        public Main_Form()
        {
            InitializeComponent();
            Mainob = this;
        }

        // Disable Menu before login
        public void DisableMenu()
        {
            createBackUpToolStripMenuItem.Enabled = false;
            restoreBackUpToolStripMenuItem.Enabled = false;
            logOutToolStripMenuItem.Enabled = false;
            productsToolStripMenuItem.Enabled = false;
            customersToolStripMenuItem.Enabled = false;
            usersToolStripMenuItem.Enabled = false;
            configurationSettingToolStripMenuItem.Enabled = false;
        }

        // Enable Menu after login
        public void EnableMenu()
        {
            createBackUpToolStripMenuItem.Enabled = true;
            restoreBackUpToolStripMenuItem.Enabled = true;
            logOutToolStripMenuItem.Enabled = true;
            productsToolStripMenuItem.Enabled = true;
            customersToolStripMenuItem.Enabled = true;
            usersToolStripMenuItem.Enabled = true;
            configurationSettingToolStripMenuItem.Enabled = true;
        }


        private void Main_Form_Load(object sender, EventArgs e)
        {
            this.DisableMenu();
            Login_Form ob = new Login_Form();
            ob.ShowDialog();
            
        }

        private void logInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login_Form ob = new Login_Form();
            ob.ShowDialog();
        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddProduct_Form ob = new AddProduct_Form();
            ob.ShowDialog();
        }

        private void categoryManageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoryManage_Form ob = new CategoryManage_Form();
            ob.ShowDialog();
        }

        private void customerManageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.CutomerManage_Form ob = new CutomerManage_Form();
            ob.ShowDialog();
        }

        private void addOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.AddOrder_Form ob = new AddOrder_Form();
            ob.ShowDialog();
        }

        private void saleManageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaleManage_Form ob = new SaleManage_Form();
            ob.ShowDialog();
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUser_Form ob = new AddUser_Form();
            ob.ShowDialog();
        }

        private void userManageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserManage_Form ob = new UserManage_Form();
            ob.ShowDialog();
        }

        private void createBackUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackUp_Form ob = new BackUp_Form();
            ob.ShowDialog();
        }

        private void restoreBackUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Restore_Form ob = new Restore_Form();
            ob.ShowDialog();
        }

        private void configurationSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.Config_Form ob = new Config_Form();
            ob.ShowDialog();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are uou sure you want to log out?", "LogOut", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.Yes)
            {
                DisableMenu();
                MessageBox.Show("You LogOut Successfully");
            }
            else
            {
                Close();
            }
        }

        private void productManageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductManage_Form ob = new ProductManage_Form();
            ob.ShowDialog();
        }

    }
}
