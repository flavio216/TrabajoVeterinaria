using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria
{
    public class Localidad
    {
        
        private int idLocalidad;
        private string localidad;

        public int pIdLocalidad { get => idLocalidad; set => idLocalidad = value; }
        public string pLocalidad { get => localidad; set => localidad = value; }

        public Localidad()
        {
            idLocalidad = 0;
            localidad = "";
        }
        
    }
}
