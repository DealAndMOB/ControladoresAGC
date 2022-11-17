namespace ControladoresAGC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Clientes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Clientes()
        {
            CotizacionVentas = new HashSet<CotizacionVentas>();
        }

        [Key]
        public string RFC_Cli { get; set; }

        public string Nombre { get; set; }

        public string Direccion { get; set; }

        public string Telefono { get; set; }

        public string Correo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CotizacionVentas> CotizacionVentas { get; set; }
    }

        public class ClientesDTO{
            public string RFC_Cli { get; set; }

            public string Nombre { get; set; }

            public string Direccion { get; set; }

            public string Telefono { get; set; }

            public string Correo { get; set; }
        }
}
