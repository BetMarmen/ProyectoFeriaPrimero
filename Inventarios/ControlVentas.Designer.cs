namespace Inventarios
{
    partial class ControlVentas
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
            this.label5 = new System.Windows.Forms.Label();
            this.cboFormato = new System.Windows.Forms.ComboBox();
            this.dataVentas = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnregistar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nuCantidad = new System.Windows.Forms.NumericUpDown();
            this.nuPrecio = new System.Windows.Forms.NumericUpDown();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtVentasT = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnMini = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.PictureBox();
            this.btnVolver = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataVentas)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVolver)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(62, 379);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(278, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "¿En qué formato desea exportarlo?";
            // 
            // cboFormato
            // 
            this.cboFormato.FormattingEnabled = true;
            this.cboFormato.Items.AddRange(new object[] {
            "PDF",
            "WORD",
            "EXCEL",
            "TXT"});
            this.cboFormato.Location = new System.Drawing.Point(349, 379);
            this.cboFormato.Name = "cboFormato";
            this.cboFormato.Size = new System.Drawing.Size(121, 28);
            this.cboFormato.TabIndex = 13;
            this.cboFormato.SelectedIndexChanged += new System.EventHandler(this.cboFormato_SelectedIndexChanged);
            // 
            // dataVentas
            // 
            this.dataVentas.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.dataVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataVentas.Location = new System.Drawing.Point(62, 153);
            this.dataVentas.Name = "dataVentas";
            this.dataVentas.RowTemplate.Height = 29;
            this.dataVentas.Size = new System.Drawing.Size(473, 138);
            this.dataVentas.TabIndex = 12;
            this.dataVentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataVentas_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Producto";
            this.Column1.Name = "Column1";
            this.Column1.Width = 120;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Precio";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Cantidad";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Total";
            this.Column4.Name = "Column4";
            this.Column4.Width = 120;
            // 
            // btnregistar
            // 
            this.btnregistar.BackColor = System.Drawing.Color.Transparent;
            this.btnregistar.BackgroundImage = global::Inventarios.Properties.Resources.agregar_archivo1;
            this.btnregistar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnregistar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnregistar.Location = new System.Drawing.Point(349, 316);
            this.btnregistar.Name = "btnregistar";
            this.btnregistar.Size = new System.Drawing.Size(52, 53);
            this.btnregistar.TabIndex = 11;
            this.btnregistar.UseVisualStyleBackColor = false;
            this.btnregistar.Click += new System.EventHandler(this.btnregistar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.nuCantidad);
            this.groupBox1.Controls.Add(this.nuPrecio);
            this.groupBox1.Controls.Add(this.txtProducto);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(62, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(473, 114);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS ";
            // 
            // nuCantidad
            // 
            this.nuCantidad.Location = new System.Drawing.Point(334, 70);
            this.nuCantidad.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nuCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuCantidad.Name = "nuCantidad";
            this.nuCantidad.Size = new System.Drawing.Size(120, 29);
            this.nuCantidad.TabIndex = 6;
            this.nuCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nuCantidad_KeyPress);
            // 
            // nuPrecio
            // 
            this.nuPrecio.Location = new System.Drawing.Point(177, 70);
            this.nuPrecio.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nuPrecio.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuPrecio.Name = "nuPrecio";
            this.nuPrecio.Size = new System.Drawing.Size(120, 29);
            this.nuPrecio.TabIndex = 5;
            this.nuPrecio.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nuPrecio_KeyPress);
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(29, 70);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(100, 29);
            this.txtProducto.TabIndex = 4;
            this.txtProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProducto_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SimSun-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(29, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "PRODUCTO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("SimSun-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(346, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "CANTIDAD:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SimSun-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(208, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "PRECIO:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(185, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Control de Ventas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(53, 315);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 19);
            this.label6.TabIndex = 15;
            this.label6.Text = "Ventas Totales:";
            // 
            // txtVentasT
            // 
            this.txtVentasT.Location = new System.Drawing.Point(185, 311);
            this.txtVentasT.Name = "txtVentasT";
            this.txtVentasT.ReadOnly = true;
            this.txtVentasT.Size = new System.Drawing.Size(100, 27);
            this.txtVentasT.TabIndex = 16;
            this.txtVentasT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVentasT_KeyPress);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BackgroundImage = global::Inventarios.Properties.Resources.guardar_el_archivo1;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Location = new System.Drawing.Point(434, 315);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(52, 53);
            this.btnSave.TabIndex = 17;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.BackgroundImage = global::Inventarios.Properties.Resources.eliminar1;
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Location = new System.Drawing.Point(504, 315);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(52, 53);
            this.btnEliminar.TabIndex = 18;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(504, 294);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 19);
            this.label9.TabIndex = 21;
            this.label9.Text = "Eliminar";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(427, 294);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 19);
            this.label8.TabIndex = 20;
            this.label8.Text = "Guardar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(349, 294);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 19);
            this.label7.TabIndex = 19;
            this.label7.Text = "Agregar";
            // 
            // btnMini
            // 
            this.btnMini.BackColor = System.Drawing.Color.Transparent;
            this.btnMini.Image = global::Inventarios.Properties.Resources.minimizar_signo1;
            this.btnMini.Location = new System.Drawing.Point(504, -3);
            this.btnMini.Name = "btnMini";
            this.btnMini.Size = new System.Drawing.Size(37, 36);
            this.btnMini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMini.TabIndex = 23;
            this.btnMini.TabStop = false;
            this.btnMini.Click += new System.EventHandler(this.btnMini_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.Image = global::Inventarios.Properties.Resources.marca_x1;
            this.btnSalir.Location = new System.Drawing.Point(552, -3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(37, 36);
            this.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSalir.TabIndex = 22;
            this.btnSalir.TabStop = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Transparent;
            this.btnVolver.Image = global::Inventarios.Properties.Resources.flecha_izquierda;
            this.btnVolver.Location = new System.Drawing.Point(3, -3);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(42, 36);
            this.btnVolver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnVolver.TabIndex = 24;
            this.btnVolver.TabStop = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // ControlVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImage = global::Inventarios.Properties.Resources._131998868_fondo_azul_de_tecnología_de_datos_elementos_gráficos_números_y_degradados_de_color_combinados_en;
            this.ClientSize = new System.Drawing.Size(603, 422);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnMini);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtVentasT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboFormato);
            this.Controls.Add(this.dataVentas);
            this.Controls.Add(this.btnregistar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ControlVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ControlVentas";
            ((System.ComponentModel.ISupportInitialize)(this.dataVentas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVolver)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label5;
        private ComboBox cboFormato;
        private DataGridView dataVentas;
        private Button btnregistar;
        private GroupBox groupBox1;
        private NumericUpDown nuCantidad;
        private NumericUpDown nuPrecio;
        private TextBox txtProducto;
        private Label label3;
        private Label label4;
        private Label label2;
        private Label label1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Label label6;
        private TextBox txtVentasT;
        private Button btnSave;
        private Button btnEliminar;
        private Label label9;
        private Label label8;
        private Label label7;
        private PictureBox btnMini;
        private PictureBox btnSalir;
        private PictureBox btnVolver;
    }
}