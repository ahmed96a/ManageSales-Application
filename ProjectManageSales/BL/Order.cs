using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ProjectManageSales.BL
{
    class Order
    {
        // GetIdOrder Function to get the last id + 1
        public static string GetIdOrder()
        {
            return DAL.DataAccessLayer.SelectDataDA("spGetIdOrder").Tables[0].Rows[0][0].ToString();
        }

        // InsertOrder Function to insert data in tblOrders DB
        public static void InsertOrder(int id, DateTime date, int idcustomer, string description, string salesman)
        {
            SqlParameter[] para = new SqlParameter[5];
            para[0] = new SqlParameter("@id",id);
            para[1] = new SqlParameter("@date",date);
            para[2] = new SqlParameter("@idcustomer",idcustomer);
            para[3] = new SqlParameter("@description",description);
            para[4] = new SqlParameter("@salesman",salesman);
            DAL.DataAccessLayer.ExecuteData("spInsertOrder", para);
        }

        // InsertOrderDetails Function to insert data in tblOrdersDetails DB
        public static void InsertOrderDetails(int Order_Id, string Product_Id, int Qty, string Price, float Discount, string Amount, string Total_Amount)
        {
            SqlParameter[] para = new SqlParameter[7];
            para[0] = new SqlParameter("@Order_Id", Order_Id);
            para[1] = new SqlParameter("@Product_Id", Product_Id);
            para[2] = new SqlParameter("@Qty", Qty);
            para[3] = new SqlParameter("@Price", Price);
            para[4] = new SqlParameter("@Discount", Discount);
            para[5] = new SqlParameter("@Amount", Amount);
            para[6] = new SqlParameter("@Total_Amount", Total_Amount);
            DAL.DataAccessLayer.ExecuteData("spInsertOrderDetails", para);
        }

        // GetOrders Function to get all orders
        public static DataTable GetOrders()
        {
            return DAL.DataAccessLayer.SelectDataDA("spGetOrders").Tables[0];
        }

        // SearchSales Function to get searched sales
        public static DataTable SearchSales(string criteria)
        {
            SqlParameter para = new SqlParameter("@criteria",criteria);
            return DAL.DataAccessLayer.SelectDataDA("spSearchSales", para).Tables[0];
        }
    }
}
