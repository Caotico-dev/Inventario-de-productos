namespace Inventarios_de_productos_
{
    partial class FormVenderProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVenderProductos));
            dataGridViewVender = new DataGridView();
            productoIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descripcionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cantidadDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            precioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productoBindingSource = new BindingSource(components);
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Box_id = new TextBox();
            Box_cedula = new TextBox();
            Box_cantidad = new TextBox();
            Btn_vender = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVender).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewVender
            // 
            dataGridViewVender.AutoGenerateColumns = false;
            dataGridViewVender.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewVender.Columns.AddRange(new DataGridViewColumn[] { productoIdDataGridViewTextBoxColumn, nombreDataGridViewTextBoxColumn, descripcionDataGridViewTextBoxColumn, cantidadDataGridViewTextBoxColumn, precioDataGridViewTextBoxColumn });
            dataGridViewVender.DataSource = productoBindingSource;
            dataGridViewVender.Location = new Point(49, 59);
            dataGridViewVender.Name = "dataGridViewVender";
            dataGridViewVender.Size = new Size(644, 297);
            dataGridViewVender.TabIndex = 0;
            // 
            // productoIdDataGridViewTextBoxColumn
            // 
            productoIdDataGridViewTextBoxColumn.DataPropertyName = "ProductoId";
            productoIdDataGridViewTextBoxColumn.HeaderText = "ProductoId";
            productoIdDataGridViewTextBoxColumn.Name = "productoIdDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            descripcionDataGridViewTextBoxColumn.Width = 200;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
            cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            // 
            // precioDataGridViewTextBoxColumn
            // 
            precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            // 
            // productoBindingSource
            // 
            productoBindingSource.DataSource = typeof(Producto);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(49, 9);
            label1.Name = "label1";
            label1.Size = new Size(200, 47);
            label1.TabIndex = 2;
            label1.Text = "Inventario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(49, 359);
            label2.Name = "label2";
            label2.Size = new Size(31, 25);
            label2.TabIndex = 3;
            label2.Text = "Id";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(281, 359);
            label3.Name = "label3";
            label3.Size = new Size(76, 25);
            label3.TabIndex = 4;
            label3.Text = "Cedula";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(165, 359);
            label4.Name = "label4";
            label4.Size = new Size(84, 25);
            label4.TabIndex = 5;
            label4.Text = "Cantida";
            // 
            // Box_id
            // 
            Box_id.Location = new Point(49, 387);
            Box_id.Name = "Box_id";
            Box_id.Size = new Size(100, 23);
            Box_id.TabIndex = 6;
            // 
            // Box_cedula
            // 
            Box_cedula.Location = new Point(281, 387);
            Box_cedula.Name = "Box_cedula";
            Box_cedula.Size = new Size(100, 23);
            Box_cedula.TabIndex = 7;
            // 
            // Box_cantidad
            // 
            Box_cantidad.Location = new Point(165, 387);
            Box_cantidad.Name = "Box_cantidad";
            Box_cantidad.Size = new Size(100, 23);
            Box_cantidad.TabIndex = 8;
            // 
            // Btn_vender
            // 
            Btn_vender.Cursor = Cursors.Hand;
            Btn_vender.Location = new Point(387, 387);
            Btn_vender.Name = "Btn_vender";
            Btn_vender.Size = new Size(75, 23);
            Btn_vender.TabIndex = 9;
            Btn_vender.Text = "Vender";
            Btn_vender.UseVisualStyleBackColor = true;
            Btn_vender.Click += Btn_vender_Click;
            // 
            // FormVenderProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(729, 422);
            Controls.Add(Btn_vender);
            Controls.Add(Box_cantidad);
            Controls.Add(Box_cedula);
            Controls.Add(Box_id);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridViewVender);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FormVenderProductos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Caja de ventas";
            FormClosing += FormVenderProductos_FormClosing;
            Load += FormVenderProductos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewVender).EndInit();
            ((System.ComponentModel.ISupportInitialize)productoBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewVender;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox Box_id;
        private TextBox Box_cedula;
        private TextBox Box_cantidad;
        private Button Btn_vender;
        private BindingSource productoBindingSource;
        private DataGridViewTextBoxColumn productoIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
    }
}