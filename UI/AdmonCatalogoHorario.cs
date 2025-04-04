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
    public partial class AdmonCatalogoHorario : Form
    {
        public AdmonCatalogoHorario()
        {
            InitializeComponent();
            
        }



        private void AdmonCatalogoHorario_Load(object sender, EventArgs e)
        {
            CargarHorarios();

        }

        private void CargarHorarios()
        {
            var horarios = DAL_CatalogoHorarios.Listar(); // Obtiene los horarios desde la BD
            cmbNombreHorario.DataSource = horarios;
            cmbNombreHorario.DisplayMember = "NombreHorario";  // Muestra los nombres en el ComboBox
            cmbNombreHorario.ValueMember = "CatalogoHorarioId"; // Guarda internamente el ID
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            cmbNombreHorario.SelectedIndex = -1;
            cmbDinicio.SelectedIndex = -1;
            cmbDfin.SelectedIndex = -1;
            cmbHinicio.SelectedIndex = -1;
            cmbHfin.SelectedIndex = -1;
            cmbDlibre.SelectedIndex = -1;

            // Opcional: Establecer el foco en el primer campo
            cmbNombreHorario.Focus();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbNombreHorario.Text) ||
        cmbDinicio.SelectedIndex == -1 ||
        cmbDfin.SelectedIndex == -1 ||
        cmbHinicio.SelectedIndex == -1 ||
        cmbHfin.SelectedIndex == -1 ||
        cmbDlibre.SelectedIndex == -1)
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var diaSemanaMap = new Dictionary<string, int>
                {
                                { "Lunes", 1 },
                                { "Martes", 2 },
                                { "Miércoles", 3 },
                                { "Jueves", 4 },
                                { "Viernes", 5 },
                                { "Sabado", 6 },
                                { "Domingo", 7 }
                };

           



            // Crear objeto para la base de datos
            var horario = new CatalogoHorarios
            {
                NombreHorario = cmbNombreHorario.Text,
                DiaSemanaInicio = diaSemanaMap.ContainsKey(cmbDinicio.SelectedItem?.ToString()) ? diaSemanaMap[cmbDinicio.SelectedItem.ToString()] : 0,
                DiaSemanaFin = diaSemanaMap.ContainsKey(cmbDfin.SelectedItem?.ToString()) ? diaSemanaMap[cmbDfin.SelectedItem.ToString()] : 0,
                HoraInicio = TimeSpan.TryParse(cmbHinicio.SelectedItem?.ToString(), out TimeSpan horaInicio) ? horaInicio : TimeSpan.Zero,
                HoraFin = TimeSpan.TryParse(cmbHfin.SelectedItem?.ToString(), out TimeSpan horaFin) ? horaFin : TimeSpan.Zero,
                DiaLibre = cmbDlibre.SelectedItem?.ToString() ?? "", // Evita null
                Activo = true,
                FechaCreacion = DateTime.Now,
                CreadoPor = "Admin" // Puedes cambiar esto según el usuario autenticado
            };

            // Insertar en la base de datos usando la DAL
            var resultado = DAL_CatalogoHorarios.Insert(horario);

            if (resultado != null)
            {
                MessageBox.Show("Horario guardado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarHorarios(); // Refrescar la lista de horarios
            }
            else
            {
                MessageBox.Show("Error al guardar el horario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            dataGridView1.AutoGenerateColumns = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Después de modificar, insertar o eliminar un horario
            dataGridView1.DataSource = null; // Desvincula la fuente de datos
            dataGridView1.DataSource = DAL_CatalogoHorarios.Listar(); // Asigna nuevamente la fuente de datos
            
            dataGridView1.Refresh(); // Refresca el DataGridView visualmente

        }

        

        private void btnAnular_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtener el ID del horario seleccionado en la columna "CatalogoHorarioId"
                int idHorario = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["CatalogoHorarioId"].Value);

                // Crear una instancia del objeto con el ID del horario
                var horario = new CatalogoHorarios { CatalogoHorarioId = idHorario };

                // Confirmación antes de anular
                DialogResult result = MessageBox.Show("¿Está seguro de anular este horario?", "Confirmación",
                                                      MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Llamar al método de la DAL para marcar el horario como inactivo
                    bool exito = DAL_CatalogoHorarios.Delete(horario);

                    if (exito)
                    {
                        MessageBox.Show("Horario anulado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarHorarios(); // Recargar los horarios en la tabla
                    }
                    else
                    {
                        MessageBox.Show("Error al anular el horario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un horario para anular.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
