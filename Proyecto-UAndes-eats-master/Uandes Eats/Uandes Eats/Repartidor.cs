using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uandes_Eats
{
    class Repartidores : Usuarios
    {
        public Repartidores(string nombre, string apellido, string rut, string mail, string telefono, string contraseña) : base(nombre, apellido, rut, mail, telefono, contraseña)
        {
        }
    }
}
