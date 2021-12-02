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

        private void verTodosLosPedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_AdministrarPedidos frmPedidos = new frm_AdministrarPedidos();
            frmPedidos.Show();
        }

        private void verTodosLosArticulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Articulos frmArticulo = new frm_Articulos();
            frmArticulo.Show();
        }

        private void asociarArticulosAFabricasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_AsociarArticulosConFabricas frmAsociar = new frm_AsociarArticulosConFabricas();
            frmAsociar.Show();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmReporteClientes rptClientes = new frmReporteClientes();
            rptClientes.Show();
        }

        private void fabricasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmReporteFabricas rptFabricas = new frmReporteFabricas();
            rptFabricas.Show();
        }

        private void articulosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmReporteArticulos rptArticulos = new frmReporteArticulos();
            rptArticulos.Show();
        }

        private void pedidosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
