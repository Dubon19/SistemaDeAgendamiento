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
    public partial class FrmEmpleados : Form
    {
        private int usuarioId;

        public FrmEmpleados(int usuarioId)
        {
            InitializeComponent();
            this.usuarioId = usuarioId; // Asignar el UsuarioId al campo
        }


        private ComboBox cmbNombreHorario;

        private void FrmEmpleados_Load(object sender, EventArgs e)
        {
            CargarEmpleados();
            CargarHorarios();
        }

        private void CargarHorarios()
        {
            var horarios = DAL_CatalogoHorarios.ObtenerTodos();  // Método que obtiene todos los horarios desde la base de datos
            cmbCHorario.DataSource = horarios;
            cmbCHorario.DisplayMember = "Nombre";  // Aquí pones el campo que se mostrará en el ComboBox
            cmbCHorario.ValueMember = "CatalogoHorarioId";  // Aquí pones el campo que se usará como valor
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNombre.Text) &&
                !string.IsNullOrWhiteSpace(txtApellido.Text) &&
                cmbCHorario.SelectedIndex != -1)
            {
                Empleados empleado = new Empleados
                {
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    Telefono = Convert.ToInt32(txtTelefono.Text),
                    Email = txtEmail.Text,
                    FechaDeIngreso = DateTime.Now,
                    VacacionesAcumuladas = 0,
                    Activo = true,
                    UsuarioId = this.usuarioId, // Vincular al UsuarioId recibido
                    CatalogoHorarioId = Convert.ToInt32(cmbCHorario.SelectedValue) // Obtener el ID del horario
                };

                DAL_Empleados.Insert(empleado);  // Método en la DAL para insertar empleado

                MessageBox.Show("Empleado agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

     

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtEmail.Text = string.Empty;
            dtpFingreso.Value = DateTime.Now;  // Si usas un DateTimePicker para la fecha
            txtVacaciones.Text = string.Empty;
            cmbCHorario.SelectedIndex = -1;  // Resetear el ComboBox de horarios si lo tienes

            // También podrías poner el foco en el primer campo para facilitar la entrada de datos
            txtNombre.Focus();

        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            if (gridEmpleados.SelectedRows.Count > 0)
            {
                // Obtener el 'EmpleadoId' del DataGridView
                int empleadoId = Convert.ToInt32(gridEmpleados.SelectedRows[0].Cells["EmpleadoId"].Value);

                // Obtener el empleado completo desde la base de datos usando el ID
                Empleados empleado = DAL_Empleados.ObtenerPorId(empleadoId); // Asumiendo que tienes este método

                if (empleado != null)
                {
                    // Llamar a la función que elimina al empleado (cambia su estado a inactivo)
                    bool resultado = DAL_Empleados.Delete(empleado);  // Pasas el objeto completo Empleados

                    if (resultado)
                    {
                        // Recargar los empleados para reflejar el cambio
                        CargarEmpleados();
                        MessageBox.Show("Empleado anulado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error al anular el empleado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Empleado no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un empleado para anular.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CargarEmpleados()
        {
            var empleados = DAL_Empleados.Listar();
            if (empleados != null && empleados.Count > 0)
            {
                gridEmpleados.DataSource = empleados;
                gridEmpleados.Refresh();  // Forzar la actualización del DataGridView
            }
            else
            {
                MessageBox.Show("No se encontraron empleados.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void gridEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
