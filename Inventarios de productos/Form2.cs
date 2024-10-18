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
    public partial class FormEliminarProductos : Form
    {
        InicioInventario InicioInventario;
        private InventarioContext InventarioContext;

        public FormEliminarProductos(InicioInventario inicioInventario,InventarioContext inventarioContext)
        {
            InitializeComponent();
            this.InicioInventario = inicioInventario;
            this.InventarioContext = inventarioContext;
        }


        private void FormEliminarProductos_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Mostrar ventana anterior
            InicioInventario.Show();
        }
        private void EliminarProducto()
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(box_id.Text) && !string.IsNullOrWhiteSpace(box_Comentario.Text) && !string.IsNullOrWhiteSpace(Box_nombrepro.Text))
                {
                    //Buscar producto
                    var buscar = int.Parse(box_id.Text);
                    var eliminar = this.InventarioContext.Productos.Find(buscar);

                    if (eliminar != null)
                    {
                        //Eliminar Producto
                        this.InventarioContext.Productos.Remove(eliminar);
                        
                        //Crear Reporte
                        var reporte = new Reportes { ProductoId = int.Parse(box_id.Text),Nombre = Box_nombrepro.Text , Comentario = box_Comentario.Text };
                        //Agregar reporte
                        this.InventarioContext.Reportes.Add(reporte);
                        //Guardar 
                        this.InventarioContext.SaveChanges();

                        MessageBox.Show("Producto eliminado con exito!");
                        
                    }
                    else
                    {
                        MessageBox.Show("Producto no encontrado");
                    }

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
        private void ModificarProducto()
        {
            try
            {

                if (!string.IsNullOrWhiteSpace(Box_id2.Text) && !string.IsNullOrWhiteSpace(Box_valor.Text))
                {
                    switch (combox.Text)
                    {
                        case "Nombre":

                            Lb_valor.Text = combox.Text;
                            //ValorId
                            var buscar = int.Parse(Box_id2.Text);
                            //Buscar objeto
                            var producto = this.InventarioContext.Productos.Find(buscar);
                            if (producto != null )
                            {
                                producto.Nombre = Box_valor.Text;
                                //Guardar Cambios
                                this.InventarioContext.SaveChanges();
                            }
                            else
                            {
                                MessageBox.Show("Producto no encontrado");
                            }

                            
                            break;

                        case "Descripcion":
                            Lb_valor.Text = combox.Text;
                            //ValorId
                            var buscar1 = int.Parse(Box_id2.Text);
                            //Buscar objeto
                            var producto1 = this.InventarioContext.Productos.Find(buscar1);
                            if (producto1 != null)
                            {
                                producto1.Descripcion = Box_valor.Text;
                                //Guardar cambios
                                this.InventarioContext.SaveChanges();

                                MessageBox.Show("Producto modificado con exito!");
                            }
                            else
                            {
                                MessageBox.Show("Producto no encontrado");
                            }                           
                           

                            break;

                        case "Precio":
                            Lb_valor.Text = combox.Text;
                            //ValorId
                            var buscar2 = int.Parse(Box_id2.Text);
                            //Buscar objeto
                            var producto2 = this.InventarioContext.Productos.Find(buscar2);
                            if(producto2 != null)
                            {
                                producto2.Precio = int.Parse(Box_valor.Text);
                                //Guardar cambios
                                this.InventarioContext.SaveChanges();

                                MessageBox.Show("Producto modificado con exito!");
                            }
                            else
                            {
                                MessageBox.Show("Producto no encontrado");
                            }
                            break;

                        case "Cantidad":
                            Lb_valor.Text = combox.Text;
                            //ValorId
                            var buscar3 = int.Parse(Box_id2.Text);
                            //Buscar objeto
                            var producto3 = this.InventarioContext.Productos.Find(buscar3);
                            if (producto3 != null)
                            {
                                producto3.Cantidad = int.Parse(Box_valor.Text);
                                //Guardar cambios
                                this.InventarioContext.SaveChanges();

                                MessageBox.Show("Producto modificado con exito!");
                            }
                            else
                            {
                                MessageBox.Show("Producto no encontrado");
                            }                            
                            break;

                        default:
                            MessageBox.Show("Campo no encontrado");
                            break;                           
                            

                    }
                    //Limpiar
                    Box_id2.Text = null;
                    Box_valor.Text = null;
                    


                }
                else
                {
                    MessageBox.Show("Recuerda rellenar todos los campos");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Recuerda rellenar todos los campos correctamente");                
            }
        }
        

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            EliminarProducto();
        }

        private void Btn_modificar_Click(object sender, EventArgs e)
        {
            ModificarProducto();
        }          

       
    }
}
