﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class VeteEntities1 : DbContext
    {
        public VeteEntities1()
            : base("name=VeteEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Dueno> Dueno { get; set; }
        public virtual DbSet<Expediente> Expediente { get; set; }
        public virtual DbSet<Mascota> Mascota { get; set; }
        public virtual DbSet<Producto> Producto { get; set; }
        public virtual DbSet<Productos_Visita> Productos_Visita { get; set; }
        public virtual DbSet<Raza> Raza { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
        public virtual DbSet<Visita> Visita { get; set; }
    }
}
