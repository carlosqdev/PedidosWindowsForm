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
        int codigoFabrica = 0;
        int codigoProducto = 0;
        bool articuloEnLista = false;

        #region
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
                comboDirecciones.DataSource = lstDirecciones;
                comboDirecciones.ValueMember = "id_direccion";
                comboDirecciones.DisplayMember = "direccion";
            }
        }
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
                comboArticulos.DataSource = lstArticulos;
                comboArticulos.ValueMember = "idArticulo";
                comboArticulos.DisplayMember = "descripcion";
            }
        }
        private void buscarArticulos(int codigoFabrica, int codigoProducto)
        {
            List<ArticuloViewModel> lstArticulo = new List<ArticuloViewModel>();

            using (var database = new dbpedidosEntities())
            {
                try
                {
                    lstArticulo = (from a in database.Articulos
                                   from af in database.ArticulosEnFabricas
                                   from f in database.Fabricas
                                   where a.numero_de_articulo == af.numero_de_articulo
                                   where f.id_fabrica == af.id_fabrica
                                   where af.id_fabrica == codigoFabrica
                                   where af.numero_de_articulo == codigoProducto
                                   select new ArticuloViewModel
                                   {
                                       descripcion = a.descripcion_articulo,
                                       numero_articulo = af.numero_de_articulo,
                                       existencia = af.existencia,
                                       cantidad = 0
                                   }).ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                foreach (var item in lstArticulo)
                {
                    txtDescripcion.Text = item.descripcion;
                    txtNumeroArticulo.Text = Convert.ToString(item.numero_articulo);
                    txtExistencia.Text = Convert.ToString(item.existencia);
                    numericCantidad.Value = item.cantidad;
                }
            }
        }
        private void guardarPedido()
        {
            using (dbpedidosEntities db = new dbpedidosEntities())
            {
                using (var dbContextTransaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        Pedido oPedido = new Pedido();
                        oPedido.numero_de_cliente = Convert.ToInt32(comboClientes.SelectedValue);
                        oPedido.id_direccion = Convert.ToInt32(txtIdDireccion.Text);
                        oPedido.fecha_pedido = DateTime.Now;

                        db.Pedidos.Add(oPedido);
                        db.SaveChanges();

                        foreach (DataGridViewRow dr in dtgvArticulos.Rows)
                        {
                            DetallesDePedido oDetalle = new DetallesDePedido();
                            oDetalle.id_pedido = oPedido.id_pedido;
                            oDetalle.numero_de_articulo = Convert.ToInt32(dr.Cells[3].Value);
                            oDetalle.id_fabrica = Convert.ToInt32(dr.Cells[1].Value);
                            oDetalle.cantidad = Convert.ToInt32(dr.Cells[2].Value);

                            db.DetallesDePedidos.Add(oDetalle);
                        }

                        db.SaveChanges();

                        dbContextTransaction.Commit();
                        MessageBox.Show("Pedido guardado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        dbContextTransaction.Rollback();
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        #endregion
        private void frm_CrearPedidos_Load(object sender, EventArgs e)
        {
            
        }
        
        private void comboClientes_SelectionChangeCommitted(object sender, EventArgs e)
        {
            numeroCliente = Convert.ToInt32(comboClientes.SelectedValue);
            if (numeroCliente > 0)
            {
                CargarDireccionesCliente(numeroCliente);
                comboDirecciones.Enabled = true;
            }
            
        }

        private void comboDirecciones_SelectionChangeCommitted(object sender, EventArgs e)
        {
            numeroCliente = Convert.ToInt32(comboClientes.SelectedValue);
            if (numeroCliente > 0)
            {
                txtIdDireccion.Text = comboDirecciones.SelectedValue.ToString();
                txtDireccionEnvio.Text = comboDirecciones.Text.ToString();
            }
        }

        private void comboFabricas_SelectionChangeCommitted(object sender, EventArgs e)
        {
            codigoFabrica = Convert.ToInt32(comboFabricas.SelectedValue);
            if (codigoFabrica > 0)
            {
                cargarArticulos(codigoFabrica);
                comboArticulos.Enabled = true;
            }
        }

        private void comboArticulos_SelectionChangeCommitted(object sender, EventArgs e)
        {
            codigoProducto = Convert.ToInt32(comboArticulos.SelectedValue);
            if (codigoFabrica > 0 && codigoProducto > 0)
            {
                buscarArticulos(codigoFabrica, codigoProducto);
                numericCantidad.Enabled = true;
                btnAgregar.Enabled = true;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (numericCantidad.Value > 0){
                if (numericCantidad.Value <= Convert.ToInt32(txtExistencia.Text))
                {
                    string descripcion = txtDescripcion.Text;
                    int idFabrica = Convert.ToInt32(comboFabricas.SelectedValue);
                    int numero_articulo = Convert.ToInt32(txtNumeroArticulo.Text);
                    int cantidad = Convert.ToInt32(numericCantidad.Value);
                    dtgvArticulos.Rows.Add(new object[] { descripcion, idFabrica, cantidad, numero_articulo, "Eliminar" });

                    txtDescripcion.Text = "";
                    txtNumeroArticulo.Text = "";
                    txtExistencia.Text = "";
                    numericCantidad.Value = 0;

                    articuloEnLista = true;
                }
                else
                {
                    MessageBox.Show("No hay suficientes articulos, su pedido supera la existencia actual", "Articulos insuficientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else {
                MessageBox.Show("La cantidad debe ser mayor a cero", "Falta definir cantidad", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }            
        }

        private void dtgvArticulos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != dtgvArticulos.Columns["Op"].Index)
                return;

            dtgvArticulos.Rows.RemoveAt(e.RowIndex);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            CargarComboCliente();
            cargarComboFabrica();
            comboClientes.Enabled = true;
            comboFabricas.Enabled = true;
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (numeroCliente <= 0)
                MessageBox.Show("Debe seleccionar un cliente", "Falta un campo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (txtIdDireccion.Text == "")
                MessageBox.Show("Debe seleccionar una dirección del cliente", "Falta un campo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (articuloEnLista == false)
                MessageBox.Show("Debe agregar como minimo un articulo", "Detalle del pedido esta vacio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
                guardarPedido();
        }
    }
}
