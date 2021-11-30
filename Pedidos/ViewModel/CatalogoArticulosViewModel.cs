using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos.ViewModel
{
    public class CatalogoArticulosViewModel
    {
        public int idArticulo { get; set; }
        public int idFabrica { get; set; }
        public string fabricado { get; set; }
        public string descripcion  { get; set; }
        public int existencia { get; set; }
    }
}
