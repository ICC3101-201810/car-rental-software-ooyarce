using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    class Cliente
    {
        String Nombre;
        int casillero;
        String[] Clients = { "Persona", "Empresa", "Organizacion", "Institucion" };
        String Type;
        String Permiso;
        public Cliente(String Name, int slot,String P)
        {
            this.casillero = slot;
            this.Nombre = Name;
            Type = Clients[slot];
            this.Permiso = P;
        }
        public string GetTyper() { return Type; }
        public string GetName() { return Nombre; }
        public bool Licence() { if (Permiso == "Si") { return true; } else { return false; } }
        public void Arrendar()
        {

        }
    }
}
