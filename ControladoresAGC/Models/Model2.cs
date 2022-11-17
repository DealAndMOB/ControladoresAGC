using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ControladoresAGC.Models
{
    public partial class Model2 : DbContext
    {
        public Model2()
            : base("name=Model2")
        {
        }

        public virtual DbSet<Clientes> Clientes { get; set; }
        public virtual DbSet<CotizacionVentas> CotizacionVentas { get; set; }
        public virtual DbSet<Facturas> Facturas { get; set; }
        public virtual DbSet<Pedidoes> Pedidoes { get; set; }
        public virtual DbSet<Productoes> Productoes { get; set; }
        public virtual DbSet<Proveedors> Proveedors { get; set; }
        public virtual DbSet<Remisions> Remisions { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CotizacionVentas>()
                .HasMany(e => e.Remisions1)
                .WithOptional(e => e.CotizacionVentas1)
                .HasForeignKey(e => e.CotizacionVenta_Folio);

            modelBuilder.Entity<CotizacionVentas>()
                .HasMany(e => e.Remisions2)
                .WithOptional(e => e.CotizacionVentas2)
                .HasForeignKey(e => e.CotizacionVentas_Folio);

            modelBuilder.Entity<Facturas>()
                .HasMany(e => e.Remisions)
                .WithOptional(e => e.Facturas)
                .HasForeignKey(e => e.Factura_FolioFac);

            modelBuilder.Entity<Remisions>()
                .HasMany(e => e.CotizacionVentas)
                .WithOptional(e => e.Remisions)
                .HasForeignKey(e => e.Remision_FolioRemision);
        }
    }
}
