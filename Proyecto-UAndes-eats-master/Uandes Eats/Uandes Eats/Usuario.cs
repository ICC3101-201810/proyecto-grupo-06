using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uandes_Eats
{
    class Usuario
    {
        string Rut;
        string Contraseña;
        public string Telefono;
        public string Mail;
        public string Apellido;
        public string Nombre;

        public Usuario(string rut, string contraseña, string telefono, string mail, string apellido, string nombre)
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
