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
    public partial class frmMascotas : Form
    {
        bool nuevo;
        const int tam = 300;
        int c;
        AccesoDato BD = new AccesoDato(@"Data Source=DESKTOP-JEV49B0\SQLEXPRESS;Initial Catalog=Veterinaria;Integrated Security=True");
        Mascota[] M = new Mascota[tam];
        public frmMascotas()
        {
            InitializeComponent();
            for (int i = 0; i < tam; i++)
            {
                M[i] = null;
            }
            Mostrar("select Id, Apellido +' '+ Nombre as Cliente from Clientes", dtgBuscarCliente);
            nuevo = false;
            btnAlta.Enabled = false;
            btnBaja.Enabled = false;
            
        }
        private void frmMascotas_Load(object sender, EventArgs e)
        {
            Mostrar("Exec prMascota", dtgMascotas);
            Mostrar("Exec prMascotaBaja", dtgMascotasBajas);
            Mostrar("select Id, Apellido +' '+ Nombre as Cliente from Clientes", dtgBuscarCliente);

            cargarCombo(cmbRaza, "Razas");
            cargarCombo(cmbEspecie, "TipoMascota");
            Habilitar(false);
            OcultarColumnas();
            lblCantidad.Text = "Cantidad de Registros: " + dtgMascotas.Rows.Count;
            lblCantidadRegistrosBaja.Text = "Cantidad de Registros: " + dtgMascotasBajas.Rows.Count;
            dtgBuscarCliente.Columns[0].Width = 30;
            dtgBuscarCliente.Columns[1].Width = 350;
            limpiar();
        }

        private void Habilitar(bool x)
        {
            txtNombre.Enabled = x;
            dtpFechaNac.Enabled = x;
            btnSalir.Enabled = x;
            dtgBuscarCliente.Enabled = x;
            cmbEspecie.Enabled = x;
            cmbRaza.Enabled = x;
            btnCargar.Enabled = x;
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

        private void btnCargar_Click(object sender, EventArgs e)
        {
            

            string consultaSQL;
            if(validarCampos())
            {
                int cod;
                Mascota m = new Mascota();
                //m.pId = Convert.ToInt32(dtgMascotas.CurrentRow.Cells[0].Value);
                m.pNombre = txtNombre.Text;
                m.pFechaNac = dtpFechaNac.Value;
                m.pTipo = Convert.ToInt32(cmbEspecie.SelectedValue);
                m.pRaza = Convert.ToInt32(cmbRaza.SelectedValue);
                m.pEstado = 1;
                
                m.pidCliente = Convert.ToInt32(dtgBuscarCliente.CurrentRow.Cells[0].Value);
                if(rbtMasculino.Checked)
                {
                    m.pSexo = 1;
                }
                else
                {
                    m.pSexo = 2;
                }
                if (nuevo)
                {
                    if (arregloCompleto(c, tam))
                    {
                        consultaSQL = "INSERT INTO Mascotas (Nombre, FechaNac," +
                               " IdTipo, IdRaza, Estado, IdCliente, IdSexo) Values ('"
                               + m.pNombre + "','"
                               + m.pFechaNac + "',"
                               + m.pTipo + ","
                               + m.pRaza + ","                              
                               + m.pEstado + ","
                               + m.pidCliente + ","
                               + m.pSexo + ")";                              
                        BD.actualizarBD(consultaSQL);
                        //cargarLista("Clientes");
                        Habilitar(false);
                        nuevo = false;
                    }


                    else
                    {
                        MessageBox.Show("Solo se puede agregar " + tam + " clientes...");
                    }
                }
                else
                {
                    consultaSQL = "UPDATE Mascotas SET Nombre='" + m.pNombre
                        + "',FechaNac='" + m.pFechaNac
                        + "',IdTipo=" + m.pTipo
                        + ",IdRaza=" + m.pRaza
                        + ",idCliente=" + m.pidCliente
                        + ",Estado=" + m.pEstado
                        + ",IdSexo=" + m.pSexo                        
                        + " WHERE Id=" + Convert.ToInt32(dtgMascotas.CurrentRow.Cells[0].Value);
                    BD.actualizarBD(consultaSQL);
                    //cargarLista("Clientes");
                    Habilitar(false);
                }
                

            }
            
            Mostrar("Exec prMascota", dtgMascotas);
            Mostrar("Exec prMascotaBaja", dtgMascotasBajas);
            Mostrar("select Id, Apellido +' '+ Nombre as Clientes from Clientes", dtgBuscarCliente);
            dtgBuscarCliente.Columns[0].Width = 30;
            dtgBuscarCliente.Columns[1].Width = 350;
            OcultarColumnas();
            btnAlta.Enabled = false;
            btnBaja.Enabled = false;
            lblCantidad.Text = "Cantidad de Registros: " + dtgMascotas.Rows.Count;
            lblCantidadRegistrosBaja.Text = "Cantidad de Registros: " + dtgMascotasBajas.Rows.Count;
            limpiar();
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

        private void cargarCombo(ComboBox combo, string tabla)
        {
            DataTable dt = new DataTable();
            dt = BD.consultarTabla(tabla);
            combo.DataSource = dt;
            combo.ValueMember = dt.Columns[0].ColumnName;
            combo.DisplayMember = dt.Columns[1].ColumnName;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public void cargarLista(string tabla)
        {
            c = 0;
            BD.leerTabla(tabla);

            while (BD.pLector.Read())
            {
                Mascota m = new Mascota();
                if (!BD.pLector.IsDBNull(0))
                    m.pId = BD.pLector.GetInt32(0);
                if (!BD.pLector.IsDBNull(1))
                    m.pNombre = BD.pLector.GetString(1);
                if (!BD.pLector.IsDBNull(2))
                    m.pFechaNac = BD.pLector.GetDateTime(2);
                if (!BD.pLector.IsDBNull(3))
                    m.pTipo = BD.pLector.GetInt32(3);
                if (!BD.pLector.IsDBNull(4))
                    m.pRaza = BD.pLector.GetInt32(4);
                if (!BD.pLector.IsDBNull(7))
                    m.pidCliente = BD.pLector.GetInt32(7);
                M[c] = m;
                c++;

            }
            BD.pLector.Close();
            BD.Desconectar();

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

            if (txtNombre.Text == "")
            {
                MessageBox.Show("Debe ingresar una nombre...");
                txtNombre.Focus();
                ok = false;
                errorMascota.SetError(txtNombre, "Ingrese un Nombre");
                return false;
            }
            if (cmbEspecie.SelectedIndex == -1)
            {
                MessageBox.Show("Debe ingresar una especie...");
                cmbEspecie.Focus();
                ok = false;
                errorMascota.SetError(cmbEspecie, "Ingrese una direccion");
                return false;
            }
            if (cmbRaza.SelectedIndex == -1)
            {
                MessageBox.Show("Debe ingresar la raza...");
                cmbRaza.Focus();
                ok = false;
                errorMascota.SetError(cmbRaza, "Ingrese un numero");
                return false;
            }
            if (dtgBuscarCliente.CurrentRow.Selected == false)
            {
                MessageBox.Show("Debe seleccionar un cliente...");
                cmbRaza.Focus();
                ok = false;
                errorMascota.SetError(cmbRaza, "Elija un cliente");
                return false;
            }
            eliminarMensajeError();
            return true;
        }
        private void eliminarMensajeError()
        {
            errorMascota.SetError(txtNombre, "");
            errorMascota.SetError(cmbEspecie, "");
            errorMascota.SetError(cmbRaza, "");
            errorMascota.SetError(dtpFechaNac, "");
        }

        private void limpiar()
        {
            txtNombre.Text = "";
            cmbRaza.SelectedIndex = -1;
            cmbEspecie.SelectedIndex = -1;
            dtpFechaNac.Value = DateTime.Today;
            if (txtCliente.Text == "")
            {
                dtgBuscarCliente.DataSource = null;
            }
            rbtHembra.Checked = false;
            rbtMasculino.Checked = false;
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

        private void OcultarColumnas()
        {
            
            dtgMascotas.Columns[0].Visible = false;
            dtgMascotas.Columns[4].Visible = false;
            dtgMascotas.Columns[6].Visible = false;
            dtgMascotas.Columns[8].Visible = false;
            dtgMascotas.Columns[10].Visible = false;

            dtgMascotasBajas.Columns[0].Visible = false;
            dtgMascotasBajas.Columns[4].Visible = false;
            dtgMascotasBajas.Columns[6].Visible = false;
            dtgMascotasBajas.Columns[8].Visible = false;
            dtgMascotasBajas.Columns[10].Visible = false;

        }

        

        private void btnAlta_Click(object sender, EventArgs e)
        {
            DialogResult Opcion;
            Opcion = MessageBox.Show("Realmente desea dar de alta a este animal?", "Veterinaria", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (Opcion == DialogResult.OK)
            {
                int Codigo;
                string sql;


                Codigo = Convert.ToInt32(dtgMascotasBajas.CurrentRow.Cells[0].Value);
                sql = "UPDATE Mascotas Set Estado = 1 WHERE Id=" + Codigo;
                BD.actualizarBD(sql);
                Mostrar("Exec prMascota", dtgMascotas);
                Mostrar("Exec prMascotaBaja", dtgMascotasBajas);

                tabControl1.SelectedIndex = 0;
                limpiar();
                lblCantidad.Text = "Cantidad de Registros: " + dtgMascotas.Rows.Count;
                lblCantidadRegistrosBaja.Text = "Cantidad de Registros: " + dtgMascotasBajas.Rows.Count;
            }
            
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            DialogResult Opcion;
            Opcion = MessageBox.Show("Realmente desea dar de baja al animal?", "Veterinaria", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (Opcion == DialogResult.OK)
            {
                int Codigo;
                string sql;
                Codigo = Convert.ToInt32(dtgMascotas.CurrentRow.Cells[0].Value);
                sql = "UPDATE Mascotas Set Estado = 0 WHERE Id=" + Codigo;
                BD.actualizarBD(sql);
                Mostrar("Exec prMascota", dtgMascotas);
                Mostrar("Exec prMascotaBaja", dtgMascotasBajas);
                tabControl1.SelectedIndex = 2;
                limpiar();
                lblCantidad.Text = "Cantidad de Registros: " + dtgMascotas.Rows.Count;
                lblCantidadRegistrosBaja.Text = "Cantidad de Registros: " + dtgMascotasBajas.Rows.Count;
            }
        }

        private void dtgMascotas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int cliente;
            string rbt;
            lblIdMascota.Text = "ID: "+Convert.ToString(dtgMascotas.CurrentRow.Cells[0].Value);
            txtNombre.Text = Convert.ToString(dtgMascotas.CurrentRow.Cells[1].Value);
            rbt = Convert.ToString(dtgMascotas.CurrentRow.Cells[2].Value);
            if(rbt == "Macho")
            {
                rbtMasculino.Checked = true;
            }
            else
            {
                rbtHembra.Checked = true;
            }
            dtpFechaNac.Value = Convert.ToDateTime(dtgMascotas.CurrentRow.Cells[3].Value);
            cmbEspecie.SelectedValue = Convert.ToInt32(dtgMascotas.CurrentRow.Cells[4].Value);
            cmbRaza.SelectedValue = Convert.ToInt32(dtgMascotas.CurrentRow.Cells[6].Value);
            cliente =  Convert.ToInt32(dtgMascotas.CurrentRow.Cells[8].Value);
            Buscar("exec PrBuscarClienteMascota @txt="+cliente, dtgBuscarCliente);
            //dtgBuscarCliente.Rows[0].Cells[0].Value
            tabControl1.SelectedIndex = 1;
            btnBaja.Enabled = true;
            btnAlta.Enabled = false;
            Habilitar(true);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            //string sql = "Select * from Mascotas " +
            //    "where Estado = 1 and Nombre like '" + txtBuscar.Text + "%'";
            Buscar("exec prBuscarMascota @txt='"+txtBuscar.Text+"'", dtgMascotas);
        }

        private void txtMascotaBaja_TextChanged(object sender, EventArgs e)
        {
            Buscar("exec prBuscarMascota @txt='" + txtMascotaBaja.Text + "'", dtgMascotasBajas);
        }

        private void dtgMascotasBajas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int cliente;
            string rbt;
            lblIdMascota.Text = "ID: " + Convert.ToString(dtgMascotasBajas.CurrentRow.Cells[0].Value);
            txtNombre.Text = Convert.ToString(dtgMascotasBajas.CurrentRow.Cells[1].Value);
            rbt = Convert.ToString(dtgMascotasBajas.CurrentRow.Cells[2].Value);
            if (rbt == "Macho")
            {
                rbtMasculino.Checked = true;
            }
            else
            {
                rbtHembra.Checked = true;
            }
            dtpFechaNac.Value = Convert.ToDateTime(dtgMascotasBajas.CurrentRow.Cells[3].Value);
            cliente = Convert.ToInt32(dtgMascotasBajas.CurrentRow.Cells[8].Value);
            Buscar("exec PrBuscarClienteMascota @txt=" + cliente, dtgBuscarCliente);
            cmbEspecie.SelectedValue = Convert.ToInt32(dtgMascotasBajas.CurrentRow.Cells[4].Value);
            cmbRaza.SelectedValue = Convert.ToInt32(dtgMascotasBajas.CurrentRow.Cells[6].Value);
            
            tabControl1.SelectedIndex = 1;
            btnBaja.Enabled = false;
            btnAlta.Enabled = true;
        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {
            string sql = "select Id, Apellido + ' ' + Nombre Clientes from Clientes " +
                "where Apellido like '" + txtCliente.Text + "%'";
            Buscar(sql, dtgBuscarCliente);
            dtgBuscarCliente.Columns[0].Width = 30;
            dtgBuscarCliente.Columns[1].Width = 370;
            if (txtCliente.Text == "")
            {
                dtgBuscarCliente.DataSource = null;
            }
        }

        private void dtgBuscarCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}

