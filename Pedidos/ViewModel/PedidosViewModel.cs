using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos.ViewModel
{
    public class PedidosViewModel
    {
        public int id_Pedido { get; set; }
        public int numero_cliente { get; set; }
        public string cliente { get; set; }
        public string direccion { get; set; }
        public DateTime fecha_pedido { get; set; }
    }
}
