using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventarios_de_productos_
{
    public class Reportes
    {
        [Key]
        public int Id { get; set; }
        public int ProductoId { get; set; }
        public string? Nombre { get; set; }
        public string? Comentario { get; set; }
    }
}
