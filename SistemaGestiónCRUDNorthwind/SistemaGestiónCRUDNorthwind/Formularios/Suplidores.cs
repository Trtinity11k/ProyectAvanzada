using FluentValidation.Results;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestiónCRUDNorthwind
{
    public partial class Suplidores : Form
    {
        string SupplierID;
        //ConexionString conexion = new ConexionString();
        public Suplidores()
        {
            InitializeComponent();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            MenuInicio menuInicio = new MenuInicio();
            menuInicio.Show();
        }
        void CargarDATAVIEW()
        {
            var connectionStringXX = Program.Configuration.GetConnectionString("NorthwindConnectionString");
            using (var connection = new SqlConnection(connectionStringXX))
            {
                var categoriaDT = new DataTable();
                var cm = connection.CreateCommand();
                cm.CommandText = "SELECT * FROM Suppliers";
                connection.Open();
                var dataReader = cm.ExecuteReader();
                categoriaDT.Load(dataReader);
                connection.Close();

                dataGridView1.DataSource = categoriaDT;


            }
        }
        private void Suplidores_Load(object sender, EventArgs e)
        {
            CargarDATAVIEW();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }


        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void InsertareButton_Click(object sender, EventArgs e)
        {
            var errorMessage = new List<string>();
            var Supply = new _Supplier()
            {                  
                    CompanyName = NombreSuplyTb.Text,
                    ContactName = ContactoTB.Text,
                    ContactTitle = TituloTB.Text,
                    Address = DirretextBox.Text,
                    City = CiudadtextBox.Text,
                    Region = RegiontextBox.Text,
                    PostalCode = CodetextBox.Text,
                    Country = PaistextBox.Text,
                    Phone = CeltextBox.Text,
                    Fax = FaxtextBox.Text,
                    HomePage = HomePagtextBox.Text,

            }

            ;
             var supplierValid = new SupplierValid();
            var ValidationResult = supplierValid.Validate(Supply);

            ////Form is Valid
            if (ValidationResult.IsValid)
            {


                MessageBox.Show("TODOS LOS DATOS INTRODUCCIDOS SON VALIDOS", "EXCELENTE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var connectionStringXX = Program.Configuration.GetConnectionString("NorthwindConnectionString");
                using (var connection = new SqlConnection(connectionStringXX))
                {


                    connection.Open();

                    var cm = connection.CreateCommand();
                    cm.CommandText = "INSERT INTO Suppliers (CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country, Phone, Fax, HomePage) " +
                                     "VALUES (@CompanyName, @ContactName, @ContactTitle, @Address, @City, @Region, @PostalCode, @Country, @Phone, @Fax, @HomePage)";

                    // Configurar parámetros
                    cm.Parameters.AddWithValue("@CompanyName", NombreSuplyTb.Text);
                    cm.Parameters.AddWithValue("@ContactName", ContactoTB.Text);
                    cm.Parameters.AddWithValue("@ContactTitle", TituloTB.Text);
                    cm.Parameters.AddWithValue("@Address", DirretextBox.Text);
                    cm.Parameters.AddWithValue("@City", CiudadtextBox.Text);
                    cm.Parameters.AddWithValue("@Region", RegiontextBox.Text);
                    cm.Parameters.AddWithValue("@PostalCode", CodetextBox.Text);
                    cm.Parameters.AddWithValue("@Country", PaistextBox.Text);
                    cm.Parameters.AddWithValue("@Phone", CeltextBox.Text);
                    cm.Parameters.AddWithValue("@Fax", FaxtextBox.Text);
                    cm.Parameters.AddWithValue("@HomePage", HomePagtextBox.Text);

                    // Ejecutar la consulta
                    cm.ExecuteNonQuery();
                    try
                    {
                        MessageBox.Show("Los datos se han insertado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al seleccionar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            SupplierID = dataGridView1.SelectedCells[0].Value.ToString();
            NombreSuplyTb.Text  = dataGridView1.SelectedCells[1].Value.ToString();
            ContactoTB.Text =  dataGridView1.SelectedCells[2].Value.ToString();
            TituloTB.Text = dataGridView1.SelectedCells[3].Value.ToString();
            DirretextBox.Text = dataGridView1.SelectedCells[4].Value.ToString();
            CiudadtextBox.Text = dataGridView1.SelectedCells[5].Value.ToString();
            RegiontextBox.Text = dataGridView1.SelectedCells[6].Value.ToString();
            CodetextBox.Text = dataGridView1.SelectedCells[7].Value.ToString();
            PaistextBox.Text = dataGridView1.SelectedCells[8].Value.ToString();
            CeltextBox.Text = dataGridView1.SelectedCells[9].Value.ToString();
            FaxtextBox.Text = dataGridView1.SelectedCells[10].Value.ToString();
            HomePagtextBox.Text = dataGridView1.SelectedCells[11].Value.ToString();

        }

        private void ActualizarButton_Click(object sender, EventArgs e)
        {
            int supplierID = Convert.ToInt32(SupplierID);

            var errorMessage = new List<string>();
            var supply = new _Supplier()
            {
                CompanyName = NombreSuplyTb.Text,
                ContactName = ContactoTB.Text,
                ContactTitle = TituloTB.Text,
                Address = DirretextBox.Text,
                City = CiudadtextBox.Text,
                Region = RegiontextBox.Text,
                PostalCode = CodetextBox.Text,
                Country = PaistextBox.Text,
                Phone = CeltextBox.Text,
                Fax = FaxtextBox.Text,
                HomePage = HomePagtextBox.Text,
            };

            var supplierValid = new SupplierValid();
            var validationResult = supplierValid.Validate(supply);

            // Form is Valid
            if (validationResult.IsValid)
            {
                MessageBox.Show("Todos los datos introducidos son válidos", "Excelente", MessageBoxButtons.OK, MessageBoxIcon.Information);

                var connectionStringXX = Program.Configuration.GetConnectionString("NorthwindConnectionString");
                using (var connection = new SqlConnection(connectionStringXX))
                {
                    connection.Open();

                    var cm = connection.CreateCommand();
                    cm.CommandText = "UPDATE Suppliers SET CompanyName = @CompanyName, ContactName = @ContactName, ContactTitle = @ContactTitle, " +
                                     "Address = @Address, City = @City, Region = @Region, PostalCode = @PostalCode, Country = @Country, " +
                                     "Phone = @Phone, Fax = @Fax, HomePage = @HomePage WHERE SupplierID = @SupplierID";

                    // Configurar parámetros
                    cm.Parameters.AddWithValue("@CompanyName", NombreSuplyTb.Text);
                    cm.Parameters.AddWithValue("@ContactName", ContactoTB.Text);
                    cm.Parameters.AddWithValue("@ContactTitle", TituloTB.Text);
                    cm.Parameters.AddWithValue("@Address", DirretextBox.Text);
                    cm.Parameters.AddWithValue("@City", CiudadtextBox.Text);
                    cm.Parameters.AddWithValue("@Region", RegiontextBox.Text);
                    cm.Parameters.AddWithValue("@PostalCode", CodetextBox.Text);
                    cm.Parameters.AddWithValue("@Country", PaistextBox.Text);
                    cm.Parameters.AddWithValue("@Phone", CeltextBox.Text);
                    cm.Parameters.AddWithValue("@Fax", FaxtextBox.Text);
                    cm.Parameters.AddWithValue("@HomePage", HomePagtextBox.Text);

                    // Aquí debes proporcionar el ID del proveedor que deseas actualizar
                    cm.Parameters.AddWithValue("@SupplierID", supplierID);

                    // Ejecutar la consulta
                    cm.ExecuteNonQuery();
                    try
                    {
                        MessageBox.Show("Los datos se han actualizado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al seleccionar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    CargarDATAVIEW();
                }
            }
            else
            {

                var message = string.Join("\n", validationResult.Errors.Select(a => a.ErrorMessage));
                MessageBox.Show(message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            // Supongamos que tienes un identificador único del producto
            int supplierID = Convert.ToInt32(SupplierID);

            var connectionStringXX = Program.Configuration.GetConnectionString("NorthwindConnectionString");
            using (var connection = new SqlConnection(connectionStringXX))
            {
                connection.Open();

                var cm = connection.CreateCommand();
                cm.CommandText = "DELETE FROM Suppliers WHERE SupplierID = @SupplierID";

                // Configurar parámetros
                cm.Parameters.AddWithValue("@SupplierID", supplierID);

                
                try
                {
                    // Ejecutar la consulta
                    cm.ExecuteNonQuery();
                    MessageBox.Show("Los datos se han eliminado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el Suplidor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                CargarDATAVIEW();
            }
        }
    }
}
