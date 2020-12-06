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
        int productsPerPage;
        int numberOfPages;
        int currentPage = 0;
        int opcion = 0;
        public Form1()
        {
            InitializeComponent();
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

                // Initializes labels
                labelProductsFound.Text = "0 Products found";
                labelOfPages.Text = "0 pages";
                comboBoxPages.Items.Add("15");
                comboBoxPages.Items.Add("20");
                comboBoxPages.Items.Add("40");
                comboBoxPages.Text = "15";
                buttonNextPage.Enabled = false;
                buttonPrevPage.Enabled = false;
                
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
        private void ProductButton_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["AdventureWorks2016"].ConnectionString;
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                string sql = $"exec dbo.getAllProductsNumber '{language}', '{availability}'";
                int totalNumbersOfProductsPerCategory = connection.Query<int>(sql).FirstOrDefault();
                numberOfPages = totalNumbersOfProductsPerCategory / int.Parse(comboBoxPages.Text) + 1;
                labelProductsFound.Text = totalNumbersOfProductsPerCategory.ToString() + " products found";
                currentPage = 0;
                if (totalNumbersOfProductsPerCategory <= int.Parse(comboBoxPages.Text))
                {
                    buttonPrevPage.Enabled = false;
                    buttonNextPage.Enabled = false;
                    opcion = 11;
                    UpdateProductsListView();
                }
                else
                {
                    buttonPrevPage.Enabled = false;
                    buttonNextPage.Enabled = true;
                    opcion = 11;
                    UpdateProductsListView();
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
                string connectionString = ConfigurationManager.ConnectionStrings["AdventureWorks2016"].ConnectionString;
                using (IDbConnection connection = new SqlConnection(connectionString))
                {

                    string sql = $"exec dbo.getProductsPriceNumber '{language}', '{availability}',{float.Parse(textBoxPriceMinim.Text)},{float.Parse(textBoxPriceMax.Text)}";
                    int totalNumbersOfProductsPerCategory = connection.Query<int>(sql).FirstOrDefault();
                    numberOfPages = totalNumbersOfProductsPerCategory / int.Parse(comboBoxPages.Text) + 1;
                    labelProductsFound.Text = totalNumbersOfProductsPerCategory.ToString() + " products found";
                    currentPage = 0;
                    if (totalNumbersOfProductsPerCategory <= int.Parse(comboBoxPages.Text))
                    {
                        buttonPrevPage.Enabled = false;
                        buttonNextPage.Enabled = false;
                        opcion = 9;
                        UpdateProductsListView();
                    }
                    else
                    {
                        buttonPrevPage.Enabled = false;
                        buttonNextPage.Enabled = true;
                        opcion = 9;
                        UpdateProductsListView();
                    }

                }
            }
            catch (Exception)
            {
                Exceptions except = new Exceptions("Only numbers can be searched for Prices ");
                except.ShowDialog();
            }
            
        }
        // ------------- aQUI
        private void UpdateProductsListView()
        {
            List<Product> products = new List<Product>();
            switch (opcion)
            {
                
                case 1:

                    labelOfPages.Text = (currentPage + 1) + "of" + numberOfPages + " pages";
                    
                    products = DataAcces.GetProductsCategory(comboBoxCategory.SelectedItem.ToString(), language, availability, currentPage, productsPerPage);
                    productListView.Items.Clear();
                    foreach (Product categoria in products)
                    {
                        productListView.Items.Add(categoria.ToString());
                    }
                    break;
                case 2:
                    labelOfPages.Text = (currentPage + 1) + "of" + numberOfPages + " pages";
                    products = DataAcces.GetProductsSubCategory(comboBoxSubCategory.SelectedItem.ToString(), language, availability, currentPage, productsPerPage);
                    productListView.Items.Clear();

                    foreach (Product subCategoria in products)
                    {
                        productListView.Items.Add(subCategoria.ToString());
                    }
                    break;
                case 3:
                    labelOfPages.Text = (currentPage + 1) + "of" + numberOfPages + " pages";
                    products = DataAcces.GetProductsSize(comboBoxSize.SelectedItem.ToString(), language, availability, currentPage, productsPerPage);
                    productListView.Items.Clear();

                    foreach (Product size in products)
                    {
                        productListView.Items.Add(size.ToString());
                    }
                    break;
                case 4:
                    labelOfPages.Text = (currentPage + 1) + "of" + numberOfPages + " pages";
                    products = DataAcces.GetProductsProductLine(comboBoxProductLine.SelectedItem.ToString(), language, availability, currentPage, productsPerPage);
                    productListView.Items.Clear();

                    foreach (Product line in products)
                    {
                        productListView.Items.Add(line.ToString());
                    }
                    break; 

                case 5:
                    labelOfPages.Text = (currentPage + 1) + "of" + numberOfPages + " pages";
                    products = DataAcces.GetProductsClass(comboBoxClass.SelectedItem.ToString(), language, availability, currentPage, productsPerPage);
                    productListView.Items.Clear();

                    foreach (Product clase in products)
                    {
                        productListView.Items.Add(clase.ToString());
                    }
                    break;
                case 6:
                    labelOfPages.Text = (currentPage + 1) + "of" + numberOfPages + " pages";
                    products = DataAcces.GetProductsStyle(comboBoxStyle.SelectedItem.ToString(), language, availability, currentPage, productsPerPage);
                    productListView.Items.Clear();

                    foreach (Product estilo in products)
                    {
                        productListView.Items.Add(estilo.ToString());
                    }
                    break;
                case 7:
                    labelOfPages.Text = (currentPage + 1) + "of" + numberOfPages + " pages";
                    products = DataAcces.GetProductsName(textBoxSearchName.Text.ToString(), language, availability, currentPage, productsPerPage);
                    productListView.Items.Clear();

                    foreach (Product nombre in products)
                    {
                        productListView.Items.Add(nombre.ToString());
                    }
                    break;
                case 8:
                    labelOfPages.Text = (currentPage + 1) + "of" + numberOfPages + " pages";
                    products = DataAcces.GetProductsModel(textBoxSearchModel.Text.ToString(), language, availability, currentPage, productsPerPage);
                    productListView.Items.Clear();

                    foreach (Product model in products)
                    {
                        productListView.Items.Add(model.ToString());
                    }
                    break;
                case 9:
                    labelOfPages.Text = (currentPage + 1) + "of" + numberOfPages + " pages";

                        float minim, max;
                        minim = float.Parse(textBoxPriceMinim.Text);
                        max = float.Parse(textBoxPriceMax.Text);
                        products = DataAcces.GetProductsPrice(minim, max, language, availability, currentPage, productsPerPage);
                        productListView.Items.Clear();

                        foreach (Product product in products)
                        {
                            productListView.Items.Add(product.ToString());
                        }
                    break;
                case 10:
                    labelOfPages.Text = (currentPage + 1) + "of" + numberOfPages + " pages";
                    List<ProductSell> productSells = new List<ProductSell>();
                    productSells = DataAcces.GetProductsSell(language,availability, currentPage, productsPerPage);
                    productListView.Items.Clear();
                    foreach (ProductSell sell in productSells)
                    {
                        productListView.Items.Add(sell.ToString());
                    }
                    break;
                case 11:
                    labelOfPages.Text = (currentPage + 1) + "of" + numberOfPages + " pages";
                    products = DataAcces.GetAllProducts(language, availability, currentPage, productsPerPage);
                    productListView.Items.Clear();
                    foreach (Product product in products)
                    {
                        productListView.Items.Add(product.ToString());
                    }
                    break;
            }
            
        }
        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            string connectionString = ConfigurationManager.ConnectionStrings["AdventureWorks2016"].ConnectionString;
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                string sql = $"exec dbo.getCategoryProductsNumber '{language}', '{availability}','{comboBoxCategory.Text}'";
                int totalNumbersOfProductsPerCategory = connection.Query<int>(sql).FirstOrDefault();
                numberOfPages = totalNumbersOfProductsPerCategory / int.Parse(comboBoxPages.Text) + 1;
                labelProductsFound.Text = totalNumbersOfProductsPerCategory.ToString() + " products found" ;
                currentPage = 0;
                if (totalNumbersOfProductsPerCategory <= int.Parse(comboBoxPages.Text))
                {
                    buttonPrevPage.Enabled = false;
                    buttonNextPage.Enabled = false;
                    opcion = 1;
                    UpdateProductsListView();
                }
                else
                {
                    buttonPrevPage.Enabled = false;
                    buttonNextPage.Enabled = true;
                    opcion = 1;
                    UpdateProductsListView();
                }
                
            }
        }

        private void comboBoxSubCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["AdventureWorks2016"].ConnectionString;
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                string sql = $"exec dbo.getSubCategoryProductsNumber '{language}', '{availability}','{comboBoxCategory.Text}'";
                int totalNumbersOfProductsPerCategory = connection.Query<int>(sql).FirstOrDefault();
                numberOfPages = totalNumbersOfProductsPerCategory / int.Parse(comboBoxPages.Text) + 1;
                labelProductsFound.Text = totalNumbersOfProductsPerCategory.ToString() + " products found";
                currentPage = 0;
                if (totalNumbersOfProductsPerCategory <= int.Parse(comboBoxPages.Text))
                {
                    buttonPrevPage.Enabled = false;
                    buttonNextPage.Enabled = false;
                    opcion = 2;
                    UpdateProductsListView();
                }
                else
                {
                    buttonPrevPage.Enabled = false;
                    buttonNextPage.Enabled = true;
                    opcion = 2;
                    UpdateProductsListView();
                }

            }
        }

        private void comboBoxSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["AdventureWorks2016"].ConnectionString;
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                string sql = $"exec dbo.getProductsSizeNumber '{language}', '{availability}','{comboBoxSize.Text}'";
                int totalNumbersOfProductsPerCategory = connection.Query<int>(sql).FirstOrDefault();
                numberOfPages = totalNumbersOfProductsPerCategory / int.Parse(comboBoxPages.Text) + 1;
                labelProductsFound.Text = totalNumbersOfProductsPerCategory.ToString() + " products found";
                currentPage = 0;
                if (totalNumbersOfProductsPerCategory <= int.Parse(comboBoxPages.Text))
                {
                    buttonPrevPage.Enabled = false;
                    buttonNextPage.Enabled = false;
                    opcion = 3;
                    UpdateProductsListView();
                }
                else
                {
                    buttonPrevPage.Enabled = false;
                    buttonNextPage.Enabled = true;
                    opcion = 3;
                    UpdateProductsListView();
                }

            }
            
        }

        private void comboBoxProductLine_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["AdventureWorks2016"].ConnectionString;
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                string sql = $"exec dbo.getProductsLineNumber '{language}', '{availability}','{comboBoxProductLine.Text}'";
                int totalNumbersOfProductsPerCategory = connection.Query<int>(sql).FirstOrDefault();
                numberOfPages = totalNumbersOfProductsPerCategory / int.Parse(comboBoxPages.Text) + 1;
                labelProductsFound.Text = totalNumbersOfProductsPerCategory.ToString() + " products found";
                currentPage = 0;
                if (totalNumbersOfProductsPerCategory <= int.Parse(comboBoxPages.Text))
                {
                    buttonPrevPage.Enabled = false;
                    buttonNextPage.Enabled = false;
                    opcion = 4;
                    UpdateProductsListView();
                }
                else
                {
                    buttonPrevPage.Enabled = false;
                    buttonNextPage.Enabled = true;
                    opcion = 4;
                    UpdateProductsListView();
                }

            }

        }

        private void comboBoxClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["AdventureWorks2016"].ConnectionString;
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                string sql = $"exec dbo.getProductsClassNumber '{language}', '{availability}','{comboBoxClass.Text}'";
                int totalNumbersOfProductsPerCategory = connection.Query<int>(sql).FirstOrDefault();
                numberOfPages = totalNumbersOfProductsPerCategory / int.Parse(comboBoxPages.Text) + 1;
                labelProductsFound.Text = totalNumbersOfProductsPerCategory.ToString() + " products found";
                currentPage = 0;
                if (totalNumbersOfProductsPerCategory <= int.Parse(comboBoxPages.Text))
                {
                    buttonPrevPage.Enabled = false;
                    buttonNextPage.Enabled = false;
                    opcion = 5;
                    UpdateProductsListView();
                }
                else
                {
                    buttonPrevPage.Enabled = false;
                    buttonNextPage.Enabled = true;
                    opcion = 5;
                    UpdateProductsListView();
                }

            }
        }
        
        private void comboBoxStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["AdventureWorks2016"].ConnectionString;
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                string sql = $"exec dbo.getProductsStyleNumber '{language}', '{availability}','{comboBoxStyle.Text}'";
                int totalNumbersOfProductsPerCategory = connection.Query<int>(sql).FirstOrDefault();
                numberOfPages = totalNumbersOfProductsPerCategory / int.Parse(comboBoxPages.Text) + 1;
                labelProductsFound.Text = totalNumbersOfProductsPerCategory.ToString() + " products found";
                currentPage = 0;
                if (totalNumbersOfProductsPerCategory <= int.Parse(comboBoxPages.Text))
                {
                    buttonPrevPage.Enabled = false;
                    buttonNextPage.Enabled = false;
                    opcion = 6;
                    UpdateProductsListView();
                }
                else
                {
                    buttonPrevPage.Enabled = false;
                    buttonNextPage.Enabled = true;
                    opcion = 6;
                    UpdateProductsListView();
                }

            }
        }

        private void textBoxSearchName_TextChanged(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["AdventureWorks2016"].ConnectionString;
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                string sql = $"exec dbo.getProductsNameNumber '{language}', '{availability}','{textBoxSearchName.Text}'";
                int totalNumbersOfProductsPerCategory = connection.Query<int>(sql).FirstOrDefault();
                numberOfPages = totalNumbersOfProductsPerCategory / int.Parse(comboBoxPages.Text) + 1;
                labelProductsFound.Text = totalNumbersOfProductsPerCategory.ToString() + " products found";
                currentPage = 0;
                if (totalNumbersOfProductsPerCategory <= int.Parse(comboBoxPages.Text))
                {
                    buttonPrevPage.Enabled = false;
                    buttonNextPage.Enabled = false;
                    opcion = 7;
                    UpdateProductsListView();
                }
                else
                {
                    buttonPrevPage.Enabled = false;
                    buttonNextPage.Enabled = true;
                    opcion = 7;
                    UpdateProductsListView();
                }

            }
        }

        private void textBoxSearchModel_TextChanged(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["AdventureWorks2016"].ConnectionString;
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                string sql = $"exec dbo.getProductsModelNumber '{language}', '{availability}','{textBoxSearchModel.Text}'";
                int totalNumbersOfProductsPerCategory = connection.Query<int>(sql).FirstOrDefault();
                numberOfPages = totalNumbersOfProductsPerCategory / int.Parse(comboBoxPages.Text) + 1;
                labelProductsFound.Text = totalNumbersOfProductsPerCategory.ToString() + " products found";
                currentPage = 0;
                if (totalNumbersOfProductsPerCategory <= int.Parse(comboBoxPages.Text))
                {
                    buttonPrevPage.Enabled = false;
                    buttonNextPage.Enabled = false;
                    opcion = 8;
                    UpdateProductsListView();
                }
                else
                {
                    buttonPrevPage.Enabled = false;
                    buttonNextPage.Enabled = true;
                    opcion = 8;
                    UpdateProductsListView();
                }

            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["AdventureWorks2016"].ConnectionString;
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                string sql = $"exec dbo.getProductsWithSellDatesNumber '{language}','{availability}'";
                int totalNumbersOfProductsPerCategory = connection.Query<int>(sql).FirstOrDefault();
                numberOfPages = totalNumbersOfProductsPerCategory / int.Parse(comboBoxPages.Text) + 1;
                labelProductsFound.Text = totalNumbersOfProductsPerCategory.ToString() + " products found";
                currentPage = 0;
                if (totalNumbersOfProductsPerCategory <= int.Parse(comboBoxPages.Text))
                {
                    buttonPrevPage.Enabled = false;
                    buttonNextPage.Enabled = false;
                    opcion = 10;
                    UpdateProductsListView();
                }
                else
                {
                    buttonPrevPage.Enabled = false;
                    buttonNextPage.Enabled = true;
                    opcion = 10;
                    UpdateProductsListView();
                }

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

        private void comboBoxPages_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            productsPerPage = int.Parse(comboBoxPages.Text);
            
            
        }

        private void buttonPrevPage_Click(object sender, EventArgs e)
        {
            currentPage--;
            if (currentPage == 0)
            {
                buttonPrevPage.Enabled = false;
            }
            buttonNextPage.Enabled = true;
            UpdateProductsListView();
        }

        private void buttonNextPage_Click(object sender, EventArgs e)
        {
            currentPage++;
            if (currentPage == numberOfPages -1)
            {
                buttonNextPage.Enabled = false;
            }
            buttonPrevPage.Enabled = true;
            UpdateProductsListView();
        }
    }
}
