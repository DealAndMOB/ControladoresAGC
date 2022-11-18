namespace ControladoresAGC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Usuarios
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Usuarios()
        {
            CotizacionVentas = new HashSet<CotizacionVentas>();
            Pedidoes = new HashSet<Pedidoes>();
        }

        [Key]
        public string IDUsuario { get; set; }

        public string Nombre { get; set; }

        public string NomUsuario { get; set; }

        public string Contraseña { get; set; }

        public string Correo { get; set; }

        public string Perfil { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CotizacionVentas> CotizacionVentas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pedidoes> Pedidoes { get; set; }
    }

    public class UsuariosDTO
    {
        public string IDUsuario { get; set; }

        public string Nombre { get; set; }

        public string NomUsuario { get; set; }

        public string Contraseña { get; set; }

        public string Correo { get; set; }

        public string Perfil { get; set; }
    }
}
