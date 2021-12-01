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
    public partial class frm_Cliente : Form
    {
        public frm_Cliente()
        {
            InitializeComponent();
        }

        bool camposCompletos = false;
        bool existenDirecciones = false;
        public int numCliente = 0;

        private void guardarCliente()
        {
            using (dbpedidosEntities db = new dbpedidosEntities())
            {
                using (var dbContextTransaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        Cliente oCliente = new Cliente();
                        oCliente.nombre_cliente = txtNombre.Text;
                        oCliente.saldo = 0;
                        oCliente.limite_de_credito = Convert.ToDecimal(txtLimiteCredito.Text);
                        oCliente.descuento = Convert.ToDecimal(txtDescuento.Text);                        

                        db.Clientes.Add(oCliente);
                        db.SaveChanges();

                        foreach (DataGridViewRow dr in dtgDirecciones.Rows)
                        {
                            DireccionesCliente oDireccion = new DireccionesCliente();
                            oDireccion.numero_de_cliente = oCliente.numero_de_cliente;
                            oDireccion.calle = Convert.ToString(dr.Cells[0].Value);
                            oDireccion.barrio = Convert.ToString(dr.Cells[1].Value);
                            oDireccion.distrito = Convert.ToString(dr.Cells[2].Value);

                            db.DireccionesClientes.Add(oDireccion);
                        }
                        db.SaveChanges();

                        dbContextTransaction.Commit();
                        MessageBox.Show("Cliente guardado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        dbContextTransaction.Rollback();
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void actualizarCliente()
        {
            using (var db = new dbpedidosEntities())
            {
                try
                {
                    Cliente oCliente = db.Clientes.Find(numCliente);
                    if (oCliente != null)
                    {
                        oCliente.nombre_cliente = txtNombre.Text.Trim();
                        oCliente.limite_de_credito = Convert.ToDecimal(txtLimiteCredito.Text.Trim());
                        oCliente.descuento = Convert.ToDecimal(txtDescuento.Text.Trim());

                        db.SaveChanges();
                        MessageBox.Show("Cliente actualizado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buscarCliente()
        {
            List<ClientesViewModel> lstCliente = new List<ClientesViewModel>();

            using (var db = new dbpedidosEntities())
            {
                try
                {
                    lstCliente = (from c in db.Clientes
                                  where c.numero_de_cliente == numCliente
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
                foreach (var client in lstCliente)
                {
                    txtNombre.Text = client.nombres.ToString();
                    txtLimiteCredito.Text = client.limite_credito.ToString();
                    txtDescuento.Text = client.descuento.ToString();
                }
            }
        }

        private void verificarCamposVacios()
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Debe escribir un nombre", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNombre.Focus();
            }
            else if (txtLimiteCredito.Text == "")
            {
                MessageBox.Show("Debe escribir un limite de credito", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLimiteCredito.Focus();
            }
            else if (txtDescuento.Text == "")
            {
                MessageBox.Show("Debe escribir la cantidad de descuento", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDescuento.Focus();
            }
            else if (existenDirecciones == false)
            {
                MessageBox.Show("Debe registrar una dirección minimo", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                camposCompletos = true;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            verificarCamposVacios();
            if (camposCompletos == true)
            {
                guardarCliente();
                DialogResult = DialogResult.OK;
            }
        }

        private void btnAgregarDireccion_Click(object sender, EventArgs e)
        {

            if (txtCalle.Text == "")
            {
                MessageBox.Show("El campo calle es requerido.", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCalle.Focus();
            }
            else if (txtBarrio.Text == "")
            {
                MessageBox.Show("El campo barrio es requerido.", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBarrio.Focus();
            }
            else if (txtDistrito.Text == "")
            {
                MessageBox.Show("El campo distrito es requerido.", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDistrito.Focus();
            }
            else
            {
                string calle = txtCalle.Text;
                string barrio = txtBarrio.Text;
                string distrito = txtDistrito.Text;
                dtgDirecciones.Rows.Add(new object[] { calle, barrio, distrito, "Eliminar" });

                txtCalle.Text = "";
                txtBarrio.Text = "";
                txtDistrito.Text = "";
                existenDirecciones = true;                  
            }
            
        }

        private void dtgDirecciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != dtgDirecciones.Columns["Op"].Index)
                    return;

            dtgDirecciones.Rows.RemoveAt(e.RowIndex);
            
        }

        private void frm_Cliente_Load(object sender, EventArgs e)
        {
            if (numCliente > 0)
            {
                buscarCliente();
                groupBoxDirecciones.Visible = false;
                btnGuardar.Visible = false;
                btnActualizar.Visible = true;
                existenDirecciones = true;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            verificarCamposVacios();
            if (camposCompletos == true)
            {
                actualizarCliente();
                DialogResult = DialogResult.OK;
            }
        }
    }
}
