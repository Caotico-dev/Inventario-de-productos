using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventarios_de_productos_
{
    public  class Producto
    {
        [Key]
        public int ProductoId {  get; set; }
        [Required]
        public string? Nombre { get; set; }
        [Required]
        public string? Descripcion {  get; set; }
        [Required]
        public int? Cantidad { get; set; }
        [Required]
        public decimal? Precio { get; set; }

        internal object Where(Func<object, bool> value)
        {
            throw new NotImplementedException();
        }
    }
}
