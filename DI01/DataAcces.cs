using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI01
{
    public static class DataAcces
    {
        public static List<Product> GetAllProducts(String language,String availability, int currentPage, int productsPerPage)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["AdventureWorks2016"].ConnectionString;
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                List<Product> products = new List<Product>();
                string sql = $"exec dbo.getAllProducts '{language}', '{availability}',{currentPage},{productsPerPage}";
                products = connection.Query<Product>(sql).ToList();
                return products;
            }
        }

        public static List<Product> GetProductsPrice(float minim, float max, String language,String availability, int currentPage, int productsPerPage)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["AdventureWorks2016"].ConnectionString;
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                List<Product> products = new List<Product>();

                string sql = $"exec dbo.getProductsPrice '{language}', '{availability}',{minim},{max},{currentPage},{productsPerPage}";
                products = connection.Query<Product>(sql).ToList();
                return products;
            }
        }

        public static List<Product> GetProductsCategory(String category,String language,String availability,int currentPage, int productsPerPage)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["AdventureWorks2016"].ConnectionString;
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                List<Product> products = new List<Product>();
                string sql = $"exec dbo.getCategoryProducts '{language}', '{availability}','{category}',{currentPage},{productsPerPage}";
                products = connection.Query<Product>(sql).ToList();
                return products;
            }
        }

        public static List<Product> GetProductsSubCategory(String subcategory, String language,String availability,int currentPage, int productsPerPage)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["AdventureWorks2016"].ConnectionString;
            using (IDbConnection connection = new SqlConnection(connectionString))
            {

                List<Product> products = new List<Product>();
                string sql = $"exec dbo.getSubCategoryProducts '{language}', '{availability}','{subcategory}',{currentPage},{productsPerPage}";
                products = connection.Query<Product>(sql).ToList();
                return products;
            }
        }

        public static List<Product> GetProductsSize(String size, String language,String availability, int currentPage, int productsPerPage)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["AdventureWorks2016"].ConnectionString;
            using (IDbConnection connection = new SqlConnection(connectionString))
            {

                List<Product> products = new List<Product>();
                string sql = $"exec dbo.getProductsSize '{language}', '{availability}','{size}',{currentPage},{productsPerPage}";
                products = connection.Query<Product>(sql).ToList();
                return products;
            }
        }

        public static List<Product> GetProductsProductLine(String line, String language,String availability, int currentPage, int productsPerPage)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["AdventureWorks2016"].ConnectionString;
            using (IDbConnection connection = new SqlConnection(connectionString))
            {

                List<Product> products = new List<Product>();
                string sql = $"exec dbo.getProductsLine '{language}','{availability}','{line}',{currentPage},{productsPerPage}";
                products = connection.Query<Product>(sql).ToList();
                return products;
            }
        }

        public static List<Product> GetProductsClass(String clase, String language, String availability, int currentPage, int productsPerPage)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["AdventureWorks2016"].ConnectionString;
            using (IDbConnection connection = new SqlConnection(connectionString))
            {

                List<Product> products = new List<Product>();
                string sql = $"exec dbo.getProductsClass '{language}','{availability}','{clase}',{currentPage},{productsPerPage}";
                products = connection.Query<Product>(sql).ToList();
                return products;
            }
        }

        public static List<Product> GetProductsStyle(String estilo, String language,String availability, int currentPage, int productsPerPage)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["AdventureWorks2016"].ConnectionString;
            using (IDbConnection connection = new SqlConnection(connectionString))
            {

                List<Product> products = new List<Product>();
                string sql = $"exec dbo.getProductsStyle '{language}','{availability}','{estilo}',{currentPage},{productsPerPage}";
                products = connection.Query<Product>(sql).ToList();
                return products;
            }
        }
        // WARING ASK TEACHER--- HERE HE WANTS TO SEE THE PRODUCT MODEL SEARCHED BY PRODUCTS OR THE PRODUCTS SEARCHED BY PRODUCTS?
        public static List<Product> GetProductsName(String name,String language,String availability, int currentPage, int productsPerPage)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["AdventureWorks2016"].ConnectionString;
            using (IDbConnection connection = new SqlConnection(connectionString))
            {

                List<Product> products = new List<Product>();
                string sql = $"exec dbo.getProductsName '{language}','{availability}','{name}',{currentPage},{productsPerPage}";
                products = connection.Query<Product>(sql).ToList();
                return products;
            }
        }

        public static List<Product> GetProductsModel(String model,String language,String availability, int currentPage, int productsPerPage)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["AdventureWorks2016"].ConnectionString;
            using (IDbConnection connection = new SqlConnection(connectionString))
            {

                List<Product> products = new List<Product>();
                string sql = $"exec dbo.getProductsModel '{language}','{availability}','{model}',{currentPage},{productsPerPage}";
                products = connection.Query<Product>(sql).ToList();
                return products;
            }
        }
        public static List<ProductSell> GetProductsSell(String language,String availability, int currentPage, int productsPerPage)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["AdventureWorks2016"].ConnectionString;
            using (IDbConnection connection = new SqlConnection(connectionString))
            {

                List<ProductSell> productsSells = new List<ProductSell>();
                string sql = $"exec getProductsWithSellDates '{language}','{availability}',{currentPage},{productsPerPage}";
                productsSells = connection.Query<ProductSell>(sql).ToList();
                return productsSells;
            }
        }
    }
}
