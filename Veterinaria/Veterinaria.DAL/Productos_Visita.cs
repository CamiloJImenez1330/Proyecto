//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Veterinaria.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Productos_Visita
    {
        public int idVisita { get; set; }
        public int idProducto { get; set; }
        public string detalle { get; set; }
    
        public virtual Producto Producto { get; set; }
        public virtual Visita Visita { get; set; }
    }
}