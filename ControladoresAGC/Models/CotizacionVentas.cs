namespace ControladoresAGC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CotizacionVentas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CotizacionVentas()
        {
            Remisions1 = new HashSet<Remisions>();
            Remisions2 = new HashSet<Remisions>();
        }

        [Key]
        public string Folio { get; set; }

        [StringLength(128)]
        public string RFC_Cli { get; set; }

        [StringLength(128)]
        public string IDProducto { get; set; }

        [StringLength(128)]
        public string IDUsuario { get; set; }

        public int Cantidad { get; set; }

        public string Descripcion { get; set; }

        public float Precio { get; set; }

        public float Total { get; set; }

        public DateTime Fecha { get; set; }

        [StringLength(128)]
        public string Remision_FolioRemision { get; set; }

        public virtual Clientes Clientes { get; set; }

        public virtual Productoes Productoes { get; set; }

        public virtual Remisions Remisions { get; set; }

        public virtual Usuarios Usuarios { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Remisions> Remisions1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Remisions> Remisions2 { get; set; }
    }

    public class CotizacionDTO
    {
        public string Folio { get; set; }

        public string RFC_Cli { get; set; }

        public string IDProducto { get; set; }

        public string IDUsuario { get; set; }

        public int Cantidad { get; set; }

        public string Descripcion { get; set; }

        public float Precio { get; set; }

        public float Total { get; set; }

        public DateTime Fecha { get; set; }

        public string Remision_FolioRemision { get; set; }

    }
}
