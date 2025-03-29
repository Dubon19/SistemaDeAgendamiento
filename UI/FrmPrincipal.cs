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
            AdmonClientes frmClientes = new AdmonClientes();
            frmClientes.Show();  
        }

        private void btnServicios_Click(object sender, EventArgs e)
        {
            AdmonServicios frmServicios = new AdmonServicios();
            frmServicios.Show();

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnHorarios_Click(object sender, EventArgs e)
        {
            AdmonCatalogoHorario frmCatalogoHorario = new AdmonCatalogoHorario();
            frmCatalogoHorario.Show();
        }
    }
}
