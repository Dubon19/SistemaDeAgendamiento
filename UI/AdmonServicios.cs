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
            CargarServicios();
        }

        private void LimpiarCampos()
        {
            txtServicios.Text = string.Empty;
            txtDuracion.Text = string.Empty;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtServicios.Text) || string.IsNullOrEmpty(txtDuracion.Text))
            {
                MessageBox.Show("Debe ingresar un nombre de servicio y duración.");
                return;
            }

            int duracion;
            if (!int.TryParse(txtDuracion.Text, out duracion))
            {
                MessageBox.Show("La duración debe ser un número válido.");
                return;
            }

            Servicios nuevoServicio = new Servicios
            {
                Nombre = txtServicios.Text,
                Duracion = txtDuracion.Text
            };

            DAL_Servicios.Insert(nuevoServicio);

            MessageBox.Show("Servicio guardado correctamente.");
            CargarServicios(); // Recargar los datos en el Grid
            LimpiarCampos();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (GridServicio.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un servicio para eliminar.");
                return;
            }

            int servicioId = Convert.ToInt32(GridServicio.SelectedRows[0].Cells["ServicioId"].Value);

            Servicios servicioEliminar = new Servicios { ServicioId = servicioId };
            DAL_Servicios.Delete(servicioEliminar);

            MessageBox.Show("Servicio eliminado correctamente.");
            CargarServicios();
        }

        private void CargarServicios()
        {
            List<Servicios> listaServicios = DAL_Servicios.Listar();

            if (listaServicios != null && listaServicios.Count > 0)
            {
                GridServicio.DataSource = listaServicios;
            }
            else
            {
                GridServicio.DataSource = null;
            }
        }

        private void GridServicio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}