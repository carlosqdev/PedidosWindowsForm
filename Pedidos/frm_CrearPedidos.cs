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

        int numeroCliente = 0;
        int idDireccion = 0;

        private void CargarComboCliente()
        {
            List<ClienteViewModel> lstClientes = new List<ClienteViewModel>();

            using (dbpedidosEntities database = new dbpedidosEntities())
            {
                try
                {
                    lstClientes = (from d in database.Clientes
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
            comboClientes.DataSource = lstClientes;
            comboClientes.ValueMember = "cod";
            comboClientes.DisplayMember = "nombreCompleto";
        }

        private void CargarDireccionesCliente(int codigoCliente)
        {
            List<DireccionesViewModel> lstDirecciones = new List<DireccionesViewModel>();

            using (dbpedidosEntities database = new dbpedidosEntities())
            {
                try
                {
                    lstDirecciones = (from d in database.DireccionesClientes
                                      where d.numero_de_cliente == codigoCliente
                                      select new DireccionesViewModel
                                      {
                                          id_direccion = d.id_direccion,
                                          numero_cliente = d.numero_de_cliente,
                                          direccion = d.calle+" "+d.barrio+" "+d.distrito
                                      }).ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Ocurrio un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dtgvDirecciones.DataSource = lstDirecciones;
            }
        }
        private void frm_CrearPedidos_Load(object sender, EventArgs e)
        {
            CargarComboCliente();
        }

        private void btnAgregarArticulo_Click(object sender, EventArgs e)
        {
            //mas tarde lo ocupo
        }

        private void comboClientes_SelectionChangeCommitted(object sender, EventArgs e)
        {
            numeroCliente = Convert.ToInt32(comboClientes.SelectedValue);
            if (numeroCliente > 0)
            {
                CargarDireccionesCliente(numeroCliente);
            }
        }

        private void dtgvDirecciones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idDireccion = int.Parse(dtgvDirecciones.Rows[dtgvDirecciones.CurrentRow.Index].Cells[0].Value.ToString());
            if (idDireccion > 0)
            {
                txtIdDireccion.Text = Convert.ToString(dtgvDirecciones.Rows[dtgvDirecciones.CurrentRow.Index].Cells[0].Value);
                txtDireccionEnvio.Text = Convert.ToString(dtgvDirecciones.Rows[dtgvDirecciones.CurrentRow.Index].Cells[2].Value);
            }
        }
    }
}
