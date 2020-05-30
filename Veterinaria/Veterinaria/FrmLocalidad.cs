using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;


namespace Veterinaria
{
    public partial class FrmLocalidad : Form
    {
        AccesoDato BDL = new AccesoDato(@"Data Source=DESKTOP-JEV49B0\SQLEXPRESS;Initial Catalog=Veterinaria;Integrated Security=True");
        int c;
        const int tam = 10;
        Localidad[] L = new Localidad[tam];
        bool nuevo;

        public FrmLocalidad()
        {
            InitializeComponent();
            for (int i = 0; i < tam; i++)
            {
                L[i] = null;
            }
            cargarLista("Localidades");
        }

        private void FrmLocalidad_Load(object sender, EventArgs e)
        {
            Habilitar(false);
        }

        private void cargarLista(string tabla)
        {
            lstLocalidad.Items.Clear();
            c = 0;
            BDL.leerTabla(tabla);

            while (BDL.pLector.Read())
            {
                Localidad l = new Localidad();
                if (!BDL.pLector.IsDBNull(0))
                    l.pIdLocalidad = BDL.pLector.GetInt32(0);
                if (!BDL.pLector.IsDBNull(1))
                    l.pLocalidad = BDL.pLector.GetString(1);
                L[c] = l;
                c++;

            }
            BDL.pLector.Close();
            BDL.Desconectar();
            for (int i = 0; i < c; i++)
            {
                lstLocalidad.Items.Add("[" + L[i].pIdLocalidad + "] - " + L[i].pLocalidad);
            }
            if (lstLocalidad.Items.Count == 0)
            {
                btnBorrar.Enabled = false;
            }
            lstLocalidad.SelectedIndex = -1;

        }

        private void actualizarCampos(int pos)
        {
            if (pos != -1)
            {
                txtCodigo.Text = L[pos].pIdLocalidad.ToString();
                txtNombre.Text = L[pos].pLocalidad.ToString();
            }
            else
            {
                txtCodigo.Text = "";
                txtNombre.Text = "";
            }
        }

        private bool validarCampos()
        {
            bool ok = true;
            if (txtCodigo.Text == "")
            {
                MessageBox.Show("Debe ingresar un codigo...");
                txtCodigo.Focus();
                ok = false;
                errorLocalidad.SetError(txtCodigo, "Ingrese un codigo");
                return false;
            }
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Debe ingresar un nombre...");
                txtNombre.Focus();
                ok = false;
                errorLocalidad.SetError(txtNombre, "Ingrese un nombre");
                return false;
            }
            eliminarMensajeError();
            return true;

        }
        private void eliminarMensajeError()
        {
            errorLocalidad.SetError(txtCodigo, "");
            errorLocalidad.SetError(txtNombre, "");


        }

        private void Habilitar(bool x)
        {
            txtCodigo.Enabled = x;
            txtNombre.Enabled = x;
            btnCargar.Enabled = x;
            btnNuevo.Enabled = !x;
            lstLocalidad.Enabled = !x;
            btnBorrar.Enabled = !x;
            btnEditar.Enabled = !x;
            btnNuevo.Enabled = !x;
            btnCancelar.Enabled = x;
        }

        private void Limpiar()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
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

        private bool validarPK(int pk)
        {
            for (int i = 0; i < c; i++)
            {
                if (L[i].pIdLocalidad == pk)
                {
                    return true;
                }
            }
            return false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            nuevo = true;
            Habilitar(true);
            Limpiar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            nuevo = false;
            Habilitar(true);
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                string consultaSQL;
                Localidad l = new Localidad();
                l.pIdLocalidad = Convert.ToInt32(txtCodigo.Text);
                l.pLocalidad = Convert.ToString(txtNombre.Text);
                if (arregloCompleto())
                {
                    if (nuevo)
                    {
                        if (!validarPK(l.pIdLocalidad))
                        {
                            consultaSQL = "INSERT INTO Localidades (Id, Localidad) Values ("
                                + l.pIdLocalidad + ",'"
                                + l.pLocalidad + "')";
                            BDL.actualizarBD(consultaSQL);
                            cargarLista("Localidades");
                            Habilitar(false);
                            nuevo = false;
                        }
                        else
                        {
                            MessageBox.Show("Ya existe una localidad con este codigo...");
                            txtCodigo.Focus();
                        }
                    }
                    else
                    {
                        consultaSQL = "UPDATE Localidades SET Localidad='" + l.pLocalidad + "' WHERE Id=" + l.pIdLocalidad;
                        BDL.actualizarBD(consultaSQL);
                        cargarLista("Localidades");
                        Habilitar(false);
                    }
                }
                else
                {
                    MessageBox.Show("Solo se pueden agregar " + tam + " tipo de productos");

                }
            }
            cargarLista("Localidades");
            Habilitar(false);
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            FrmClientes frm = new FrmClientes();
            if (frm.GuardarFK("Localidad", L[lstLocalidad.SelectedIndex].pIdLocalidad))
            {
                if (MessageBox.Show("Estas seguro que quieres borrar esta Localidad?", "Eliminando...", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    string consultaSQL = "DELETE FROM Localidades WHERE Id=" + L[lstLocalidad.SelectedIndex].pIdLocalidad;
                    BDL.actualizarBD(consultaSQL);
                    cargarLista("Localidades");
                    MessageBox.Show("Localidad borrada con exito...");

                }
            }
            else
            {
                MessageBox.Show("No puede borrar esta localidad si hay clientes registrados con el mismo...");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Habilitar(false);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lstLocalidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualizarCampos(lstLocalidad.SelectedIndex);
        }

        
    }
}
