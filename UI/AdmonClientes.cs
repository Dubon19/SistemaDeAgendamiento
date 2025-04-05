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
    public partial class AdmonClientes : Form
    {
        public AdmonClientes()
        {
            InitializeComponent();



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void CargarClientes()
        {
            try
            {

                List<Clientes> listaClientes = DAL_Clientes.Listar();


                GridCliente.DataSource = listaClientes;
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error al cargar los clientes: {ex.Message}");
            }
        }

        private void AdmonClientes_Load(object sender, EventArgs e)
        {
            CargarClientes();
        }

        private int _usuarioId;



        private string _usuarioActual;





        private void btnNuevo_Click(object sender, EventArgs e)
        {
            TxtNombreCliente.Clear();
            TxtApellidos.Clear();
            TxtTelefono.Clear();
            TxtEmail.Clear();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtNombreCliente.Text) ||
                string.IsNullOrWhiteSpace(TxtApellidos.Text))
            {
                MessageBox.Show("Por favor, ingrese el nombre y apellido del cliente.", "Campos requeridos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Clientes cliente = new Clientes()
            {
                Nombre = TxtNombreCliente.Text.Trim(),
                Apellido = TxtApellidos.Text.Trim(),
                Telefono = TxtTelefono.Text.Trim(),
                Email = TxtEmail.Text.Trim(),
                CreadoPor = _usuarioActual
            };

            try
            {
                var nuevoCliente = DAL_Clientes.Insert(cliente);

                if (nuevoCliente != null)
                {
                    MessageBox.Show("Cliente guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarClientes();
                }
                else
                {
                    MessageBox.Show("Hubo un problema al guardar el cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el cliente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            try
            {

                string telefono = TxtTelefono.Text;


                Clientes cliente = DAL_Clientes.Listar().FirstOrDefault(c => c.Telefono == telefono);

                if (cliente != null)
                {

                    DAL_Clientes.Delete(cliente);


                    CargarClientes();

                    MessageBox.Show("Cliente anulado correctamente.");
                }
                else
                {
                    MessageBox.Show("Cliente no encontrado con ese número de teléfono.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

        }

        private void textBuscar_TextChanged(object sender, EventArgs e)
        {
            string textoBusqueda = txtBuscar.Text.ToLower();
            var listaFiltrada = DAL_Clientes.Listar()
                .Where(c => c.Telefono.ToLower().Contains(textoBusqueda)) // Filtra por número de teléfono
                .ToList();
            GridCliente.DataSource = listaFiltrada;
        }

        private void GridCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}