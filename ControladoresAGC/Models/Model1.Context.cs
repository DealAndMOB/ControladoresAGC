﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ControladoresAGC.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AGCComercialEntities : DbContext
    {
        public AGCComercialEntities()
            : base("name=AGCComercialEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Clientes> Clientes { get; set; }
        public virtual DbSet<CotizacionVentas> CotizacionVentas { get; set; }
        public virtual DbSet<Facturas> Facturas { get; set; }
        public virtual DbSet<Pedidoes> Pedidoes { get; set; }
        public virtual DbSet<Productoes> Productoes { get; set; }
        public virtual DbSet<Proveedors> Proveedors { get; set; }
        public virtual DbSet<Remisions> Remisions { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }
    }
}