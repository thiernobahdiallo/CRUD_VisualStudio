namespace DI01
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ProductButton = new System.Windows.Forms.Button();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.labelCategory = new System.Windows.Forms.Label();
            this.labelPages = new System.Windows.Forms.Label();
            this.comboBoxSubCategory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxSize = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxProductLine = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxClass = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxStyle = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxPriceMinim = new System.Windows.Forms.TextBox();
            this.textBoxPriceMax = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxSearchName = new System.Windows.Forms.TextBox();
            this.textBoxSearchModel = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.productListView = new System.Windows.Forms.ListView();
            this.radioButtonEnglish = new System.Windows.Forms.RadioButton();
            this.radioButtonFrench = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.radioButtonAvalableProducts = new System.Windows.Forms.RadioButton();
            this.radioButtonAllProducts = new System.Windows.Forms.RadioButton();
            this.pictureBoxSpain = new System.Windows.Forms.PictureBox();
            this.pictureBoxFrance = new System.Windows.Forms.PictureBox();
            this.buttonPrevPage = new System.Windows.Forms.Button();
            this.buttonNextPage = new System.Windows.Forms.Button();
            this.comboBoxPages = new System.Windows.Forms.ComboBox();
            this.labelProductsFound = new System.Windows.Forms.Label();
            this.labelOfPages = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSpain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFrance)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductButton
            // 
            this.ProductButton.Location = new System.Drawing.Point(560, 362);
            this.ProductButton.Name = "ProductButton";
            this.ProductButton.Size = new System.Drawing.Size(115, 34);
            this.ProductButton.TabIndex = 1;
            this.ProductButton.Text = "Get All Products";
            this.ProductButton.UseVisualStyleBackColor = true;
            this.ProductButton.Click += new System.EventHandler(this.ProductButton_Click);
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(28, 41);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(85, 21);
            this.comboBoxCategory.TabIndex = 3;
            this.comboBoxCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategory_SelectedIndexChanged);
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(25, 13);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(88, 13);
            this.labelCategory.TabIndex = 4;
            this.labelCategory.Text = "Choose Category";
            // 
            // labelPages
            // 
            this.labelPages.AutoSize = true;
            this.labelPages.Location = new System.Drawing.Point(694, 13);
            this.labelPages.Name = "labelPages";
            this.labelPages.Size = new System.Drawing.Size(75, 13);
            this.labelPages.TabIndex = 6;
            this.labelPages.Text = "Films per page";
            // 
            // comboBoxSubCategory
            // 
            this.comboBoxSubCategory.FormattingEnabled = true;
            this.comboBoxSubCategory.Location = new System.Drawing.Point(134, 41);
            this.comboBoxSubCategory.Name = "comboBoxSubCategory";
            this.comboBoxSubCategory.Size = new System.Drawing.Size(85, 21);
            this.comboBoxSubCategory.TabIndex = 7;
            this.comboBoxSubCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxSubCategory_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Choose subcategory";
            // 
            // comboBoxSize
            // 
            this.comboBoxSize.FormattingEnabled = true;
            this.comboBoxSize.Location = new System.Drawing.Point(244, 41);
            this.comboBoxSize.Name = "comboBoxSize";
            this.comboBoxSize.Size = new System.Drawing.Size(85, 21);
            this.comboBoxSize.TabIndex = 9;
            this.comboBoxSize.SelectedIndexChanged += new System.EventHandler(this.comboBoxSize_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Choose size";
            // 
            // comboBoxProductLine
            // 
            this.comboBoxProductLine.FormattingEnabled = true;
            this.comboBoxProductLine.Location = new System.Drawing.Point(347, 41);
            this.comboBoxProductLine.Name = "comboBoxProductLine";
            this.comboBoxProductLine.Size = new System.Drawing.Size(85, 21);
            this.comboBoxProductLine.TabIndex = 11;
            this.comboBoxProductLine.SelectedIndexChanged += new System.EventHandler(this.comboBoxProductLine_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(344, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Choose ProductLine ";
            // 
            // comboBoxClass
            // 
            this.comboBoxClass.FormattingEnabled = true;
            this.comboBoxClass.Location = new System.Drawing.Point(461, 41);
            this.comboBoxClass.Name = "comboBoxClass";
            this.comboBoxClass.Size = new System.Drawing.Size(85, 21);
            this.comboBoxClass.TabIndex = 13;
            this.comboBoxClass.SelectedIndexChanged += new System.EventHandler(this.comboBoxClass_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(458, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Choose Class";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(567, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Choose Style";
            // 
            // comboBoxStyle
            // 
            this.comboBoxStyle.FormattingEnabled = true;
            this.comboBoxStyle.Location = new System.Drawing.Point(570, 41);
            this.comboBoxStyle.Name = "comboBoxStyle";
            this.comboBoxStyle.Size = new System.Drawing.Size(85, 21);
            this.comboBoxStyle.TabIndex = 16;
            this.comboBoxStyle.SelectedIndexChanged += new System.EventHandler(this.comboBoxStyle_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(704, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Set price Minimal";
            // 
            // textBoxPriceMinim
            // 
            this.textBoxPriceMinim.Location = new System.Drawing.Point(707, 127);
            this.textBoxPriceMinim.Name = "textBoxPriceMinim";
            this.textBoxPriceMinim.Size = new System.Drawing.Size(93, 20);
            this.textBoxPriceMinim.TabIndex = 19;
            this.textBoxPriceMinim.TextChanged += new System.EventHandler(this.textBoxPriceMinim_TextChanged);
            // 
            // textBoxPriceMax
            // 
            this.textBoxPriceMax.Location = new System.Drawing.Point(707, 190);
            this.textBoxPriceMax.Name = "textBoxPriceMax";
            this.textBoxPriceMax.Size = new System.Drawing.Size(93, 20);
            this.textBoxPriceMax.TabIndex = 20;
            this.textBoxPriceMax.TextChanged += new System.EventHandler(this.textBoxPriceMax_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(704, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Set price Maximum";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(704, 233);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Search by Product Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(704, 298);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Search by Product Model";
            // 
            // textBoxSearchName
            // 
            this.textBoxSearchName.Location = new System.Drawing.Point(707, 262);
            this.textBoxSearchName.Name = "textBoxSearchName";
            this.textBoxSearchName.Size = new System.Drawing.Size(93, 20);
            this.textBoxSearchName.TabIndex = 24;
            this.textBoxSearchName.TextChanged += new System.EventHandler(this.textBoxSearchName_TextChanged);
            // 
            // textBoxSearchModel
            // 
            this.textBoxSearchModel.Location = new System.Drawing.Point(707, 325);
            this.textBoxSearchModel.Name = "textBoxSearchModel";
            this.textBoxSearchModel.Size = new System.Drawing.Size(93, 20);
            this.textBoxSearchModel.TabIndex = 25;
            this.textBoxSearchModel.TextChanged += new System.EventHandler(this.textBoxSearchModel_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(697, 362);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 34);
            this.button2.TabIndex = 27;
            this.button2.Text = "Get  Products Sell Info";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // productListView
            // 
            this.productListView.HideSelection = false;
            this.productListView.Location = new System.Drawing.Point(35, 91);
            this.productListView.Name = "productListView";
            this.productListView.Size = new System.Drawing.Size(658, 265);
            this.productListView.TabIndex = 28;
            this.productListView.UseCompatibleStateImageBehavior = false;
            this.productListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.productListView_MouseDoubleClick);
            // 
            // radioButtonEnglish
            // 
            this.radioButtonEnglish.AutoSize = true;
            this.radioButtonEnglish.Location = new System.Drawing.Point(189, 381);
            this.radioButtonEnglish.Name = "radioButtonEnglish";
            this.radioButtonEnglish.Size = new System.Drawing.Size(14, 13);
            this.radioButtonEnglish.TabIndex = 31;
            this.radioButtonEnglish.TabStop = true;
            this.radioButtonEnglish.UseVisualStyleBackColor = true;
            this.radioButtonEnglish.CheckedChanged += new System.EventHandler(this.radioButtonEnglish_CheckedChanged);
            // 
            // radioButtonFrench
            // 
            this.radioButtonFrench.AutoSize = true;
            this.radioButtonFrench.Location = new System.Drawing.Point(259, 380);
            this.radioButtonFrench.Name = "radioButtonFrench";
            this.radioButtonFrench.Size = new System.Drawing.Size(14, 13);
            this.radioButtonFrench.TabIndex = 32;
            this.radioButtonFrench.TabStop = true;
            this.radioButtonFrench.UseVisualStyleBackColor = true;
            this.radioButtonFrench.CheckedChanged += new System.EventHandler(this.radioButtonFrench_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(171, 364);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 13);
            this.label10.TabIndex = 33;
            this.label10.Text = "Select language";
            // 
            // radioButtonAvalableProducts
            // 
            this.radioButtonAvalableProducts.AutoSize = true;
            this.radioButtonAvalableProducts.Location = new System.Drawing.Point(35, 385);
            this.radioButtonAvalableProducts.Name = "radioButtonAvalableProducts";
            this.radioButtonAvalableProducts.Size = new System.Drawing.Size(113, 17);
            this.radioButtonAvalableProducts.TabIndex = 34;
            this.radioButtonAvalableProducts.TabStop = true;
            this.radioButtonAvalableProducts.Text = "Available Products";
            this.radioButtonAvalableProducts.UseVisualStyleBackColor = true;
            this.radioButtonAvalableProducts.CheckedChanged += new System.EventHandler(this.radioButtonAvalableProducts_CheckedChanged);
            // 
            // radioButtonAllProducts
            // 
            this.radioButtonAllProducts.AutoSize = true;
            this.radioButtonAllProducts.Location = new System.Drawing.Point(35, 362);
            this.radioButtonAllProducts.Name = "radioButtonAllProducts";
            this.radioButtonAllProducts.Size = new System.Drawing.Size(81, 17);
            this.radioButtonAllProducts.TabIndex = 35;
            this.radioButtonAllProducts.TabStop = true;
            this.radioButtonAllProducts.Text = "All Products";
            this.radioButtonAllProducts.UseVisualStyleBackColor = true;
            this.radioButtonAllProducts.CheckedChanged += new System.EventHandler(this.radioButtonAllProducts_CheckedChanged);
            // 
            // pictureBoxSpain
            // 
            this.pictureBoxSpain.Image = global::DI01.Properties.Resources.english;
            this.pictureBoxSpain.Location = new System.Drawing.Point(174, 400);
            this.pictureBoxSpain.Name = "pictureBoxSpain";
            this.pictureBoxSpain.Size = new System.Drawing.Size(44, 32);
            this.pictureBoxSpain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSpain.TabIndex = 30;
            this.pictureBoxSpain.TabStop = false;
            // 
            // pictureBoxFrance
            // 
            this.pictureBoxFrance.Image = global::DI01.Properties.Resources.france;
            this.pictureBoxFrance.Location = new System.Drawing.Point(244, 400);
            this.pictureBoxFrance.Name = "pictureBoxFrance";
            this.pictureBoxFrance.Size = new System.Drawing.Size(44, 32);
            this.pictureBoxFrance.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFrance.TabIndex = 29;
            this.pictureBoxFrance.TabStop = false;
            // 
            // buttonPrevPage
            // 
            this.buttonPrevPage.Location = new System.Drawing.Point(329, 362);
            this.buttonPrevPage.Name = "buttonPrevPage";
            this.buttonPrevPage.Size = new System.Drawing.Size(75, 23);
            this.buttonPrevPage.TabIndex = 36;
            this.buttonPrevPage.Text = "<Prev";
            this.buttonPrevPage.UseVisualStyleBackColor = true;
            this.buttonPrevPage.Click += new System.EventHandler(this.buttonPrevPage_Click);
            // 
            // buttonNextPage
            // 
            this.buttonNextPage.Location = new System.Drawing.Point(422, 362);
            this.buttonNextPage.Name = "buttonNextPage";
            this.buttonNextPage.Size = new System.Drawing.Size(75, 23);
            this.buttonNextPage.TabIndex = 37;
            this.buttonNextPage.Text = "Next>";
            this.buttonNextPage.UseVisualStyleBackColor = true;
            this.buttonNextPage.Click += new System.EventHandler(this.buttonNextPage_Click);
            // 
            // comboBoxPages
            // 
            this.comboBoxPages.FormattingEnabled = true;
            this.comboBoxPages.Location = new System.Drawing.Point(697, 40);
            this.comboBoxPages.Name = "comboBoxPages";
            this.comboBoxPages.Size = new System.Drawing.Size(85, 21);
            this.comboBoxPages.TabIndex = 38;
            this.comboBoxPages.SelectedIndexChanged += new System.EventHandler(this.comboBoxPages_SelectedIndexChanged);
            // 
            // labelProductsFound
            // 
            this.labelProductsFound.AutoSize = true;
            this.labelProductsFound.Location = new System.Drawing.Point(244, 69);
            this.labelProductsFound.Name = "labelProductsFound";
            this.labelProductsFound.Size = new System.Drawing.Size(57, 13);
            this.labelProductsFound.TabIndex = 39;
            this.labelProductsFound.Text = "films found";
            // 
            // labelOfPages
            // 
            this.labelOfPages.AutoSize = true;
            this.labelOfPages.Location = new System.Drawing.Point(397, 68);
            this.labelOfPages.Name = "labelOfPages";
            this.labelOfPages.Size = new System.Drawing.Size(71, 13);
            this.labelOfPages.TabIndex = 40;
            this.labelOfPages.Text = "X of Y pages ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 450);
            this.Controls.Add(this.labelOfPages);
            this.Controls.Add(this.labelProductsFound);
            this.Controls.Add(this.comboBoxPages);
            this.Controls.Add(this.buttonNextPage);
            this.Controls.Add(this.buttonPrevPage);
            this.Controls.Add(this.radioButtonAllProducts);
            this.Controls.Add(this.radioButtonAvalableProducts);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.radioButtonFrench);
            this.Controls.Add(this.radioButtonEnglish);
            this.Controls.Add(this.pictureBoxSpain);
            this.Controls.Add(this.pictureBoxFrance);
            this.Controls.Add(this.productListView);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBoxSearchModel);
            this.Controls.Add(this.textBoxSearchName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxPriceMax);
            this.Controls.Add(this.textBoxPriceMinim);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxStyle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxClass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxProductLine);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxSize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxSubCategory);
            this.Controls.Add(this.labelPages);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.ProductButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSpain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFrance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ProductButton;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label labelPages;
        private System.Windows.Forms.ComboBox comboBoxSubCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxProductLine;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxClass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxStyle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxPriceMinim;
        private System.Windows.Forms.TextBox textBoxPriceMax;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxSearchName;
        private System.Windows.Forms.TextBox textBoxSearchModel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView productListView;
        private System.Windows.Forms.PictureBox pictureBoxFrance;
        private System.Windows.Forms.PictureBox pictureBoxSpain;
        private System.Windows.Forms.RadioButton radioButtonEnglish;
        private System.Windows.Forms.RadioButton radioButtonFrench;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton radioButtonAvalableProducts;
        private System.Windows.Forms.RadioButton radioButtonAllProducts;
        private System.Windows.Forms.Button buttonPrevPage;
        private System.Windows.Forms.Button buttonNextPage;
        private System.Windows.Forms.ComboBox comboBoxPages;
        private System.Windows.Forms.Label labelProductsFound;
        private System.Windows.Forms.Label labelOfPages;
    }
}

