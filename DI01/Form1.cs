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
    public partial class Form1 : Form
    {
        String language = "en";
        String availability = "NO";
        public Form1()
        {
            InitializeComponent();
        }

        private void productListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ProductButton_Click(object sender, EventArgs e)
        {
            //productListView.Items = DataAcces.GetProduct();
            List<Product> products = new List<Product>();
            products = DataAcces.GetAllProducts(language,availability);
            productListView.Items.Clear();
            foreach (Product product in products)
            {
                productListView.Items.Add(product.ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            string connectionString = ConfigurationManager.ConnectionStrings["AdventureWorks2016"].ConnectionString;
            using (IDbConnection connection = new SqlConnection(connectionString))
            {

                // We make ListView vertically scrollable.
                productListView.Scrollable = true;
                productListView.View = View.Details;
                ColumnHeader columnHeader = new ColumnHeader();
                columnHeader.Text = "";
                columnHeader.Name = "col1";
                productListView.Columns.Add(columnHeader);
                columnHeader.Width = productListView.Width - 50;
                productListView.HeaderStyle = ColumnHeaderStyle.None;

                //String sql to deploy the categorys in a combobox
                string categorySql = "SELECT Production.ProductCategory.Name FROM Production.ProductCategory";
                List<string> categories = new List<string>();
                categories = connection.Query<string>(categorySql).ToList();
                foreach (String category in categories)
                {
                    comboBoxCategory.Items.Add(category);
                }
                //String sql to deploy the subcategries in a combobox
                string subCategorysql = "SELECT Name FROM Production.ProductSubcategory";
                List<string> subCategories = new List<string>();
                subCategories = connection.Query<string>(subCategorysql).ToList();
                foreach (String subCategory in subCategories)
                {
                    comboBoxSubCategory.Items.Add(subCategory);
                }
                //String sql to deploy the sizes in a combobox
                string sizeSql = "SELECT DISTINCT Size FROM Production.Product WHERE Size IS NOT NULL";
                List<string> size = new List<string>();
                size = connection.Query<string>(sizeSql).ToList();
                foreach (String sizes in size)
                {
                    comboBoxSize.Items.Add(sizes);
                }
                //String sql to deploy the ProductLines in a combobox
                string productLineSql = "SELECT DISTINCT ProductLine FROM Production.Product WHERE ProductLine IS NOT NULL";
                List<string> productLine = new List<string>();
                productLine = connection.Query<string>(productLineSql).ToList();
                foreach (String Lines in productLine)
                {
                    comboBoxProductLine.Items.Add(Lines);
                }
                //String sql to deploy the Classes in a combobox
                string classSql = "SELECT DISTINCT Class FROM Production.Product WHERE Class IS NOT NULL";
                List<string> classes = new List<string>();
                classes = connection.Query<string>(classSql).ToList();
                foreach (String clase in classes)
                {
                    comboBoxClass.Items.Add(clase);
                }
                //  WARNING THIS SELECT IS NOT WORKING WELL MUST ASK THE TEACHER
                string styleSql = "SELECT DISTINCT Style FROM Production.Product WHERE Style IS NOT NULL ";
                List<string> styles = new List<string>();
                styles = connection.Query<string>(styleSql).ToList();
                foreach (String estilo in styles)
                {
                    comboBoxStyle.Items.Add(estilo);
                }

            }
            
        }

        private void textBoxPriceMinim_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxPriceMax_TextChanged(object sender, EventArgs e)
        {
            //The prices are in float so we parse them and we pass the values to the class DataAcces so the class returns as the products
            try
            {
                List<Product> products = new List<Product>();
                float minim, max;
                minim = float.Parse(textBoxPriceMinim.Text);
                max = float.Parse(textBoxPriceMax.Text);
                products = DataAcces.GetProductsPrice(minim, max, language, availability);
                productListView.Items.Clear();

                foreach (Product product in products)
                {
                    productListView.Items.Add(product.ToString());
                }
            }
            catch (Exception)
            {
                Exceptions except = new Exceptions("Only numbers can be searched for Prices ");
                except.ShowDialog();
            }      
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Product> products = new List<Product>();
            products = DataAcces.GetProductsCategory(comboBoxCategory.SelectedItem.ToString(),language,availability);
            productListView.Items.Clear();

            foreach (Product categoria in products)
            {
                productListView.Items.Add(categoria.ToString());
            }
        }

        private void comboBoxSubCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Product> products = new List<Product>();
            products = DataAcces.GetProductsSubCategory(comboBoxSubCategory.SelectedItem.ToString(),language,availability);
            productListView.Items.Clear();

            foreach (Product subCategoria in products)
            {
                productListView.Items.Add(subCategoria.ToString());
            }
        }

        private void comboBoxSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Product> products = new List<Product>();
            products = DataAcces.GetProductsSize(comboBoxSize.SelectedItem.ToString(),language,availability);
            productListView.Items.Clear();

            foreach (Product size in products)
            {
                productListView.Items.Add(size.ToString());
            }
        }

        private void comboBoxProductLine_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Product> products = new List<Product>();
            products = DataAcces.GetProductsProductLine(comboBoxProductLine.SelectedItem.ToString(),language,availability);
            productListView.Items.Clear();

            foreach (Product line in products)
            {
                productListView.Items.Add(line.ToString());
            }
        }

        private void comboBoxClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Product> products = new List<Product>();
            products = DataAcces.GetProductsClass(comboBoxClass.SelectedItem.ToString(),language,availability);
            productListView.Items.Clear();

            foreach (Product clase in products)
            {
                productListView.Items.Add(clase.ToString());
            }
        }
        
        private void comboBoxStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            List<Product> products = new List<Product>();
            products = DataAcces.GetProductsStyle(comboBoxStyle.SelectedItem.ToString(),language,availability);
            productListView.Items.Clear();

            foreach (Product estilo in products)
            {
                productListView.Items.Add(estilo.ToString());
            }
        }

        private void textBoxSearchName_TextChanged(object sender, EventArgs e)
        {
            List<Product> products = new List<Product>();
            products = DataAcces.GetProductsName(textBoxSearchName.Text.ToString(),language,availability);
            productListView.Items.Clear();

            foreach (Product nombre in products)
            {
                productListView.Items.Add(nombre.ToString());
            }
        }

        private void textBoxSearchModel_TextChanged(object sender, EventArgs e)
        {
            List<Product> products = new List<Product>();
            products = DataAcces.GetProductsModel(textBoxSearchModel.Text.ToString(),language,availability);
            productListView.Items.Clear();

            foreach (Product model in products)
            {
                productListView.Items.Add(model.ToString());
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            List<ProductSell> productSells = new List<ProductSell>();
            productSells = DataAcces.GetProductsSell(language);
            productListView.Items.Clear();
            foreach (ProductSell sell in productSells)
            {
                productListView.Items.Add(sell.ToString());
            }
        }

        private void productListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string productSelected = productListView.SelectedItems[0].Text;
            string name = productSelected.Substring(0, productSelected.IndexOf("--"));
            Product product = new Product();
            product.Name = name;
            FormDetails formDetails = new FormDetails(product,language,availability);
            formDetails.ShowDialog();
        }

        private void radioButtonEnglish_CheckedChanged(object sender, EventArgs e)
        {
            language = "en";
        }

        private void radioButtonFrench_CheckedChanged(object sender, EventArgs e)
        {
            language = "fr";
        }

        private void radioButtonAvalableProducts_CheckedChanged(object sender, EventArgs e)
        {
            availability = "YES";
        }

        private void radioButtonAllProducts_CheckedChanged(object sender, EventArgs e)
        {
            availability = "NO";
        }
    }
}
