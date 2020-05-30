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
    public partial class frmProducto : Form
    {
        string sqlDefault = "Select p.*, tp.Tipo from Productos p inner join Tipo_Producto tp " +
                "on p.IdTipo = tp.Id where Estado = 1";
        string sqlSinStockDefault = "Select p.*, tp.Tipo from Productos p inner join Tipo_Producto tp " +
                "on p.IdTipo = tp.Id where Estado = 0";
        const int tam = 200;
        Producto[] P = new Producto[tam];
        int c;

        AccesoDato BD = new AccesoDato(@"Data Source=DESKTOP-JEV49B0\SQLEXPRESS;Initial Catalog=Veterinaria;Integrated Security=True");
        public frmProducto()
        {
            
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.txtNombre, "Ingrese el nombre del producto...");
            Mostrar(sqlDefault, dtgProducto);
            Mostrar(sqlSinStockDefault, dtgSinStock);
            for (int i = 0; i < tam; i++)
            {
                P[i] = null;
            }
            
        }

        private void frmProducto_Load(object sender, EventArgs e)
        {
            OcultarColumnas();
            lblCantidad.Text = "Cantidad de Registros: " + dtgProducto.Rows.Count;
            cargarCombo(cmbTipoProductos, "Tipo_Producto");
            limpiar();
            txtCodigo.Enabled = false;
        }

        private void OcultarColumnas()
        {
            dtgProducto.Columns[0].Visible = false;
            dtgProducto.Columns[1].Visible = false;
            dtgProducto.Columns[6].Visible = false;
            dtgProducto.Columns[5].Visible = false;

            dtgSinStock.Columns[0].Visible = false;
            dtgSinStock.Columns[4].Visible = false;
            dtgSinStock.Columns[5].Visible = false;

        }

        private void Mostrar(string sql, DataGridView dtgv)
        {
            DataTable dt = new DataTable();
            dt = BD.buscarTabla(sql);
            dtgv.DataSource = dt;       
        }



        private void cargarLista(string tabla)
        {
            c = 0;
            BD.leerTabla(tabla);

            while (BD.pLector.Read())
            {
                Producto p = new Producto();
                if (!BD.pLector.IsDBNull(0))
                    p.pId = BD.pLector.GetInt32(0);
                if (!BD.pLector.IsDBNull(1))
                    p.pDescripcion = BD.pLector.GetString(1);
                if (!BD.pLector.IsDBNull(2))
                    p.pPrecio = BD.pLector.GetDouble(2);
                if (!BD.pLector.IsDBNull(3))
                    p.pStock = BD.pLector.GetInt32(3);
                if (!BD.pLector.IsDBNull(4))
                    p.pTipo = BD.pLector.GetInt32(4);
                
                P[c] = p;
                c++;

            }
            BD.pLector.Close();
            BD.Desconectar();
        }
        private void cargarCombo(ComboBox combo, string tabla)
        {
            DataTable dt = new DataTable();
            dt = BD.consultarTabla(tabla);
            combo.DataSource = dt;
            combo.ValueMember = dt.Columns[0].ColumnName;
            combo.DisplayMember = dt.Columns[1].ColumnName;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void buscarProducto(string sql, DataGridView dtgv)
        {
            DataTable dt = new DataTable();
            dt = BD.buscarTabla(sql);
            dtgv.DataSource = dt;
            lblCantidad.Text = "Cantidad de Registros: " + dtgv.Rows.Count;
            lblCantidadRegistrosSinStock.Text = "Cantidad de Registros: " + dtgv.Rows.Count;
        }

        

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string sql = "Select p.*, tp.Tipo from Productos p inner join Tipo_Producto tp " +
                "on p.IdTipo = tp.Id where Estado = 1 and Descripcion like '" + txtBuscar.Text + "%'";
            buscarProducto(sql, dtgProducto);
        }

        private void dtgProducto_DoubleClick(object sender, EventArgs e)
        {
            
            txtCodigo.Text = Convert.ToString(dtgProducto.CurrentRow.Cells[1].Value);
            txtNombre.Text = Convert.ToString(dtgProducto.CurrentRow.Cells[2].Value);
            txtPrecio.Text = Convert.ToString(dtgProducto.CurrentRow.Cells[3].Value);
            txtStock.Text = Convert.ToString(dtgProducto.CurrentRow.Cells[4].Value);
            cmbTipoProductos.SelectedValue = Convert.ToInt32(dtgProducto.CurrentRow.Cells[5].Value);
            tabControl1.SelectedIndex = 1;
            Habilitar(true);
        }

        private bool validarCampos()
        {
            bool ok = true;
            if (txtCodigo.Text == "")
            {
                MessageBox.Show("Debe ingresar un codigo...");
                txtCodigo.Focus();
                ok = false;
                errorCargarProducto.SetError(txtCodigo, "Ingrese un Tipo"); 
                return false;
            }
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Debe ingresar una descripcion...");
                txtNombre.Focus();
                ok = false;
                errorCargarProducto.SetError(txtNombre, "Ingrese un Nombre");
                return false;
            }
            if (txtPrecio.Text == "")
            {
                MessageBox.Show("Debe ingresar un precio...");
                txtPrecio.Focus();
                ok = false;
                errorCargarProducto.SetError(txtPrecio, "Ingrese un Precio");
                return false;
            }
            if (txtStock.Text == "")
            {
                MessageBox.Show("Debe ingresar el Stock...");
                txtStock.Focus();
                ok = false;
                errorCargarProducto.SetError(txtStock, "Ingrese un Stock");
                return false;
            }
            if (cmbTipoProductos.SelectedIndex == -1)
            {
                MessageBox.Show("Debe ingresar un tipo producto...");
                cmbTipoProductos.Focus();
                ok = false;
                errorCargarProducto.SetError(cmbTipoProductos, "Seleccione un Tipo");
                return false;
            }    
            eliminarMensajeError();
            return true;
        }
        private void eliminarMensajeError()
        {
            errorCargarProducto.SetError(txtCodigo, "");
            errorCargarProducto.SetError(txtNombre, "");
            errorCargarProducto.SetError(txtPrecio, "");
            errorCargarProducto.SetError(txtStock, "");
            errorCargarProducto.SetError(cmbTipoProductos, "");

        }

        private void limpiar()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtStock.Text = "";
            txtPrecio.Text = "";
            cmbTipoProductos.SelectedIndex = -1;
        }
        

        

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                string consultaSQL;
                Producto p = new Producto();
                p.pId = Convert.ToInt32(txtCodigo.Text);
                p.pDescripcion = txtNombre.Text;
                p.pPrecio = Convert.ToDouble(txtPrecio.Text);
                p.pStock = Convert.ToInt32(txtStock.Text);
                p.pTipo = Convert.ToInt32(cmbTipoProductos.SelectedValue);
                if(p.pStock > 0)
                {
                    p.pEstado = 1;
                }
                else
                {
                    p.pEstado = 0;
                }
                if(arregloCompleto(c, tam))
                {
                    
                    consultaSQL = "UPDATE Productos SET Descripcion = '" + p.pDescripcion
                        + "', Precio =" + p.pPrecio + ","
                        + "Stock=" + p.pStock + "," 
                        + "IdTipo=" + p.pTipo + ","
                        + "Estado="+ p.pEstado +
                        "WHERE Id=" + p.pId;
                    BD.actualizarBD(consultaSQL);
                    cargarLista("Productos");
                    //Habilitar(false);
                    Mostrar(sqlDefault, dtgProducto);
                    Mostrar(sqlSinStockDefault, dtgSinStock);
                    limpiar();
                    tabControl1.SelectedIndex = 0;
                }
            }
        }
        #region darbaja
        private void chkEliminar_CheckedChanged(object sender, EventArgs e)
        {
            if(chkEliminar.Checked == true)
            {
                dtgProducto.Columns[0].Visible = true;
            }
            else
            {
                dtgProducto.Columns[0].Visible = false;

            }
        }

        private bool arregloCompleto(int contador, int tamanio)
        {
            if (contador != tamanio)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void dtgProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dtgProducto.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell ChkEliminar =
                    (DataGridViewCheckBoxCell)dtgProducto.Rows[e.RowIndex].Cells["Eliminar"];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            DialogResult Opcion;
            Opcion = MessageBox.Show("Realmente desea eliminar los registros?", "Veterinaria", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (Opcion == DialogResult.OK)
            {
                string Codigo;
                string sql;

                foreach (DataGridViewRow row in dtgProducto.Rows)
                {

                    if (Convert.ToBoolean(row.Cells[0].Value))
                    {
                        Codigo = Convert.ToString(row.Cells[1].Value);
                        sql = "UPDATE Productos Set Estado = 0, Stock=0 WHERE Id=" + Codigo;

                        BD.actualizarBD(sql);
                       
                    }
                }

               
                Mostrar(sqlDefault, dtgProducto);
                Mostrar(sqlSinStockDefault, dtgSinStock);
            }
        }
        #endregion
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmEditarTipoProductos frm = new frmEditarTipoProductos();
            frm.ShowDialog();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            cargarCombo(cmbTipoProductos, "Tipo_Producto");
            cargarLista("Productos");
        }

        private void txtBuscarStock_TextChanged(object sender, EventArgs e)
        {
            string sql = "Select p.*, tp.Tipo from Productos p inner join Tipo_Producto tp " +
               "on p.IdTipo = tp.Id where Estado = 0 and Descripcion like '" + txtBuscarStock.Text + "%'";
            buscarProducto(sql, dtgSinStock);
        }

        

        private void dtgSinStock_DoubleClick(object sender, EventArgs e)
        {
            txtCodigo.Text = Convert.ToString(dtgSinStock.CurrentRow.Cells[0].Value);
            txtNombre.Text = Convert.ToString(dtgSinStock.CurrentRow.Cells[1].Value);
            txtPrecio.Text = Convert.ToString(dtgSinStock.CurrentRow.Cells[2].Value);
            txtStock.Text = Convert.ToString(dtgSinStock.CurrentRow.Cells[3].Value);
            cmbTipoProductos.SelectedValue = Convert.ToInt32(dtgSinStock.CurrentRow.Cells[4].Value);
            tabControl1.SelectedIndex = 1;
            Habilitar(false);
            txtStock.Enabled = true;
        }

        private void dtgSinStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          

        }

        private void Habilitar(bool x)
        {
            txtCodigo.Enabled = x;
            txtNombre.Enabled = x;
            txtPrecio.Enabled = x;
            txtStock.Enabled = x;
            cmbTipoProductos.Enabled = x;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        public bool GuardarFK(int fk)
        {
            Producto[] FK = new Producto[tam];
            for (int i = 0; i < tam; i++)
            {
                FK[i] = null;
            }
            c = 0;
            BD.leerTabla("Productos");
            while (BD.pLector.Read())
            {
                Producto p = new Producto();
                if (!BD.pLector.IsDBNull(4))
                    p.pTipo = BD.pLector.GetInt32(4);

                FK[c] = p;
                c++;

            }
            BD.pLector.Close();
            BD.Desconectar();

            for (int i = 0; i < c; i++)
                {
                    if (fk == FK[i].pTipo)
                    {             
                    return false;
                    }
                }
            return true;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            frmReporteProducto frm = new frmReporteProducto();
            frm.ShowDialog();

        }
    }
}
