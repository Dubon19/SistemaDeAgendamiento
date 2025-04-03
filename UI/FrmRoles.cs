using DAL;
using EL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class FrmRoles : Form
    {
        public FrmRoles()
        {
            InitializeComponent();
        }

        private void FrmRoles_Load(object sender, EventArgs e)
        {

        }

        public List<Roles> ListarRoles()
        {
            using (var context = new DBGestionCita()) // TuDbContext es tu contexto de base de datos
            {
                return context.Roles.ToList();
            }
        }

        public void CargarRoles()
        {
            // Obtener los roles desde la base de datos
            List<Roles> roles = DAL_Roles.Listar();

            // Suponiendo que tienes un DataGridView llamado 'dataGridRoles'
            gridRoles.DataSource = roles;  // Enlaza la lista de roles al DataGridView
        }



        public void AgregarRol(Roles nuevoRol)
        {
            using (var context = new DBGestionCita())
            {
                context.Roles.Add(nuevoRol);
                context.SaveChanges();
            }
        }

        public List<Roles> ObtenerRoles()
        {
            using (var context = new DBGestionCita())
            {
                return context.Roles.ToList();  // Obtener todos los roles
            }
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbNombre.Text))
            {
                MessageBox.Show("El nombre del rol no puede estar vacío.");
                return;
            }

            Roles nuevoRol = new Roles
            {
                Nombre = cmbNombre.Text,
                Activo = true,  // Asegúrate de que 'Activo' esté bien asignado
                FechaCreacion = DateTime.Now,
                CreadoPor = "UsuarioActual", // Cambiar por el nombre del usuario actual
            };

            DAL_Roles.Insert(nuevoRol); // Llamar a DAL_Roles.Insert en lugar de DAL_Roles.AgregarRol
            MessageBox.Show("Rol agregado exitosamente.");
            CargarRoles();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbNombre.Text))
            {
                MessageBox.Show("El nombre del rol no puede estar vacío.");
                return;
            }

            // Obtén el rol existente y actualízalo
            Roles rolExistente = new Roles
            {
                
                Nombre = cmbNombre.Text,
                
                FechaModificacion = DateTime.Now,
                ModificadoPor = "UsuarioActual" // Cambiar por el nombre del usuario actual
            };

            DAL_Roles.Update(rolExistente);  // Llamar a DAL_Roles.Update para actualizar el rol
            MessageBox.Show("Rol modificado exitosamente.");
            CargarRoles();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Asegúrate de que se haya seleccionado un rol
            if (gridRoles.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona un rol para eliminar.");
                return;
            }

            // Obtener el ID del rol seleccionado
            int rolId = Convert.ToInt32(gridRoles.SelectedRows[0].Cells["RolId"].Value);

            // Crear el objeto 'Roles' con el ID del rol
            Roles rolAEliminar = new Roles { RolId = rolId };

            // Eliminar el rol
            bool resultado = DAL_Roles.Delete(rolAEliminar);

            if (resultado)
            {
                MessageBox.Show("Rol eliminado exitosamente.");
                CargarRoles(); // Refrescar el DataGridView
            }
            else
            {
                MessageBox.Show("No se pudo eliminar el rol.");
            }

        }
    }
}
