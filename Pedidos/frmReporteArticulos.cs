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
    public partial class frmReporteArticulos : Form
    {
        public frmReporteArticulos()
        {
            InitializeComponent();
        }

        private void frmReporteArticulos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dbpedidosDataSet.Articulos' Puede moverla o quitarla según sea necesario.
            this.ArticulosTableAdapter.Fill(this.dbpedidosDataSet.Articulos);

            this.reportViewer1.RefreshReport();
        }
    }
}
