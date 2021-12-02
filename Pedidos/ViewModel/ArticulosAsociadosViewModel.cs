using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos.ViewModel
{
    public class ArticulosAsociadosViewModel
    {
        public int id { get; set; }
        public string fabrica { get; set; }
        public string descripcion { get; set; }
        public int existencia { get; set; }
    }
}
