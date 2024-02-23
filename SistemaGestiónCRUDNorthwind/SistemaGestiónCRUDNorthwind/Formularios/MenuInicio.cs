using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestiónCRUDNorthwind
{
    public partial class MenuInicio : Form
    {
        public MenuInicio()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Categorias categorias = new Categorias();
            categorias.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Productos productos = new Productos();
            productos.Show();   
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Suplidores suplidores = new Suplidores();
            suplidores.Show();
                this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Mostrar un mensaje de confirmación
            DialogResult result = MessageBox.Show("¿Está seguro de que desea cerrar la aplicación?", "Confirmar cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Si el usuario elige "No", cancelar el cierre de la aplicación
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            
        }
    }
}
