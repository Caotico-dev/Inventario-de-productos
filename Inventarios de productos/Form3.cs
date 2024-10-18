using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventarios_de_productos_
{
    public partial class Formlistaclientes : Form
    {
        InicioInventario InicioInventario;
        private InventarioContext InventarioContext;
        public Formlistaclientes(InicioInventario inicioInventario, InventarioContext inventarioContext)
        {
            InitializeComponent();
            this.InicioInventario = inicioInventario;
            this.InventarioContext = inventarioContext;
        }

        private void Formlistaclientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Liberar datos
            dataGridViewcliente.DataSource = null;
            //Mostrar ventana
            InicioInventario.Show();

        }


        private void Formlistaclientes_Load(object sender, EventArgs e)
        {
            //Carga la tabla
            this.InventarioContext.Clientes.Load();
            //Hace la conexion de los datos con el datagridview
            this.clienteBindingSource.DataSource = this.InventarioContext.Clientes.Local.ToBindingList();

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.InventarioContext != null)
                {
                    var cliente = (Cliente)this.dataGridViewcliente.CurrentRow.DataBoundItem;

                    if (cliente != null)
                    {
                        this.InventarioContext.Entry(cliente).Collection(e => e.Compras).Load();
                    }
                }
                else
                {
                    MessageBox.Show("Seleciona un campos con valor");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Seleciona un campos con valor");
            }

        }
        private void RegistrarCliente()
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(Box_nombrecliente.Text) && !string.IsNullOrWhiteSpace(box_cedulacliente.Text))
                {
                    //Creamos el cliente
                    var cliente = new Cliente { Nombre = Box_nombrecliente.Text, Cedula = double.Parse(box_cedulacliente.Text) };
                    //Agreamos el cliente
                    this.InventarioContext.Clientes.Add(cliente);
                    //Lo guardamos 
                    this.InventarioContext.SaveChanges();
                    MessageBox.Show("Cliente registrado con exito!.");
                    //Actualizar
                    dataGridViewcliente.Refresh();
                    //limpiar
                    box_cedulacliente.Text = null;
                    Box_nombrecliente.Text = null;


                }
                else
                {
                    MessageBox.Show("Recuerda rellenar todos los campos");
                }
            }
            catch
            {

                MessageBox.Show("Recuerda rellenar todos los campos correctamente");
            }
        }

        private void Btn_registracliente_Click(object sender, EventArgs e)
        {
            double cedula = double.Parse(box_cedulacliente.Text);
            var validar = this.InventarioContext.Clientes.FirstOrDefault(cliente => cliente.Cedula == cedula);

            if (validar != null)
            {
                MessageBox.Show("Esta cedula ya esta registrada!");
                box_cedulacliente.Text = null;
            }
            else
            {
                RegistrarCliente();
            }

        }

        private void dataGridViewcliente_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Ocurrió un error al manejar los datos: " + e.Exception!.Message);
            e.ThrowException = false; // Evita que el error se propague
        }
        private void BuscarCliente()
        {
            try
            {
                //Confirma que el box no este vacio
                if (string.IsNullOrWhiteSpace(Box_nombrecliente.Text))
                {
                    var clientes = this.InventarioContext.Clientes.ToList();
                    dataGridViewcliente.DataSource = clientes;

                }
                else
                {
                    //conversion de string a double 
                    double cedula = double.Parse(Box_nombrecliente.Text);
                    //busqueda del cliente
                    var busqueda = this.InventarioContext.Clientes.Where(p => p.Cedula == cedula).ToList();
                    //confirmacion de datos
                    if (busqueda != null)
                    {
                        dataGridViewcliente.DataSource = busqueda;
                    }
                    else
                    {
                        MessageBox.Show("Cliente no encontrado.");
                        box_cedulacliente.Text = null;
                    }
                }

            }
            catch
            {
                MessageBox.Show("Recuerda rellenar todos los campos correctamente");
                Box_nombrecliente.Text = null;
            }
        }

        private void Btn_BuscarCliente_Click(object sender, EventArgs e)
        {
            BuscarCliente();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //buscar denuevo la base de datos
            var cliente = this.InventarioContext.Clientes.ToList();
            dataGridViewcliente.DataSource = cliente;
        }
    }
}
