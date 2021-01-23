using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ProjectManageSales.BL
{
    class Customer
    {
        // GetIdCustomer Function to return the last id of tblCustomer
        public static int GetIdCustomer()
        {
            SqlDataReader rdr = DAL.DataAccessLayer.SelectDataDR("spGetIdCustomer");
            rdr.Read(); // to make the cursor (pointer) point to the first row in rdr
            int index = Convert.ToInt32(rdr[0]);
            rdr.Close();
            DAL.DataAccessLayer.CloseConnection();
            return index;
        }

        // AddCustomer Function to insert A customer in the database
        public static void AddCustomer(int id,string fname,string lname,string tel,string email,string image)
        {
            SqlParameter[] para = new SqlParameter[6];
            para[0] = new SqlParameter("@id", id);
            para[1] = new SqlParameter("@fname", fname);
            para[2] = new SqlParameter("@lname", lname);
            para[3] = new SqlParameter("@tel", tel);
            para[4] = new SqlParameter("@email", email);
            para[5] = new SqlParameter("@image", image);

            DAL.DataAccessLayer.ExecuteData("spAddCustomer", para);
        }

        // ValidateCustel Function to validate Tel
        public static bool ValidateCusTel(string tel)
        {
            SqlParameter para = new SqlParameter("@tel", tel);
            DataTable dt = DAL.DataAccessLayer.SelectDataDA("spValidateCusTel", para).Tables[0];
            return (dt.Rows.Count == 0 ? true : false);
        }

        // ValidateCusEmail Function to validate Email
        public static bool ValidateCusEmail(string email)
        {
            SqlParameter para = new SqlParameter("@email", email);
            DataTable dt = DAL.DataAccessLayer.SelectDataDA("spValidateCusEmail", para).Tables[0];
            return (dt.Rows.Count == 0 ? true : false);
        }

        // GetCustomers Function to get all the Customers
        public static DataTable GetCustomers()
        {
            return DAL.DataAccessLayer.SelectDataDA("spGetCustomers").Tables[0];
        }

        // DelCustomer Function to delete selected record
        public static void DelCustomer(int id)
        {
            SqlParameter para = new SqlParameter("@id", id);
            DAL.DataAccessLayer.ExecuteData("spDelCustomer", para);
        }

        // UpdateCustomer Function to update an product
        public static int UpdateCustomer(int id, string fname, string lname, string tel, string email, string image)
        {
            SqlParameter[] para = new SqlParameter[6];
            para[0] = new SqlParameter("@id", id);
            para[1] = new SqlParameter("@fname", fname);
            para[2] = new SqlParameter("@lname", lname);
            para[3] = new SqlParameter("@tel", tel);
            para[4] = new SqlParameter("@email", email);
            para[5] = new SqlParameter("@image", image);

            return DAL.DataAccessLayer.ExecuteData("spUpdateCustomer", para);
        }

        // SearchCustomer Function to retrive Searched items in tblCustomer
        public static DataTable SearchCustomer(string id)
        {
            SqlParameter para = new SqlParameter("@id", id);
            return DAL.DataAccessLayer.SelectDataDA("spSearchCustomer", para).Tables[0];
        }
    }
}
