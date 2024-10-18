using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Inventarios_de_productos_
{
    public class InventarioContext:DbContext
    {
        public DbSet<Producto> Productos { get; set; }  
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Compras> Compras { get; set; }
        public DbSet<Reportes> Reportes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data source=Almacen.db");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().HasMany(p => p.Compras).WithOne(p => p.Cliente); 
            modelBuilder.Entity<Producto>().Property(p => p.Precio).HasPrecision(18,2);

            modelBuilder.Entity<Producto>().HasData(
                new Producto { ProductoId = 1, Nombre = "Salami", Descripcion = "Salami Bravo", Cantidad = 100, Precio = 300.24m },
                new Producto { ProductoId = 2, Nombre = "Platano", Descripcion = "Platano Grande", Cantidad = 300, Precio = 27 },
                new Producto { ProductoId = 3, Nombre = "Huevo", Descripcion = "De Gallinas Felices", Cantidad = 300, Precio = 8 },
                new Producto { ProductoId = 4, Nombre = "PicaPica", Descripcion = "Saldinas en tomate", Cantidad = 8, Precio = 80 }
                );
            modelBuilder.Entity<Cliente>().HasData(
                new Cliente { ClienteId = 1, Nombre = "Daniel",Cedula = 40231189131});           
            

        }

    }
}
