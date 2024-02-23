namespace SistemaGestiónCRUDNorthwind
{
    partial class Productos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Productos));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Eliminedbutton = new System.Windows.Forms.Button();
            this.Actualizarbutton = new System.Windows.Forms.Button();
            this.Insertarbutton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.NametextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Categories = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DisconcheckBox1 = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ReorderNiveltextBox7 = new System.Windows.Forms.TextBox();
            this.UnidadesOrdentextBox6 = new System.Windows.Forms.TextBox();
            this.StocktextBox = new System.Windows.Forms.TextBox();
            this.PreciotextBox = new System.Windows.Forms.TextBox();
            this.CantidadtextBox = new System.Windows.Forms.TextBox();
            this.CategoriacomboBox = new System.Windows.Forms.ComboBox();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.northwindDataSet1 = new SistemaGestiónCRUDNorthwind.NorthwindDataSet1();
            this.SuplidorcomboBox = new System.Windows.Forms.ComboBox();
            this.suppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.northwindDataSet = new SistemaGestiónCRUDNorthwind.NorthwindDataSet();
            this.northwindDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new SistemaGestiónCRUDNorthwind.NorthwindDataSetTableAdapters.ProductsTableAdapter();
            this.northwindDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.suppliersTableAdapter = new SistemaGestiónCRUDNorthwind.NorthwindDataSet1TableAdapters.SuppliersTableAdapter();
            this.categoriesTableAdapter = new SistemaGestiónCRUDNorthwind.NorthwindDataSet1TableAdapters.CategoriesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Eliminedbutton
            // 
            resources.ApplyResources(this.Eliminedbutton, "Eliminedbutton");
            this.Eliminedbutton.Name = "Eliminedbutton";
            this.Eliminedbutton.UseVisualStyleBackColor = true;
            this.Eliminedbutton.Click += new System.EventHandler(this.Eliminedbutton_Click);
            // 
            // Actualizarbutton
            // 
            resources.ApplyResources(this.Actualizarbutton, "Actualizarbutton");
            this.Actualizarbutton.Name = "Actualizarbutton";
            this.Actualizarbutton.UseVisualStyleBackColor = true;
            this.Actualizarbutton.Click += new System.EventHandler(this.Actualizarbutton_Click);
            // 
            // Insertarbutton
            // 
            resources.ApplyResources(this.Insertarbutton, "Insertarbutton");
            this.Insertarbutton.Name = "Insertarbutton";
            this.Insertarbutton.UseVisualStyleBackColor = true;
            this.Insertarbutton.Click += new System.EventHandler(this.Insertarbutton_Click);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // NametextBox
            // 
            resources.ApplyResources(this.NametextBox, "NametextBox");
            this.NametextBox.Name = "NametextBox";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGreen;
            this.panel1.Controls.Add(this.Categories);
            this.panel1.Controls.Add(this.button5);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // Categories
            // 
            resources.ApplyResources(this.Categories, "Categories");
            this.Categories.Name = "Categories";
            // 
            // button5
            // 
            resources.ApplyResources(this.button5, "button5");
            this.button5.Name = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DisconcheckBox1);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.NametextBox);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.Eliminedbutton);
            this.panel2.Controls.Add(this.ReorderNiveltextBox7);
            this.panel2.Controls.Add(this.Actualizarbutton);
            this.panel2.Controls.Add(this.UnidadesOrdentextBox6);
            this.panel2.Controls.Add(this.Insertarbutton);
            this.panel2.Controls.Add(this.StocktextBox);
            this.panel2.Controls.Add(this.PreciotextBox);
            this.panel2.Controls.Add(this.CantidadtextBox);
            this.panel2.Controls.Add(this.CategoriacomboBox);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.SuplidorcomboBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // DisconcheckBox1
            // 
            resources.ApplyResources(this.DisconcheckBox1, "DisconcheckBox1");
            this.DisconcheckBox1.Name = "DisconcheckBox1";
            this.DisconcheckBox1.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // ReorderNiveltextBox7
            // 
            resources.ApplyResources(this.ReorderNiveltextBox7, "ReorderNiveltextBox7");
            this.ReorderNiveltextBox7.Name = "ReorderNiveltextBox7";
            // 
            // UnidadesOrdentextBox6
            // 
            resources.ApplyResources(this.UnidadesOrdentextBox6, "UnidadesOrdentextBox6");
            this.UnidadesOrdentextBox6.Name = "UnidadesOrdentextBox6";
            // 
            // StocktextBox
            // 
            resources.ApplyResources(this.StocktextBox, "StocktextBox");
            this.StocktextBox.Name = "StocktextBox";
            // 
            // PreciotextBox
            // 
            resources.ApplyResources(this.PreciotextBox, "PreciotextBox");
            this.PreciotextBox.Name = "PreciotextBox";
            // 
            // CantidadtextBox
            // 
            resources.ApplyResources(this.CantidadtextBox, "CantidadtextBox");
            this.CantidadtextBox.Name = "CantidadtextBox";
            // 
            // CategoriacomboBox
            // 
            this.CategoriacomboBox.DataSource = this.categoriesBindingSource;
            this.CategoriacomboBox.DisplayMember = "CategoryID";
            this.CategoriacomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.CategoriacomboBox, "CategoriacomboBox");
            this.CategoriacomboBox.FormattingEnabled = true;
            this.CategoriacomboBox.Name = "CategoriacomboBox";
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "Categories";
            this.categoriesBindingSource.DataSource = this.northwindDataSet1;
            // 
            // northwindDataSet1
            // 
            this.northwindDataSet1.DataSetName = "NorthwindDataSet1";
            this.northwindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SuplidorcomboBox
            // 
            this.SuplidorcomboBox.DataSource = this.suppliersBindingSource;
            this.SuplidorcomboBox.DisplayMember = "SupplierID";
            this.SuplidorcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.SuplidorcomboBox, "SuplidorcomboBox");
            this.SuplidorcomboBox.FormattingEnabled = true;
            this.SuplidorcomboBox.Name = "SuplidorcomboBox";
            this.SuplidorcomboBox.SelectedIndexChanged += new System.EventHandler(this.SuplidorcomboBox_SelectedIndexChanged);
            // 
            // suppliersBindingSource
            // 
            this.suppliersBindingSource.DataMember = "Suppliers";
            this.suppliersBindingSource.DataSource = this.northwindDataSet1;
            // 
            // northwindDataSet
            // 
            this.northwindDataSet.DataSetName = "NorthwindDataSet";
            this.northwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // northwindDataSetBindingSource
            // 
            this.northwindDataSetBindingSource.DataSource = this.northwindDataSet;
            this.northwindDataSetBindingSource.Position = 0;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.northwindDataSetBindingSource;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // northwindDataSetBindingSource1
            // 
            this.northwindDataSetBindingSource1.DataSource = this.northwindDataSet;
            this.northwindDataSetBindingSource1.Position = 0;
            // 
            // suppliersTableAdapter
            // 
            this.suppliersTableAdapter.ClearBeforeFill = true;
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // Productos
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Productos";
            this.Load += new System.EventHandler(this.Productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Eliminedbutton;
        private System.Windows.Forms.Button Actualizarbutton;
        private System.Windows.Forms.Button Insertarbutton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NametextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox CategoriacomboBox;
        private System.Windows.Forms.ComboBox SuplidorcomboBox;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox ReorderNiveltextBox7;
        private System.Windows.Forms.TextBox UnidadesOrdentextBox6;
        private System.Windows.Forms.TextBox StocktextBox;
        private System.Windows.Forms.TextBox PreciotextBox;
        private System.Windows.Forms.TextBox CantidadtextBox;
        private System.Windows.Forms.Label Categories;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource northwindDataSetBindingSource;
        private NorthwindDataSet northwindDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private NorthwindDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.BindingSource northwindDataSetBindingSource1;
        private NorthwindDataSet1 northwindDataSet1;
        private System.Windows.Forms.BindingSource suppliersBindingSource;
        private NorthwindDataSet1TableAdapters.SuppliersTableAdapter suppliersTableAdapter;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private NorthwindDataSet1TableAdapters.CategoriesTableAdapter categoriesTableAdapter;
        private System.Windows.Forms.CheckBox DisconcheckBox1;
    }
}