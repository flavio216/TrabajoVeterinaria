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
    public partial class FrmClientes : Form
    {
        bool nuevo;
        const int tam = 300;
        int c;
        AccesoDato BD = new AccesoDato(@"Data Source=DESKTOP-JEV49B0\SQLEXPRESS;Initial Catalog=Veterinaria;Integrated Security=True");
        Clientes[] C = new Clientes[tam];
        public FrmClientes()
        {
            InitializeComponent();
            for (int i = 0; i < tam; i++)
            {
                C[i] = null;
            }
            cargarCombo(cmbLocalidad, "Localidades");
            cargarCombo(cmbTipoDocumento, "Tipo_Documentos");
            nuevo = false;
            btnAlta.Enabled = false;
            btnBaja.Enabled = false;
            Mostrar("Exec prCliente", dtgCliente);
            Mostrar("Exec prClienteBaja", dtgClientesBajas);
            
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            Habilitar(false);
            dtgCliente.Columns[0].Visible = false;
            OcultarColumnas();
            lblCantidad.Text = "Cantidad de Registros: " + dtgCliente.Rows.Count;
            lblCantidadRegistrosBaja.Text = "Cantidad de Registros: " + dtgClientesBajas.Rows.Count;
        }

        private void Habilitar(bool x)
        {
            txtApellido.Enabled = x;
            txtNroCliente.Enabled = x;
            txtDocumento.Enabled = x;
            txtNombre.Enabled = x;
            txtDireccion.Enabled = x;
            dtpFechaNacimiento.Enabled = x;
            btnSalir.Enabled = x;
            btnCargar.Enabled = x;
            txtNumero.Enabled = x;
            cmbTipoDocumento.Enabled = x;
            txtTelefono.Enabled = x;
            cmbLocalidad.Enabled = x;
            btnCancelar.Enabled = x;
            btnNuevo.Enabled = !x;
            btnNuevo.Enabled = !x;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Habilitar(true);
            nuevo = true;
            limpiar();
            btnBaja.Enabled = false;
            btnAlta.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Habilitar(false);
            nuevo = false;
        }

        private void Mostrar(string sql, DataGridView dtgv)
        {
            DataTable dt = new DataTable();
            dt = BD.buscarTabla(sql);
            dtgv.DataSource = dt;
        }

        public void cargarLista(string tabla)
        {
            c = 0;
            BD.leerTabla(tabla);

            while (BD.pLector.Read())
            {
                Clientes cl = new Clientes();
                if (!BD.pLector.IsDBNull(0))
                    cl.pIdCliente = BD.pLector.GetInt32(0);
                if (!BD.pLector.IsDBNull(1))
                    cl.pApellido = BD.pLector.GetString(1);
                if (!BD.pLector.IsDBNull(2))
                    cl.pNombre = BD.pLector.GetString(2);
                if (!BD.pLector.IsDBNull(3))
                    cl.pTipoDocumento = BD.pLector.GetInt32(3);
                if (!BD.pLector.IsDBNull(4))
                    cl.pDocumento = BD.pLector.GetInt32(4);
                if (!BD.pLector.IsDBNull(5))
                    cl.pFechaNac = BD.pLector.GetDateTime(5);
                if (!BD.pLector.IsDBNull(6))
                    cl.pTelefono = BD.pLector.GetDouble(6);
                if (!BD.pLector.IsDBNull(7))
                    cl.pLocalidad = BD.pLector.GetInt32(7);
                if (!BD.pLector.IsDBNull(8))
                    cl.pDireccion = BD.pLector.GetString(8);
                if (!BD.pLector.IsDBNull(9))
                    cl.pNumeroCasa = BD.pLector.GetInt32(9);

                C[c] = cl;
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

        private void Buscar(string sql, DataGridView dtgv)
        {
            DataTable dt = new DataTable();
            dt = BD.buscarTabla(sql);
            dtgv.DataSource = dt;
            lblCantidad.Text = "Cantidad de Registros: " + dtgv.Rows.Count;
            lblCantidadRegistrosBaja.Text = "Cantidad de Registros: " + dtgv.Rows.Count;
        }

        private bool validarCampos()
        {
            bool ok = true;
            if (txtNroCliente.Text == "")
            {
                MessageBox.Show("Debe ingresar el Nro de Cliente...");
                txtNroCliente.Focus();
                ok = false;
                errorCliente.SetError(txtNroCliente, "Ingrese un Tipo");
                return false;
            }
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Debe ingresar una descripcion...");
                txtNombre.Focus();
                ok = false;
                errorCliente.SetError(txtNombre, "Ingrese un Nombre");
                return false;
            }
            if (txtApellido.Text == "")
            {
                MessageBox.Show("Debe ingresar el Apellido...");
                txtApellido.Focus();
                ok = false;
                errorCliente.SetError(txtApellido, "Ingrese Apellido");
                return false;
            }
            if (txtDireccion.Text == "")
            {
                MessageBox.Show("Debe ingresar la direccion...");
                txtDireccion.Focus();
                ok = false;
                errorCliente.SetError(txtDireccion, "Ingrese una direccion");
                return false;
            }
            if (txtNumero.Text == "")
            {
                MessageBox.Show("Debe ingresar el numero de mi casa...");
                txtNumero.Focus();
                ok = false;
                errorCliente.SetError(txtNumero, "Ingrese un numero");
                return false;
            }
            if (cmbTipoDocumento.SelectedIndex == -1)
            {
                MessageBox.Show("Debe ingresar un tipo documento...");
                cmbTipoDocumento.Focus();
                ok = false;
                errorCliente.SetError(cmbTipoDocumento, "Seleccione un Tipo");
                return false;
            }
            if (txtDocumento.Text == "") 
            {
                MessageBox.Show("Debe ingresar un documento...");
                txtDocumento.Focus();
                ok = false;
                errorCliente.SetError(txtDocumento, "Seleccione un Documento");
                return false;
            }
            if (cmbLocalidad.SelectedIndex == -1)
            {
                MessageBox.Show("Debe ingresar una localidad...");
                cmbLocalidad.Focus();
                ok = false;
                errorCliente.SetError(cmbLocalidad, "Seleccione una localidad");
                return false;
            }

            eliminarMensajeError();      
            return true;
            
        }
        private void eliminarMensajeError()
        {
            errorCliente.SetError(txtNroCliente, "");
            errorCliente.SetError(txtNombre, "");
            errorCliente.SetError(txtApellido, "");
            errorCliente.SetError(txtDireccion, "");
            errorCliente.SetError(cmbTipoDocumento, "");
            errorCliente.SetError(cmbLocalidad, "");
            errorCliente.SetError(txtNumero, "");

        }

        private void limpiar()
        {
            txtNumero.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDireccion.Text = "";
            txtDocumento.Text = "";
            txtTelefono.Text = "";
            cmbLocalidad.SelectedIndex = -1;
            cmbTipoDocumento.SelectedIndex = -1;
            dtpFechaNacimiento.Value = DateTime.Today;
        }

        private void pbLocalidad_Click(object sender, EventArgs e)
        {
            FrmLocalidad frm = new FrmLocalidad();
            frm.ShowDialog();
        }

        public bool GuardarFK(string txt, int fk)
        {
            Clientes[] FK = new Clientes[tam];
            for (int i = 0; i < tam; i++)
            {
                FK[i] = null;
            }
            c = 0;
            BD.leerTabla("Clientes");        
                while (BD.pLector.Read())
                {
                    Clientes cl = new Clientes();
                    if(!BD.pLector.IsDBNull(3))
                        cl.pTipoDocumento = BD.pLector.GetInt32(3);              
                    if (!BD.pLector.IsDBNull(7))
                        cl.pLocalidad = BD.pLector.GetInt32(7);

                FK[c] = cl;
                c++;

                }
            BD.pLector.Close();
            BD.Desconectar();
            
            if(txt == "TipoDocumento")
            {
                for (int i = 0; i < c; i++)
                {
                    if(fk == FK[i].pTipoDocumento)
                    {
                        return false;
                    }
                }
            }
            if(txt == "Localidad")
            {
                for (int i = 0; i < c; i++)
                {
                    if(fk == FK[i].pLocalidad)
                    {
                        return false;
                    }
                }
            }
            MessageBox.Show("No puede borrar este registro por que esta siendo usado en otro...");
            return true;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string sql = "Select * from Clientes " +
                "where Estado = 1 and Apellido like '" + txtBuscar.Text + "%'";
            Buscar(sql, dtgCliente);
        }

        private void dtgCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNroCliente.Text = Convert.ToString(dtgCliente.CurrentRow.Cells[1].Value);
            txtApellido.Text = Convert.ToString(dtgCliente.CurrentRow.Cells[2].Value);
            txtNombre.Text = Convert.ToString(dtgCliente.CurrentRow.Cells[3].Value);
            cmbTipoDocumento.SelectedValue = Convert.ToInt32(dtgCliente.CurrentRow.Cells[4].Value);
            txtDocumento.Text = Convert.ToString(dtgCliente.CurrentRow.Cells[6].Value);
            dtpFechaNacimiento.Value = Convert.ToDateTime(dtgCliente.CurrentRow.Cells[7].Value);
            txtTelefono.Text = Convert.ToString(dtgCliente.CurrentRow.Cells[8].Value); ;
            cmbLocalidad.SelectedValue = Convert.ToInt32(dtgCliente.CurrentRow.Cells[9].Value);
            txtDireccion.Text = Convert.ToString(dtgCliente.CurrentRow.Cells[11].Value);
            txtNumero.Text = Convert.ToString(dtgCliente.CurrentRow.Cells[12].Value);
            nuevo = false;
            btnBaja.Enabled = true;
            btnAlta.Enabled = false;
            Habilitar(true);
            txtNroCliente.Enabled = false;
            txtDocumento.Enabled = false;
            cmbTipoDocumento.Enabled = false;
            tabControl1.SelectedIndex = 1;
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

        private bool validarPK(int pk)
        {
            for (int i = 0; i < c; i++)
            {
                if (C[i].pIdCliente == pk)
                {
                    return true;
                }
            }
            return false;
        }

        private void chkEliminar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEliminar.Checked == true)
            {
                dtgCliente.Columns[0].Visible = true;
            }
            else
            {
                dtgCliente.Columns[0].Visible = false;

            }
        }

        private void dtgClientesBajas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNroCliente.Text = Convert.ToString(dtgClientesBajas.CurrentRow.Cells[0].Value);
            txtApellido.Text = Convert.ToString(dtgClientesBajas.CurrentRow.Cells[1].Value);
            txtNombre.Text = Convert.ToString(dtgClientesBajas.CurrentRow.Cells[2].Value);
            cmbTipoDocumento.SelectedValue = Convert.ToInt32(dtgClientesBajas.CurrentRow.Cells[3].Value);
            txtDocumento.Text = Convert.ToString(dtgClientesBajas.CurrentRow.Cells[5].Value);
            dtpFechaNacimiento.Value = Convert.ToDateTime(dtgClientesBajas.CurrentRow.Cells[6].Value);
            txtTelefono.Text = Convert.ToString(dtgClientesBajas.CurrentRow.Cells[7].Value); ;
            cmbLocalidad.SelectedValue = Convert.ToInt32(dtgClientesBajas.CurrentRow.Cells[8].Value);
            txtDireccion.Text = Convert.ToString(dtgClientesBajas.CurrentRow.Cells[10].Value);
            txtNumero.Text = Convert.ToString(dtgClientesBajas.CurrentRow.Cells[11].Value);
            Habilitar(false);
            nuevo = false;
            txtNroCliente.Enabled = false;
            txtDocumento.Enabled = false;
            cmbTipoDocumento.Enabled = false;
            tabControl1.SelectedIndex = 1;
            btnBaja.Enabled = false;
            btnAlta.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult Opcion;
            Opcion = MessageBox.Show("Realmente desea eliminar los registros?", "Veterinaria", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (Opcion == DialogResult.OK)
            {
                string Codigo;
                string sql;

                foreach (DataGridViewRow row in dtgCliente.Rows)
                {

                    if (Convert.ToBoolean(row.Cells[0].Value))
                    {
                        Codigo = Convert.ToString(row.Cells[1].Value);
                        sql = "UPDATE Clientes Set Estado = 0 WHERE Id=" + Codigo;
                        BD.actualizarBD(sql);
                        Mostrar("Exec prCliente", dtgCliente);
                        Mostrar("Exec prClienteBaja", dtgClientesBajas);
                    }
                }
            }
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {

            DialogResult Opcion;
            Opcion = MessageBox.Show("Quiere dar de alta al cliente?", "Veterinaria", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (Opcion == DialogResult.OK)
            {
                int Codigo;
                string sql;


                Codigo = Convert.ToInt32(dtgClientesBajas.CurrentRow.Cells[0].Value);
                sql = "UPDATE Clientes Set Estado = 1 WHERE Id=" + Codigo;
                    BD.actualizarBD(sql);
                    Mostrar("Exec prCliente", dtgCliente);
                    Mostrar("Exec prClienteBaja", dtgClientesBajas);
                
                tabControl1.SelectedIndex = 0;
                limpiar();
            }
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            DialogResult Opcion;
            Opcion = MessageBox.Show("Quiere dar de baja al cliente?", "Veterinaria", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (Opcion == DialogResult.OK)
            {
                int Codigo;
                string sql;

            
                    
                    Codigo = Convert.ToInt32(dtgCliente.CurrentRow.Cells[1].Value);
                    sql = "UPDATE Clientes Set Estado = 0 WHERE Id=" + Codigo;
                    BD.actualizarBD(sql);
                    Mostrar("Exec prCliente", dtgCliente);
                    Mostrar("Exec prClienteBaja", dtgClientesBajas);

                
                tabControl1.SelectedIndex = 2;
                limpiar();
            }
            
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                string consultaSQL;
                Clientes cl = new Clientes();
                cl.pIdCliente = Convert.ToInt32(txtNroCliente.Text);
                cl.pNombre = txtNombre.Text;
                cl.pApellido = txtApellido.Text;
                cl.pTipoDocumento = Convert.ToInt32(cmbTipoDocumento.SelectedValue);
                cl.pDocumento = Convert.ToInt32(txtDocumento.Text);
                cl.pFechaNac = dtpFechaNacimiento.Value;
                cl.pDireccion = txtDireccion.Text;
                cl.pTelefono = Convert.ToDouble(txtTelefono.Text);
                cl.pNumeroCasa = Convert.ToInt32(txtNumero.Text);
                cl.pLocalidad = Convert.ToInt32(cmbLocalidad.SelectedValue);
                cl.pEstado = 1;
                if(nuevo)
                {
                    if(arregloCompleto(c,tam))
                    {
                        if(!validarPK(cl.pIdCliente))
                        {
                            consultaSQL = "INSERT INTO Clientes (Id, Apellido, Nombre, TipoDoc, Documento, FechaNac," +
                                " Telefono, IdLocalidad, Direccion, Numero, Estado) Values ("
                                + cl.pIdCliente + ",'"
                                + cl.pApellido + "','"
                                + cl.pNombre + "',"
                                + cl.pTipoDocumento + ","
                                + cl.pDocumento + ",'"
                                + cl.pFechaNac + "',"
                                + cl.pTelefono + ","
                                + cl.pLocalidad + ",'"
                                + cl.pDireccion + "',"
                                + cl.pNumeroCasa + ","
                                + cl.pEstado + ")";
                            BD.actualizarBD(consultaSQL);
                            //cargarLista("Clientes");
                            Habilitar(false);
                            nuevo = false;
                        }
                        else
                        {
                            MessageBox.Show("Ya existe un cliente con esta ID...");
                            txtNroCliente.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Solo se puede agregar " + tam + " clientes...");
                    }
                }
                else
                {
                    consultaSQL = "UPDATE Clientes SET Apellido='" + cl.pApellido
                        + "',Nombre='" + cl.pNombre
                        + "',TipoDoc=" + cl.pTipoDocumento
                        + ",Documento=" + cl.pDocumento
                        + ",FechaNac='" + cl.pFechaNac
                        + "',Telefono=" + cl.pTelefono
                        + ",Direccion='" + cl.pDireccion
                        + "',Numero=" + cl.pNumeroCasa
                        + ",IdLocalidad=" + cl.pLocalidad
                        + ",Estado=" + cl.pEstado
                        + " WHERE Id=" + cl.pIdCliente;
                    BD.actualizarBD(consultaSQL);
                    //cargarLista("Clientes");
                    Habilitar(false);
                     
                }
            }
            limpiar();
            Mostrar("Exec prCliente", dtgCliente);
            Mostrar("Exec prClienteBaja", dtgClientesBajas);
            btnAlta.Enabled = false;
            btnBaja.Enabled = false;
        }

        private void txtClienteBaja_TextChanged(object sender, EventArgs e)
        {
            string sql = "Select * from Clientes " +
                "where Estado = 0 and Apellido like '" + txtClienteBaja.Text + "%'";
            Buscar(sql, dtgClientesBajas);
        }

        private void OcultarColumnas()
        {
            dtgCliente.Columns[1].Visible = false;
            dtgCliente.Columns[4].Visible = false;
            dtgCliente.Columns[9].Visible = false;
            dtgCliente.Columns[13].Visible = false;

            dtgClientesBajas.Columns[0].Visible = false;
            dtgClientesBajas.Columns[3].Visible = false;
            dtgClientesBajas.Columns[8].Visible = false;
            dtgClientesBajas.Columns[12].Visible = false;
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}