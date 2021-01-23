using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ProjectManageSales.BL
{
    class Products
    {
        // getCategory Function to get all the categories
        public static DataTable getCategory()
        {
            return DAL.DataAccessLayer.SelectDataDA("spGetCategory").Tables[0];
        }

        // insertProduct Function to add product
        public static int insertProduct(string id,string name,int qty,string price,byte[] image,int idcat)
        {
            SqlParameter[] para = new SqlParameter[6];
            para[0] = new SqlParameter("@id", id);
            para[1] = new SqlParameter("@name", name);
            para[2] = new SqlParameter("@qty", qty);
            para[3] = new SqlParameter("@price", price);
            para[4] = new SqlParameter("@Catid", idcat);
            para[5] = new SqlParameter("@image", image);

            return DAL.DataAccessLayer.ExecuteData("spAddProduct", para);
        }

        // validateProId Function to validate product id
        public static int validateProId(string id)
        {
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@id",id);
            para[1] = new SqlParameter("@state",SqlDbType.Int);
            para[1].Direction = ParameterDirection.Output;
            DAL.DataAccessLayer.SelectDataDA("spValidateProId", para);
            // state = 1 => not validate ,, 0 => validate
            return (int)para[1].Value;
        }

        // GetProduct Function to get all the products
        public static DataTable GetProduct()
        {
            return DAL.DataAccessLayer.SelectDataDA("spGetProduct").Tables[0];
        }

        // GetProductSearched Function used to get searched products
        public static DataTable GetProductSearched(string text)
        {
            SqlParameter para = new SqlParameter("@id", text);
            return DAL.DataAccessLayer.SelectDataDA("spGetProductSearched", para).Tables[0];
        }

        // DelProduct Function to delete selected records
        public static void DelProduct(string id)
        {
            SqlParameter para = new SqlParameter("@id", id);
            DAL.DataAccessLayer.ExecuteData("spDelProduct", para);
        }

        // DelMProduct Function to delete selected records using table valued parameters
        public static void DelMProduct(DataTable var)
        {
            SqlParameter para = new SqlParameter("@var", var);
            //para.SqlDbType = SqlDbType.Structured
            //para.TypeName = "dbo.ProductType";
            DAL.DataAccessLayer.ExecuteData("spDelMProduct", para);
        }

        // GetImage Function to Get the image of selected product
        public static DataTable GetImage(string id)
        {
            SqlParameter para = new SqlParameter("@id", id);
            return DAL.DataAccessLayer.SelectDataDA("spGetImage", para).Tables[0];
        }

        // UpdateProduct Function to update an product
        public static int UpdateProduct(string id, string name, int qty, string price, byte[] image, int idcat)
        {
            SqlParameter[] para = new SqlParameter[6];
            para[0] = new SqlParameter("@id", id);
            para[1] = new SqlParameter("@name", name);
            para[2] = new SqlParameter("@qty", qty);
            para[3] = new SqlParameter("@price", price);
            para[4] = new SqlParameter("@Catid", idcat);
            para[5] = new SqlParameter("@image", image);

            return DAL.DataAccessLayer.ExecuteData("spUpdateProduct", para);
        }
    }
}
