namespace ControladoresAGC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Productoes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Productoes()
        {
            CotizacionVentas = new HashSet<CotizacionVentas>();
            Pedidoes = new HashSet<Pedidoes>();
        }

        [Key]
        public string IDProducto { get; set; }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public float Precio { get; set; }

        public string Categoria { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CotizacionVentas> CotizacionVentas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pedidoes> Pedidoes { get; set; }
    }
}
