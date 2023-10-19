namespace Inventarios
{
    partial class EstadoResultado
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nuDsVtas = new System.Windows.Forms.NumericUpDown();
            this.nuDsV = new System.Windows.Forms.NumericUpDown();
            this.txtVentasTotales = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtComprasTotales = new System.Windows.Forms.TextBox();
            this.nugastoCompra = new System.Windows.Forms.NumericUpDown();
            this.nuDSC = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.nuDesSC = new System.Windows.Forms.NumericUpDown();
            this.nuRebajas = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.nuInvF = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nuInvI = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.nuGastosFinancieros = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.nuGastosAdmo = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.nuGastosVentas = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.dataEstadoR = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.cboFormato = new System.Windows.Forms.ComboBox();
            this.btnMini = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.PictureBox();
            this.btnVolver = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuDsVtas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuDsV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nugastoCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuDSC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuDesSC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuRebajas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuInvF)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuInvI)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuGastosFinancieros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuGastosAdmo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuGastosVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataEstadoR)).BeginInit();
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
            this.label1.Location = new System.Drawing.Point(311, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Estado de Resultado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SimSun-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label2.Location = new System.Drawing.Point(20, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ventas Totales: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.nuDsVtas);
            this.groupBox1.Controls.Add(this.nuDsV);
            this.groupBox1.Controls.Add(this.txtVentasTotales);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(40, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(821, 131);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ventas";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // nuDsVtas
            // 
            this.nuDsVtas.Location = new System.Drawing.Point(530, 76);
            this.nuDsVtas.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nuDsVtas.Name = "nuDsVtas";
            this.nuDsVtas.Size = new System.Drawing.Size(135, 26);
            this.nuDsVtas.TabIndex = 6;
            this.nuDsVtas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nuDsVtas_KeyPress);
            // 
            // nuDsV
            // 
            this.nuDsV.Location = new System.Drawing.Point(296, 76);
            this.nuDsV.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nuDsV.Name = "nuDsV";
            this.nuDsV.Size = new System.Drawing.Size(120, 26);
            this.nuDsV.TabIndex = 5;
            this.nuDsV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nuDsV_KeyPress);
            // 
            // txtVentasTotales
            // 
            this.txtVentasTotales.Location = new System.Drawing.Point(20, 75);
            this.txtVentasTotales.Name = "txtVentasTotales";
            this.txtVentasTotales.ReadOnly = true;
            this.txtVentasTotales.Size = new System.Drawing.Size(138, 26);
            this.txtVentasTotales.TabIndex = 4;
            this.txtVentasTotales.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVentasTotales_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("SimSun-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label4.Location = new System.Drawing.Point(530, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(250, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Devoluciones sobre Ventas: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SimSun-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label3.Location = new System.Drawing.Point(271, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descuento sobre Ventas: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label7.Location = new System.Drawing.Point(11, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Compras Totales: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("SimSun-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label6.Location = new System.Drawing.Point(296, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Gasto de Compras: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("SimSun-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label5.Location = new System.Drawing.Point(11, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(250, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Devoluciones sobre Compras:";
            // 
            // txtComprasTotales
            // 
            this.txtComprasTotales.Location = new System.Drawing.Point(11, 47);
            this.txtComprasTotales.Name = "txtComprasTotales";
            this.txtComprasTotales.ReadOnly = true;
            this.txtComprasTotales.Size = new System.Drawing.Size(138, 26);
            this.txtComprasTotales.TabIndex = 4;
            this.txtComprasTotales.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtComprasTotales_KeyPress);
            // 
            // nugastoCompra
            // 
            this.nugastoCompra.Location = new System.Drawing.Point(296, 48);
            this.nugastoCompra.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nugastoCompra.Name = "nugastoCompra";
            this.nugastoCompra.Size = new System.Drawing.Size(120, 26);
            this.nugastoCompra.TabIndex = 5;
            this.nugastoCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nugastoCompra_KeyPress);
            // 
            // nuDSC
            // 
            this.nuDSC.Location = new System.Drawing.Point(11, 108);
            this.nuDSC.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nuDSC.Name = "nuDSC";
            this.nuDSC.Size = new System.Drawing.Size(135, 26);
            this.nuDSC.TabIndex = 6;
            this.nuDSC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nuDSC_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("SimSun-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label8.Location = new System.Drawing.Point(11, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(178, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Inventario Inicial:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("SimSun-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label9.Location = new System.Drawing.Point(530, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(205, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Rebajas sobre Compras:";
            // 
            // nuDesSC
            // 
            this.nuDesSC.Location = new System.Drawing.Point(296, 107);
            this.nuDesSC.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nuDesSC.Name = "nuDesSC";
            this.nuDesSC.Size = new System.Drawing.Size(152, 26);
            this.nuDesSC.TabIndex = 9;
            this.nuDesSC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nuDesSC_KeyPress);
            // 
            // nuRebajas
            // 
            this.nuRebajas.Location = new System.Drawing.Point(530, 107);
            this.nuRebajas.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nuRebajas.Name = "nuRebajas";
            this.nuRebajas.Size = new System.Drawing.Size(152, 26);
            this.nuRebajas.TabIndex = 10;
            this.nuRebajas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nuRebajas_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("SimSun-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label10.Location = new System.Drawing.Point(296, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(232, 16);
            this.label10.TabIndex = 11;
            this.label10.Text = "Descuento sobre Compras: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("SimSun-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label11.Location = new System.Drawing.Point(296, 143);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(169, 16);
            this.label11.TabIndex = 12;
            this.label11.Text = "Inventario Final: ";
            // 
            // nuInvF
            // 
            this.nuInvF.Location = new System.Drawing.Point(294, 156);
            this.nuInvF.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nuInvF.Name = "nuInvF";
            this.nuInvF.Size = new System.Drawing.Size(171, 26);
            this.nuInvF.TabIndex = 13;
            this.nuInvF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nuInvF_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.nuInvI);
            this.groupBox2.Controls.Add(this.nuInvF);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.nuRebajas);
            this.groupBox2.Controls.Add(this.nuDesSC);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.nuDSC);
            this.groupBox2.Controls.Add(this.nugastoCompra);
            this.groupBox2.Controls.Add(this.txtComprasTotales);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(40, 181);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(821, 188);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Costo de Venta";
            // 
            // nuInvI
            // 
            this.nuInvI.Location = new System.Drawing.Point(11, 162);
            this.nuInvI.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nuInvI.Name = "nuInvI";
            this.nuInvI.Size = new System.Drawing.Size(171, 26);
            this.nuInvI.TabIndex = 14;
            this.nuInvI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nuInvI_KeyPress);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.nuGastosFinancieros);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.nuGastosAdmo);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.nuGastosVentas);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(40, 387);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(821, 131);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Gastos de Operación";
            // 
            // nuGastosFinancieros
            // 
            this.nuGastosFinancieros.Location = new System.Drawing.Point(530, 68);
            this.nuGastosFinancieros.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nuGastosFinancieros.Name = "nuGastosFinancieros";
            this.nuGastosFinancieros.Size = new System.Drawing.Size(120, 26);
            this.nuGastosFinancieros.TabIndex = 18;
            this.nuGastosFinancieros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericUpDown3_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("SimSun-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label14.Location = new System.Drawing.Point(530, 39);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(187, 16);
            this.label14.TabIndex = 17;
            this.label14.Text = "Gastos Financieros: ";
            // 
            // nuGastosAdmo
            // 
            this.nuGastosAdmo.Location = new System.Drawing.Point(234, 68);
            this.nuGastosAdmo.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nuGastosAdmo.Name = "nuGastosAdmo";
            this.nuGastosAdmo.Size = new System.Drawing.Size(120, 26);
            this.nuGastosAdmo.TabIndex = 16;
            this.nuGastosAdmo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericUpDown2_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("SimSun-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label15.Location = new System.Drawing.Point(234, 49);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(240, 16);
            this.label15.TabIndex = 15;
            this.label15.Text = "Gastos de Administración: ";
            // 
            // nuGastosVentas
            // 
            this.nuGastosVentas.Location = new System.Drawing.Point(11, 68);
            this.nuGastosVentas.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nuGastosVentas.Name = "nuGastosVentas";
            this.nuGastosVentas.Size = new System.Drawing.Size(120, 26);
            this.nuGastosVentas.TabIndex = 13;
            this.nuGastosVentas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericUpDown1_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("SimSun-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label13.Location = new System.Drawing.Point(11, 39);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(169, 16);
            this.label13.TabIndex = 12;
            this.label13.Text = "Gastos de Ventas: ";
            // 
            // dataEstadoR
            // 
            this.dataEstadoR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataEstadoR.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column5,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataEstadoR.Location = new System.Drawing.Point(38, 551);
            this.dataEstadoR.Name = "dataEstadoR";
            this.dataEstadoR.RowTemplate.Height = 29;
            this.dataEstadoR.Size = new System.Drawing.Size(537, 198);
            this.dataEstadoR.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "";
            this.Column5.Name = "Column5";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "";
            this.Column4.Name = "Column4";
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.SlateGray;
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGenerar.Location = new System.Drawing.Point(581, 551);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 38);
            this.btnGenerar.TabIndex = 6;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.SlateGray;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Location = new System.Drawing.Point(581, 614);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 38);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SlateGray;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Location = new System.Drawing.Point(581, 670);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 38);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(673, 547);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(147, 38);
            this.label12.TabIndex = 15;
            this.label12.Text = "¿En qué formato \r\ndesea exportarlo?";
            // 
            // cboFormato
            // 
            this.cboFormato.FormattingEnabled = true;
            this.cboFormato.Items.AddRange(new object[] {
            "PDF",
            "WORD",
            "EXCEL",
            "TXT"});
            this.cboFormato.Location = new System.Drawing.Point(684, 600);
            this.cboFormato.Name = "cboFormato";
            this.cboFormato.Size = new System.Drawing.Size(121, 29);
            this.cboFormato.TabIndex = 14;
            this.cboFormato.SelectedIndexChanged += new System.EventHandler(this.cboFormato_SelectedIndexChanged);
            // 
            // btnMini
            // 
            this.btnMini.BackColor = System.Drawing.Color.Transparent;
            this.btnMini.Image = global::Inventarios.Properties.Resources.minimizar_signo1;
            this.btnMini.Location = new System.Drawing.Point(805, 2);
            this.btnMini.Name = "btnMini";
            this.btnMini.Size = new System.Drawing.Size(37, 36);
            this.btnMini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMini.TabIndex = 25;
            this.btnMini.TabStop = false;
            this.btnMini.Click += new System.EventHandler(this.btnMini_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.Image = global::Inventarios.Properties.Resources.marca_x1;
            this.btnSalir.Location = new System.Drawing.Point(848, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(37, 36);
            this.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSalir.TabIndex = 24;
            this.btnSalir.TabStop = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Transparent;
            this.btnVolver.Image = global::Inventarios.Properties.Resources.flecha_izquierda;
            this.btnVolver.Location = new System.Drawing.Point(12, 2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(42, 36);
            this.btnVolver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnVolver.TabIndex = 26;
            this.btnVolver.TabStop = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // EstadoResultado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImage = global::Inventarios.Properties.Resources._131998868_fondo_azul_de_tecnología_de_datos_elementos_gráficos_números_y_degradados_de_color_combinados_en;
            this.ClientSize = new System.Drawing.Size(897, 761);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnMini);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cboFormato);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.dataEstadoR);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EstadoResultado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EstadoResultado";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuDsVtas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuDsV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nugastoCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuDSC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuDesSC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuRebajas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuInvF)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuInvI)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuGastosFinancieros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuGastosAdmo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuGastosVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataEstadoR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVolver)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private NumericUpDown nuDsVtas;
        private NumericUpDown nuDsV;
        private TextBox txtVentasTotales;
        private Label label4;
        private Label label3;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox txtComprasTotales;
        private NumericUpDown nugastoCompra;
        private NumericUpDown nuDSC;
        private Label label8;
        private Label label9;
        private NumericUpDown nuDesSC;
        private NumericUpDown nuRebajas;
        private Label label10;
        private Label label11;
        private NumericUpDown nuInvF;
        private GroupBox groupBox2;
        private NumericUpDown nuInvI;
        private GroupBox groupBox3;
        private NumericUpDown nuGastosFinancieros;
        private Label label14;
        private NumericUpDown nuGastosAdmo;
        private Label label15;
        private NumericUpDown nuGastosVentas;
        private Label label13;
        private DataGridView dataEstadoR;
        private Button btnGenerar;
        private Button btnDelete;
        private Button btnSave;
        private Label label12;
        private ComboBox cboFormato;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private PictureBox btnMini;
        private PictureBox btnSalir;
        private PictureBox btnVolver;
    }
}