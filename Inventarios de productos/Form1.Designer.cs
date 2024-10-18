namespace Inventarios_de_productos_
{
    partial class InicioInventario
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioInventario));
            dataGridView1 = new DataGridView();
            productoIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descripcionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cantidadDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            precioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productoBindingSource = new BindingSource(components);
            label1 = new Label();
            Btn_AñadirProductos = new Button();
            Btn_ModificarEliminar = new Button();
            Btn_VenderProductos = new Button();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            Btn_ListaClientes = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            Box_nombre = new TextBox();
            Box_cantida = new TextBox();
            Box_descripcion = new TextBox();
            button1 = new Button();
            Box_Precio = new TextBox();
            label6 = new Label();
            label7 = new Label();
            Box_BuscarProducto = new TextBox();
            Btn_BuscarProducto = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { productoIdDataGridViewTextBoxColumn, nombreDataGridViewTextBoxColumn, descripcionDataGridViewTextBoxColumn, cantidadDataGridViewTextBoxColumn, precioDataGridViewTextBoxColumn });
            dataGridView1.DataSource = productoBindingSource;
            dataGridView1.Location = new Point(12, 59);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(643, 379);
            dataGridView1.TabIndex = 0;
            // 
            // productoIdDataGridViewTextBoxColumn
            // 
            productoIdDataGridViewTextBoxColumn.DataPropertyName = "ProductoId";
            productoIdDataGridViewTextBoxColumn.HeaderText = "ProductoId";
            productoIdDataGridViewTextBoxColumn.Name = "productoIdDataGridViewTextBoxColumn";
            productoIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            descripcionDataGridViewTextBoxColumn.Width = 200;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
            cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            cantidadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precioDataGridViewTextBoxColumn
            // 
            precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            precioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productoBindingSource
            // 
            productoBindingSource.DataSource = typeof(Producto);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(200, 47);
            label1.TabIndex = 1;
            label1.Text = "Inventario";
            // 
            // Btn_AñadirProductos
            // 
            Btn_AñadirProductos.Cursor = Cursors.Hand;
            Btn_AñadirProductos.Location = new Point(437, 466);
            Btn_AñadirProductos.Name = "Btn_AñadirProductos";
            Btn_AñadirProductos.Size = new Size(128, 23);
            Btn_AñadirProductos.TabIndex = 2;
            Btn_AñadirProductos.Text = "Añadir Productos";
            Btn_AñadirProductos.UseVisualStyleBackColor = true;
            Btn_AñadirProductos.Click += Btn_AñadirProductos_Click;
            // 
            // Btn_ModificarEliminar
            // 
            Btn_ModificarEliminar.Cursor = Cursors.Hand;
            Btn_ModificarEliminar.Location = new Point(685, 346);
            Btn_ModificarEliminar.Name = "Btn_ModificarEliminar";
            Btn_ModificarEliminar.Size = new Size(128, 23);
            Btn_ModificarEliminar.TabIndex = 3;
            Btn_ModificarEliminar.Text = "Modificar o Eliminar";
            Btn_ModificarEliminar.UseVisualStyleBackColor = true;
            Btn_ModificarEliminar.Click += button2_Click;
            // 
            // Btn_VenderProductos
            // 
            Btn_VenderProductos.Cursor = Cursors.Hand;
            Btn_VenderProductos.Location = new Point(819, 346);
            Btn_VenderProductos.Name = "Btn_VenderProductos";
            Btn_VenderProductos.Size = new Size(144, 23);
            Btn_VenderProductos.TabIndex = 5;
            Btn_VenderProductos.Text = "Vender Productos";
            Btn_VenderProductos.UseVisualStyleBackColor = true;
            Btn_VenderProductos.Click += Btn_VenderProductos_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(685, 74);
            label2.Name = "label2";
            label2.Size = new Size(253, 32);
            label2.TabIndex = 6;
            label2.Text = "Gestionar Inventario";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.png_clipart_inventory_management_software_inventory_control_cartoon_inventory_management_service_public_relations2;
            pictureBox1.Location = new Point(685, 142);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(268, 178);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // Btn_ListaClientes
            // 
            Btn_ListaClientes.Cursor = Cursors.Hand;
            Btn_ListaClientes.Location = new Point(685, 375);
            Btn_ListaClientes.Name = "Btn_ListaClientes";
            Btn_ListaClientes.Size = new Size(128, 23);
            Btn_ListaClientes.TabIndex = 8;
            Btn_ListaClientes.Text = "Lista de Clientes";
            Btn_ListaClientes.UseVisualStyleBackColor = true;
            Btn_ListaClientes.Click += Btn_ListaClientes_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 447);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 9;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(118, 448);
            label4.Name = "label4";
            label4.Size = new Size(78, 15);
            label4.TabIndex = 10;
            label4.Text = "Descripcion";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(224, 448);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 11;
            label5.Text = "Cantida";
            // 
            // Box_nombre
            // 
            Box_nombre.Location = new Point(12, 466);
            Box_nombre.Name = "Box_nombre";
            Box_nombre.Size = new Size(100, 23);
            Box_nombre.TabIndex = 12;
            // 
            // Box_cantida
            // 
            Box_cantida.Location = new Point(224, 466);
            Box_cantida.Name = "Box_cantida";
            Box_cantida.Size = new Size(100, 23);
            Box_cantida.TabIndex = 13;
            // 
            // Box_descripcion
            // 
            Box_descripcion.Location = new Point(118, 466);
            Box_descripcion.Name = "Box_descripcion";
            Box_descripcion.Size = new Size(100, 23);
            Box_descripcion.TabIndex = 14;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(819, 375);
            button1.Name = "button1";
            button1.Size = new Size(144, 23);
            button1.TabIndex = 15;
            button1.Text = "Estadisticas y Reportes";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Box_Precio
            // 
            Box_Precio.Location = new Point(331, 465);
            Box_Precio.Name = "Box_Precio";
            Box_Precio.Size = new Size(100, 23);
            Box_Precio.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(331, 447);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 17;
            label6.Text = "Precio";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(685, 447);
            label7.Name = "label7";
            label7.Size = new Size(60, 15);
            label7.TabIndex = 18;
            label7.Text = "Nombre:";
            // 
            // Box_BuscarProducto
            // 
            Box_BuscarProducto.Location = new Point(685, 466);
            Box_BuscarProducto.Name = "Box_BuscarProducto";
            Box_BuscarProducto.Size = new Size(127, 23);
            Box_BuscarProducto.TabIndex = 19;
            // 
            // Btn_BuscarProducto
            // 
            Btn_BuscarProducto.Cursor = Cursors.Hand;
            Btn_BuscarProducto.Location = new Point(819, 466);
            Btn_BuscarProducto.Name = "Btn_BuscarProducto";
            Btn_BuscarProducto.Size = new Size(75, 23);
            Btn_BuscarProducto.TabIndex = 20;
            Btn_BuscarProducto.Text = "Buscar ";
            Btn_BuscarProducto.UseVisualStyleBackColor = true;
            Btn_BuscarProducto.Click += Btn_BuscarProducto_Click;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Location = new Point(900, 464);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 21;
            button2.Text = "Restablecer";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // InicioInventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(1053, 500);
            Controls.Add(button2);
            Controls.Add(Btn_BuscarProducto);
            Controls.Add(Box_BuscarProducto);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(Box_Precio);
            Controls.Add(button1);
            Controls.Add(Box_descripcion);
            Controls.Add(Box_cantida);
            Controls.Add(Box_nombre);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(Btn_ListaClientes);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(Btn_VenderProductos);
            Controls.Add(Btn_ModificarEliminar);
            Controls.Add(Btn_AñadirProductos);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "InicioInventario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            Load += InicioInventario_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)productoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Button Btn_AñadirProductos;
        private Button Btn_ModificarEliminar;
        private Button Btn_VenderProductos;
        private Label label2;
        private PictureBox pictureBox1;
        private Button Btn_ListaClientes;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox Box_nombre;
        private TextBox Box_cantida;
        private TextBox Box_descripcion;
        private Button button1;
        private TextBox Box_Precio;
        private Label label6;
        private BindingSource productoBindingSource;
        private DataGridViewTextBoxColumn productoIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private Label label7;
        private TextBox Box_BuscarProducto;
        private Button Btn_BuscarProducto;
        private Button button2;
    }
}
