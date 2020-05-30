using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria
{
     public class Veterinario:Persona
    {
        private int matricula;
        private string password;
        private int estado;
        private string nombre;
        public int pIdMatricula
        {
            set { matricula = value; }
            get { return matricula; }
        }
        public string pPassword
        {
            set { password = value; }
            get { return password; }
        }
        public int pEstado { get => estado; set => estado = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public Veterinario() : base()
        {
            matricula = 0;
            password="";
            estado = 0;
    }
        public  string toStringVeterinario()
        {

            return "Matricula: " + matricula.ToString();
        }
    }
}
