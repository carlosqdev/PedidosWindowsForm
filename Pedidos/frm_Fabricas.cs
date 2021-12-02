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
    public partial class frm_Fabricas : Form
    {
        public frm_Fabricas()
        {
            InitializeComponent();
        }

        int idFabrica = 0;
        bool camposCompletados = false;
        bool modoActualizar = false;

        #region Metodos
        private void cargarFabricas()
        {
            List<FabricasViewModel> lstFabricas = new List<FabricasViewModel>();
            using (var db = new dbpedidosEntities())
            {
                try
                {
                    lstFabricas = (from f in db.Fabricas
                                   select new FabricasViewModel 
                                   { 
                                       id_fabrica = f.id_fabrica, 
                                       nombre_fabrica = f.nombre_fabrica, 
                                       numero_telefono = f.numero_telefono 
                                   }).ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dtgFabricas.DataSource = lstFabricas;
            }
        }
        private void crearFabrica()
        {
            using (var db = new dbpedidosEntities())
            {
                try
                {
                    Fabrica oFabrica = new Fabrica();
                    oFabrica.nombre_fabrica = txtNombre.Text.Trim();
                    oFabrica.numero_telefono = txtTelefono.Text.Trim();

                    db.Fabricas.Add(oFabrica);
                    db.SaveChanges();
                    MessageBox.Show("Fabrica guardada correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }
        private void actualizarFabrica(int idFabrica)
        {
            using (var db = new dbpedidosEntities())
            {
                try
                {
                    Fabrica oFabrica = db.Fabricas.Find(idFabrica);
                    if (oFabrica != null)
                    {
                        oFabrica.nombre_fabrica = txtNombre.Text.Trim();
                        oFabrica.numero_telefono = txtTelefono.Text.Trim();

                        db.SaveChanges();
                        MessageBox.Show("Fabrica actualizada correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (txtNombre.Text.Trim() == "")
            {
                MessageBox.Show("Nombre es requerido", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNombre.Focus();
            }
            else if (txtTelefono.Text.Trim() == "")
            {
                MessageBox.Show("Teléfono es requerido", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTelefono.Focus();
            }
            else
            {
                camposCompletados = true;
            }
        }
        private void reiniciarFormulario()
        {
            txtNombre.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            
            txtNombre.Enabled = false;
            txtTelefono.Enabled = false;

            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnModificar.Enabled = false;
            btnCancelar.Enabled = false;

            idFabrica = 0;
            camposCompletados = false;
            modoActualizar = false;

        }
        #endregion

        private void frm_Fabricas_Load(object sender, EventArgs e)
        {
            cargarFabricas();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtNombre.Enabled = true;
            txtNombre.Focus();
            txtTelefono.Enabled = true;
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnModificar.Enabled = false;
            btnCancelar.Enabled = true;
            modoActualizar = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            verificarCamposVacios();
            if (camposCompletados == true)
            {
                if (modoActualizar == true)
                {
                    actualizarFabrica(idFabrica);
                    reiniciarFormulario();
                    cargarFabricas();
                }
                else
                {
                    crearFabrica();
                    reiniciarFormulario();
                    cargarFabricas();
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            txtNombre.Enabled = true;
            txtNombre.Focus();
            txtTelefono.Enabled = true;

            modoActualizar = true;
            btnModificar.Enabled = false;
            btnGuardar.Enabled = true;
        }

        private void dtgFabricas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idFabrica = Convert.ToInt32(dtgFabricas.Rows[dtgFabricas.CurrentRow.Index].Cells[0].Value.ToString());
            if (idFabrica > 0)
            {
                txtNombre.Text = dtgFabricas.Rows[dtgFabricas.CurrentRow.Index].Cells[1].Value.ToString();
                txtTelefono.Text = dtgFabricas.Rows[dtgFabricas.CurrentRow.Index].Cells[2].Value.ToString();

                btnNuevo.Enabled = false;
                btnGuardar.Enabled = false;
                btnModificar.Enabled = true;
                btnCancelar.Enabled = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            reiniciarFormulario();
        }
    }
}
