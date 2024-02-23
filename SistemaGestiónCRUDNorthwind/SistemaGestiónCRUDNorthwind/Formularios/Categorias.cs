using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using FluentValidation;
using Microsoft.Extensions.Configuration;
using System.Drawing.Imaging;
using System.IO;
using Microsoft.Identity.Client;
using System.Data.Common;

namespace SistemaGestiónCRUDNorthwind
{
    
    public partial class Categorias : Form
    {
        string CategoriaID;
        public Categorias()
        {
            InitializeComponent();
            Load += Categorias_Load;

        }

        private void Categorias_Load(object sender, EventArgs e)
        {
            CargarDATAVIEW();
            MostrarImagenEnPictureBox();

        }
        private void MostrarImagenEnPictureBox()
        {
            string imagePath = "C:\\Users\\Admin\\source\\repos\\SistemaGestiónCRUDNorthwind\\SistemaGestiónCRUDNorthwind\\Imagen Pred\\app-6702045_1280.png";
            {
                using (FileStream fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                {
                    pbImagen.Image = Image.FromStream(fs);
                }
            }
            
        }

        void CargarDATAVIEW()
        {
            var connectionStringXX = Program.Configuration.GetConnectionString("NorthwindConnectionString");
            using (var connection = new SqlConnection(connectionStringXX))
            {
                var categoriaDT = new DataTable();
                var cm = connection.CreateCommand();
                cm.CommandText = "SELECT * FROM Categories";
                connection.Open();
                var dataReader = cm.ExecuteReader();
                categoriaDT.Load(dataReader);
                connection.Close();

                dataGridView1.DataSource = categoriaDT;


            }
            MostrarImagenEnPictureBox();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

       

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            MenuInicio menuInicio = new MenuInicio();
            menuInicio.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        

        

        private void Insertarbutton_Click(object sender, EventArgs e)
        {
            // Convertir la imagen del PictureBox a un arreglo de bytes
            byte[] imagenBytes = new byte[0];
            if (pbImagen.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    pbImagen.Image.Save(ms, ImageFormat.Jpeg);
                    imagenBytes = ms.ToArray();
                }
            }

            // Validar los datos de la categoría
            var categ = new _Categories
            {
                CategoryName = CatenametextBox.Text,
                Description = DescripciontextBox.Text
            };
            var categoriesValidator = new CategoriesValidator();
            var validationResult = categoriesValidator.Validate(categ);

            // Verificar si la validación fue exitosa
            if (validationResult.IsValid)
            {
                MessageBox.Show("Los datos son válidos", "Éxito", MessageBoxButtons.OK);

                var connectionStringXX = Program.Configuration.GetConnectionString("NorthwindConnectionString");
                using (var connection = new SqlConnection(connectionStringXX))
                {
                    try
                    {
                        // Abrir la conexión a la base de datos
                        connection.Open();

                        // Crear el comando SQL para insertar la nueva categoría
                        
                        var command = connection.CreateCommand();
                        command.CommandText = "INSERT INTO Categories (CategoryName, Description, Picture) VALUES (@CategoryName, @Description, @Picture)";

                        // Configurar los parámetros del comando
                        command.Parameters.AddWithValue("@CategoryName", CatenametextBox.Text);
                            command.Parameters.AddWithValue("@Description", DescripciontextBox.Text);
                            command.Parameters.AddWithValue("@Picture", imagenBytes); // Manejar el caso de que la imagen sea nula

                            // Ejecutar el comando SQL para insertar la categoría
                            command.ExecuteNonQuery();
                        

                        MessageBox.Show("La categoría se ha guardado correctamente", "Éxito", MessageBoxButtons.OK);
                        pbImagen.Image = null; // Limpiar el PictureBox después de guardar la imagen
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al guardar la categoría: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                // Actualizar la vista de datos después de guardar la categoría
                CargarDATAVIEW();
            }
            else
            {
                // Mostrar los errores de validación
                var message = string.Join("\n", validationResult.Errors.Select(a => a.ErrorMessage));
                MessageBox.Show(message, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }


        private void SelectIMAGENbutton_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog seleccionarimg = new OpenFileDialog();
            seleccionarimg.Filter = "Imagenes|*.jpg; *.png";
            seleccionarimg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            seleccionarimg.Title = "Seleccionar Imagen";

            if (seleccionarimg.ShowDialog() == DialogResult.OK)
            {
                pbImagen.Image = Image.FromFile(seleccionarimg.FileName);
            }
        }
        
        private void Actualizarbutton_Click(object sender, EventArgs e)
        {
            // Identificador de la categoría
            int categoryId = Convert.ToInt32(CategoriaID);

            // Convertir la imagen del PictureBox a un arreglo de bytes
            byte[] imagenBytes = null;
            if (pbImagen.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    pbImagen.Image.Save(ms, ImageFormat.Jpeg);
                    imagenBytes = ms.ToArray();
                }
            }

            // Validar los datos de la categoría
            var categ = new _Categories
            {
                CategoryName = CatenametextBox.Text,
                Description = DescripciontextBox.Text
            };
            var categoriesValidator = new CategoriesValidator();
            var validationResult = categoriesValidator.Validate(categ);

            // Verificar si la validación fue exitosa
            if (validationResult.IsValid)
            {
                MessageBox.Show("Los datos son válidos", "Éxito", MessageBoxButtons.OK);

                var connectionStringXX = Program.Configuration.GetConnectionString("NorthwindConnectionString");
                using (var connection = new SqlConnection(connectionStringXX))
                {
                    try
                    {
                        // Abrir la conexión a la base de datos
                        connection.Open();

                        // Crear el comando SQL para actualizar la categoría
                        string updateQuery = "UPDATE Categories SET CategoryName = @CategoryName, Description = @Description, Picture = @Picture WHERE CategoryID = @CategoryID";
                        using (var command = new SqlCommand(updateQuery, connection))
                        {
                            // Configurar los parámetros del comando
                            command.Parameters.AddWithValue("@CategoryName", CatenametextBox.Text);
                            command.Parameters.AddWithValue("@Description", DescripciontextBox.Text);
                            command.Parameters.AddWithValue("@Picture", (object)imagenBytes ?? DBNull.Value); // Manejar el caso de que la imagen sea nula
                            command.Parameters.AddWithValue("@CategoryID", categoryId);

                            // Ejecutar el comando SQL para actualizar la categoría
                            command.ExecuteNonQuery();
                        }

                        MessageBox.Show("Los datos se han actualizado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        pbImagen.Image = null; // Limpiar el PictureBox después de actualizar la imagen
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al actualizar la categoría: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                // Actualizar la vista de datos después de actualizar la categoría
                CargarDATAVIEW();
            }
            else
            {
                // Mostrar los errores de validación
                var message = string.Join("\n", validationResult.Errors.Select(a => a.ErrorMessage));
                MessageBox.Show(message, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CategoriaID = dataGridView1.SelectedCells[0].Value.ToString();
            CatenametextBox.Text = dataGridView1.SelectedCells[1].Value.ToString();
            DescripciontextBox.Text = dataGridView1.SelectedCells[2].Value.ToString();

            // Verificar si se hizo clic en una fila válida
            if (e.RowIndex >= 0)
            {
                // Obtener el valor de la celda que contiene la imagen (debe ser un arreglo de bytes)
                byte[] imagenBytes = (byte[])dataGridView1.Rows[e.RowIndex].Cells[3].Value;

                // Verificar si la celda de la imagen no está vacía
                if (imagenBytes != null && imagenBytes.Length > 0)
                {
                    // Convertir el arreglo de bytes en una imagen
                    using (MemoryStream ms = new MemoryStream(imagenBytes))
                    {
                        Image imagen = Image.FromStream(ms);

                        // Asignar la imagen al PictureBox
                        pbImagen.Image = imagen;
                    }
                }
                else
                {
                    // Si la celda de la imagen está vacía, limpiar el PictureBox
                    pbImagen.Image = null;
                }
            }


        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            int categoryId = Convert.ToInt32(CategoriaID);

            var connectionStringXX = Program.Configuration.GetConnectionString("NorthwindConnectionString");
            using (var connection = new SqlConnection(connectionStringXX))
            {
                var cm = connection.CreateCommand();
                cm.CommandText = "DELETE FROM Categories WHERE CategoryID = @CategoryID";

                // Asegúrate de reemplazar CategoryID con el nombre correcto de la columna que identifica la categoría
                cm.Parameters.AddWithValue("@CategoryID", categoryId);

                connection.Open();
                try
                {
                    cm.ExecuteNonQuery();
                    MessageBox.Show("La categoría se ha eliminado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar la categoría: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                CargarDATAVIEW();
            }

        }

        private void LimpiarBoton_Click(object sender, EventArgs e)
        {
            // Limpiar los TextBox
            CatenametextBox.Text = "";
            DescripciontextBox.Text = "";

            // Limpiar el PictureBox
            pbImagen.Image = null;

        }
    }
}
