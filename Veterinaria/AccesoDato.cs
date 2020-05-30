using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace Veterinaria
{
    class AccesoDato
    {
        private OleDbConnection conexion;
        private OleDbCommand comando;
        private OleDbDataReader lector;
        private string cadenaConexion;
        
        public OleDbDataReader pLector
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
            conexion = new OleDbConnection();
            comando = new OleDbCommand();
            lector = null;
            cadenaConexion = "";
        }

        public AccesoDato(string cadenaConexion)
        {
            conexion = new OleDbConnection();
            comando = new OleDbCommand();
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
