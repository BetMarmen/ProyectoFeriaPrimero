namespace Inventarios
{
    partial class frmInventarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInventarios));
            this.label8 = new System.Windows.Forms.Label();
            this.cboInventario = new System.Windows.Forms.ComboBox();
            this.lvFecha = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lvSaldos = new System.Windows.Forms.ListView();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader10 = new System.Windows.Forms.ColumnHeader();
            this.lvSalidas = new System.Windows.Forms.ListView();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValorUnit = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.cboMovimiento = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lvEntradas = new System.Windows.Forms.ListView();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.btnExportar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnMini = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.PictureBox();
            this.btnVolver = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnMini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVolver)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(28, 62);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 18);
            this.label8.TabIndex = 38;
            this.label8.Text = "Tipo de Inventario";
            // 
            // cboInventario
            // 
            this.cboInventario.FormattingEnabled = true;
            this.cboInventario.Location = new System.Drawing.Point(12, 100);
            this.cboInventario.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cboInventario.Name = "cboInventario";
            this.cboInventario.Size = new System.Drawing.Size(150, 28);
            this.cboInventario.TabIndex = 37;
            this.cboInventario.Text = "Seleccione";
            this.cboInventario.SelectedIndexChanged += new System.EventHandler(this.cboInventario_SelectedIndexChanged);
            // 
            // lvFecha
            // 
            this.lvFecha.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvFecha.GridLines = true;
            this.lvFecha.Location = new System.Drawing.Point(8, 202);
            this.lvFecha.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.lvFecha.Name = "lvFecha";
            this.lvFecha.Size = new System.Drawing.Size(77, 285);
            this.lvFecha.TabIndex = 36;
            this.lvFecha.UseCompatibleStateImageBehavior = false;
            this.lvFecha.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Fecha";
            this.columnHeader1.Width = 110;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(852, 171);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 18);
            this.label7.TabIndex = 35;
            this.label7.Text = "SALDOS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(533, 171);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 18);
            this.label6.TabIndex = 34;
            this.label6.Text = "SALIDAS";
            // 
            // lvSaldos
            // 
            this.lvSaldos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.lvSaldos.GridLines = true;
            this.lvSaldos.Location = new System.Drawing.Point(712, 202);
            this.lvSaldos.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.lvSaldos.Name = "lvSaldos";
            this.lvSaldos.Size = new System.Drawing.Size(308, 285);
            this.lvSaldos.TabIndex = 33;
            this.lvSaldos.UseCompatibleStateImageBehavior = false;
            this.lvSaldos.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Cantidad";
            this.columnHeader8.Width = 160;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Valor Unit";
            this.columnHeader9.Width = 160;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Total";
            this.columnHeader10.Width = 170;
            // 
            // lvSalidas
            // 
            this.lvSalidas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lvSalidas.GridLines = true;
            this.lvSalidas.Location = new System.Drawing.Point(396, 202);
            this.lvSalidas.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.lvSalidas.Name = "lvSalidas";
            this.lvSalidas.Size = new System.Drawing.Size(309, 285);
            this.lvSalidas.TabIndex = 32;
            this.lvSalidas.UseCompatibleStateImageBehavior = false;
            this.lvSalidas.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Cantidad";
            this.columnHeader5.Width = 160;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Valor Unit";
            this.columnHeader6.Width = 160;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Total";
            this.columnHeader7.Width = 170;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.CadetBlue;
            this.btnAgregar.BackgroundImage = global::Inventarios.Properties.Resources.agregar_archivo1;
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAgregar.Location = new System.Drawing.Point(740, 96);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(69, 56);
            this.btnAgregar.TabIndex = 31;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(200, 171);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 18);
            this.label5.TabIndex = 29;
            this.label5.Text = "ENTRADAS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(558, 62);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 28;
            this.label4.Text = "Valor Unitario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(423, 62);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 18);
            this.label3.TabIndex = 27;
            this.label3.Text = "Cantidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(241, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 18);
            this.label2.TabIndex = 26;
            this.label2.Text = "Movimiento";
            // 
            // txtValorUnit
            // 
            this.txtValorUnit.AllowDrop = true;
            this.txtValorUnit.Location = new System.Drawing.Point(558, 100);
            this.txtValorUnit.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtValorUnit.Name = "txtValorUnit";
            this.txtValorUnit.Size = new System.Drawing.Size(104, 27);
            this.txtValorUnit.TabIndex = 25;
            this.txtValorUnit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorUnit_KeyPress);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(402, 100);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(107, 27);
            this.txtCantidad.TabIndex = 24;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // cboMovimiento
            // 
            this.cboMovimiento.FormattingEnabled = true;
            this.cboMovimiento.Location = new System.Drawing.Point(207, 99);
            this.cboMovimiento.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cboMovimiento.Name = "cboMovimiento";
            this.cboMovimiento.Size = new System.Drawing.Size(150, 28);
            this.cboMovimiento.TabIndex = 23;
            this.cboMovimiento.Text = "Escoja";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(391, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 30);
            this.label1.TabIndex = 22;
            this.label1.Text = "METODOS DE INVENTARIO";
            // 
            // lvEntradas
            // 
            this.lvEntradas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvEntradas.GridLines = true;
            this.lvEntradas.Location = new System.Drawing.Point(89, 202);
            this.lvEntradas.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.lvEntradas.Name = "lvEntradas";
            this.lvEntradas.Size = new System.Drawing.Size(304, 285);
            this.lvEntradas.TabIndex = 21;
            this.lvEntradas.UseCompatibleStateImageBehavior = false;
            this.lvEntradas.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Cantidad";
            this.columnHeader2.Width = 160;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Valor Unit";
            this.columnHeader3.Width = 160;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Total";
            this.columnHeader4.Width = 170;
            // 
            // btnExportar
            // 
            this.btnExportar.BackColor = System.Drawing.Color.CadetBlue;
            this.btnExportar.BackgroundImage = global::Inventarios.Properties.Resources.exportar;
            this.btnExportar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExportar.Location = new System.Drawing.Point(815, 96);
            this.btnExportar.Margin = new System.Windows.Forms.Padding(4);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(69, 56);
            this.btnExportar.TabIndex = 39;
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(740, 63);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 17);
            this.label9.TabIndex = 40;
            this.label9.Text = "Agregar";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(821, 63);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 17);
            this.label10.TabIndex = 41;
            this.label10.Text = "Exportar";
            // 
            // btnMini
            // 
            this.btnMini.BackColor = System.Drawing.Color.Transparent;
            this.btnMini.Image = ((System.Drawing.Image)(resources.GetObject("btnMini.Image")));
            this.btnMini.Location = new System.Drawing.Point(952, -1);
            this.btnMini.Name = "btnMini";
            this.btnMini.Size = new System.Drawing.Size(39, 33);
            this.btnMini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMini.TabIndex = 42;
            this.btnMini.TabStop = false;
            this.btnMini.Click += new System.EventHandler(this.btnMini_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.Image = global::Inventarios.Properties.Resources.marca_x;
            this.btnSalir.Location = new System.Drawing.Point(997, -1);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(39, 33);
            this.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSalir.TabIndex = 43;
            this.btnSalir.TabStop = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Transparent;
            this.btnVolver.Image = global::Inventarios.Properties.Resources.flecha_izquierda;
            this.btnVolver.Location = new System.Drawing.Point(8, -1);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(39, 33);
            this.btnVolver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnVolver.TabIndex = 44;
            this.btnVolver.TabStop = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmInventarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Inventarios.Properties.Resources._131998868_fondo_azul_de_tecnología_de_datos_elementos_gráficos_números_y_degradados_de_color_combinados_en;
            this.ClientSize = new System.Drawing.Size(1048, 534);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnMini);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cboInventario);
            this.Controls.Add(this.lvFecha);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lvSaldos);
            this.Controls.Add(this.lvSalidas);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtValorUnit);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.cboMovimiento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvEntradas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "frmInventarios";
            this.Text = "frmInventarios";
            this.Load += new System.EventHandler(this.frmInventarios_Load_2);
            ((System.ComponentModel.ISupportInitialize)(this.btnMini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVolver)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label8;
        private ComboBox cboInventario;
        private ListView lvFecha;
        private ColumnHeader columnHeader1;
        private Label label7;
        private Label label6;
        private ListView lvSaldos;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ListView lvSalidas;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private Button btnAgregar;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtValorUnit;
        private TextBox txtCantidad;
        private ComboBox cboMovimiento;
        private Label label1;
        private ListView lvEntradas;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Button btnExportar;
        private Label label9;
        private Label label10;
        private PictureBox btnMini;
        private PictureBox btnSalir;
        private PictureBox btnVolver;
    }
}