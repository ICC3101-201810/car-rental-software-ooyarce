using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{

    class Vehiculo
    {
        int casilla;
        String Nombre;
        String[] Clase = new String[7];
        int Stock;
        public Vehiculo(string[] tipoVehiculo, int Stk, int Slot)
        {
            this.Clase = tipoVehiculo;
            this.Stock = Stk;
            this.casilla = Slot;
            this.Nombre = Clase[casilla];
        }
        public String GetName(){ return Nombre;}
        public int GetStock()
        {
            if (casilla == 0) { Stock = (int)PriceVehicules.Auto; return Stock; };
            if (casilla == 1) { Stock = (int)PriceVehicules.Acuatico; return Stock; };
            if (casilla == 2) { Stock = (int)PriceVehicules.Moto; return Stock; };
            if (casilla == 3) { Stock = (int)PriceVehicules.Camion; return Stock; };
            if (casilla == 4) { Stock = (int)PriceVehicules.Bus; return Stock; };
            if (casilla == 5) { Stock = (int)PriceVehicules.Tractor; return Stock; };
            if (casilla == 6) { Stock = (int)PriceVehicules.RetroExcabadora; return Stock; };
            Stock = (int)PriceVehicules.Auto;
            return Stock;
        }
    }
}
