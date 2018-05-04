using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uandes_Eats
{
    class LogIn
    {
        public List<Usuarios> UsuariosRegistrados;
        public Usuarios UsuarioIniciado;

        public LogIn(List<Usuarios> usuariosRegistrados)
        {
            UsuariosRegistrados = usuariosRegistrados;
        }

        public void RegistrarUsuario()
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
            bool crear = true;
            foreach (Usuarios usuario in UsuariosRegistrados)
            {
                if (usuario.Rut == Rut)
                {
                    Console.WriteLine("Este RUT ya esta registrado");
                    crear = false;
                    break;
                }
            }
            if (crear)
            {
                UsuariosRegistrados.Add(new Clientes(Nombre, Apellido, Rut, Mail, Telefono, Contraseña));
            }
        }

        public bool IngresarACuenta (string RUT, string ContraseñaCuenta)
        {
            foreach(Usuarios usuario in UsuariosRegistrados)
            {
                if (usuario.Rut == RUT && usuario.Contraseña == ContraseñaCuenta)
                {
                    UsuarioIniciado = usuario;
                    return true;
                }
            }

            return false;

        }
    }
}