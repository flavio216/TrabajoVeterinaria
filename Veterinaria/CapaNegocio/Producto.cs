using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria
{
    public class Producto
    {
        private int id;
        private string descripcion;
        private double precio;
        private int stock;
        private int tipo;
        private int Estado;

        public int pId { get => id; set => id = value; }
        public string pDescripcion { get => descripcion; set => descripcion = value; }
        public double pPrecio { get => precio; set => precio = value; }
        public int pStock { get => stock; set => stock = value; }
        public int pTipo { get => tipo; set => tipo = value; }
        public int pEstado { get => Estado; set => Estado = value; }

        public Producto()
        {
            id = 0;
            descripcion = "";
            precio = 0;
            stock = 0;
            tipo = 0;
        }

        public Producto(int id, string desc, float pr, int st, int tipo)
        {
            this.id = id;
            descripcion = desc;
            precio = pr;
            stock = st;
            this.tipo = tipo;
        }

    

   

    }
}
