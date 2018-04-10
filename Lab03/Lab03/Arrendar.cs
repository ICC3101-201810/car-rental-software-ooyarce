using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    public enum PriceVehicules { Auto = 2000, Acuatico = 1000, Moto = 500, Camion = 10000, Bus = 8000, Tractor = 5000, RetroExcabadora = 25000 };
    class Sucursal
    { 
        String Nombre;

        List<Cliente> Historial = new List<Cliente>();
        List<Vehiculo> Inventario = new List<Vehiculo>();
        String[] Clase = { "Auto", "Acuatico", "Moto", "Camion", "Bus", "Tractor", "Retro-Excabadora" };

        public void NombrarSucursal()
        {
            Console.WriteLine("Escoja un nombre para su sucursal: ");
            Nombre = Console.ReadLine();
        }
        public void DefinirStock()
        {
            for (int i = 0; i < 7;i++)
            {
                int valor;
                Console.WriteLine("Defina un numero de stock para " + Clase[i] + ": ");
                Console.ReadLine();
                
            }
            
        }
    }
}
