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
    public partial class frmConsultas : Form
    {
        bool nuevo;
        Consulta[] Co = new Consulta[tam];
        int c;
        const int tam = 200;

        AccesoDato BD = new AccesoDato(@"Data Source=DESKTOP-JEV49B0\SQLEXPRESS;Initial Catalog=Veterinaria;Integrated Security=True");
        public frmConsultas()
        {
            InitializeComponent();
            for (int i = 0; i < tam; i++)
            {
                Co[i] = null;
            }
            nuevo = false;
           
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Habilitar(true);
            limpiar();
            nuevo = true;
            lblConsulta.Visible = false;
            txtNroConsulta.Visible = false;
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

        private void frmConsultas_Load(object sender, EventArgs e)
        {
            Habilitar(false);            
            lblCantidadRegistros.Text = "Cantidad de Registros: " + dtgvConsulta.Rows.Count;
            cargarCombo(cmbVeterinario,"Veterinarios");
            Mostrar("Exec prConsultas", dtgvConsulta);
            lblCantidadRegistros.Text = "Cantidad de Registros: " + dtgvConsulta.Rows.Count;
            OcultarColumnas();
            limpiar();
        }
        private bool validarCampos()
        {
            bool ok = true;
            
            if (txtConsulta.Text == "")
            {
                MessageBox.Show("Debe ingresar una consulta...");
                txtConsulta.Focus();
                ok = false;
                errorConsulta.SetError(txtConsulta, "Ingrese una consulta");
                return false;
            }
            if (txtPrecio.Text == "")
            {
                MessageBox.Show("Debe ingresar un precio...");
                txtPrecio.Focus();
                ok = false;
                errorConsulta.SetError(txtPrecio, "Ingrese un Precio");
                return false;
            }
            if(cmbVeterinario.SelectedIndex == -1)
            {
                MessageBox.Show("Debe ingresar el veterinario...");
                cmbVeterinario.Focus();
                ok = false;
                errorConsulta.SetError(cmbVeterinario, "Ingrese un veterinario");
                return false;
            }          
            eliminarMensajeError();
            return true;
        }
        private void eliminarMensajeError()
        {
            errorConsulta.SetError(txtNroConsulta, "");
            errorConsulta.SetError(txtConsulta, "");
            errorConsulta.SetError(txtPrecio, "");
            errorConsulta.SetError(cmbVeterinario, "");

        }
        private void limpiar()
        {
            txtNroConsulta.Text = "";
            txtConsulta.Text = "";
            txtPrecio.Text = "";
            cmbVeterinario.SelectedIndex = -1;
            
        }
        private void Habilitar(bool x)
        {
            txtNroConsulta.Enabled = false;
            txtConsulta.Enabled = x;
            txtPrecio.Enabled = x;
            dtgvConsulta.Enabled = x;
            cmbVeterinario.Enabled = x;
            txtNroConsulta.Enabled = false;
            btnNuevo.Enabled = !x;
            btnCargar.Enabled = x;
            
        }
       
        private void Buscar(string sql, DataGridView dtgv)
        {
            DataTable dt = new DataTable();
            dt = BD.buscarTabla(sql);
            dtgv.DataSource = dt;
            lblCantidadRegistros.Text = "Cantidad de Registros: " + dtgv.Rows.Count;
            
        }

        private void txtBuscarConsulta_TextChanged(object sender, EventArgs e)
        {
            string sql = "Select * from Consultas " +
                 "where consulta = '" + txtBuscarConsulta.Text + "'";
            Buscar(sql, dtgvConsulta);


        }
       
        private void Mostrar(string sql, DataGridView dtgv)
        {
            DataTable dt = new DataTable();
            dt = BD.buscarTabla(sql);
            dtgv.DataSource = dt;
        }
        private void btnCargarProductos_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                string consultaSQL;
                Consulta cl = new Consulta();
                cl.pConsulta = txtConsulta.Text;
                cl.pPrecio = Convert.ToDouble(txtPrecio.Text);
                cl.pIdVeterinario = Convert.ToInt32(cmbVeterinario.SelectedValue);

                if (nuevo)
                {
                    {
                        consultaSQL = "INSERT INTO Consultas (consulta, precio, IdVeterinario)" +
                            " Values ('"
                            + cl.pConsulta + "',"
                            + cl.pPrecio + ","
                            + cl.pIdVeterinario + ")";
                        BD.actualizarBD(consultaSQL);
                        //cargarLista("Clientes");
                        Habilitar(false);
                        nuevo = false;
                    }
                        
                }               
                else
                {
                    consultaSQL = "UPDATE Consultas SET consulta='" + cl.pConsulta                       
                        + "',precio=" + cl.pPrecio
                        + ",IdVeterinario=" + cl.pIdVeterinario                   
                        + " WHERE Id=" + Convert.ToInt32(txtNroConsulta.Text);
                    BD.actualizarBD(consultaSQL);
                    //cargarLista("Clientes");
                    Habilitar(false);

                }
            }
            limpiar();
            //cargarLista("Consultas");
            Mostrar("exec prConsultas", dtgvConsulta);


        }

        private void dtgvConsulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNroConsulta.Text = Convert.ToString(dtgvConsulta.CurrentRow.Cells[0].Value);
            txtConsulta.Text = Convert.ToString(dtgvConsulta.CurrentRow.Cells[1].Value);
            txtPrecio.Text = Convert.ToString(dtgvConsulta.CurrentRow.Cells[2].Value);
            cmbVeterinario.SelectedValue = Convert.ToInt32(dtgvConsulta.CurrentRow.Cells[3].Value);
            tabControl1.SelectedIndex = 0;
            btnCargar.Enabled = true;
            //txtNroConsulta.Visible = true;
            //lblConsulta.Visible = true;
            Habilitar(true);
            lblConsulta.Visible = true;
            txtNroConsulta.Visible = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Habilitar(false);
            nuevo = false;
        }

        private void OcultarColumnas()
        {
            dtgvConsulta.Columns[0].Visible = false;

        }

    }
}
