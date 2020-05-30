using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria
{
    class Vendedor
    {
        private int idVendedor;
        public int pIdVendedor
        {
            set { idVendedor = value; }
            get { return idVendedor; }
        }

        public Vendedor() : base()
        {
            idVendedor = 0;
        }
    }
}
