namespace Veterinaria
{
    partial class frmReporteProducto
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtsPrincipal = new Veterinaria.dtsPrincipal();
            this.spProductosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spProductosTableAdapter = new Veterinaria.dtsPrincipalTableAdapters.spProductosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dtsPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spProductosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(800, 450);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.spProductosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Veterinaria.Productos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 1;
            // 
            // dtsPrincipal
            // 
            this.dtsPrincipal.DataSetName = "dtsPrincipal";
            this.dtsPrincipal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spProductosBindingSource
            // 
            this.spProductosBindingSource.DataMember = "spProductos";
            this.spProductosBindingSource.DataSource = this.dtsPrincipal;
            // 
            // spProductosTableAdapter
            // 
            this.spProductosTableAdapter.ClearBeforeFill = true;
            // 
            // frmReporteProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "frmReporteProducto";
            this.Text = "frmReporteProducto";
            this.Load += new System.EventHandler(this.frmReporteProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtsPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spProductosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spProductosBindingSource;
        private dtsPrincipal dtsPrincipal;
        private dtsPrincipalTableAdapters.spProductosTableAdapter spProductosTableAdapter;
    }
}