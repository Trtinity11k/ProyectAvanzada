using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestiónCRUDNorthwind
{
    public partial class Productos : Form
    {
        string ProductID;
        public Productos()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            MenuInicio menuInicio = new MenuInicio();
            menuInicio.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Productos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'northwindDataSet1.Categories' Puede moverla o quitarla según sea necesario.
            this.categoriesTableAdapter.Fill(this.northwindDataSet1.Categories);
            // TODO: esta línea de código carga datos en la tabla 'northwindDataSet1.Suppliers' Puede moverla o quitarla según sea necesario.
            this.suppliersTableAdapter.Fill(this.northwindDataSet1.Suppliers);
            // TODO: esta línea de código carga datos en la tabla 'northwindDataSet.Products' Puede moverla o quitarla según sea necesario.
            this.productsTableAdapter.Fill(this.northwindDataSet.Products);
            CargarDATAVIEW();
            
        }
        void CargarDATAVIEW()
        {
            var connectionStringXX = Program.Configuration.GetConnectionString("NorthwindConnectionString");
            using (var connection = new SqlConnection(connectionStringXX))
            {
                var categoriaDT = new DataTable();
                var cm = connection.CreateCommand();
                cm.CommandText = "SELECT * FROM Products";
                connection.Open();
                var dataReader = cm.ExecuteReader();
                categoriaDT.Load(dataReader);
                connection.Close();

                dataGridView1.DataSource = categoriaDT;


            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Insertarbutton_Click(object sender, EventArgs e)
        {
            var errorMessage = new List<string>();
            var Prod = new _ProductValidator()
            {
                
                ProductName = NametextBox.Text,
                SupplierID = Convert.ToInt32(SuplidorcomboBox.Text),
                CategoryID = Convert.ToInt32(CategoriacomboBox.Text),
                QuantityPerUnit = CantidadtextBox.Text,
                UnitPrice = Convert.ToDecimal(PreciotextBox.Text),
                UnitsInStock = Convert.ToInt16(StocktextBox.Text),
                UnitsOnOrder = Convert.ToInt16(UnidadesOrdentextBox6.Text),
                ReorderLevel = Convert.ToInt16(ReorderNiveltextBox7.Text),
                Discontinued = Convert.ToBoolean(DisconcheckBox1.Checked),

            }

            ;
            var Product = new Product();
            var ValidationResult = Product.Validate(Prod);

            ////Form is Valid
            if (ValidationResult.IsValid)
            {


                MessageBox.Show("TODOS LOS DATOS INTRODUCCIDOS SON VALIDOS", "EXCELENTE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var connectionStringXX = Program.Configuration.GetConnectionString("NorthwindConnectionString");
                using (var connection = new SqlConnection(connectionStringXX))
                {
                    
                    
                        connection.Open();

                        var cm = connection.CreateCommand();
                        cm.CommandText = "INSERT INTO Products (ProductName, SupplierID, CategoryID, QuantityPerUnit, UnitPrice, UnitsInStock, ReorderLevel, Discontinued) " +
                                        "VALUES (@ProductName, @SupplierID, @CategoryID, @QuantityPerUnit, @UnitPrice, @UnitsInStock, @ReorderLevel, @Discontinued)";

                        // Configurar parámetros
                        
                        cm.Parameters.AddWithValue("@ProductName",ProductName);
                        cm.Parameters.AddWithValue("@SupplierID", SuplidorcomboBox.Text);
                        cm.Parameters.AddWithValue("@CategoryID", CategoriacomboBox.Text);
                        cm.Parameters.AddWithValue("@QuantityPerUnit", CantidadtextBox.Text);
                        cm.Parameters.AddWithValue("@UnitPrice", PreciotextBox.Text);
                        cm.Parameters.AddWithValue("@UnitsInStock", StocktextBox.Text);
                        cm.Parameters.AddWithValue("@ReorderLevel", UnidadesOrdentextBox6.Text);
                        cm.Parameters.AddWithValue("@Discontinued", DisconcheckBox1.Checked);

                    try
                    {
                        // Ejecutar la consulta
                        cm.ExecuteNonQuery();

                        MessageBox.Show("Los datos se han insertado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al insertar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    CargarDATAVIEW();



                }
            }

            else
            {
                var message = string.Join("\n", ValidationResult.Errors.Select(a => a.ErrorMessage));
                MessageBox.Show(message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ProductID = dataGridView1.SelectedCells[0].Value.ToString();
            NametextBox.Text = dataGridView1.SelectedCells[1].Value.ToString();
            SuplidorcomboBox.Text = dataGridView1.SelectedCells[2].Value.ToString();
            CategoriacomboBox.Text = dataGridView1.SelectedCells[3].Value.ToString();
            CantidadtextBox.Text = dataGridView1.SelectedCells[4].Value.ToString();
            PreciotextBox.Text = dataGridView1.SelectedCells[5].Value.ToString();
            StocktextBox.Text = dataGridView1.SelectedCells[6].Value.ToString();
            UnidadesOrdentextBox6.Text = dataGridView1.SelectedCells[7].Value.ToString();
            ReorderNiveltextBox7.Text = dataGridView1.SelectedCells[8].Value.ToString();
            
            try
            {
                // Ejecutar la accion
                DisconcheckBox1.Checked = Convert.ToBoolean(dataGridView1.SelectedCells[9].Value.ToString());
                MessageBox.Show("Los datos se han seleccionado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void Actualizarbutton_Click(object sender, EventArgs e)
        {
            // Supongamos que tienes un identificador único del producto
            int productId = Convert.ToInt32(ProductID);

            var connectionStringXX = Program.Configuration.GetConnectionString("NorthwindConnectionString");
            using (var connection = new SqlConnection(connectionStringXX))
            {
                connection.Open();

                var cm = connection.CreateCommand();
                cm.CommandText = "UPDATE Products SET ProductName = @ProductName, SupplierID = @SupplierID, CategoryID = @CategoryID, " +
                                 "QuantityPerUnit = @QuantityPerUnit, UnitPrice = @UnitPrice, UnitsInStock = @UnitsInStock, " +
                                 "ReorderLevel = @ReorderLevel, Discontinued = @Discontinued WHERE ProductID = @ProductID";

                // Configurar parámetros
                cm.Parameters.AddWithValue("@ProductName", NametextBox.Text);
                cm.Parameters.AddWithValue("@SupplierID", SuplidorcomboBox.Text);
                cm.Parameters.AddWithValue("@CategoryID", CategoriacomboBox.Text);
                cm.Parameters.AddWithValue("@QuantityPerUnit", CantidadtextBox.Text);
                cm.Parameters.AddWithValue("@UnitPrice", PreciotextBox.Text);
                cm.Parameters.AddWithValue("@UnitsInStock", StocktextBox.Text);
                cm.Parameters.AddWithValue("@ReorderLevel", UnidadesOrdentextBox6.Text);
                cm.Parameters.AddWithValue("@Discontinued", DisconcheckBox1.Checked);
                cm.Parameters.AddWithValue("@ProductID", productId);
                try
                {
                    // Ejecutar la consulta
                    cm.ExecuteNonQuery();
                
                MessageBox.Show("Los datos se han actualizado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar los datos del producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                CargarDATAVIEW();
            }

        }

        private void Eliminedbutton_Click(object sender, EventArgs e)
        {
            // Supongamos que tienes un identificador único del producto
            int productId = Convert.ToInt32(ProductID);

            var connectionStringXX = Program.Configuration.GetConnectionString("NorthwindConnectionString");
            using (var connection = new SqlConnection(connectionStringXX))
            {
                connection.Open();

                var cm = connection.CreateCommand();
                cm.CommandText = "DELETE FROM Products WHERE ProductID = @ProductID";

                // Configurar parámetros
                cm.Parameters.AddWithValue("@ProductID", productId);

                
                try
                {
                    // Ejecutar la consulta
                    cm.ExecuteNonQuery();
                    MessageBox.Show("Los datos se han eliminado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                catch (Exception ex)
                {
                MessageBox.Show("Error al eliminar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            CargarDATAVIEW();
            }

        }

        private void SuplidorcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
