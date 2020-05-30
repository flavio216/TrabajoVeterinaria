using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria
{
    public abstract class Persona
    {
        private string apellido;
        private string nombre;
        private int tipoDocumento;
        private int documento;
        private double telefono;
        private DateTime fechaNac;
        private string direccion;
        private int numeroCasa;
        //private int barrio;
        private int localidad;
        //private int sexo;

        public string pApellido
        {
            set { apellido = value; }
            get { return apellido; }
        }
        public string pNombre
        { 
            set { nombre = value; }
            get { return nombre; }
        }
        public int pTipoDocumento
        {
            set { tipoDocumento = value; }
            get { return tipoDocumento; }
        }
        public int pDocumento
        {
            set { documento = value; }
            get { return documento; }
        }
        public double pTelefono
        {
            set { telefono = value; }
            get { return telefono; }
        }
        public string pDireccion
        {
            set { direccion = value; }
            get { return direccion; }
        }
        public int pNumeroCasa
        {
            set { numeroCasa = value; }
            get { return numeroCasa; }
        }
        //public int pBarrio
        //{
        //    set { barrio = value; }
        //    get { return barrio; }
        //}
        public int pLocalidad
        {
            set { localidad = value; }
            get { return localidad; }
        }

        public DateTime pFechaNac { get => fechaNac; set => fechaNac = value; }

        //public int pSexo
        //{
        //    set { sexo = value; }
        //    get { return sexo; }
        //}

        public Persona()
        {
            apellido = "";
            nombre = "";
            tipoDocumento = 0;
            documento = 0;
            telefono = 0;
            fechaNac = DateTime.Today;
            direccion = "";
            numeroCasa = 0;
            //barrio = 0;
            localidad = 0;
            //sexo = 0;
            
        }

        public Persona(string ape, string nom, int tD, int doc, double tel, DateTime fec, string dir, int nC, int loc, int sexo)
        {
            apellido = ape;
            nombre = nom;
            tipoDocumento = tD;
            documento = doc;
            telefono = tel;
            fechaNac = fec;
            this.direccion = dir;
            numeroCasa = nC;
            //this.barrio = barrio;
            localidad = loc;
            //this.sexo = sexo;
        }
        //public string toStringSexo()
        //{
        //    if (sexo == 1)
        //        return "Masculino";
        //    else
        //        return "Femenino";
        //}

        //public string toStringPersona()
        //{
        //    return apellido+", "+nombre+"\n"
        //        +"Sexo:"+toStringSexo()+"\n"
        //        +"p"
           
        //}
    }
}
