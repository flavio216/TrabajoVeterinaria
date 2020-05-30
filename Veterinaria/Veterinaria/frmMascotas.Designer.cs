namespace Veterinaria
{
    partial class frmMascotas
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMascotas));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Cargar = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgBuscarCliente = new System.Windows.Forms.DataGridView();
            this.lblIdMascota = new System.Windows.Forms.Label();
            this.rbtHembra = new System.Windows.Forms.RadioButton();
            this.rbtMasculino = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBaja = new System.Windows.Forms.Button();
            this.btnAlta = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.lblNacimiento = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.cmbEspecie = new System.Windows.Forms.ComboBox();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblEspecieText = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnTipoProductos = new System.Windows.Forms.Button();
            this.cmbRaza = new System.Windows.Forms.ComboBox();
            this.lblRaza = new System.Windows.Forms.Label();
            this.lblFechaText = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombreText = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dtgMascotas = new System.Windows.Forms.DataGridView();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.PictureBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblApellidoBuscar = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dtgMascotasBajas = new System.Windows.Forms.DataGridView();
            this.lblCantidadRegistrosBaja = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.txtMascotaBaja = new System.Windows.Forms.TextBox();
            this.lblMascotaBaja = new System.Windows.Forms.Label();
            this.errorMascota = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Cargar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBuscarCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMascotas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMascotasBajas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMascota)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(786, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Cargar
            // 
            this.Cargar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.Cargar.Controls.Add(this.groupBox1);
            this.Cargar.Location = new System.Drawing.Point(4, 25);
            this.Cargar.Name = "Cargar";
            this.Cargar.Padding = new System.Windows.Forms.Padding(3);
            this.Cargar.Size = new System.Drawing.Size(767, 537);
            this.Cargar.TabIndex = 1;
            this.Cargar.Text = "Cargar";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dtgBuscarCliente);
            this.groupBox1.Controls.Add(this.lblIdMascota);
            this.groupBox1.Controls.Add(this.rbtHembra);
            this.groupBox1.Controls.Add(this.rbtMasculino);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCliente);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnBaja);
            this.groupBox1.Controls.Add(this.btnAlta);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnSalir);
            this.groupBox1.Controls.Add(this.btnNuevo);
            this.groupBox1.Controls.Add(this.btnCargar);
            this.groupBox1.Controls.Add(this.lblNacimiento);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.cmbEspecie);
            this.groupBox1.Controls.Add(this.dtpFechaNac);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.lblEspecieText);
            this.groupBox1.Controls.Add(this.btnActualizar);
            this.groupBox1.Controls.Add(this.btnTipoProductos);
            this.groupBox1.Controls.Add(this.cmbRaza);
            this.groupBox1.Controls.Add(this.lblRaza);
            this.groupBox1.Controls.Add(this.lblFechaText);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.lblNombreText);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(768, 515);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // dtgBuscarCliente
            // 
            this.dtgBuscarCliente.AllowUserToAddRows = false;
            this.dtgBuscarCliente.AllowUserToDeleteRows = false;
            this.dtgBuscarCliente.AllowUserToOrderColumns = true;
            this.dtgBuscarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgBuscarCliente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.dtgBuscarCliente.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgBuscarCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgBuscarCliente.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgBuscarCliente.Location = new System.Drawing.Point(40, 221);
            this.dtgBuscarCliente.MultiSelect = false;
            this.dtgBuscarCliente.Name = "dtgBuscarCliente";
            this.dtgBuscarCliente.ReadOnly = true;
            this.dtgBuscarCliente.RowHeadersWidth = 51;
            this.dtgBuscarCliente.RowTemplate.Height = 24;
            this.dtgBuscarCliente.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dtgBuscarCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgBuscarCliente.Size = new System.Drawing.Size(448, 132);
            this.dtgBuscarCliente.TabIndex = 108;
            this.dtgBuscarCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgBuscarCliente_CellContentClick);
            // 
            // lblIdMascota
            // 
            this.lblIdMascota.AutoSize = true;
            this.lblIdMascota.Font = new System.Drawing.Font("Imprint MT Shadow", 10F, System.Drawing.FontStyle.Bold);
            this.lblIdMascota.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblIdMascota.Location = new System.Drawing.Point(481, 24);
            this.lblIdMascota.Name = "lblIdMascota";
            this.lblIdMascota.Size = new System.Drawing.Size(33, 20);
            this.lblIdMascota.TabIndex = 107;
            this.lblIdMascota.Text = "ID";
            // 
            // rbtHembra
            // 
            this.rbtHembra.AutoSize = true;
            this.rbtHembra.Font = new System.Drawing.Font("Imprint MT Shadow", 10F, System.Drawing.FontStyle.Bold);
            this.rbtHembra.Location = new System.Drawing.Point(256, 138);
            this.rbtHembra.Name = "rbtHembra";
            this.rbtHembra.Size = new System.Drawing.Size(97, 24);
            this.rbtHembra.TabIndex = 106;
            this.rbtHembra.TabStop = true;
            this.rbtHembra.Text = "Hembra";
            this.rbtHembra.UseVisualStyleBackColor = true;
            // 
            // rbtMasculino
            // 
            this.rbtMasculino.AutoSize = true;
            this.rbtMasculino.Font = new System.Drawing.Font("Imprint MT Shadow", 10F, System.Drawing.FontStyle.Bold);
            this.rbtMasculino.Location = new System.Drawing.Point(156, 138);
            this.rbtMasculino.Name = "rbtMasculino";
            this.rbtMasculino.Size = new System.Drawing.Size(86, 24);
            this.rbtMasculino.TabIndex = 105;
            this.rbtMasculino.TabStop = true;
            this.rbtMasculino.Text = "Macho";
            this.rbtMasculino.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Imprint MT Shadow", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(58, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 104;
            this.label3.Text = "Sexo";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(136, 193);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(283, 22);
            this.txtCliente.TabIndex = 103;
            this.txtCliente.TextChanged += new System.EventHandler(this.txtCliente_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Imprint MT Shadow", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(36, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 102;
            this.label1.Text = "Cliente";
            // 
            // btnBaja
            // 
            this.btnBaja.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBaja.FlatAppearance.BorderSize = 0;
            this.btnBaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaja.Font = new System.Drawing.Font("Imprint MT Shadow", 14F, System.Drawing.FontStyle.Bold);
            this.btnBaja.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBaja.Image = ((System.Drawing.Image)(resources.GetObject("btnBaja.Image")));
            this.btnBaja.Location = new System.Drawing.Point(531, 392);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(124, 98);
            this.btnBaja.TabIndex = 101;
            this.btnBaja.Text = "Dar Baja";
            this.btnBaja.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBaja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // btnAlta
            // 
            this.btnAlta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAlta.FlatAppearance.BorderSize = 0;
            this.btnAlta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlta.Font = new System.Drawing.Font("Imprint MT Shadow", 14F, System.Drawing.FontStyle.Bold);
            this.btnAlta.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAlta.Image = ((System.Drawing.Image)(resources.GetObject("btnAlta.Image")));
            this.btnAlta.Location = new System.Drawing.Point(406, 392);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(124, 98);
            this.btnAlta.TabIndex = 100;
            this.btnAlta.Text = "Dar Alta";
            this.btnAlta.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAlta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Imprint MT Shadow", 14F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(276, 392);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(124, 98);
            this.btnCancelar.TabIndex = 99;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Imprint MT Shadow", 14F, System.Drawing.FontStyle.Bold);
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(644, 392);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(124, 98);
            this.btnSalir.TabIndex = 98;
            this.btnSalir.Text = "Volver";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Imprint MT Shadow", 14F, System.Drawing.FontStyle.Bold);
            this.btnNuevo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.Location = new System.Drawing.Point(6, 392);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(124, 98);
            this.btnNuevo.TabIndex = 97;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCargar.FlatAppearance.BorderSize = 0;
            this.btnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargar.Font = new System.Drawing.Font("Imprint MT Shadow", 14F, System.Drawing.FontStyle.Bold);
            this.btnCargar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCargar.Image = ((System.Drawing.Image)(resources.GetObject("btnCargar.Image")));
            this.btnCargar.Location = new System.Drawing.Point(136, 392);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(124, 98);
            this.btnCargar.TabIndex = 96;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCargar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // lblNacimiento
            // 
            this.lblNacimiento.AutoSize = true;
            this.lblNacimiento.Font = new System.Drawing.Font("Imprint MT Shadow", 10F, System.Drawing.FontStyle.Bold);
            this.lblNacimiento.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNacimiento.Location = new System.Drawing.Point(44, 96);
            this.lblNacimiento.Name = "lblNacimiento";
            this.lblNacimiento.Size = new System.Drawing.Size(42, 20);
            this.lblNacimiento.TabIndex = 57;
            this.lblNacimiento.Text = "Nac";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(644, 83);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(42, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 56;
            this.pictureBox3.TabStop = false;
            // 
            // cmbEspecie
            // 
            this.cmbEspecie.FormattingEnabled = true;
            this.cmbEspecie.Location = new System.Drawing.Point(540, 92);
            this.cmbEspecie.Name = "cmbEspecie";
            this.cmbEspecie.Size = new System.Drawing.Size(94, 24);
            this.cmbEspecie.TabIndex = 55;
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Location = new System.Drawing.Point(134, 83);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(266, 22);
            this.dtpFechaNac.TabIndex = 54;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(644, 123);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(42, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 52;
            this.pictureBox2.TabStop = false;
            // 
            // lblEspecieText
            // 
            this.lblEspecieText.AutoSize = true;
            this.lblEspecieText.Font = new System.Drawing.Font("Imprint MT Shadow", 10F, System.Drawing.FontStyle.Bold);
            this.lblEspecieText.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblEspecieText.Location = new System.Drawing.Point(442, 96);
            this.lblEspecieText.Name = "lblEspecieText";
            this.lblEspecieText.Size = new System.Drawing.Size(72, 20);
            this.lblEspecieText.TabIndex = 51;
            this.lblEspecieText.Text = "Especie";
            // 
            // btnActualizar
            // 
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Imprint MT Shadow", 14F, System.Drawing.FontStyle.Bold);
            this.btnActualizar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.Location = new System.Drawing.Point(764, 24);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(166, 109);
            this.btnActualizar.TabIndex = 50;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnTipoProductos
            // 
            this.btnTipoProductos.FlatAppearance.BorderSize = 0;
            this.btnTipoProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTipoProductos.Font = new System.Drawing.Font("Imprint MT Shadow", 14F, System.Drawing.FontStyle.Bold);
            this.btnTipoProductos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTipoProductos.Image = ((System.Drawing.Image)(resources.GetObject("btnTipoProductos.Image")));
            this.btnTipoProductos.Location = new System.Drawing.Point(472, 198);
            this.btnTipoProductos.Name = "btnTipoProductos";
            this.btnTipoProductos.Size = new System.Drawing.Size(83, 5);
            this.btnTipoProductos.TabIndex = 49;
            this.btnTipoProductos.Text = "Tipos";
            this.btnTipoProductos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTipoProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTipoProductos.UseVisualStyleBackColor = true;
            // 
            // cmbRaza
            // 
            this.cmbRaza.FormattingEnabled = true;
            this.cmbRaza.Location = new System.Drawing.Point(540, 140);
            this.cmbRaza.Name = "cmbRaza";
            this.cmbRaza.Size = new System.Drawing.Size(94, 24);
            this.cmbRaza.TabIndex = 47;
            // 
            // lblRaza
            // 
            this.lblRaza.AutoSize = true;
            this.lblRaza.Font = new System.Drawing.Font("Imprint MT Shadow", 10F, System.Drawing.FontStyle.Bold);
            this.lblRaza.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblRaza.Location = new System.Drawing.Point(464, 144);
            this.lblRaza.Name = "lblRaza";
            this.lblRaza.Size = new System.Drawing.Size(50, 20);
            this.lblRaza.TabIndex = 46;
            this.lblRaza.Text = "Raza";
            // 
            // lblFechaText
            // 
            this.lblFechaText.AutoSize = true;
            this.lblFechaText.Font = new System.Drawing.Font("Imprint MT Shadow", 10F, System.Drawing.FontStyle.Bold);
            this.lblFechaText.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblFechaText.Location = new System.Drawing.Point(36, 76);
            this.lblFechaText.Name = "lblFechaText";
            this.lblFechaText.Size = new System.Drawing.Size(60, 20);
            this.lblFechaText.TabIndex = 43;
            this.lblFechaText.Text = "Fecha";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(134, 35);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(283, 22);
            this.txtNombre.TabIndex = 42;
            // 
            // lblNombreText
            // 
            this.lblNombreText.AutoSize = true;
            this.lblNombreText.Font = new System.Drawing.Font("Imprint MT Shadow", 10F, System.Drawing.FontStyle.Bold);
            this.lblNombreText.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNombreText.Location = new System.Drawing.Point(31, 37);
            this.lblNombreText.Name = "lblNombreText";
            this.lblNombreText.Size = new System.Drawing.Size(76, 20);
            this.lblNombreText.TabIndex = 41;
            this.lblNombreText.Text = "Nombre";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.Cargar);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 135);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(775, 566);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.tabPage1.Controls.Add(this.dtgMascotas);
            this.tabPage1.Controls.Add(this.lblCantidad);
            this.tabPage1.Controls.Add(this.btnImprimir);
            this.tabPage1.Controls.Add(this.btnBuscar);
            this.tabPage1.Controls.Add(this.txtBuscar);
            this.tabPage1.Controls.Add(this.lblApellidoBuscar);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(767, 537);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Mantenimiento";
            // 
            // dtgMascotas
            // 
            this.dtgMascotas.AllowUserToAddRows = false;
            this.dtgMascotas.AllowUserToDeleteRows = false;
            this.dtgMascotas.AllowUserToOrderColumns = true;
            this.dtgMascotas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgMascotas.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtgMascotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMascotas.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dtgMascotas.Location = new System.Drawing.Point(31, 105);
            this.dtgMascotas.MultiSelect = false;
            this.dtgMascotas.Name = "dtgMascotas";
            this.dtgMascotas.ReadOnly = true;
            this.dtgMascotas.RowHeadersWidth = 51;
            this.dtgMascotas.RowTemplate.Height = 24;
            this.dtgMascotas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgMascotas.Size = new System.Drawing.Size(733, 277);
            this.dtgMascotas.TabIndex = 23;
            this.dtgMascotas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgMascotas_CellContentClick);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblCantidad.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblCantidad.Location = new System.Drawing.Point(532, 65);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(208, 20);
            this.lblCantidad.TabIndex = 22;
            this.lblCantidad.Text = "Cantidad de Registros: ";
            // 
            // btnImprimir
            // 
            this.btnImprimir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnImprimir.Location = new System.Drawing.Point(853, 10);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 33);
            this.btnImprimir.TabIndex = 20;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(387, 12);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(51, 40);
            this.btnBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBuscar.TabIndex = 18;
            this.btnBuscar.TabStop = false;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(123, 21);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(258, 22);
            this.txtBuscar.TabIndex = 17;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // lblApellidoBuscar
            // 
            this.lblApellidoBuscar.AutoSize = true;
            this.lblApellidoBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblApellidoBuscar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblApellidoBuscar.Location = new System.Drawing.Point(34, 21);
            this.lblApellidoBuscar.Name = "lblApellidoBuscar";
            this.lblApellidoBuscar.Size = new System.Drawing.Size(69, 20);
            this.lblApellidoBuscar.TabIndex = 16;
            this.lblApellidoBuscar.Text = "Dueño:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.tabPage2.Controls.Add(this.dtgMascotasBajas);
            this.tabPage2.Controls.Add(this.lblCantidadRegistrosBaja);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.pictureBox4);
            this.tabPage2.Controls.Add(this.txtMascotaBaja);
            this.tabPage2.Controls.Add(this.lblMascotaBaja);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(767, 537);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Inactivos";
            // 
            // dtgMascotasBajas
            // 
            this.dtgMascotasBajas.AllowUserToAddRows = false;
            this.dtgMascotasBajas.AllowUserToDeleteRows = false;
            this.dtgMascotasBajas.AllowUserToOrderColumns = true;
            this.dtgMascotasBajas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgMascotasBajas.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtgMascotasBajas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMascotasBajas.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dtgMascotasBajas.Location = new System.Drawing.Point(20, 104);
            this.dtgMascotasBajas.MultiSelect = false;
            this.dtgMascotasBajas.Name = "dtgMascotasBajas";
            this.dtgMascotasBajas.ReadOnly = true;
            this.dtgMascotasBajas.RowHeadersWidth = 51;
            this.dtgMascotasBajas.RowTemplate.Height = 24;
            this.dtgMascotasBajas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgMascotasBajas.Size = new System.Drawing.Size(730, 290);
            this.dtgMascotasBajas.TabIndex = 29;
            this.dtgMascotasBajas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgMascotasBajas_CellContentClick);
            // 
            // lblCantidadRegistrosBaja
            // 
            this.lblCantidadRegistrosBaja.AutoSize = true;
            this.lblCantidadRegistrosBaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblCantidadRegistrosBaja.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblCantidadRegistrosBaja.Location = new System.Drawing.Point(529, 61);
            this.lblCantidadRegistrosBaja.Name = "lblCantidadRegistrosBaja";
            this.lblCantidadRegistrosBaja.Size = new System.Drawing.Size(208, 20);
            this.lblCantidadRegistrosBaja.TabIndex = 28;
            this.lblCantidadRegistrosBaja.Text = "Cantidad de Registros: ";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(842, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 27;
            this.button1.Text = "Imprimir";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(376, 11);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(51, 40);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 26;
            this.pictureBox4.TabStop = false;
            // 
            // txtMascotaBaja
            // 
            this.txtMascotaBaja.Location = new System.Drawing.Point(112, 20);
            this.txtMascotaBaja.Name = "txtMascotaBaja";
            this.txtMascotaBaja.Size = new System.Drawing.Size(258, 22);
            this.txtMascotaBaja.TabIndex = 25;
            this.txtMascotaBaja.TextChanged += new System.EventHandler(this.txtMascotaBaja_TextChanged);
            // 
            // lblMascotaBaja
            // 
            this.lblMascotaBaja.AutoSize = true;
            this.lblMascotaBaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblMascotaBaja.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblMascotaBaja.Location = new System.Drawing.Point(23, 20);
            this.lblMascotaBaja.Name = "lblMascotaBaja";
            this.lblMascotaBaja.Size = new System.Drawing.Size(86, 20);
            this.lblMascotaBaja.TabIndex = 24;
            this.lblMascotaBaja.Text = "Mascota:";
            // 
            // errorMascota
            // 
            this.errorMascota.ContainerControl = this;
            // 
            // frmMascotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(789, 678);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frmMascotas";
            this.Text = "frmMascotas";
            this.Load += new System.EventHandler(this.frmMascotas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Cargar.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBuscarCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMascotas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMascotasBajas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMascota)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage Cargar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNacimiento;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ComboBox cmbEspecie;
        private System.Windows.Forms.DateTimePicker dtpFechaNac;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblEspecieText;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnTipoProductos;
        private System.Windows.Forms.ComboBox cmbRaza;
        private System.Windows.Forms.Label lblRaza;
        private System.Windows.Forms.Label lblFechaText;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombreText;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.DataGridView dtgMascotas;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.PictureBox btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblApellidoBuscar;
        private System.Windows.Forms.DataGridView dtgMascotasBajas;
        private System.Windows.Forms.Label lblCantidadRegistrosBaja;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox txtMascotaBaja;
        private System.Windows.Forms.Label lblMascotaBaja;
        private System.Windows.Forms.ErrorProvider errorMascota;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtHembra;
        private System.Windows.Forms.RadioButton rbtMasculino;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblIdMascota;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.DataGridView dtgBuscarCliente;
    }
}