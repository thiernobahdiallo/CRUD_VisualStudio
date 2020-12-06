using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DI01
{
    public partial class FormDetails : Form
    {
        Product product1;
        String idioma, disponibilidad;
        public FormDetails(Product product,String language,String availability)
        {
            InitializeComponent();
            if (product.Name.Contains("'"))
            {
                product.Name = product.Name.Replace("'", "''");
            }
            product1 = product;
            idioma = language;
            disponibilidad = availability;
        }

        private void buttonCloseDialog_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonUpdateProduct_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["AdventureWorks2016"].ConnectionString;
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                ProductDetails details = new ProductDetails();
                try
                {
                    // This is a series of a string for trying to update the database but its now working cause we need the id to select 
                    // the especififc product for updating, cause only with the name we cant do it cuase its not unique...
                    string productModel = $"exec dbo.updateProductModel '{idioma}','{disponibilidad}','{product1.Name}','{textBoxDetailName.Text}'";
                    connection.Execute(productModel);

                    string productProduct = $"exec dbo.updateProduct '{idioma}','{disponibilidad}','{product1.Name}','{textBoxDetailColor.Text}','{textBoxDetailLine.Text}','{textBoxDetailNumber.Text}',{float.Parse(textBoxDetailPrice.Text)},'{textBoxDetailSize.Text}','{textBoxDetailStyle.Text}','{textBoxClass.Text}'";
                    connection.Execute(productProduct);

                    string productDescription = $"exec dbo.updateProductDescription '{idioma}','{disponibilidad}','{details.Description}','{textBoxDetailDescription.Text}'";
                    connection.Execute(productDescription);

                    string productCategory = $"exec dbo.updateProductCategory '{idioma}','{disponibilidad}','{product1.Name}','{textBoxDetailCategory.Text}'";
                    connection.Execute(productCategory);

                    string productSubCategory = $"exec dbo.updateProductSubCategory '{idioma}','{disponibilidad}','{product1.Name}','{textBoxDetailSubCategory.Text}'";
                    connection.Execute(productSubCategory);
                }catch(Exception)
                {
                    Exceptions exception = new Exceptions("ERROR DURING UPDATE ");
                    exception.ShowDialog();
                }
                Exceptions except = new Exceptions("Update comitted ");
                except.ShowDialog();

            }
        }

        private void FormDetails_Load(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["AdventureWorks2016"].ConnectionString;
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                //The names of the variables must be the same as the database
                string sql = $"exec dbo.getProductDetail '{idioma}','{disponibilidad}','{product1.Name}'";
                ProductDetails details = connection.Query<ProductDetails>(sql).FirstOrDefault();
                textBoxDetailName.Text = details.Name;
                textBoxDetailDescription.Text = details.Description;
                textBoxDetailColor.Text = details.Color;
                textBoxDetailCategory.Text = details.Category;
                textBoxDetailSubCategory.Text = details.SubCategory;
                textBoxDetailLine.Text = details.ProductLine;
                textBoxDetailNumber.Text = details.ProductNumber;
                textBoxDetailPrice.Text = details.ListPrice;
                textBoxDetailSize.Text = details.Size;
                textBoxDetailStyle.Text = details.Style;
                textBoxClass.Text = details.Class;
            }
        }
    }
}
