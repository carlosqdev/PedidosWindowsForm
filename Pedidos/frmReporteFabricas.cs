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
    public partial class frmReporteFabricas : Form
    {
        public frmReporteFabricas()
        {
            InitializeComponent();
        }

        private void frmReporteFabricas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dbpedidosDataSet.Fabricas' Puede moverla o quitarla según sea necesario.
            this.FabricasTableAdapter.Fill(this.dbpedidosDataSet.Fabricas);

            this.reportViewer1.RefreshReport();
        }
    }
}
