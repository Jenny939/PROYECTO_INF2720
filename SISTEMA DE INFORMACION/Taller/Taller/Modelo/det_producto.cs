//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Taller.Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class det_producto
    {
        public int id { get; set; }
        public int id_producto { get; set; }
        public int id_factura { get; set; }
        public int cantidad { get; set; }
        public double precio_unitario { get; set; }
        public double subtotal { get; set; }
    
        public virtual factura factura { get; set; }
        public virtual producto producto { get; set; }
    }
}
