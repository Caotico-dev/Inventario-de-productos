using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventarios_de_productos_
{
    public class Compras
    {
        [Key]
        public int ComprasId { get; set; }
        public int ClienteId { get; set; } // Foreign key
        [Required]
        public int ProductoId { get; set; }      
        [Required]
        public int? Cantidad { get;  set; }
        public virtual Cliente Cliente { get; set; } = null!;// navegacion

    }
}
