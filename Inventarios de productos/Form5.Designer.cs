namespace Inventarios_de_productos_
{
    partial class FormEstadisticayReportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEstadisticayReportes));
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            Lb_ProductosRegistrados = new Label();
            Lb_ClienteRegistrados = new Label();
            Lb_GananciasProyectadas = new Label();
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productoIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            comentarioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            reportesBindingSource = new BindingSource(components);
            label10 = new Label();
            listViewA = new ListView();
            ProductoId = new ColumnHeader();
            Nombre = new ColumnHeader();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)reportesBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(4, -2);
            label1.Name = "label1";
            label1.Size = new Size(212, 45);
            label1.TabIndex = 0;
            label1.Text = "Estadisiticas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(4, 64);
            label2.Name = "label2";
            label2.Size = new Size(214, 25);
            label2.TabIndex = 1;
            label2.Text = "Productos registrados:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(4, 146);
            label4.Name = "label4";
            label4.Size = new Size(220, 25);
            label4.TabIndex = 3;
            label4.Text = "Ganancias proyectadas:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(4, 101);
            label5.Name = "label5";
            label5.Size = new Size(191, 25);
            label5.TabIndex = 4;
            label5.Text = "Clientes registrados:";
            // 
            // Lb_ProductosRegistrados
            // 
            Lb_ProductosRegistrados.AutoSize = true;
            Lb_ProductosRegistrados.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lb_ProductosRegistrados.Location = new Point(245, 64);
            Lb_ProductosRegistrados.Name = "Lb_ProductosRegistrados";
            Lb_ProductosRegistrados.Size = new Size(23, 25);
            Lb_ProductosRegistrados.TabIndex = 5;
            Lb_ProductosRegistrados.Text = "0";
            // 
            // Lb_ClienteRegistrados
            // 
            Lb_ClienteRegistrados.AutoSize = true;
            Lb_ClienteRegistrados.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lb_ClienteRegistrados.Location = new Point(245, 101);
            Lb_ClienteRegistrados.Name = "Lb_ClienteRegistrados";
            Lb_ClienteRegistrados.Size = new Size(23, 25);
            Lb_ClienteRegistrados.TabIndex = 6;
            Lb_ClienteRegistrados.Text = "0";
            // 
            // Lb_GananciasProyectadas
            // 
            Lb_GananciasProyectadas.AutoSize = true;
            Lb_GananciasProyectadas.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lb_GananciasProyectadas.Location = new Point(245, 146);
            Lb_GananciasProyectadas.Name = "Lb_GananciasProyectadas";
            Lb_GananciasProyectadas.Size = new Size(23, 25);
            Lb_GananciasProyectadas.TabIndex = 8;
            Lb_GananciasProyectadas.Text = "0";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, productoIdDataGridViewTextBoxColumn, nombreDataGridViewTextBoxColumn, comentarioDataGridViewTextBoxColumn });
            dataGridView1.DataSource = reportesBindingSource;
            dataGridView1.Location = new Point(336, 64);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(514, 347);
            dataGridView1.TabIndex = 9;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 70;
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
            // comentarioDataGridViewTextBoxColumn
            // 
            comentarioDataGridViewTextBoxColumn.DataPropertyName = "Comentario";
            comentarioDataGridViewTextBoxColumn.HeaderText = "Comentario";
            comentarioDataGridViewTextBoxColumn.Name = "comentarioDataGridViewTextBoxColumn";
            comentarioDataGridViewTextBoxColumn.Width = 200;
            // 
            // reportesBindingSource
            // 
            reportesBindingSource.DataSource = typeof(Reportes);
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(336, 16);
            label10.Name = "label10";
            label10.Size = new Size(161, 45);
            label10.TabIndex = 10;
            label10.Text = "Reportes";
            // 
            // listViewA
            // 
            listViewA.Columns.AddRange(new ColumnHeader[] { ProductoId, Nombre });
            listViewA.Location = new Point(25, 241);
            listViewA.Name = "listViewA";
            listViewA.Size = new Size(243, 151);
            listViewA.TabIndex = 11;
            listViewA.UseCompatibleStateImageBehavior = false;
            listViewA.View = View.Details;
            // 
            // ProductoId
            // 
            ProductoId.Text = "ProductoId";
            ProductoId.Width = 80;
            // 
            // Nombre
            // 
            Nombre.Text = "Nombre";
            Nombre.Width = 140;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(25, 213);
            label6.Name = "label6";
            label6.Size = new Size(238, 25);
            label6.TabIndex = 12;
            label6.Text = "Productos casi agotados";
            // 
            // FormEstadisticayReportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(862, 450);
            Controls.Add(label6);
            Controls.Add(listViewA);
            Controls.Add(label10);
            Controls.Add(dataGridView1);
            Controls.Add(Lb_GananciasProyectadas);
            Controls.Add(Lb_ClienteRegistrados);
            Controls.Add(Lb_ProductosRegistrados);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FormEstadisticayReportes";
            Text = "Estadisticas y Reportes";
            FormClosing += FormEstadisticayReportes_FormClosing;
            Load += FormEstadisticayReportes_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)reportesBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label Lb_ProductosRegistrados;
        private Label Lb_ClienteRegistrados;
        private Label Lb_GananciasProyectadas;
        private DataGridView dataGridView1;
        private Label label10;
        private ListView listViewA;
        private Label label6;
        private ColumnHeader ProductoId;
        private ColumnHeader Nombre;
        private BindingSource reportesBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productoIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn comentarioDataGridViewTextBoxColumn;
    }
}