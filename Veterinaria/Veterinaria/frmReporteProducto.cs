using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veterinaria
{
    public partial class frmReporteProducto : Form
    {
        public frmReporteProducto()
        {
            InitializeComponent();
        }

        private void frmReporteProducto_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dtsPrincipal.spProductos' Puede moverla o quitarla según sea necesario.
            this.spProductosTableAdapter.Fill(this.dtsPrincipal.spProductos);

            this.reportViewer1.RefreshReport();
        }
    }
}
