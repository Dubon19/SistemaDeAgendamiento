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

        private void AdmonClientes_Load(object sender, EventArgs e)
        {
            try
            {
                List<Clientes> listaClientes = DAL_Clientes.Listar();
                MessageBox.Show($"Clientes encontrados: {listaClientes.Count}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

    }
}
