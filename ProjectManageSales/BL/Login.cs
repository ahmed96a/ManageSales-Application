using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ProjectManageSales.BL
{
    class Login
    {
        // Login Function For Login_Form
        public static DataSet LoginFn(string name, string pass)
        {

            SqlParameter Name = new SqlParameter("@name", name);
            SqlParameter Pass = new SqlParameter("@pass", pass);

            return DAL.DataAccessLayer.SelectDataDA("spLogin", Name, Pass);


            // Using DataReader if we return bool immediately

            //SqlDataReader rdr = DAL.DataAccessLayer.SelectDataDR("spLogin", Name, Pass);
            //bool val = rdr.HasRows;
            //rdr.Close();
            //DAL.DataAccessLayer.CloseConnection();
            //return val;
        }
    }
}
