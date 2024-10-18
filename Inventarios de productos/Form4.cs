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
    public partial class FormVenderProductos : Form
    {
        InicioInventario InicioInventario;
        InventarioContext InventarioContext;
        public FormVenderProductos(InicioInventario inicioInventario, InventarioContext inventarioContext)
        {
            InitializeComponent();
            this.InicioInventario = inicioInventario;
            this.InventarioContext = inventarioContext;
        }

        private void FormVenderProductos_FormClosing(object sender, FormClosingEventArgs e)
        {
            //MostrarVentana
            InicioInventario.Show();
        }

       

        private void FormVenderProductos_Load(object sender, EventArgs e)
        {
            //Carga la tabla
            this.InventarioContext.Productos.Load();
            //Hace la conexion de los datos con el datagridview
            this.productoBindingSource.DataSource = this.InventarioContext.Productos.Local.ToBindingList();
        }

        private void VenderProducto()
        {
            try
            {
                           
                if (!string.IsNullOrWhiteSpace(Box_id.Text) && !string.IsNullOrWhiteSpace(Box_cantidad.Text) && !string.IsNullOrWhiteSpace(Box_cedula.Text))
                {
                    double cedula = double.Parse(Box_cedula.Text);
                    //Buscar la cedula
                    var validar = this.InventarioContext.Clientes.FirstOrDefault(c => c.Cedula == cedula);                   
                    
                    if (validar != null)
                    {
                        int producto = int.Parse(Box_id.Text);
                        //Busca el producto
                        var Producto = this.InventarioContext.Productos.Find(producto);  
                        
                        if (Producto != null)
                        {
                            //Busca la cantidad del producto
                            var cantidad = Producto.Cantidad;
                            if (cantidad != 0)
                            {
                                //Restar la cantidad de producto vendido
                                Producto.Cantidad = cantidad - int.Parse(Box_cantidad.Text);

                                //Registrar compras
                                //Id de la tabla cliente 
                                var id = validar.ClienteId;
                                var Comprar = new Compras { ClienteId = (int)id!, ProductoId = producto, Cantidad = int.Parse(Box_cantidad.Text) };
                                //Agregamos la compra a la base de datos
                                this.InventarioContext.Compras.Add(Comprar);
                                var Precio = Producto.Precio;

                                MessageBox.Show($"Compra realizada con exito!. Cantidad de dinero a pagar: {decimal.Parse(Box_cantidad.Text) * Precio}");
                                //guardamos los cambios
                                this.InventarioContext.SaveChanges();
                                //Actualizar tabla
                                dataGridViewVender.Refresh();
                                //Limpiar campos
                                Box_id.Text = null;
                                Box_cantidad.Text = null;
                                Box_cedula.Text = null;
                            }
                            else
                            {
                                MessageBox.Show("Producto agotado.");
                                Box_id.Text = null;
                                Box_cantidad.Text = null;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Producto No disponible");
                            Box_id.Text = null;
                            Box_cantidad.Text = null;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cedula no registrada.");
                        Box_cedula.Text = null;
                    }
                }
                else
                {
                    MessageBox.Show("Recuerda rellenar todos los campos.");
                }
            }
            catch
            {
                MessageBox.Show("Recuerda rellenar todos los campos correctamente");
                Box_id.Text = null;
                Box_cantidad.Text = null;
                Box_cedula.Text = null;
            }

        }
       

        private void Btn_vender_Click(object sender, EventArgs e)
        {
            VenderProducto();
        }
    }
}
