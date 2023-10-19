namespace Inventarios
{
    partial class CuentasBalance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CuentasBalance));
            this.label1 = new System.Windows.Forms.Label();
            this.btnAC = new System.Windows.Forms.Button();
            this.dataBalance = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPNC = new System.Windows.Forms.Button();
            this.btnAF = new System.Windows.Forms.Button();
            this.btnPC = new System.Windows.Forms.Button();
            this.btnAD = new System.Windows.Forms.Button();
            this.btnMostrarBalance = new System.Windows.Forms.Button();
            this.btnDisminuciones = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cboFormato = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnMini = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.PictureBox();
            this.btnVolver = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataBalance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVolver)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(160, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro de Cuentas   \r\n  Balance General:";
            // 
            // btnAC
            // 
            this.btnAC.BackColor = System.Drawing.Color.Transparent;
            this.btnAC.BackgroundImage = global::Inventarios.Properties.Resources.economia_circular;
            this.btnAC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAC.Location = new System.Drawing.Point(71, 95);
            this.btnAC.Name = "btnAC";
            this.btnAC.Size = new System.Drawing.Size(68, 59);
            this.btnAC.TabIndex = 1;
            this.btnAC.UseVisualStyleBackColor = false;
            this.btnAC.Click += new System.EventHandler(this.btnAC_Click);
            // 
            // dataBalance
            // 
            this.dataBalance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataBalance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataBalance.Location = new System.Drawing.Point(36, 258);
            this.dataBalance.Name = "dataBalance";
            this.dataBalance.RowTemplate.Height = 29;
            this.dataBalance.Size = new System.Drawing.Size(409, 150);
            this.dataBalance.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 160F;
            this.Column1.HeaderText = "Nombre";
            this.Column1.Name = "Column1";
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Monto";
            this.Column2.Name = "Column2";
            this.Column2.Width = 170;
            // 
            // btnPNC
            // 
            this.btnPNC.BackColor = System.Drawing.Color.Transparent;
            this.btnPNC.BackgroundImage = global::Inventarios.Properties.Resources.ingresos;
            this.btnPNC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPNC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPNC.Location = new System.Drawing.Point(195, 177);
            this.btnPNC.Name = "btnPNC";
            this.btnPNC.Size = new System.Drawing.Size(68, 59);
            this.btnPNC.TabIndex = 6;
            this.btnPNC.UseVisualStyleBackColor = false;
            this.btnPNC.Click += new System.EventHandler(this.btnPNC_Click);
            // 
            // btnAF
            // 
            this.btnAF.BackColor = System.Drawing.Color.Transparent;
            this.btnAF.BackgroundImage = global::Inventarios.Properties.Resources.activo_fijo;
            this.btnAF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAF.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAF.Location = new System.Drawing.Point(195, 95);
            this.btnAF.Name = "btnAF";
            this.btnAF.Size = new System.Drawing.Size(68, 59);
            this.btnAF.TabIndex = 7;
            this.btnAF.Text = " ";
            this.btnAF.UseVisualStyleBackColor = false;
            this.btnAF.Click += new System.EventHandler(this.btnAF_Click);
            // 
            // btnPC
            // 
            this.btnPC.BackColor = System.Drawing.Color.Transparent;
            this.btnPC.BackgroundImage = global::Inventarios.Properties.Resources.pasivoCir;
            this.btnPC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPC.Location = new System.Drawing.Point(71, 177);
            this.btnPC.Name = "btnPC";
            this.btnPC.Size = new System.Drawing.Size(68, 59);
            this.btnPC.TabIndex = 8;
            this.btnPC.UseVisualStyleBackColor = false;
            this.btnPC.Click += new System.EventHandler(this.btnPC_Click);
            // 
            // btnAD
            // 
            this.btnAD.BackColor = System.Drawing.Color.Transparent;
            this.btnAD.BackgroundImage = global::Inventarios.Properties.Resources.tiempo_de_trabajo;
            this.btnAD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAD.Location = new System.Drawing.Point(312, 95);
            this.btnAD.Name = "btnAD";
            this.btnAD.Size = new System.Drawing.Size(68, 59);
            this.btnAD.TabIndex = 9;
            this.btnAD.UseVisualStyleBackColor = false;
            this.btnAD.Click += new System.EventHandler(this.btnAD_Click);
            // 
            // btnMostrarBalance
            // 
            this.btnMostrarBalance.BackColor = System.Drawing.Color.Transparent;
            this.btnMostrarBalance.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMostrarBalance.BackgroundImage")));
            this.btnMostrarBalance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMostrarBalance.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMostrarBalance.Location = new System.Drawing.Point(312, 177);
            this.btnMostrarBalance.Name = "btnMostrarBalance";
            this.btnMostrarBalance.Size = new System.Drawing.Size(69, 59);
            this.btnMostrarBalance.TabIndex = 10;
            this.btnMostrarBalance.UseVisualStyleBackColor = false;
            this.btnMostrarBalance.Click += new System.EventHandler(this.btnMostrarBalance_Click_1);
            // 
            // btnDisminuciones
            // 
            this.btnDisminuciones.BackColor = System.Drawing.Color.Transparent;
            this.btnDisminuciones.BackgroundImage = global::Inventarios.Properties.Resources.disminuir_prestamo;
            this.btnDisminuciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDisminuciones.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDisminuciones.Location = new System.Drawing.Point(431, 95);
            this.btnDisminuciones.Name = "btnDisminuciones";
            this.btnDisminuciones.Size = new System.Drawing.Size(68, 59);
            this.btnDisminuciones.TabIndex = 11;
            this.btnDisminuciones.UseVisualStyleBackColor = false;
            this.btnDisminuciones.Click += new System.EventHandler(this.btnDisminuciones_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(451, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 38);
            this.label5.TabIndex = 13;
            this.label5.Text = "¿En qué formato \r\ndesea exportarlo?";
            // 
            // cboFormato
            // 
            this.cboFormato.FormattingEnabled = true;
            this.cboFormato.Items.AddRange(new object[] {
            "PDF",
            "WORD",
            "EXCEL",
            "TXT"});
            this.cboFormato.Location = new System.Drawing.Point(451, 310);
            this.cboFormato.Name = "cboFormato";
            this.cboFormato.Size = new System.Drawing.Size(121, 28);
            this.cboFormato.TabIndex = 12;
            this.cboFormato.SelectedIndexChanged += new System.EventHandler(this.cboFormato_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(50, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Activos Circulantes";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(195, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Activos Fijos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(312, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Activos Diferidos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(431, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Disminuciones de Activos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(50, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Pasivo Circulante";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(195, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 20);
            this.label8.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(312, 157);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Mostrar Balance General";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(171, 157);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = "Pasivo No Circulante";
            // 
            // btnMini
            // 
            this.btnMini.BackColor = System.Drawing.Color.Transparent;
            this.btnMini.Image = global::Inventarios.Properties.Resources.minimizar_signo3;
            this.btnMini.Location = new System.Drawing.Point(505, 0);
            this.btnMini.Name = "btnMini";
            this.btnMini.Size = new System.Drawing.Size(38, 31);
            this.btnMini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMini.TabIndex = 22;
            this.btnMini.TabStop = false;
            this.btnMini.Click += new System.EventHandler(this.btnMini_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.Image = global::Inventarios.Properties.Resources.marca_x3;
            this.btnSalir.Location = new System.Drawing.Point(549, 0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(38, 31);
            this.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSalir.TabIndex = 23;
            this.btnSalir.TabStop = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Transparent;
            this.btnVolver.Image = global::Inventarios.Properties.Resources.flecha_izquierda3;
            this.btnVolver.Location = new System.Drawing.Point(12, 0);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(38, 31);
            this.btnVolver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnVolver.TabIndex = 24;
            this.btnVolver.TabStop = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // CuentasBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImage = global::Inventarios.Properties.Resources._131998868_fondo_azul_de_tecnología_de_datos_elementos_gráficos_números_y_degradados_de_color_combinados_en2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(599, 420);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnMini);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboFormato);
            this.Controls.Add(this.btnDisminuciones);
            this.Controls.Add(this.btnMostrarBalance);
            this.Controls.Add(this.btnAD);
            this.Controls.Add(this.btnPC);
            this.Controls.Add(this.btnAF);
            this.Controls.Add(this.btnPNC);
            this.Controls.Add(this.dataBalance);
            this.Controls.Add(this.btnAC);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CuentasBalance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.CuentasBalance_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataBalance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVolver)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btnAC;
        private DataGridView dataBalance;
        private Button btnPNC;
        private Button btnAF;
        private Button btnPC;
        private Button btnAD;
        private Button btnMostrarBalance;
        private Button btnDisminuciones;
        private Label label5;
        private ComboBox cboFormato;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private PictureBox btnMini;
        private PictureBox btnSalir;
        private PictureBox btnVolver;
    }
}