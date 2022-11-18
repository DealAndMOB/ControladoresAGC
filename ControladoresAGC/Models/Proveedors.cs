namespace ControladoresAGC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Proveedors
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Proveedors()
        {
            Pedidoes = new HashSet<Pedidoes>();
        }

        [Key]
        public string RFC { get; set; }

        public string Empresa { get; set; }

        public string RazonSocial { get; set; }

        public string Contacto { get; set; }

        public string Categoria { get; set; }

        public string Giro { get; set; }

        public string Telefono { get; set; }

        public string Correo { get; set; }

        public string Direccion { get; set; }

        public string Zona { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pedidoes> Pedidoes { get; set; }
    }

    public class ProveedoresDTO
    {
        public string RFC { get; set; }

        public string Empresa { get; set; }

        public string RazonSocial { get; set; }

        public string Contacto { get; set; }

        public string Categoria { get; set; }

        public string Giro { get; set; }

        public string Telefono { get; set; }

        public string Correo { get; set; }

        public string Direccion { get; set; }

        public string Zona { get; set; }
    }
}
