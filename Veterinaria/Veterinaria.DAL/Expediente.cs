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
    
    public partial class Expediente
    {
        public int idExpendiente { get; set; }
        public int idMascota { get; set; }
        public int idVisita { get; set; }
        public System.DateTime fechaIngreso { get; set; }
    
        public virtual Mascota Mascota { get; set; }
        public virtual Visita Visita { get; set; }
    }
}
