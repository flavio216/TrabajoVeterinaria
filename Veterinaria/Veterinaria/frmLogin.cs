using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Veterinaria
{
    public partial class Login : Form
    {
        AccesoDato BD = new AccesoDato(@"Data Source=DESKTOP-JEV49B0\SQLEXPRESS;Initial Catalog=Veterinaria;Integrated Security=True");
        const int tam = 200;
        Veterinario[] V = new Veterinario[tam];
        int c;
        string login = "SELECT Matricula, password FROM Veterinarios WHERE Matricula=@user AND password=@pass";
        public Login()
        {
            InitializeComponent();
            for (int i = 0; i < tam; i++)
            {
                V[i] = null;
            }
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuario")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.LightGray;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Usuario";
                txtUsuario.ForeColor = Color.DimGray;
            }

        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "Contraseña")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.LightGray;
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "Contraseña";
                txtContraseña.ForeColor = Color.DimGray;
                txtContraseña.UseSystemPasswordChar = false;
            }

        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            cargarLista("Veterinarios");
        }
        private void cargarLista(string tabla)
            {
            
                c = 0;
                BD.leerTabla(tabla);

                while (BD.pLector.Read())
                {
                    Veterinario v = new Veterinario();
                    if (!BD.pLector.IsDBNull(0))
                        v.pIdMatricula = BD.pLector.GetInt32(0);
                        v.pApellido = BD.pLector.GetString(1);
                        v.pNombre = BD.pLector.GetString(2);
                if (!BD.pLector.IsDBNull(3))
                        v.pPassword = BD.pLector.GetString(3);
              

                    V[c] = v;
                    c++;

                }
                BD.pLector.Close();
                BD.Desconectar();
            cargarLista("Veterinarios");
            Mostrar(login);

        }
        private void Mostrar(string sql)
        {
            DataTable dt = new DataTable();
            dt = BD.buscarTabla(sql);
            
        }
      
        
    }



    //    public void logins()
    //    {
    //        try
    //        {
    //            string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
    //            using (SqlConnection conexion = new SqlConnection(cnn))
    //            {
    //                conexion.Open();
    //                using (SqlCommand cmd = new SqlCommand("SELECT Matricula, password FROM Veterinarios WHERE Matricula='" + txtUsuario.Text + "' AND password='" + txtContraseña.Text + "'", conexion))
    //                {
    //                    SqlDataReader dr = cmd.ExecuteReader();
    //                    if (dr.Read())
    //                    {
    //                        MessageBox.Show("Login exitoso.");
    //                    }
    //                    else
    //                    {
    //                        MessageBox.Show("Datos incorrectos.");
    //                    }
    //                }
    //            }
    //        }
    //        catch (Exception ex)
    //        {
    //            MessageBox.Show(ex.ToString());
    //        }
    //    }

    //    private void btnIngresar_Click(object sender, EventArgs e)
    //    {
    //        logins();
    //    }
    //}

}
