namespace Veterinaria
{
    partial class frmEditarTipoProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditarTipoProductos));
            this.lstTipoProductos = new System.Windows.Forms.ListBox();
            this.txtNombreProductos = new System.Windows.Forms.TextBox();
            this.lblNombreProductoText = new System.Windows.Forms.Label();
            this.txtCodigoProductos = new System.Windows.Forms.TextBox();
            this.lblCodigoProductoText = new System.Windows.Forms.Label();
            this.btnNuevoProductos = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.errorTipo = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorTipo)).BeginInit();
            this.SuspendLayout();
            // 
            // lstTipoProductos
            // 
            this.lstTipoProductos.FormattingEnabled = true;
            this.lstTipoProductos.ItemHeight = 16;
            this.lstTipoProductos.Location = new System.Drawing.Point(360, 12);
            this.lstTipoProductos.Name = "lstTipoProductos";
            this.lstTipoProductos.Size = new System.Drawing.Size(213, 292);
            this.lstTipoProductos.TabIndex = 0;
            this.lstTipoProductos.SelectedIndexChanged += new System.EventHandler(this.lstTipoProductos_SelectedIndexChanged);
            // 
            // txtNombreProductos
            // 
            this.txtNombreProductos.Location = new System.Drawing.Point(101, 174);
            this.txtNombreProductos.Name = "txtNombreProductos";
            this.txtNombreProductos.Size = new System.Drawing.Size(154, 22);
            this.txtNombreProductos.TabIndex = 8;
            // 
            // lblNombreProductoText
            // 
            this.lblNombreProductoText.AutoSize = true;
            this.lblNombreProductoText.Font = new System.Drawing.Font("Imprint MT Shadow", 10F, System.Drawing.FontStyle.Bold);
            this.lblNombreProductoText.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNombreProductoText.Location = new System.Drawing.Point(12, 174);
            this.lblNombreProductoText.Name = "lblNombreProductoText";
            this.lblNombreProductoText.Size = new System.Drawing.Size(76, 20);
            this.lblNombreProductoText.TabIndex = 7;
            this.lblNombreProductoText.Text = "Nombre";
            // 
            // txtCodigoProductos
            // 
            this.txtCodigoProductos.Location = new System.Drawing.Point(101, 131);
            this.txtCodigoProductos.Name = "txtCodigoProductos";
            this.txtCodigoProductos.Size = new System.Drawing.Size(154, 22);
            this.txtCodigoProductos.TabIndex = 6;
            // 
            // lblCodigoProductoText
            // 
            this.lblCodigoProductoText.AutoSize = true;
            this.lblCodigoProductoText.Font = new System.Drawing.Font("Imprint MT Shadow", 10F, System.Drawing.FontStyle.Bold);
            this.lblCodigoProductoText.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCodigoProductoText.Location = new System.Drawing.Point(12, 131);
            this.lblCodigoProductoText.Name = "lblCodigoProductoText";
            this.lblCodigoProductoText.Size = new System.Drawing.Size(68, 20);
            this.lblCodigoProductoText.TabIndex = 5;
            this.lblCodigoProductoText.Text = "Codigo";
            // 
            // btnNuevoProductos
            // 
            this.btnNuevoProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNuevoProductos.FlatAppearance.BorderSize = 0;
            this.btnNuevoProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoProductos.Font = new System.Drawing.Font("Imprint MT Shadow", 10F, System.Drawing.FontStyle.Bold);
            this.btnNuevoProductos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNuevoProductos.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevoProductos.Image")));
            this.btnNuevoProductos.Location = new System.Drawing.Point(16, 307);
            this.btnNuevoProductos.Name = "btnNuevoProductos";
            this.btnNuevoProductos.Size = new System.Drawing.Size(98, 101);
            this.btnNuevoProductos.TabIndex = 10;
            this.btnNuevoProductos.Text = "Nuevo";
            this.btnNuevoProductos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNuevoProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNuevoProductos.UseVisualStyleBackColor = true;
            this.btnNuevoProductos.Click += new System.EventHandler(this.btnNuevoProductos_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Imprint MT Shadow", 10F, System.Drawing.FontStyle.Bold);
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.Location = new System.Drawing.Point(102, 307);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(87, 101);
            this.btnEditar.TabIndex = 11;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBorrar.FlatAppearance.BorderSize = 0;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Font = new System.Drawing.Font("Imprint MT Shadow", 10F, System.Drawing.FontStyle.Bold);
            this.btnBorrar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBorrar.Image = ((System.Drawing.Image)(resources.GetObject("btnBorrar.Image")));
            this.btnBorrar.Location = new System.Drawing.Point(275, 307);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(91, 101);
            this.btnBorrar.TabIndex = 12;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBorrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click_1);
            // 
            // btnVolver
            // 
            this.btnVolver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Imprint MT Shadow", 10F, System.Drawing.FontStyle.Bold);
            this.btnVolver.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVolver.Image = ((System.Drawing.Image)(resources.GetObject("btnVolver.Image")));
            this.btnVolver.Location = new System.Drawing.Point(482, 310);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(91, 101);
            this.btnVolver.TabIndex = 13;
            this.btnVolver.Text = "Volver";
            this.btnVolver.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCargar.FlatAppearance.BorderSize = 0;
            this.btnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargar.Font = new System.Drawing.Font("Imprint MT Shadow", 10F, System.Drawing.FontStyle.Bold);
            this.btnCargar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCargar.Image = ((System.Drawing.Image)(resources.GetObject("btnCargar.Image")));
            this.btnCargar.Location = new System.Drawing.Point(180, 307);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(98, 101);
            this.btnCargar.TabIndex = 14;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCargar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Imprint MT Shadow", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(376, 307);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(107, 101);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // errorTipo
            // 
            this.errorTipo.ContainerControl = this;
            // 
            // frmEditarTipoProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(585, 420);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevoProductos);
            this.Controls.Add(this.txtNombreProductos);
            this.Controls.Add(this.lblNombreProductoText);
            this.Controls.Add(this.txtCodigoProductos);
            this.Controls.Add(this.lblCodigoProductoText);
            this.Controls.Add(this.lstTipoProductos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEditarTipoProductos";
            this.Text = "Tipo Productos";
            this.Load += new System.EventHandler(this.frmEditarTipoProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorTipo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstTipoProductos;
        private System.Windows.Forms.TextBox txtNombreProductos;
        private System.Windows.Forms.Label lblNombreProductoText;
        private System.Windows.Forms.TextBox txtCodigoProductos;
        private System.Windows.Forms.Label lblCodigoProductoText;
        private System.Windows.Forms.Button btnNuevoProductos;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ErrorProvider errorTipo;
    }
}