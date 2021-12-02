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
    public partial class frm_DetallesPedidos : Form
    {
        public frm_DetallesPedidos()
        {
            InitializeComponent();
        }

        public int numPedido = 0;

        #region MisMetodos
        private void cargarDetalle()
        {
            List<DetallePedidoViewModel> lstDetalle = new List<DetallePedidoViewModel>();
            using (var db = new dbpedidosEntities())
            {
                try
                {
                    lstDetalle = (from dp in db.DetallesDePedidos
                                  from a in db.Articulos
                                  from f in db.Fabricas
                                  where dp.numero_de_articulo == a.numero_de_articulo
                                  where dp.id_fabrica == f.id_fabrica
                                  where dp.id_pedido == numPedido
                                  select new DetallePedidoViewModel
                                  {
                                      idPedido = dp.id_pedido,
                                      fabrica = f.nombre_fabrica,
                                      numeroDeArticulo = dp.numero_de_articulo,
                                      nombreArticulo = a.descripcion_articulo,
                                      cantidad = dp.cantidad
                                  }).ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dtgDetalle.DataSource = lstDetalle;
            }
        }
        #endregion

        private void frm_DetallesPedidos_Load(object sender, EventArgs e)
        {
            if (numPedido > 0)
            {
                cargarDetalle();               
            }
        }
    }
}
