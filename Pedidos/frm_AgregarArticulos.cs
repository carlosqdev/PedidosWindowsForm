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
    public partial class frm_AgregarArticulos : Form
    {
        public frm_AgregarArticulos()
        {
            InitializeComponent();
        }

        int codigoFabrica = 0;

        private void cargarComboFabrica()
        {
            List<FabricaViewModel> lstFabrica = new List<FabricaViewModel>();

            using (dbpedidosEntities database = new dbpedidosEntities())
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

        private void cargarArticulos(int codigoFabrica)
        {
            List<CatalogoArticulosViewModel> lstArticulos = new List<CatalogoArticulosViewModel>();

            using (var database = new dbpedidosEntities())
            {
                try
                {
                    lstArticulos = (from a in database.Articulos
                                    from af in database.ArticulosEnFabricas
                                    from f in database.Fabricas
                                    where a.numero_de_articulo == af.numero_de_articulo
                                    where f.id_fabrica == af.id_fabrica
                                    where af.id_fabrica == codigoFabrica
                                    select new CatalogoArticulosViewModel
                                    {
                                        idArticulo = a.numero_de_articulo,
                                        idFabrica = f.id_fabrica,
                                        fabricado = f.nombre_fabrica,
                                        descripcion = a.descripcion_articulo,
                                        existencia = af.existencia
                                    }).ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dtgvArticulos.DataSource = lstArticulos;
            }
        }

        private void frm_AgregarArticulos_Load(object sender, EventArgs e)
        {
            cargarComboFabrica();
        }

        private void comboFabricas_SelectionChangeCommitted(object sender, EventArgs e)
        {
            codigoFabrica = Convert.ToInt32(comboFabricas.SelectedValue);
            if (codigoFabrica > 0)
            {
                cargarArticulos(codigoFabrica);
            }
        }
    }
}
