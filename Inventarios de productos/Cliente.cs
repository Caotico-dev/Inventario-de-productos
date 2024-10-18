using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventarios_de_productos_
{
    public class Cliente
    {
        [Key]
        public int? ClienteId { get; set; }
        [Required]
        public string? Nombre { get; set; }
        [Required]
        public double? Cedula { get; set; }    
        public virtual ObservableCollectionListSource<Compras> Compras { get;} = new();//Relacion inversa 


    }
}
