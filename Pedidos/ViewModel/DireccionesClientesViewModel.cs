using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos.ViewModel
{
    public class DireccionesClientesViewModel
    {
        public int id_direccion { get; set; }
        public int numero_de_cliente { get; set; }
        public string calle { get; set; }
        public string barrio { get; set; }
        public string distrito { get; set; }

    }
}
