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
    public partial class frm_Articulos : Form
    {
        public frm_Articulos()
        {
            InitializeComponent();
        }

        bool camposCompletados = false;
        bool modoActualizar = false;
        int numArticulo = 0;

        #region MisMetodos
        private void crearArticulo()
        {
            using (var db = new dbpedidosEntities())
            {
                try
                {
                    Articulo oArticulo = new Articulo();
                    oArticulo.descripcion_articulo = txtDescripcionArticulo.Text.Trim();

                    db.Articulos.Add(oArticulo);
                    db.SaveChanges();

                    MessageBox.Show("Articulo guardado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void actualizarArticulo(int numeroArticulo)
        {
            using (var db = new dbpedidosEntities())
            {
                try
                {
                    Articulo oArticulo = db.Articulos.Find(numArticulo);
                    oArticulo.descripcion_articulo = txtDescripcionArticulo.Text.Trim();
                    db.SaveChanges();
                    MessageBox.Show("Actualizado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void cargarDatosEnGrid()
        {
            List<ArticulosViewModel> lstArticulos = new List<ArticulosViewModel>();
            using (var db = new dbpedidosEntities())
            {
                try
                {
                    lstArticulos = (from a in db.Articulos
                                    select new ArticulosViewModel
                                    {
                                        numero_articulo = a.numero_de_articulo,
                                        descripcion = a.descripcion_articulo
                                    }).ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                dtgArticulos.DataSource = lstArticulos;                
            }
        }
        private void verificarCamposVacios()
        {
            if (txtDescripcionArticulo.Text.Trim() == "")
            {
                MessageBox.Show("Descripción es requerida","Faltan datos",MessageBoxButtons.OK,MessageBoxIcon.Information);
                txtDescripcionArticulo.Focus();
            }
            else
            {
                camposCompletados = true;
            }
        }
        private void reiniciarFormulario()
        {
            txtDescripcionArticulo.Text = "";
            txtDescripcionArticulo.Enabled = false;

            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnModificar.Enabled = false;
            btnCancelar.Enabled = false;

            camposCompletados = false;
            modoActualizar = false;

        }
        #endregion

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtDescripcionArticulo.Enabled = true;
            
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnModificar.Enabled = false;
            btnCancelar.Enabled = true;

            modoActualizar = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            verificarCamposVacios();
            if (modoActualizar == true)
            {
                actualizarArticulo(numArticulo);
                reiniciarFormulario();
                cargarDatosEnGrid();
            }
            else
            {
                crearArticulo();
                reiniciarFormulario();
                cargarDatosEnGrid();
            }
        }

        private void frm_Articulos_Load(object sender, EventArgs e)
        {
            cargarDatosEnGrid();
        }

        private void dtgArticulos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            numArticulo = Convert.ToInt32(dtgArticulos.Rows[dtgArticulos.CurrentRow.Index].Cells[0].Value);
            if (numArticulo > 0)
            {
                txtDescripcionArticulo.Text = dtgArticulos.Rows[dtgArticulos.CurrentRow.Index].Cells[1].Value.ToString();

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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            modoActualizar = true;
            txtDescripcionArticulo.Enabled = true;
            btnModificar.Enabled = false;
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
        }
    }
}
