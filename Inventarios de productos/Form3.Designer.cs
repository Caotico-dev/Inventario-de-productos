namespace Inventarios_de_productos_
{
    partial class Formlistaclientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formlistaclientes));
            label1 = new Label();
            dataGridViewcliente = new DataGridView();
            clienteIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cedulaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            clienteBindingSource = new BindingSource(components);
            label2 = new Label();
            label3 = new Label();
            Box_nombrecliente = new TextBox();
            box_cedulacliente = new TextBox();
            Btn_registracliente = new Button();
            dataGridView2 = new DataGridView();
            comprasIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            clienteIdDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            productoIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cantidadDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            clienteDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            comprasBindingSource = new BindingSource(components);
            label4 = new Label();
            button2 = new Button();
            Btn_BuscarCliente = new Button();
            Box_BuscarProducto = new TextBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewcliente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)comprasBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(31, 19);
            label1.Name = "label1";
            label1.Size = new Size(255, 45);
            label1.TabIndex = 0;
            label1.Text = "Lista de clientes";
            // 
            // dataGridViewcliente
            // 
            dataGridViewcliente.AutoGenerateColumns = false;
            dataGridViewcliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewcliente.Columns.AddRange(new DataGridViewColumn[] { clienteIdDataGridViewTextBoxColumn, nombreDataGridViewTextBoxColumn, cedulaDataGridViewTextBoxColumn });
            dataGridViewcliente.DataSource = clienteBindingSource;
            dataGridViewcliente.Location = new Point(31, 67);
            dataGridViewcliente.Name = "dataGridViewcliente";
            dataGridViewcliente.Size = new Size(344, 237);
            dataGridViewcliente.TabIndex = 1;
            dataGridViewcliente.DataError += dataGridViewcliente_DataError;
            dataGridViewcliente.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // clienteIdDataGridViewTextBoxColumn
            // 
            clienteIdDataGridViewTextBoxColumn.DataPropertyName = "ClienteId";
            clienteIdDataGridViewTextBoxColumn.HeaderText = "ClienteId";
            clienteIdDataGridViewTextBoxColumn.Name = "clienteIdDataGridViewTextBoxColumn";
            clienteIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cedulaDataGridViewTextBoxColumn
            // 
            cedulaDataGridViewTextBoxColumn.DataPropertyName = "Cedula";
            cedulaDataGridViewTextBoxColumn.HeaderText = "Cedula";
            cedulaDataGridViewTextBoxColumn.Name = "cedulaDataGridViewTextBoxColumn";
            cedulaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clienteBindingSource
            // 
            clienteBindingSource.DataSource = typeof(Cliente);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(31, 319);
            label2.Name = "label2";
            label2.Size = new Size(73, 21);
            label2.TabIndex = 2;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(137, 319);
            label3.Name = "label3";
            label3.Size = new Size(63, 21);
            label3.TabIndex = 3;
            label3.Text = "Cedula";
            // 
            // Box_nombrecliente
            // 
            Box_nombrecliente.Location = new Point(31, 343);
            Box_nombrecliente.Name = "Box_nombrecliente";
            Box_nombrecliente.Size = new Size(100, 23);
            Box_nombrecliente.TabIndex = 4;
            // 
            // box_cedulacliente
            // 
            box_cedulacliente.Location = new Point(137, 343);
            box_cedulacliente.Name = "box_cedulacliente";
            box_cedulacliente.Size = new Size(100, 23);
            box_cedulacliente.TabIndex = 5;
            // 
            // Btn_registracliente
            // 
            Btn_registracliente.Cursor = Cursors.Hand;
            Btn_registracliente.Location = new Point(255, 343);
            Btn_registracliente.Name = "Btn_registracliente";
            Btn_registracliente.Size = new Size(75, 23);
            Btn_registracliente.TabIndex = 6;
            Btn_registracliente.Text = "Registrar";
            Btn_registracliente.UseVisualStyleBackColor = true;
            Btn_registracliente.Click += Btn_registracliente_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { comprasIdDataGridViewTextBoxColumn, clienteIdDataGridViewTextBoxColumn1, productoIdDataGridViewTextBoxColumn, cantidadDataGridViewTextBoxColumn, clienteDataGridViewTextBoxColumn });
            dataGridView2.DataSource = comprasBindingSource;
            dataGridView2.Location = new Point(418, 71);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(444, 237);
            dataGridView2.TabIndex = 7;
            // 
            // comprasIdDataGridViewTextBoxColumn
            // 
            comprasIdDataGridViewTextBoxColumn.DataPropertyName = "ComprasId";
            comprasIdDataGridViewTextBoxColumn.HeaderText = "ComprasId";
            comprasIdDataGridViewTextBoxColumn.Name = "comprasIdDataGridViewTextBoxColumn";
            comprasIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clienteIdDataGridViewTextBoxColumn1
            // 
            clienteIdDataGridViewTextBoxColumn1.DataPropertyName = "ClienteId";
            clienteIdDataGridViewTextBoxColumn1.HeaderText = "ClienteId";
            clienteIdDataGridViewTextBoxColumn1.Name = "clienteIdDataGridViewTextBoxColumn1";
            clienteIdDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // productoIdDataGridViewTextBoxColumn
            // 
            productoIdDataGridViewTextBoxColumn.DataPropertyName = "ProductoId";
            productoIdDataGridViewTextBoxColumn.HeaderText = "ProductoId";
            productoIdDataGridViewTextBoxColumn.Name = "productoIdDataGridViewTextBoxColumn";
            productoIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
            cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            cantidadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clienteDataGridViewTextBoxColumn
            // 
            clienteDataGridViewTextBoxColumn.DataPropertyName = "Cliente";
            clienteDataGridViewTextBoxColumn.HeaderText = "Cliente";
            clienteDataGridViewTextBoxColumn.Name = "clienteDataGridViewTextBoxColumn";
            clienteDataGridViewTextBoxColumn.ReadOnly = true;
            clienteDataGridViewTextBoxColumn.Visible = false;
            // 
            // comprasBindingSource
            // 
            comprasBindingSource.DataMember = "Compras";
            comprasBindingSource.DataSource = clienteBindingSource;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(420, 23);
            label4.Name = "label4";
            label4.Size = new Size(162, 45);
            label4.TabIndex = 8;
            label4.Text = "Compras ";
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Location = new Point(635, 342);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 29;
            button2.Text = "Restablecer";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Btn_BuscarCliente
            // 
            Btn_BuscarCliente.Cursor = Cursors.Hand;
            Btn_BuscarCliente.Location = new Point(554, 344);
            Btn_BuscarCliente.Name = "Btn_BuscarCliente";
            Btn_BuscarCliente.Size = new Size(75, 23);
            Btn_BuscarCliente.TabIndex = 28;
            Btn_BuscarCliente.Text = "Buscar ";
            Btn_BuscarCliente.UseVisualStyleBackColor = true;
            Btn_BuscarCliente.Click += Btn_BuscarCliente_Click;
            // 
            // Box_BuscarProducto
            // 
            Box_BuscarProducto.Location = new Point(420, 344);
            Box_BuscarProducto.Name = "Box_BuscarProducto";
            Box_BuscarProducto.Size = new Size(127, 23);
            Box_BuscarProducto.TabIndex = 27;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(420, 325);
            label7.Name = "label7";
            label7.Size = new Size(49, 15);
            label7.TabIndex = 26;
            label7.Text = "Cedula";
            // 
            // Formlistaclientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(876, 391);
            Controls.Add(button2);
            Controls.Add(Btn_BuscarCliente);
            Controls.Add(Box_BuscarProducto);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(dataGridView2);
            Controls.Add(Btn_registracliente);
            Controls.Add(box_cedulacliente);
            Controls.Add(Box_nombrecliente);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridViewcliente);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Formlistaclientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lista de clientes";
            FormClosing += Formlistaclientes_FormClosing;
            Load += Formlistaclientes_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewcliente).EndInit();
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)comprasBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridViewcliente;
        private Label label2;
        private Label label3;
        private TextBox Box_nombrecliente;
        private TextBox box_cedulacliente;
        private Button Btn_registracliente;
        private DataGridView dataGridView2;
        private Label label4;
        private DataGridViewTextBoxColumn productoDataGridViewTextBoxColumn;
        private BindingSource clienteBindingSource;
        private BindingSource comprasBindingSource;
        private DataGridViewTextBoxColumn clienteIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cedulaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn comprasIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn clienteIdDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn productoIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn clienteDataGridViewTextBoxColumn;
        private Button button2;
        private Button Btn_BuscarCliente;
        private TextBox Box_BuscarProducto;
        private Label label7;
    }
}