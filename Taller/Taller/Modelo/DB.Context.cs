﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DBTallerEntities : DbContext
    {
        public DBTallerEntities()
            : base("name=DBTallerEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<cliente> cliente { get; set; }
        public virtual DbSet<det_producto> det_producto { get; set; }
        public virtual DbSet<det_servicio> det_servicio { get; set; }
        public virtual DbSet<factura> factura { get; set; }
        public virtual DbSet<producto> producto { get; set; }
        public virtual DbSet<rampa> rampa { get; set; }
        public virtual DbSet<reservacion> reservacion { get; set; }
        public virtual DbSet<servicio> servicio { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<tecnico> tecnico { get; set; }
        public virtual DbSet<usuario> usuario { get; set; }
    }
}