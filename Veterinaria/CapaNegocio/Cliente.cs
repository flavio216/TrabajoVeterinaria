using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria
{
    public class Clientes:Persona
    {
        private int idCliente;
     
        //private DateTime fechanac;
        //private int id_mascota;
        //private string direccion;
        //private int numero;
        private int estado;
        public int pIdCliente
        {
            set { idCliente = value; }
            get { return idCliente; }
        }

        public int pEstado { get => Estado; set => Estado = value; }
        public int Estado { get => estado; set => estado = value; }

        public Clientes():base()
        {
            idCliente = 0;
            Estado = 0;
        }
    }
}
