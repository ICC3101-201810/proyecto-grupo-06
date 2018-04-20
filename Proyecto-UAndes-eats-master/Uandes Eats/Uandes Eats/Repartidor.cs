using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uandes_Eats
{
    class Repartidores : Usuarios
    {
        public Repartidores(string rut, string contraseña, string telefono, string mail, string apellido, string nombre) : base(rut, contraseña, telefono, mail, apellido, nombre)
        {

        }
    }
}
