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
            //TODO
            using (var db = new dbpedidosEntities())
            {
                try
                {
                    //TODO
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion

        private void frm_DetallesPedidos_Load(object sender, EventArgs e)
        {
            if (numPedido > 0)
            {
                //Buscar detalles del pedido                
            }
        }
    }
}
