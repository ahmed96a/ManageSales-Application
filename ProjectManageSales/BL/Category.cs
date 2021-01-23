using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ProjectManageSales.BL
{
    class Category
    {
        // AUDCategory Function to perform Insert,Update and Delete in tblCategory based on SqlCommandBuilder
        public static int AUDCategory(DataTable dt)
        {
            return DAL.DataAccessLayer.ExecuteDataSB("select * from tblCategory", dt);
        }

        // getCategory Function to get all the categories
        public static DataTable getCategory()
        {
            return DAL.DataAccessLayer.SelectDataDA("spGetCategory").Tables[0];
        }
    }
}
