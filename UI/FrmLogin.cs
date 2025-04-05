using DAL;
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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text; // Campo de usuario
            string contrasena = txtPassword.Text; // Campo de contraseña

            // Llamamos al método de validación en el DAL (Data Access Layer)
            bool esValido = DAL_Usuarios.ValidarUsuario(usuario, contrasena);

            if (esValido)
            {
                // Si es válido, redirigimos al formulario principal
                FrmPrincipal frmPrincipal = new FrmPrincipal();
                frmPrincipal.Show();
                this.Hide(); // Ocultamos el formulario de login
            }
            else
            {
                // Si no es válido, mostramos un mensaje de error
                MessageBox.Show("Usuario o contraseña incorrectos.");
            }

        }
    }
}
