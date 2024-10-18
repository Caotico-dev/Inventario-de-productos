using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventarios_de_productos_
{
    public partial class FormEstadisticayReportes : Form
    {
        InicioInventario InicioInventario;
        private InventarioContext InventarioContext;
        public FormEstadisticayReportes(InicioInventario inicioInventario, InventarioContext inventarioContext)
        {
            InitializeComponent();
            this.InicioInventario = inicioInventario;
            this.InventarioContext = inventarioContext;
        }


        private void FormEstadisticayReportes_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Mostrar ventana
            InicioInventario.Show();

        }

        private void FormEstadisticayReportes_Load(object sender, EventArgs e)
        {
            
            //Carga la tabla
            this.InventarioContext.Reportes.Load();
            //Hace la conexion de los datos con el datagridview
            this.reportesBindingSource.DataSource = this.InventarioContext.Reportes.Local.ToBindingList();

            //Metodo para poner a trabajr las estadisticas
            EstadisticaLb();

            //Cargar productos agotados
            ProductoA();

        }

        private void EstadisticaLb()
        {
            //Buscar la cantidad de productos registrados
            var CantidadProducto = this.InventarioContext.Productos.Count();
            Lb_ProductosRegistrados.Text = CantidadProducto.ToString();

            //Buscar la cantidad de clientes registrados
            var ClienteRegistrado = this.InventarioContext.Clientes.Count();
            Lb_ClienteRegistrados.Text = ClienteRegistrado.ToString();

            //Calcular las gananancias
            var preciop = this.InventarioContext.Productos.Sum(x => x.Precio);
            var cantidadp = this.InventarioContext.Productos.Sum(x => x.Cantidad);
            var gananciasp = preciop * cantidadp;
            Lb_GananciasProyectadas.Text = gananciasp.ToString();
        }
        private void ProductoA()
        {                     
            //Consulta
            var productoA = this.InventarioContext.Productos.Where(c => c.Cantidad <= 20).ToList();
            //Limpiar
            listViewA.Items.Clear();
            foreach (var producto in productoA)
            {
                //Creamos item
                ListViewItem item = new ListViewItem(producto.ProductoId.ToString());
                
                item.SubItems.Add(producto.Nombre);
                //llenamos el listview
                listViewA.Items.Add(item);

            }          
           

        }
    }
}
