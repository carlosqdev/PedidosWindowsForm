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
    public partial class frm_AdministrarClientes : Form
    {
        public frm_AdministrarClientes()
        {
            InitializeComponent();
        }

        #region
        private void cargarClientes()
        {
            List<ClientesViewModel> lstClientes = new List<ClientesViewModel>();

            using (var db = new dbpedidosEntities())
            {
                try
                {
                    lstClientes = (from c in db.Clientes
                                   select new ClientesViewModel
                                   {
                                       numero = c.numero_de_cliente,
                                       nombres = c.nombre_cliente,
                                       saldo = c.saldo,
                                       limite_credito = c.limite_de_credito,
                                       descuento = c.descuento
                                   }).ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dtgClientes.DataSource = lstClientes;
            }

        }
        #endregion

        private void frm_AdministrarClientes_Load(object sender, EventArgs e)
        {
            cargarClientes();
        }

        private void dtgClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            frm_Cliente frmCliente = new frm_Cliente();
            frmCliente.ShowDialog();
            cargarClientes();
        }
    }
}
