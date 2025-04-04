using DAL;
using EL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class FrmCitas : Form
    {
        public FrmCitas()
        {
            InitializeComponent();
        }

        public void CargarEmpleadosEstilistas()
        {
            var usuariosEstilistas = DAL_Usuarios.Listar()
                .Where(u => u.Rol != null && u.Rol.Nombre == "ESTILISTA")
                .Select(u => u.UsuarioId)
                .ToList();

            if (usuariosEstilistas.Count > 0)
            {
                // Obtener empleados de la base de datos
                List<Empleados> listaEmpleadosEstilistas = DAL_Empleados.Listar()
                    .Where(e => usuariosEstilistas.Contains(e.UsuarioId))
                    .ToList();

                // Asignar la lista al ComboBox
                cmbEstilista.DataSource = listaEmpleadosEstilistas;
                cmbEstilista.DisplayMember = "Nombre";  // Mostrar solo el Nombre
                cmbEstilista.ValueMember = "EmpleadoId";  // Usar el EmpleadoId como el valor
            }
            else
            {
                MessageBox.Show("No se encontraron estilistas.");
                cmbEstilista.DataSource = null;
            }
        }



        public void CargarServicios()
        {
            List<Servicios> listaServicios = DAL_Servicios.Listar();

            if (listaServicios != null && listaServicios.Count > 0)
            {
                // Verifica si la lista de servicios contiene elementos
                Console.WriteLine("Servicios cargados: " + listaServicios.Count);

                // Asignar la lista al ComboBox
                cmbServicio.DataSource = listaServicios;
                cmbServicio.DisplayMember = "Nombre";  // Mostrar el Nombre del servicio
                cmbServicio.ValueMember = "ServicioId";    // Usar el ServicioId como ValueMember
            }
            else
            {
                // Mostrar mensaje si no se encontraron servicios
                Console.WriteLine("No se encontraron servicios.");
                cmbServicio.DataSource = null;
            }
        }


        public void CargarClientes()
        {
            List<Clientes> listaClientes = DAL_Clientes.Listar(); // Obtener la lista de clientes desde la base de datos

            if (listaClientes != null && listaClientes.Count > 0)
            {
                // Asignar la lista de clientes al ComboBox
                cmbClienteId.DataSource = listaClientes;
                cmbClienteId.DisplayMember = "ClienteId";  // Mostrar el ClienteId
                cmbClienteId.ValueMember = "ClienteId";   // Usar el ClienteId como ValueMember
            }
            else
            {
                MessageBox.Show("No se encontraron clientes.");
                cmbClienteId.DataSource = null;
            }
        }







        private void FrmCitas_Load(object sender, EventArgs e)
        {
            CargarEmpleadosEstilistas();
            CargarServicios();
            CargarClientes();
            CargarCitas();
        }

        public void CargarCitas()
        {
            try
            {
                // Obtener la lista de citas desde la base de datos
                List<Citas> listaCitas = DAL_Citas.Listar();

                // Asignar la lista de citas al DataGridView
                gridCitas.DataSource = listaCitas;

                // Ajustar el ancho de las columnas automáticamente
                gridCitas.AutoResizeColumns();
            }
            catch (Exception ex)
            {
                // Manejo de errores
                MessageBox.Show("Error al cargar las citas: " + ex.Message);
            }
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Verificar si los ComboBox están vacíos
            if (cmbEstilista.SelectedIndex == -1 || string.IsNullOrEmpty(cmbClienteId.Text) || cmbServicio.SelectedItem == null)
            {
                MessageBox.Show("Por favor, complete todos los campos antes de guardar.");
                return; // No guardar si hay campos vacíos
            }

            // Obtener el servicio seleccionado
            var servicioSeleccionado = (Servicios)cmbServicio.SelectedItem; // Obtienes el objeto completo Servicio

            // Obtener el EmpleadoId seleccionado
            var empleadoIdSeleccionado = cmbEstilista.SelectedValue;  // Esto te da el EmpleadoId

            if (empleadoIdSeleccionado == null)
            {
                MessageBox.Show("Debe seleccionar un empleado.");
                return;
            }

            // Verificar que el EmpleadoId no sea NULL ni vacío
            int empleadoId = (int)empleadoIdSeleccionado;
            if (empleadoId == 0) // Si el valor es 0, significa que no se ha seleccionado correctamente
            {
                MessageBox.Show("Debe seleccionar un empleado válido.");
                return;
            }

            // Crear una nueva cita
            Citas nuevaCita = new Citas
            {
                ClienteId = (int)cmbClienteId.SelectedValue,  // Obtener el ClienteId
                ServicioId = servicioSeleccionado.ServicioId,  // Obtener el ID del servicio
                EmpleadoId = empleadoId,  // Asignar el EmpleadoId validado
                Fecha = dtpCitas.Value.Date,
                HoraInicio = TimeSpan.Parse(cmbHoraInicio.Text),
                HoraFin = TimeSpan.Parse(cmbHoraFin.Text),
                Activo = true,
                FechaCreacion = DateTime.Now,
                CreadoPor = "Admin"
            };

            // Llamar a la DAL para guardar la cita en la base de datos
            DAL_Citas.Guardar(nuevaCita);

            // Mostrar mensaje de confirmación
            MessageBox.Show("Cita guardada correctamente.");

            // Limpiar los campos para una nueva cita
            btnNuevo_Click(sender, e);
        }




        private void btnNuevo_Click(object sender, EventArgs e)
        {
            cmbEstilista.SelectedIndex = -1;  // Limpiar el ComboBox de estilistas
            cmbClienteId.Text = "";             // Limpiar el campo del cliente
            cmbServicio.Text = "";            // Limpiar el campo de servicio
            dtpCitas.Value = DateTime.Now; // Resetear la fecha y hora a la actual
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            // Verificar si hay una cita seleccionada en el DataGridView
            if (gridCitas.SelectedRows.Count > 0)
            {
                // Obtener el CitaId de la fila seleccionada
                int citaId = Convert.ToInt32(gridCitas.SelectedRows[0].Cells[0].Value);

                // Llamar al método de eliminación
                try
                {
                    DAL_Citas.Eliminar(citaId);  // Eliminar la cita de la base de datos
                    MessageBox.Show("Cita anulada exitosamente.");

                    // Actualizar la lista de citas en el DataGridView
                    ListarCitas();  // Método para listar las citas en el DataGridView
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al anular la cita: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una cita para anular.");
            }

            // Limpiar los campos del formulario (ya lo haces en tu código)
            cmbEstilista.SelectedIndex = -1;
            cmbClienteId.Text = "";
            cmbServicio.Text = "";
            dtpCitas.Value = DateTime.Now;
        }

        private void ListarCitas()
        {
            try
            {
                List<Citas> citas = DAL_Citas.Listar();
                gridCitas.DataSource = citas;  // Asumiendo que dgvCitas es tu DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las citas: {ex.Message}");
            }
        }

    }
}
