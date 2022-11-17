namespace ControladoresAGC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Remisions
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Remisions()
        {
            CotizacionVentas = new HashSet<CotizacionVentas>();
        }

        [Key]
        public string FolioRemision { get; set; }

        public string Folio { get; set; }

        public string Responsable { get; set; }

        public DateTime FechaEntrega { get; set; }

        [StringLength(128)]
        public string CotizacionVenta_Folio { get; set; }

        [StringLength(128)]
        public string CotizacionVentas_Folio { get; set; }

        [StringLength(128)]
        public string Factura_FolioFac { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CotizacionVentas> CotizacionVentas { get; set; }

        public virtual CotizacionVentas CotizacionVentas1 { get; set; }

        public virtual CotizacionVentas CotizacionVentas2 { get; set; }

        public virtual Facturas Facturas { get; set; }
    }
}
