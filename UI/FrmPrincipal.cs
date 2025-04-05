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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            this.Hide(); // Oculta el formulario principal
            AdmonClientes frmClientes = new AdmonClientes();
            frmClientes.ShowDialog();  // Abre el formulario de clientes y espera a que se cierre
            this.Show(); // Muestra nuevamente el formulario principal cuando se cierre el otro
        }

        private void btnServicios_Click(object sender, EventArgs e)
        {
            this.Hide(); // Oculta el formulario principal
            AdmonServicios frmServicios = new AdmonServicios();
            frmServicios.ShowDialog(); // Abre el formulario de servicios y espera a que se cierre
            this.Show(); // Muestra nuevamente el formulario principal cuando se cierre el otro
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnHorarios_Click(object sender, EventArgs e)
        {
            this.Hide(); // Oculta el formulario principal
            AdmonCatalogoHorario frmCatalogoHorario = new AdmonCatalogoHorario();
            frmCatalogoHorario.ShowDialog(); // Abre el formulario de horarios y espera a que se cierre
            this.Show(); // Muestra nuevamente el formulario principal cuando se cierre el otro
        }

        private void btnAdmon_Click(object sender, EventArgs e)
        {
            this.Hide(); // Oculta el formulario principal
            FrmConfiguracion gestionAdminForm = new FrmConfiguracion();
            gestionAdminForm.ShowDialog(); // Abre el formulario de configuración y espera a que se cierre
            this.Show(); // Muestra nuevamente el formulario principal cuando se cierre el otro
        }

        private void btnConfigAdmin_Click(object sender, EventArgs e)
        {
            this.Hide(); // Oculta el formulario principal
            FrmConfiguracion gestionAdminForm = new FrmConfiguracion();

            // Mostrar el formulario y esperar a que se cierre
            gestionAdminForm.ShowDialog();

            this.Show(); // Muestra nuevamente el formulario principal al cerrar el otro formulario
        }

        private void btnCitas_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmCitas formCitas = new FrmCitas();
            formCitas.ShowDialog();  // Mostrar como modal
            this.Show();             // Mostrar FrmPrincipal al cerrar FrmCitas
        }
    }
}
