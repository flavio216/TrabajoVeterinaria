using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria
{
    public class Consulta
    {
        int id;
        string consulta;
        DateTime fechaConsulta;
        double precio;
        int idVeterinario;
        int idMascota;

        public int pId { get => id; set => id = value; }
        public string pConsulta { get => consulta; set => consulta = value; }
        public DateTime pFechaConsulta { get => fechaConsulta; set => fechaConsulta = value; }
        public double pPrecio { get => precio; set => precio = value; }
        public int pIdVeterinario { get => idVeterinario; set => idVeterinario = value; }
        public int pIMascota { get => idMascota; set => idMascota = value; }
    

    public Consulta()
    {
            id= 0;
            consulta = "";
            fechaConsulta = DateTime.Today;
            precio = 0;
            idVeterinario = 0;
            idMascota = 0;
    }
    public Consulta(int ID, string con, DateTime fec, double pre, int idv, int idm)
    {
         
           this.id= ID;
            consulta = con;
            fechaConsulta = fec;
            precio = pre;
            idVeterinario = idv;
            idMascota = idm;

        }
    }
}
