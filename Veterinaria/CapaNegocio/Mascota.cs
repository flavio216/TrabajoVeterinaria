using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Veterinaria
{
    public class Mascota
    {
        private int Id;
        private string nombre;
        private int tipo;
        private int raza;
        private int idCliente;
        private DateTime fechaNac;
        private int estado;
        private int sexo;

       

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
        public int pidCliente
        {
            set { idCliente = value; }
            get { return idCliente; }
        }
        public DateTime pFechaNac
        {
            set { fechaNac = value; }
            get { return fechaNac; }
        }

        public int pId { get => Id; set => Id = value; }
        public int pEstado { get => estado; set => estado = value; }
        public int pSexo { get => sexo; set => sexo = value; }

        public Mascota()
        {
            Id = 0;
            nombre = "";
            tipo = 0;
            raza = 0;
            idCliente = 0;
            fechaNac = DateTime.Today;
        }
    }
}
