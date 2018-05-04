using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;


namespace Uandes_Eats
{
    [Serializable()]
    class Platos
    {
        public string Nombre;
        public string Descripcion;
        public int Precio;

        public Platos(string nombre, string descripcion, int precio)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            Precio = precio;
        }

    }
}
