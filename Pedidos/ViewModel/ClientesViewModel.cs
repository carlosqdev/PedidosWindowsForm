using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos.ViewModel
{
    public class ClientesViewModel
    {
        public int numero { get; set; }
        public string nombres { get; set; }
        public decimal saldo { get; set; }
        public decimal limite_credito { get; set; }
        public decimal descuento { get; set; }
    }
}
