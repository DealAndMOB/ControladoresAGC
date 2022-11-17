namespace ControladoresAGC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Pedidoes
    {
        [Key]
        public string PedidoID { get; set; }

        [StringLength(128)]
        public string RFC { get; set; }

        [StringLength(128)]
        public string IDProducto { get; set; }

        [StringLength(128)]
        public string IDUsuario { get; set; }

        public int Cantidad { get; set; }

        public float PrecioUnitario { get; set; }

        public float Total { get; set; }

        public long ClabeBancaria { get; set; }

        public DateTime FechaInicio { get; set; }

        public DateTime FechaVencimiento { get; set; }

        public virtual Productoes Productoes { get; set; }

        public virtual Proveedors Proveedors { get; set; }

        public virtual Usuarios Usuarios { get; set; }
    }
}
