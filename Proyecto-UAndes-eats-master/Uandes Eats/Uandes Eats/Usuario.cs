using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uandes_Eats
{
    abstract class Usuarios
    {
        public string Nombre;
        public string Apellido;
        string Rut;
        public string Mail;
        public string Telefono;
        public string Contraseña;

        public Usuarios(string rut, string contraseña, string telefono, string mail, string apellido, string nombre)
        {
            Rut = rut;
            Contraseña = contraseña;
            Telefono = telefono;
            Mail = mail;
            Apellido = apellido;
            Nombre = nombre;
        }
    }
}
