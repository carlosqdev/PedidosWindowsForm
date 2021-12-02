using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pedidos
{
    public partial class Frm_MenuPrincipal : Form
    {
        public Frm_MenuPrincipal()
        {
            InitializeComponent();
        }

        private void verTodosLosClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_AdministrarClientes frmClientes = new frm_AdministrarClientes();
            frmClientes.Show();
        }

        private void verTodasLasFabricasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Fabricas frmFabricas = new frm_Fabricas();
            frmFabricas.Show();
        }
    }
}
