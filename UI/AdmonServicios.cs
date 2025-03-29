using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EL;
using DAL;


namespace UI
{
    public partial class AdmonServicios : Form
    {
        public AdmonServicios()
        {
            InitializeComponent();
        }

        private void LimpiarCampos()
        {
            txtServicios.Text = string.Empty;
            txtDuracion.Text = string.Empty;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void txtServicios_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtServicios.Text) || string.IsNullOrEmpty(txtDuracion.Text))
            {
                MessageBox.Show("Debe ingresar un nombre de servicio y duración.");
                return;
            }

            // Guardar el servicio en la base de datos
            string nombreServicio = txtServicios.Text;

            // Usar TryParse para validar y convertir la duración a un entero
            int duracion;
            if (!int.TryParse(txtDuracion.Text, out duracion))
            {
                MessageBox.Show("La duración debe ser un número válido.");
                return;
            }

            // Aquí puedes agregar tu lógica de inserción en la base de datos
            // Ejemplo: InsertarServicio(nombreServicio, duracion);
            // Luego, actualizar el DataGridView con los nuevos datos

            MessageBox.Show("Servicio guardado correctamente.");
            CargarServicios();
            LimpiarCampos();

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void CargarServicios()
        {
            // Aquí deberías cargar los servicios desde la base de datos
            // Ejemplo: var servicios = ObtenerServicios();

            // Asumimos que "servicios" es una lista de objetos de tipo Servicio
            // dataGridView1.DataSource = servicios;

            // Si tienes un DataTable, sería algo así:
            // dataGridView1.DataSource = servicioTable;
        }
    }
}
