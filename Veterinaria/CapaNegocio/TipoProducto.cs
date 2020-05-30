using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria
{
   public class TipoProducto
    {
        private int id;
        private string tipo;
        public int pId
        {
            set { id = value; }
            get { return id; }
        }
        public string pTipo
        {
            set { tipo = value; }
            get { return tipo; }
        }

        public TipoProducto()
        {
            id = 0;
            tipo = "";
        }
        public TipoProducto(int id, string tipo)
        {
            this.id = id;
            this.tipo = tipo;
        }
    }
}
