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
    public partial class frmAdministracion : Form
    {
        bool nuevo;
        const int tam = 10;
        Veterinario[] Ve = new Veterinario[tam];
        int c;

        AccesoDato BD = new AccesoDato(@"Data Source=DESKTOP-JEV49B0\SQLEXPRESS;Initial Catalog=Veterinaria;Integrated Security=True");
        public frmAdministracion()
        {
            InitializeComponent();
        }

        private void frmAdministracion_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < tam; i++)
            {
                Ve[i] = null;
                nuevo = false;
           
                Habilitar(false);
                
            }
            cargarLista("Veterinarios");
        }
        private void Habilitar(bool x)
        {
            txtApellido.Enabled = x;
            txtMatricula.Enabled = x;
            txtNombre.Enabled = x;          
            btnCargar.Enabled = x;           
            btnCancelar.Enabled = x;
            btnNuevo.Enabled = !x;
            btnNuevo.Enabled = !x;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Habilitar(true);
            nuevo = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Habilitar(false);
            nuevo = false;
        }
        public void cargarLista(string tabla)
        {
            lstIzquierda.Items.Clear();
            c = 0;
            BD.leerTabla(tabla);

            while (BD.pLector.Read())
            {
                Veterinario v = new Veterinario();
                if (!BD.pLector.IsDBNull(0))
                    v.pIdMatricula = BD.pLector.GetInt32(0);
                if (!BD.pLector.IsDBNull(1))
                    v.pApellido = BD.pLector.GetString(1);
                if (!BD.pLector.IsDBNull(2))
                    v.pNombre = BD.pLector.GetString(2);
                if (!BD.pLector.IsDBNull(3))
                    v.pPassword = BD.pLector.GetString(3);
                if (!BD.pLector.IsDBNull(4))
                    v.pEstado = Convert.ToInt16(BD.pLector.GetInt32(4));
                Ve[c] = v;
                c++;

            }
            BD.pLector.Close();
            BD.Desconectar();
            for (int i = 0; i < c; i++)
            {
                if (Ve[i].pEstado == 1)
                {
                    lstIzquierda.Items.Add("[" + Ve[i].pIdMatricula + "] " + Ve[i].pApellido + " " + Ve[i].pNombre);
                }
                if(Ve[i].pEstado == 0)
                {
                    lstDerecha.Items.Add("[" + Ve[i].pIdMatricula + "] " + Ve[i].pApellido + " " + Ve[i].pNombre);
                }
            }

        }
        private bool validarCampos()
        {
            bool ok = true;
            if (txtMatricula.Text == "")
            {
                MessageBox.Show("Debe ingresar una matricula...");
                txtMatricula.Focus();
                ok = false;
                errorVeterinarios.SetError(txtMatricula, "Ingrese un Tipo");
                return false;
            }
            if (txtApellido.Text == "")
            {
                MessageBox.Show("Debe ingresar una descripcion...");
                txtApellido.Focus();
                ok = false;
                errorVeterinarios.SetError(txtApellido, "Ingrese un apellido");
                return false;
            }
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Debe ingresar el Apellido...");
                txtNombre.Focus();
                ok = false;
                errorVeterinarios.SetError(txtNombre, "Ingrese un nombre");
                return false;
            }
            eliminarMensajeError();
            return true;

        }
        private void eliminarMensajeError()
        {
            errorVeterinarios.SetError(txtMatricula, "");
            errorVeterinarios.SetError(txtNombre, "");
            errorVeterinarios.SetError(txtApellido, "");
        }
        private void limpiar()
        {
            txtMatricula.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
        }
        private bool validarPK(int pk)
        {
            for (int i = 0; i < c; i++)
            {
                if (Ve[i].pIdMatricula == pk)
                {
                    return true;
                }
            }
            return false;
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                string consultaSQL;
                Veterinario v = new Veterinario();
                v.pIdMatricula = Convert.ToInt32(txtMatricula.Text);
                v.pApellido = txtApellido.Text;
                v.pNombre = txtNombre.Text;
               //v.pPassword = Convert.ToInt32(txtpassword.Text);


                if (nuevo)
                {                
                    {
                        if (!validarPK(v.pIdMatricula))
                        {
                            consultaSQL = "INSERT INTO Veterinarios (Matricula, Apellido, Nombre," +
                                " password, Estado) Values ("
                                + v.pIdMatricula + ",'"
                                + v.pApellido + "','"
                                + v.pNombre + "',"
                                + v.pPassword + ","
                                + v.pEstado + ")";
                            BD.actualizarBD(consultaSQL);
                            
                            Habilitar(false);
                            nuevo = false;
                        }
                        else
                        {
                            MessageBox.Show("Ya existe un veterinario con esta matricula...");
                            txtMatricula.Focus();
                        }
                    }
                   
                   
                }
                else
                {
                    consultaSQL = "UPDATE Veterinarios SET Apellido='" + v.pApellido
                        + "',Nombre='" + v.pNombre
                        + "',TipoDoc=" + v.pTipoDocumento                       
                        + ",Estado=" + v.pEstado
                        + " WHERE Id=" + v.pIdMatricula;
                    BD.actualizarBD(consultaSQL);               
                    Habilitar(false);

                }
            }
            limpiar();
            
            btnAlta.Enabled = false;
            btnBaja.Enabled = false;
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            int pos = lstDerecha.SelectedIndex;
            lstIzquierda.Items.Add(lstDerecha.SelectedItem);
            lstDerecha.Items.Remove(lstDerecha.SelectedItem);
            BD.actualizarBD("exec prActivarVeterinario @cod=" + Ve[pos].pIdMatricula.ToString());

        }

        private void btnAlt_Click(object sender, EventArgs e)
        {
            Habilitar(true);
        }

        private void btnBaj_Click(object sender, EventArgs e)
        {
            Habilitar(true);
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            int pos = lstIzquierda.SelectedIndex;
            lstDerecha.Items.Add(lstIzquierda.SelectedItem);
            lstIzquierda.Items.Remove(lstIzquierda.SelectedItem);
            BD.actualizarBD("exec prDesactivarVeterinario @cod=" + Ve[pos].pIdMatricula.ToString());

        }

        private void actualizarCampos(int pos)
        {
            if (pos != -1)
            {
                txtMatricula.Text = Ve[pos].pIdMatricula.ToString();
                txtNombre.Text = Ve[pos].pNombre.ToString();
                txtApellido.Text = Ve[pos].pApellido.ToString();
            }
            else
            {
                txtMatricula.Text = "";
                txtNombre.Text = "";
            }
        }

        private void lstIzquierda_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualizarCampos(lstIzquierda.SelectedIndex);
        }

        private void lstDerecha_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualizarCampos(lstDerecha.SelectedIndex);
        }
    }
    }
