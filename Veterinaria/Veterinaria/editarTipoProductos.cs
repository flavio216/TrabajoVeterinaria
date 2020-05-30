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
    public partial class frmEditarTipoProductos : Form
    {
        AccesoDato DBTP = new AccesoDato(@"Data Source=DESKTOP-JEV49B0\SQLEXPRESS;Initial Catalog=Veterinaria;Integrated Security=True");
        int c;
        const int tam = 10;
        TipoProducto[] TP = new TipoProducto[tam];
        bool nuevo;

        public frmEditarTipoProductos()
        {
            InitializeComponent();
            for (int i = 0; i < tam; i++)
            {
                TP[i] = null;
            }
        }

        private void frmEditarTipoProductos_Load(object sender, EventArgs e)
        {
            cargarLista("Tipo_Producto");
            nuevo = false;
            Habilitar(false);
            c = 0;
            
        }

        private void cargarLista(string tabla)
        {
            lstTipoProductos.Items.Clear();
            c = 0;
            DBTP.leerTabla(tabla);
            
            while (DBTP.pLector.Read())
            {
                TipoProducto Tp = new TipoProducto();
                if (!DBTP.pLector.IsDBNull(0))
                    Tp.pId = DBTP.pLector.GetInt32(0);
                if (!DBTP.pLector.IsDBNull(1))
                    Tp.pTipo = DBTP.pLector.GetString(1);
                TP[c] = Tp;
                c++;

            }
            DBTP.pLector.Close();
            DBTP.Desconectar();
            for (int i = 0; i < c; i++)
            {
                lstTipoProductos.Items.Add("[" + TP[i].pId + "] - " + TP[i].pTipo);
            }
            if (lstTipoProductos.Items.Count == 0)
            {
                btnBorrar.Enabled = false;
            }
            lstTipoProductos.SelectedIndex = -1;
            
        }

        public void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void actualizarCampos(int pos)
        {
            if (pos != -1)
            {
                txtCodigoProductos.Text = TP[pos].pId.ToString();
                txtNombreProductos.Text = TP[pos].pTipo.ToString();
            }
            else
            {
                txtCodigoProductos.Text = "";
                txtNombreProductos.Text = "";
            }
        }

        private void lstTipoProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualizarCampos(lstTipoProductos.SelectedIndex);
        }

        private bool validarPK(int pk)
        {
            for (int i = 0; i < c; i++)
            {
                if (TP[i].pId == pk)
                {
                    return true;
                }
            }
            return false;
        }

        private bool validarCampos()
        {
            bool ok = true;
            if (txtCodigoProductos.Text == "")
            {             
                MessageBox.Show("Debe ingresar un codigo...");
                txtCodigoProductos.Focus();
                ok = false;
                errorTipo.SetError(txtCodigoProductos, "Ingrese un Tipo");
                return false;
            }
            if (txtNombreProductos.Text == "")
            {
                MessageBox.Show("Debe ingresar un nombre...");
                txtNombreProductos.Focus();
                ok = false;
                errorTipo.SetError(txtNombreProductos, "Ingrese un Tipo");
                return false;
            }
            else
            {
                
                eliminarMensajeError();
            }
            return true;
           
        }
        private void eliminarMensajeError()
        {
            errorTipo.SetError(txtCodigoProductos, "");
            errorTipo.SetError(txtNombreProductos, "");
           

        }


        private void btnNuevoProductos_Click(object sender, EventArgs e)
        {
            nuevo = true;
            Habilitar(true);
            Limpiar();
        }

        private void Habilitar(bool x)
        {
            txtCodigoProductos.Enabled = x;
            txtNombreProductos.Enabled = x;
            btnCargar.Enabled = x;
            btnNuevoProductos.Enabled = !x;
            lstTipoProductos.Enabled = !x;
            btnBorrar.Enabled = !x;
            btnEditar.Enabled = !x;
            btnNuevoProductos.Enabled = !x;
            btnCancelar.Enabled = x;
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                string consultaSQL;
                TipoProducto p = new TipoProducto();
                p.pId = Convert.ToInt32(txtCodigoProductos.Text);
                p.pTipo = Convert.ToString(txtNombreProductos.Text);
                if (arregloCompleto())
                {
                    if (nuevo)
                    {
                        if (!validarPK(TP[c].pId))
                        {
                            consultaSQL = "INSERT INTO Tipo_Producto (Id, Tipo) Values ("
                                + p.pId + ",'"
                                + p.pTipo + "')";
                            DBTP.actualizarBD(consultaSQL);
                            cargarLista("Tipo_Producto");
                            Habilitar(false);
                            nuevo = false;
                        }
                        else
                        {
                            MessageBox.Show("Ya existe un producto con este codigo...");
                            txtCodigoProductos.Focus();
                        }
                    }
                    else
                    {
                        consultaSQL = "UPDATE Tipo_Producto SET Tipo='" + p.pTipo + "' WHERE Id=" + p.pId;
                        DBTP.actualizarBD(consultaSQL);
                        cargarLista("Tipo_Producto");
                        Habilitar(false);
                    }
                }
                else
                {
                    MessageBox.Show("Solo se pueden agregar " + tam + " tipo de productos");
                    
                }
            }
            cargarLista("Tipo_Producto");
            Habilitar(false);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            nuevo = false;
            Habilitar(true);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Habilitar(false);
        }

        private void Limpiar()
        {
            txtCodigoProductos.Text = "";
            txtNombreProductos.Text = "";
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {

         

        }

        private void btnBorrar_Click_1(object sender, EventArgs e)
        {
            frmProducto frm = new frmProducto();
            if (frm.GuardarFK(TP[lstTipoProductos.SelectedIndex].pId))
            {
                if (MessageBox.Show("Estas seguro que quieres borrar este tipo de producto?", "Eliminando...", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    string consultaSQL = "DELETE FROM Tipo_Producto WHERE Id=" + TP[lstTipoProductos.SelectedIndex].pId;
                    DBTP.actualizarBD(consultaSQL);
                    cargarLista("Tipo_Producto");
                    MessageBox.Show("Tipo de producto borrado con exito...");
                    Limpiar();
                }
            }
            else
            {
                MessageBox.Show("No puede borrar este tipo de producto por que esta siendo utilizado por algun producto...", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private bool arregloCompleto()
        {
            if(c != tam)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        
    }
}   
