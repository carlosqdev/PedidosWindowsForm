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
    public partial class frm_CrearPedidos : Form
    {
        public frm_CrearPedidos()
        {
            InitializeComponent();
        }

        private void CargarComboCliente()
        {
            List<ClienteViewModel> lstEmployed = new List<ClienteViewModel>();

            using (dbpedidosEntities database = new dbpedidosEntities())
            {
                try
                {
                    lstEmployed = (from d in database.Clientes
                                   select new ClienteViewModel
                                   {
                                       cod = d.numero_de_cliente,
                                       nombreCompleto = d.nombre_cliente
                                   }).ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Ocurrio un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            comboClientes.DataSource = lstEmployed;
            comboClientes.ValueMember = "cod";
            comboClientes.DisplayMember = "nombreCompleto";
        }
        private void frm_CrearPedidos_Load(object sender, EventArgs e)
        {
            CargarComboCliente();
        }
    }
}
