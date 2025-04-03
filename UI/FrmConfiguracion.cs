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
    public partial class FrmConfiguracion : Form
    {
        public FrmConfiguracion()
        {
            InitializeComponent();
        }

        private void FrmConfiguracion_Load(object sender, EventArgs e)
        {

        }

        private void btnRoles_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Crea una instancia del formulario FrmRoles
            FrmRoles frmRoles = new FrmRoles();

            // Suscríbete al evento FormClosed del formulario FrmRoles para mostrar el formulario de Gestión de Administrador cuando FrmRoles se cierre
            frmRoles.FormClosed += (s, args) => this.Show();

            // Muestra el formulario FrmRoles
            frmRoles.Show();
        }
    }
}
