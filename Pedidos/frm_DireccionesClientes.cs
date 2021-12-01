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
    public partial class frm_DireccionesClientes : Form
    {
        public frm_DireccionesClientes()
        {
            InitializeComponent();
        }

        public int numCliente = 0;
        int idDireccion = 0;
        bool camposCompletados = false;
        bool banderaActualizar = false;

        private void cargarDirecciones()
        {
            List<DireccionesClientesViewModel> lstDirecciones = new List<DireccionesClientesViewModel>();

            using (var db = new dbpedidosEntities())
            {
                try
                {
                    lstDirecciones = (from d in db.DireccionesClientes
                                      where d.numero_de_cliente == numCliente
                                      select new DireccionesClientesViewModel
                                      {
                                          id_direccion = d.id_direccion,
                                          numero_de_cliente = d.numero_de_cliente,
                                          calle = d.calle,
                                          barrio = d.barrio,
                                          distrito = d.distrito
                                      }).ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dtgDirecciones.Rows.Clear();
                foreach (var direccion in lstDirecciones)
                {
                    dtgDirecciones.Rows.Add(new object[] { direccion.calle, direccion.barrio, direccion.distrito, direccion.id_direccion });
                }
            }
        }

        private void crearDireccion()
        {
            using (var db = new dbpedidosEntities())
            {
                try
                {
                    DireccionesCliente oDireccion = new DireccionesCliente();
                    oDireccion.numero_de_cliente = numCliente;
                    oDireccion.calle = txtCalle.Text.Trim();
                    oDireccion.barrio = txtBarrio.Text.Trim();
                    oDireccion.distrito = txtDistrito.Text.Trim();

                    db.DireccionesClientes.Add(oDireccion);
                    db.SaveChanges();
                    MessageBox.Show("Dirección creada correctamente","Exito",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    limpiarFormulario();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }
        private void actualizarDireccion()
        {
            using (var db = new dbpedidosEntities())
            {
                try
                {
                    DireccionesCliente oDireccion = db.DireccionesClientes.Find(idDireccion);
                    if (oDireccion != null)
                    {
                        oDireccion.calle = txtCalle.Text.Trim();
                        oDireccion.barrio = txtBarrio.Text.Trim();
                        oDireccion.distrito = txtDistrito.Text.Trim();

                        db.SaveChanges();
                        MessageBox.Show("Dirección actualizada", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiarFormulario();
                        banderaActualizar = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void verificarCamposVacios()
        {
            if (txtBarrio.Text.Trim() == "")
            {
                MessageBox.Show("Barrio es un campo requerido", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBarrio.Focus();
            }
            else if (txtCalle.Text.Trim() == "")
            {
                MessageBox.Show("Calle es un campo requerido", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCalle.Focus();
            }
            else if (txtDistrito.Text.Trim() == "")
            {
                MessageBox.Show("Distrito es un campo requerido", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDistrito.Focus();
            }
            else
            {
                camposCompletados = true;
            }
        }

        private void limpiarFormulario()
        {
            txtCalle.Text = "";
            txtBarrio.Text = "";
            txtDistrito.Text = "";

            txtCalle.Enabled = false;
            txtBarrio.Enabled = false;
            txtDistrito.Enabled = false;

            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
        }

        private void frm_DireccionesClientes_Load(object sender, EventArgs e)
        {
            cargarDirecciones();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            verificarCamposVacios();
            if (camposCompletados == true)
            {
                if (banderaActualizar == true)
                {
                    actualizarDireccion();
                    cargarDirecciones();
                }
                else
                {
                    crearDireccion();
                    cargarDirecciones();
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            txtCalle.Enabled = true;
            txtBarrio.Enabled = true;
            txtDistrito.Enabled = true;
            txtCalle.Focus();
            banderaActualizar = false;
        }

        private void dtgDirecciones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idDireccion = int.Parse(dtgDirecciones.Rows[dtgDirecciones.CurrentRow.Index].Cells[3].Value.ToString());
            if (idDireccion > 0)
            {
                txtCalle.Text = dtgDirecciones.Rows[dtgDirecciones.CurrentRow.Index].Cells[0].Value.ToString();
                txtBarrio.Text = dtgDirecciones.Rows[dtgDirecciones.CurrentRow.Index].Cells[1].Value.ToString();
                txtDistrito.Text = dtgDirecciones.Rows[dtgDirecciones.CurrentRow.Index].Cells[2].Value.ToString();

                txtBarrio.Enabled = true;
                txtCalle.Enabled = true;
                txtDistrito.Enabled = true;
                btnNuevo.Enabled = false;
                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;
                banderaActualizar = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
