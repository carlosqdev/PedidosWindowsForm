//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Pedidos.Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class DetallesDePedido
    {
        public int id { get; set; }
        public int id_pedido { get; set; }
        public int numero_de_articulo { get; set; }
        public int id_fabrica { get; set; }
        public int cantidad { get; set; }
    
        public virtual Articulo Articulo { get; set; }
        public virtual Fabrica Fabrica { get; set; }
        public virtual Pedido Pedido { get; set; }
    }
}
