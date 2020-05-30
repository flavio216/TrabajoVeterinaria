using System;
using System.Data;
using System.Windows.Forms;


namespace Veterinaria
{
    public partial class frmCargarProducto : Form
    {
        const int tam = 20;
        AccesoDato DBP = new AccesoDato(@"Data Source=DESKTOP-JEV49B0\SQLEXPRESS;Initial Catalog=Veterinaria;Integrated Security=True");
        Producto[] P = new Producto[tam];
        int c;
        //bool nuevo = true;

        public frmCargarProducto()
        {
            InitializeComponent();
            for (int i = 0; i < tam; i++)
            {
                P[i] = null;
            }
            Habilitar(false);
        }

        private void btnVolverProductos_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCargarProducto_Load(object sender, EventArgs e)
        {
            cargarCombo(cmbTipoProductos, "Tipo_Producto");
            cargarLista("Productos");
        }

        private void cargarLista(string tabla)
        {
            c = 0;
            DBP.leerTabla(tabla);

            while (DBP.pLector.Read())
            {
                Producto p = new Producto();
                if (!DBP.pLector.IsDBNull(0))
                    p.pId = DBP.pLector.GetInt32(0);
                if (!DBP.pLector.IsDBNull(1))
                    p.pDescripcion = DBP.pLector.GetString(1);
                if (!DBP.pLector.IsDBNull(2))
                    p.pPrecio = DBP.pLector.GetDouble(2);
                if (!DBP.pLector.IsDBNull(3))
                    p.pStock = DBP.pLector.GetInt32(3);
                if (!DBP.pLector.IsDBNull(4))
                    p.pTipo = DBP.pLector.GetInt32(4);
                P[c] = p;
                c++;

            }
            DBP.pLector.Close();
            DBP.Desconectar();
        }
        private void cargarCombo(ComboBox combo, string tabla)
        {
            DataTable dt = new DataTable();
            dt = DBP.consultarTabla(tabla);
            combo.DataSource = dt;
            combo.ValueMember = dt.Columns[0].ColumnName;
            combo.DisplayMember = dt.Columns[1].ColumnName;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

       

        private void btnVolverProductos_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            cargarCombo(cmbTipoProductos, "Tipo_Producto");
            cargarLista("Productos");
        }

        private void btnCargarProductos_Click(object sender, EventArgs e)
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
                if (p.pStock > 0)
                {
                    p.pEstado = 1;
                }
                else
                {
                    p.pEstado = 0;
                }
                if (arregloCompleto())
                {
                    if (!validarPK(p.pId))
                    {
                        consultaSQL = "INSERT INTO Productos (Id, Descripcion, Precio, Stock, IdTipo, Estado) Values ("
                            + p.pId + ",'"
                            + p.pDescripcion + "',"
                            + p.pPrecio + ","
                            + p.pStock + ","
                            + p.pTipo + ","
                            + p.pEstado + ")";

                        DBP.actualizarBD(consultaSQL);
                        cargarLista("Productos");
                        MessageBox.Show("Producto Cargado correctamente...");
                        limpiar();
                    }
                    else
                    {
                        MessageBox.Show("Ya existe un producto con este codigo...");
                        txtCodigo.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Solo se pueden agregar " + tam + " tipo de productos");

                }
            }
        }

        //private bool validarerror()
        //{
        //    bool ok = true;
        //    if (txtCodigo.Text == "")
        //    {
        //        ok = false;
        //        errorProvider1.SetError(txtCodigo, "Ingrese un Codigo");
        //    }
        //    if (txtNombre.Text == "")
        //    {
        //        ok = false;
        //        errorProvider1.SetError(txtCodigo, "Ingrese un Nombre");
        //    }

        //    if (txtPrecio.Text == "")
        //    {
        //        ok = false;
        //        errorProvider1.SetError(txtCodigo, "Ingrese un Precio");
        //    }

        //    if (txtStock.Text == "")
        //    {
        //        ok = false;
        //        errorProvider1.SetError(txtCodigo, "Ingrese un stock");
        //    }
        //    if (cmbTipoProductos.Text == "")
        //    {
        //        ok = false;
        //        errorProvider1.SetError(txtCodigo, "Ingrese un Tipo");
        //    }
        //    return ok;
                
        //}

        private void eliminarMensajeError()
        {
            errorProvider1.SetError(txtCodigo, "");
            errorProvider1.SetError(txtNombre, "");
            errorProvider1.SetError(txtPrecio, "");
            errorProvider1.SetError(txtStock, "");
            errorProvider1.SetError(cmbTipoProductos, "");

        }

        public bool validarCampos()
        {
           bool ok = true;
            if (txtCodigo.Text == "")
            {
                MessageBox.Show("Debe ingresar un codigo...");
                txtCodigo.Focus();
                ok = false;
                errorProvider1.SetError(txtCodigo, "Ingrese un Codigo");
                return false;
            }
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Debe ingresar una descripcion...");
                txtNombre.Focus();
                ok = false;
                errorProvider1.SetError(txtNombre, "Ingrese un Nombre");
                return false;
            }
            if (txtPrecio.Text == "")
            {
                MessageBox.Show("Debe ingresar un precio...");
                txtPrecio.Focus();
                ok = false;
                errorProvider1.SetError(txtPrecio, "Ingrese un Precio");
                return false;
            }
            if (txtStock.Text == "")
            {
                MessageBox.Show("Debe ingresar un stock...");
                txtStock.Focus();
                ok = false;
                errorProvider1.SetError(txtStock, "Ingrese un Stock");
                return false;
            }
            if (cmbTipoProductos.SelectedIndex == -1)
            {
                MessageBox.Show("Debe ingresar un tipo producto...");
                cmbTipoProductos.Focus();
                ok = false;
                errorProvider1.SetError(cmbTipoProductos, "Ingrese un Tipo");
                return false;
            }
           
            else
            {
                eliminarMensajeError();
            }
            return true;
        }

        private void limpiar()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtStock.Text = "";
            txtPrecio.Text = "";
            cmbTipoProductos.SelectedIndex = -1;
        }

        private bool validarPK(int pk)
        {
            for (int i = 0; i < c; i++)
            {
                if (P[i].pId == pk)
                {
                    return true;
                }
            }
            return false;
        }

        private bool arregloCompleto()
        {
            if (c != tam)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmEditarTipoProductos frm = new frmEditarTipoProductos();
            frm.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            
        }

        private Form activeForm = null;
        public void abrirFormHijo(Form formHijo, Panel panel)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = formHijo;
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            panel.Controls.Add(formHijo);
            panel.Tag = formHijo;
            formHijo.BringToFront();
            formHijo.Show();
        }

        private void Habilitar(bool x)
        {
            ///HABILITAR
            txtCodigo.Enabled = x;
            txtNombre.Enabled = x;
            txtStock.Enabled = x;
            cmbTipoProductos.Enabled = x;
            txtPrecio.Enabled = x;           
            btnCargarProductos.Enabled = x;
            btnCancelar.Enabled = x;
            //btnEditar.Enabled = x;
            ///DESHABILITAR
            btnNuevo.Enabled = !x;
            //btnEditar.Enabled = !x;
            btnEliminar.Enabled = !x;

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Habilitar(true);
            limpiar();
           

                
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Habilitar(false);
        }

        
    }
}

