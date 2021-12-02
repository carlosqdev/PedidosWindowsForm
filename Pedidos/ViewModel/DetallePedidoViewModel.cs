using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos.ViewModel
{
    public class DetallePedidoViewModel
    {
        public int idPedido { get; set; }
        public string fabrica { get; set; }
        public int numeroDeArticulo { get; set; }
        public string nombreArticulo { get; set; }
        public int cantidad { get; set; }

    }
}
