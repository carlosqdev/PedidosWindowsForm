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
    public partial class frm_AsociarArticulosConFabricas : Form
    {
        public frm_AsociarArticulosConFabricas()
        {
            InitializeComponent();
        }

        int idFabrica = 0;
        int numArticulo = 0;

        #region misMetodos
        private void reiniciarFormulario()
        {
            comboFabricas.Enabled = false;
            comboArticulo.Enabled = false;
            numericExistencia.Enabled = false;
            btnAgregar.Enabled = true;
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;

            idFabrica = 0;
            numArticulo = 0;
        }       
        private void guardarAsociacion()
        {
            using (var db = new dbpedidosEntities())
            {
                try
                {
                    ArticulosEnFabrica oAsociar = new ArticulosEnFabrica();
                    oAsociar.id_fabrica = Convert.ToInt32(comboFabricas.SelectedValue);
                    oAsociar.numero_de_articulo = Convert.ToInt32(comboArticulo.SelectedValue);
                    oAsociar.existencia = Convert.ToInt32(numericExistencia.Value);

                    db.ArticulosEnFabricas.Add(oAsociar);
                    db.SaveChanges();
                    MessageBox.Show("Guardado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void cargarDatosEnGrid()
        {
            List<ArticulosAsociadosViewModel> lstArticulo = new List<ArticulosAsociadosViewModel>();
            using (var db = new dbpedidosEntities())
            {
                try
                {
                    lstArticulo = (from af in db.ArticulosEnFabricas
                                   from f in db.Fabricas
                                   from a in db.Articulos
                                   where af.id_fabrica == f.id_fabrica
                                   where a.numero_de_articulo == af.numero_de_articulo
                                   select new ArticulosAsociadosViewModel
                                   {
                                       id = af.id,
                                       fabrica = f.nombre_fabrica,
                                       descripcion = a.descripcion_articulo,
                                       existencia = af.existencia
                                   }).ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                dtgArticulos.DataSource = lstArticulo;
            }    
        }
        private void cargarDatosDeFabrica()
        {
            List<FabricaViewModel> lstFabrica = new List<FabricaViewModel>();

            using (var database = new dbpedidosEntities())
            {
                try
                {
                    lstFabrica = (from d in database.Fabricas
                                  select new FabricaViewModel
                                  {
                                      id_fabrica = d.id_fabrica,
                                      nombre_fabrica = d.nombre_fabrica
                                  }).ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                comboFabricas.DataSource = lstFabrica;
                comboFabricas.ValueMember = "id_fabrica";
                comboFabricas.DisplayMember = "nombre_fabrica";
            }
        }
        private void cargarDatosDeArticulo()
        {
            List<ArticulosViewModel> lstArticulos = new List<ArticulosViewModel>();

            using (var database = new dbpedidosEntities())
            {
                try
                {
                    lstArticulos = (from a in database.Articulos
                                    select new ArticulosViewModel
                                    {
                                        numero_articulo = a.numero_de_articulo,
                                        descripcion = a.descripcion_articulo
                                    }).ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                comboArticulo.DataSource = lstArticulos;
                comboArticulo.ValueMember = "numero_articulo";
                comboArticulo.DisplayMember = "descripcion";
            }
        }
        #endregion

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            comboFabricas.Enabled = true;
            comboArticulo.Enabled = true;
            numericExistencia.Enabled = true;
            btnAgregar.Enabled = false;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            reiniciarFormulario();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (idFabrica <= 0)
            {
                MessageBox.Show("La fabrica es requerida", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboFabricas.Focus();
            }
            else if (numArticulo <= 0)
            {
                MessageBox.Show("El articulo es requerido", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboArticulo.Focus();
            }
            else if (numericExistencia.Value <= 0)
            {
                MessageBox.Show("La existencia inicial debe ser mayor a cero", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                numericExistencia.Focus();
            }
            else
            {
                guardarAsociacion();
                reiniciarFormulario();
                cargarDatosEnGrid();
            }
        }

        private void frm_AsociarArticulosConFabricas_Load(object sender, EventArgs e)
        {
            cargarDatosDeFabrica();
            cargarDatosDeArticulo();
            cargarDatosEnGrid();
        }

        private void comboFabricas_SelectionChangeCommitted(object sender, EventArgs e)
        {
            idFabrica = Convert.ToInt32(comboFabricas.SelectedValue);
        }

        private void comboArticulo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            numArticulo = Convert.ToInt32(comboArticulo.SelectedValue);
        }
    }
}
