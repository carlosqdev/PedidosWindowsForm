using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos.ViewModel
{
    public class ArticuloViewModel
    {
        public string descripcion { get; set; }
        public int numero_articulo { get; set; }
        public int existencia { get; set; }
        public int cantidad { get; set; }
    }
}
