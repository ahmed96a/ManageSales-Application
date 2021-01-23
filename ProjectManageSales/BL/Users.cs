using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ProjectManageSales.BL
{
    class Users
    {
        // AddUser Function to add new user in tblEmployee DB
        public static void AddUser(string id,string pass,string usertype)
        {
            SqlParameter[] para = new SqlParameter[3];
            para[0] = new SqlParameter("@ID", id);
            para[1] = new SqlParameter("@Pass", pass);
            para[2] = new SqlParameter("@UserType", usertype);
            DAL.DataAccessLayer.ExecuteData("spAddUser", para);
        }

        // GetUsers Function to get all users
        public static DataTable GetUsers()
        {
            return DAL.DataAccessLayer.SelectDataDA("spGetUsers").Tables[0];
        }

        // SearchUsers Function to search Users
        public static DataTable SearchUsers(string criteria)
        {
            SqlParameter para = new SqlParameter("@criteria", criteria);
            return DAL.DataAccessLayer.SelectDataDA("spSearchUsers", para).Tables[0];
        }

        // UpdateUser Function to update user
        public static void UpdateUser(string id,string pass,string usertype)
        {
            SqlParameter[] para = new SqlParameter[3];
            para[0] = new SqlParameter("@ID", id);
            para[1] = new SqlParameter("@Pass", pass);
            para[2] = new SqlParameter("@UserType", usertype);
            DAL.DataAccessLayer.ExecuteData("spUpdateUser", para);
        }

        // DeleteUser Function to update user
        public static void DeleteUser(string id)
        {
            SqlParameter para = new SqlParameter("@ID",id);
            DAL.DataAccessLayer.ExecuteData("spDeleteUser", para);
        }
    }
}
