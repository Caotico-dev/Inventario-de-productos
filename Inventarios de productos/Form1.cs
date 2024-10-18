using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Linq;

namespace Inventarios_de_productos_
{
    public partial class InicioInventario : Form
    {
        private InventarioContext? InventarioContext;

        public InicioInventario()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormEliminarProductos formEliminarProductos = new FormEliminarProductos(this, this.InventarioContext!);
            //Mostrar ventana
            formEliminarProductos.Show();
            //Ocultar vetnana
            this.Hide();

        }

        private void Btn_ListaClientes_Click(object sender, EventArgs e)
        {
            //Crear objeto
            Formlistaclientes formlistaclientes = new Formlistaclientes(this, this.InventarioContext!);
            //Mostrar objeto
            formlistaclientes.Show();
            //Ocultar ventana
            this.Hide();


        }

        private void Btn_VenderProductos_Click(object sender, EventArgs e)
        {
            //Crear objeto
            FormVenderProductos formVenderProductos = new FormVenderProductos(this, this.InventarioContext!);
            //Mostrar Objeto
            formVenderProductos.Show();
            //Ocultar ventana
            this.Hide();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //Crear objeto
            FormEstadisticayReportes formEstadisticayReportes = new FormEstadisticayReportes(this, this.InventarioContext!);
            // Mostrar objeto
            formEstadisticayReportes.Show();
            //ocultar venta
            this.Hide();

        }

        private void InicioInventario_Load(object sender, EventArgs e)
        {
            //base.OnLoad(e);
            //Crear el contexto 
            this.InventarioContext = new InventarioContext();
            //Elimina la base de datos 
            //this.InventarioContext.Database.EnsureDeleted();
            //Crea la base de datos sino existe
            this.InventarioContext.Database.EnsureCreated();
            //Carga la tabla
            this.InventarioContext.Productos.Load();
            //Hace la conexion de los datos con el datagridview
            this.productoBindingSource.DataSource = this.InventarioContext.Productos.Local.ToBindingList();


        }
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            //Libera los datos
            this.InventarioContext?.Dispose();
            this.InventarioContext = null;
        }
        private void AgregarProducto()
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(Box_nombre.Text) && !string.IsNullOrWhiteSpace(Box_descripcion.Text) && !string.IsNullOrWhiteSpace(Box_cantida.Text) && !string.IsNullOrWhiteSpace(Box_Precio.Text))
                {
                    //Crear productos
                    var producto = new Producto { Nombre = Box_nombre.Text, Descripcion = Box_descripcion.Text, Cantidad = int.Parse(Box_cantida.Text), Precio = int.Parse(Box_Precio.Text) };
                    //Agregar productos
                    this.InventarioContext!.Productos.Add(producto);
                    //Guardar productos
                    this.InventarioContext.SaveChanges();
                    MessageBox.Show("Producto registrado con exito!.");
                    //Actualizar
                    dataGridView1.Refresh();

                    //Limpiar
                    Box_nombre.Text = null;
                    Box_descripcion.Text = null;
                    Box_cantida.Text = null;
                    Box_Precio.Text = null;


                }
                else
                {
                    MessageBox.Show("Recuerda rellenar todos los campos.");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Recuerda rellenar todos los campos correctamente");

            }

        }
        private void BuscarProducto()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(Box_BuscarProducto.Text))
                {                   
                        var producto = this.InventarioContext!.Productos.ToList();
                        //Mostrar producto en datagridview
                        dataGridView1.DataSource = producto;   
                        Box_BuscarProducto.Text = null;           
                                       
                }
                else
                {
                    string nombre = Box_BuscarProducto.Text.Trim().ToLower();
                    //buscar el nombre en la base de datos
                    var busqueda = this.InventarioContext!.Productos.Where(p => p.Nombre!.ToLower().Contains(nombre)).ToList();
                    //Confirmacion de datos
                    if (busqueda != null)
                    {
                        dataGridView1.DataSource = busqueda;
                    }
                    else
                    {
                        MessageBox.Show("Producto no encontrado.");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Recuerda rellenar todos los campos correctamente");
                Box_BuscarProducto.Text = null;
            }
        }

        private void Btn_AñadirProductos_Click(object sender, EventArgs e)
        {
            AgregarProducto();

        }

        private void Btn_BuscarProducto_Click(object sender, EventArgs e)
        {
            BuscarProducto();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            var producto = this.InventarioContext!.Productos.ToList();

            dataGridView1.DataSource = producto;
        }
    }
}
