using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Veterinaria
{
    public class AccesoDato
    {
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;
        private string cadenaConexion;
        
        public SqlDataReader pLector
        {
            set { lector = value; }
            get { return lector; }
        }

        public string pCadenaConexion
        {
            set { cadenaConexion = value; }
            get { return cadenaConexion; }
        }

        public AccesoDato()
        {
            conexion = new SqlConnection();
            comando = new SqlCommand();
            lector = null;
            cadenaConexion = "";
        }

        public AccesoDato(string cadenaConexion)
        {
            conexion = new SqlConnection();
            comando = new SqlCommand();
            lector = null;
            this.cadenaConexion = cadenaConexion;
        }

        public void Conectar()
        {
            conexion.ConnectionString = cadenaConexion;
            conexion.Open();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
        }

        public void Desconectar()
        {
            conexion.Close();
            conexion.Dispose();
        }

        public DataTable consultarTabla(string tabla)
        {
            DataTable dt = new DataTable();
            Conectar();
            comando.CommandText = "SELECT * FROM " + tabla + " ORDER BY 2";
            dt.Load(comando.ExecuteReader());
            Desconectar();
            return dt;
        }

        public DataTable buscarTabla(string sql)
        {
            DataTable dt = new DataTable();
            Conectar();
            comando.CommandText = sql;
            dt.Load(comando.ExecuteReader());
            Desconectar();
            return dt;
        }

        public void leerTabla(string tabla)
        {
            DataTable dt = new DataTable();
            Conectar();
            comando.CommandText = "SELECT * FROM " + tabla + " ORDER BY 1";
            lector = comando.ExecuteReader();
        }

        public void actualizarBD(string sql)
        {
            Conectar();
            comando.CommandText = sql;
            comando.ExecuteNonQuery();
            Desconectar();
        }


    }
}
