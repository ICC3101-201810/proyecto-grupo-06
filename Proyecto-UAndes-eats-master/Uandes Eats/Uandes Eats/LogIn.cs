using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uandes_Eats
{
    class LogIn
    {

        public  Usuario RegistrarUsuario()
        {
            Console.WriteLine("Necesitamos los siguientes datos para que se registre:");
            Console.WriteLine("Nombre: ");
            string Nombre = Console.ReadLine();
            Console.WriteLine("Apellido: ");
            string Apellido = Console.ReadLine();
            Console.WriteLine("Rut: ");
            string Rut = Console.ReadLine();
            Console.WriteLine("Mail: ");
            string Mail = Console.ReadLine();
            Console.WriteLine("Telefono: ");
            string Telefono = Console.ReadLine();
            Console.WriteLine("Contraseña: ");
            string Contraseña = Console.ReadLine();

            return new Usuario(Nombre, Apellido, Rut, Mail, Telefono, Contraseña);
        }
    }
}
