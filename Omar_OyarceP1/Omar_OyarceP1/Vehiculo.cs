using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omar_OyarceP1
{
    class Vehiculo
    {
        int Precio;
        string nombre;
        int stock;
        public Vehiculo(string nombre, int precio, int s)
        {
            this.Precio = precio;
            this.nombre = nombre;
            this.stock = s;
        }
        public int GetPrecio()
        {
            return Precio;
        }
        public string GetNombre()
        {
            return nombre;
        }
        public int GetStock()
        {
            return stock;
        }
    }
}
