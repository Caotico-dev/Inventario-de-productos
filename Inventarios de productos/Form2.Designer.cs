namespace Inventarios_de_productos_
{
    partial class FormEliminarProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEliminarProductos));
            label1 = new Label();
            label2 = new Label();
            box_id = new TextBox();
            box_Comentario = new TextBox();
            pictureBox1 = new PictureBox();
            Btn_eliminar = new Button();
            label4 = new Label();
            Lb_valor = new Label();
            Box_id2 = new TextBox();
            Box_valor = new TextBox();
            Btn_modificar = new Button();
            combox = new ComboBox();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            Box_nombrepro = new TextBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 319);
            label1.Name = "label1";
            label1.Size = new Size(25, 21);
            label1.TabIndex = 0;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(223, 319);
            label2.Name = "label2";
            label2.Size = new Size(100, 21);
            label2.TabIndex = 1;
            label2.Text = "Comentario";
            // 
            // box_id
            // 
            box_id.Location = new Point(12, 343);
            box_id.Name = "box_id";
            box_id.Size = new Size(75, 23);
            box_id.TabIndex = 2;
            // 
            // box_Comentario
            // 
            box_Comentario.Location = new Point(223, 343);
            box_Comentario.Name = "box_Comentario";
            box_Comentario.Size = new Size(161, 23);
            box_Comentario.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.n1;
            pictureBox1.Location = new Point(82, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(323, 250);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // Btn_eliminar
            // 
            Btn_eliminar.Cursor = Cursors.Hand;
            Btn_eliminar.Location = new Point(394, 343);
            Btn_eliminar.Name = "Btn_eliminar";
            Btn_eliminar.Size = new Size(75, 23);
            Btn_eliminar.TabIndex = 5;
            Btn_eliminar.Text = "Eliminar";
            Btn_eliminar.UseVisualStyleBackColor = true;
            Btn_eliminar.Click += Btn_eliminar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(94, 423);
            label4.Name = "label4";
            label4.Size = new Size(111, 21);
            label4.TabIndex = 7;
            label4.Text = "Modificacion";
            // 
            // Lb_valor
            // 
            Lb_valor.AutoSize = true;
            Lb_valor.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lb_valor.Location = new Point(279, 418);
            Lb_valor.Name = "Lb_valor";
            Lb_valor.Size = new Size(0, 25);
            Lb_valor.TabIndex = 8;
            // 
            // Box_id2
            // 
            Box_id2.Location = new Point(12, 446);
            Box_id2.Name = "Box_id2";
            Box_id2.Size = new Size(75, 23);
            Box_id2.TabIndex = 9;
            // 
            // Box_valor
            // 
            Box_valor.Location = new Point(279, 446);
            Box_valor.Name = "Box_valor";
            Box_valor.Size = new Size(100, 23);
            Box_valor.TabIndex = 10;
            // 
            // Btn_modificar
            // 
            Btn_modificar.Cursor = Cursors.Hand;
            Btn_modificar.Location = new Point(394, 446);
            Btn_modificar.Name = "Btn_modificar";
            Btn_modificar.Size = new Size(75, 23);
            Btn_modificar.TabIndex = 11;
            Btn_modificar.Text = "Modificar";
            Btn_modificar.UseVisualStyleBackColor = true;
            Btn_modificar.Click += Btn_modificar_Click;
            // 
            // combox
            // 
            combox.FormattingEnabled = true;
            combox.Items.AddRange(new object[] { "Nombre", "Descripcion", "Precio", "Cantidad" });
            combox.Location = new Point(93, 447);
            combox.Name = "combox";
            combox.Size = new Size(147, 23);
            combox.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 423);
            label3.Name = "label3";
            label3.Size = new Size(25, 21);
            label3.TabIndex = 6;
            label3.Text = "Id";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 289);
            label5.Name = "label5";
            label5.Size = new Size(179, 25);
            label5.TabIndex = 13;
            label5.Text = "Eliminar Producto";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 393);
            label6.Name = "label6";
            label6.Size = new Size(193, 25);
            label6.TabIndex = 14;
            label6.Text = "Modificar Producto";
            // 
            // Box_nombrepro
            // 
            Box_nombrepro.Location = new Point(93, 344);
            Box_nombrepro.Name = "Box_nombrepro";
            Box_nombrepro.Size = new Size(124, 23);
            Box_nombrepro.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(94, 320);
            label7.Name = "label7";
            label7.Size = new Size(73, 21);
            label7.TabIndex = 16;
            label7.Text = "Nombre";
            // 
            // FormEliminarProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(520, 491);
            Controls.Add(label7);
            Controls.Add(Box_nombrepro);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(combox);
            Controls.Add(Btn_modificar);
            Controls.Add(Box_valor);
            Controls.Add(Box_id2);
            Controls.Add(Lb_valor);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(Btn_eliminar);
            Controls.Add(pictureBox1);
            Controls.Add(box_Comentario);
            Controls.Add(box_id);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FormEliminarProductos";
            Text = "Gestion inventario";
            FormClosing += FormEliminarProductos_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox box_id;
        private TextBox box_Comentario;
        private PictureBox pictureBox1;
        private Button Btn_eliminar;
        private Label label4;
        private Label Lb_valor;
        private TextBox Box_id2;
        private TextBox Box_valor;
        private Button Btn_modificar;
        private ComboBox combox;
        private Label label3;
        private Label label5;
        private Label label6;
        private TextBox Box_nombrepro;
        private Label label7;
    }
}