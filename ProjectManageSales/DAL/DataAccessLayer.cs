using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace ProjectManageSales.DAL
{
    class DataAccessLayer
    {
        //static SqlConnection con;
        static SqlConnection con;
        

        // Static Constructor used to intialize static objects
        static DataAccessLayer()
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString);
        }
        

        // Method to Open the Connection
        public static void OpenConnection()
        {
            if(con.State != ConnectionState.Open)
            {
                con.Open();
            }
        }
      

        // Method to Close the Connection
        public static void CloseConnection()
        {
            if (con.State != ConnectionState.Closed)
            {
                con.Close();
            }
        }

        
        // Method to State the Connection
        public static string StateConnection()
        {
            return con.State.ToString();
        }


        // Method to read the data from the Database by SqlAdapter
        public static DataSet SelectDataDA(string stored_procedure,params SqlParameter[] para)
        {
            SqlDataAdapter da = new SqlDataAdapter(stored_procedure, con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            if (para != null)
                da.SelectCommand.Parameters.AddRange(para);

            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        
        // Method to read the data from the Database by SqlDataReader
        public static SqlDataReader SelectDataDR(string stored_procedure, params SqlParameter[] para)
        {
            // the DataReader is connection oriented so we shouldn't close the connection 
            // after we return the datareader also the shouldn't close the reader object
            //so we will comment the using(con)and rdr.close(). but we should close both after
            //we end using them

            //using (con)
            //{
                SqlCommand cmd = new SqlCommand(stored_procedure, con);
                cmd.CommandType = CommandType.StoredProcedure;

                if (para != null)
                {
                    foreach (SqlParameter p in para)
                        cmd.Parameters.Add(p);
                }

                OpenConnection();
                SqlDataReader rdr = cmd.ExecuteReader();
                //rdr.Close();
                return rdr;
            //}
        }

        
        // Method to insert,update,delete the data into the Database
        public static int ExecuteData(string stored_procedure, params SqlParameter[] para)
        {
            // Important Notice that when we use using at the end of its scope it not only close the connection 
            // it's remove the connection string from the con object so when we perform any SP after it (that not mean
            // close the application and open it again we mean while the app is running) it failes because the con object
            // hasn't a connection string so we use CloseConnection() instead of using(){}

            //using (con)
            //{
                SqlCommand cmd = new SqlCommand(stored_procedure, con);
                cmd.CommandType = CommandType.StoredProcedure;
                

                if (para != null)
                {
                    cmd.Parameters.AddRange(para);
                }
                OpenConnection();
                int x = cmd.ExecuteNonQuery();
                CloseConnection();
                return x;
            //}
        }

        
        // Method to insert,update,delete the data into the Database using SqlBuilder
        public static int ExecuteDataSB(string select_command,DataTable dt)
        {
            SqlDataAdapter da = new SqlDataAdapter(select_command,con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            return da.Update(dt);
        }

    }
}
