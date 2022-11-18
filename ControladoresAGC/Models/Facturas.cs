namespace ControladoresAGC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Facturas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Facturas()
        {
            Remisions = new HashSet<Remisions>();
        }

        [Key]
        public string FolioFac { get; set; }

        public string FolioRemision { get; set; }

        public float PrecioUni { get; set; }

        public float Importe { get; set; }

        public float Subtotal { get; set; }

        public float IVA { get; set; }

        public float Total { get; set; }

        public DateTime FechaHora { get; set; }

        public string MetodoPago { get; set; }

        public string FormaPago { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Remisions> Remisions { get; set; }
    }

    public class FacturasDTO
    {
        public string FolioFac { get; set; }

        public string FolioRemision { get; set; }

        public float PrecioUni { get; set; }

        public float Importe { get; set; }

        public float Subtotal { get; set; }

        public float IVA { get; set; }

        public float Total { get; set; }

        public DateTime FechaHora { get; set; }

        public string MetodoPago { get; set; }

        public string FormaPago { get; set; }
    }
}
