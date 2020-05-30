using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria
{
    class Mascota
    {
        private string nombre;
        private int tipo;
        private int raza;
        private int duenio;
        public string pNombre
        {
            set { nombre = value; }
            get { return nombre; }
        }
        public int pTipo
        {
            set { tipo = value; }
            get { return tipo; }
        }
        public int pRaza
        {
            set { raza = value;}
            get { return raza; }
        }
        public int pDuenio
        {
            set { duenio = value; }
            get { return duenio; }
        }

    }
}
