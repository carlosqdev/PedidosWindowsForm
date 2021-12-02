using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pedidos.Datos;
using Pedidos.ViewModel;

namespace Pedidos
{
    public partial class frm_AdministrarPedidos : Form
    {
        public frm_AdministrarPedidos()
        {
            InitializeComponent();
        }

        int idPedido = 0;

        private void cargarPedidos()
        {
            List<PedidosViewModel> lstPedidos = new List<PedidosViewModel>();

            using (var db = new dbpedidosEntities())
            {
                try
                {
                    lstPedidos = (from p in db.Pedidos
                                  from c in db.Clientes
                                  from d in db.DireccionesClientes
                                  where p.numero_de_cliente == c.numero_de_cliente
                                  where p.id_direccion == d.id_direccion
                                  select new PedidosViewModel
                                  {
                                      id_Pedido = p.id_pedido,
                                      numero_cliente = p.numero_de_cliente,
                                      cliente = c.nombre_cliente,
                                      direccion = d.calle + " " + d.barrio + " " + d.distrito,
                                      fecha_pedido = p.fecha_pedido
                                  }).ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                dtgPedidos.DataSource = lstPedidos;
            }
        }

        private void frm_AdministrarPedidos_Load(object sender, EventArgs e)
        {
            cargarPedidos();
        }

        private void btnCrearPedido_Click(object sender, EventArgs e)
        {
            frm_CrearPedidos frmCrear = new frm_CrearPedidos();
            frmCrear.ShowDialog();
            cargarPedidos();
        }

        private void btnVerDetalles_Click(object sender, EventArgs e)
        {
            frm_DetallesPedidos frmDetalles = new frm_DetallesPedidos();
            frmDetalles.numPedido = idPedido;
            frmDetalles.ShowDialog();
            btnVerDetalles.Enabled = false;
        }

        private void dtgPedidos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idPedido = Convert.ToInt32(dtgPedidos.Rows[dtgPedidos.CurrentRow.Index].Cells[0].Value.ToString());
            if (idPedido > 0)
            {
                btnVerDetalles.Enabled = true;
            }
        }
    }
}
