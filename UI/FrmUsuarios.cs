using DAL;
using EL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
            CargarRoles();
            CargarUsuarios();
        }

        private void CargarRoles()
        {
            cmbRol.DataSource = DAL_Roles.Listar();
            cmbRol.DisplayMember = "Nombre";
            cmbRol.ValueMember = "RolId";
        }

        private void CargarUsuarios()
        {
            var usuarios = DAL_Usuarios.Listar();
            var usuariosSinContrasena = usuarios.Select(u => new
            {
                u.UsuarioId,
                u.Usuario,
                u.RolId,
                u.Activo
            }).ToList();

            gridUsuarios.DataSource = usuariosSinContrasena;
        }


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = string.Empty;
            txtPassword.Text = string.Empty;
            cmbRol.SelectedIndex = -1;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtUsuario.Text) && !string.IsNullOrWhiteSpace(txtPassword.Text) && cmbRol.SelectedIndex != -1)
            {
                // ✅ Encriptar la contraseña correctamente usando SHA-256
                byte[] contrasenaBytes = DAL_Usuarios.EncriptarContrasena(txtPassword.Text);

                // Crear un nuevo objeto Usuario
                Usuarios usuario = new Usuarios
                {
                    Usuario = txtUsuario.Text,
                    Contrasena = contrasenaBytes,
                    RolId = Convert.ToInt32(cmbRol.SelectedValue)
                };

                var usuarioInsertado = DAL_Usuarios.Insert(usuario);
                CargarUsuarios();
                this.Close();

                FrmEmpleados frmEmpleados = new FrmEmpleados(usuarioInsertado.UsuarioId);
                frmEmpleados.Show();

            }
            else
            {
                MessageBox.Show("Complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btnAnular_Click(object sender, EventArgs e)
        {
            if (gridUsuarios.SelectedRows.Count > 0)
            {
                // Convertir correctamente el valor de la celda (que es un string) a int
                int usuarioId = Convert.ToInt32(gridUsuarios.SelectedRows[0].Cells["UsuarioId"].Value);

                // Pasar el usuarioId como int al método Delete
                DAL_Usuarios.Delete(usuarioId);

                CargarUsuarios();
            }
            else
            {
                MessageBox.Show("Seleccione un usuario para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void gridUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

    }
}
