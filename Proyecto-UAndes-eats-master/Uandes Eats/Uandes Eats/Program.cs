using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uandes_Eats
{
    class Program
    {
        static void Main(string[] args)
        {
            int resultado;
            int rut;
            int contraseña;
            int accion;

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Hola, bienvenido a Uandes Eats");
            Console.WriteLine("1) Login");
            Console.WriteLine("2) Registrarse");
            Console.WriteLine("0) Salir");

            int.TryParse(Console.ReadLine(), out resultado);

            while (resultado != 1 & resultado != 2 & resultado != 0)
            {
                Console.WriteLine("Comando inválido");
                Console.WriteLine("1) Login");
                Console.WriteLine("2) Registrarse");
                Console.WriteLine("0) Salir");
                int.TryParse(Console.ReadLine(), out resultado);
            } 
        
            if (resultado == 1)
            {
                Console.WriteLine("Por favor ingresar RUT sin puntos ni guiones " +
                    "(Si RUT termina en k, reemplaze por 0)");

                int.TryParse(Console.ReadLine(), out rut);

                while (rut != 180260897)
                {
                    Console.WriteLine("RUT ingresado no válido. ");
                    Console.WriteLine("Recuerde que el RUT ingresado no debe tener " +
                        "puntos ni guiones y si termina en k, esta debe ser reemplazada por un 0");
                    int.TryParse(Console.ReadLine(), out rut);
                }

                Console.WriteLine("Por favor ingresar contraseña");
                int.TryParse(Console.ReadLine(), out contraseña);

                while (contraseña != 123456)
                {
                    Console.WriteLine("Contraseña ingresada incorrecta. ");
                    Console.WriteLine("Por favor intente nuevamente");
                    int.TryParse(Console.ReadLine(), out contraseña);
                }

                Console.WriteLine("Bienvenido");
                Console.WriteLine("1)Realizar Pedido");
                Console.WriteLine("2)Ver Pedidos");
                Console.WriteLine("0)Salir");
                int.TryParse(Console.ReadLine(), out accion);

                while (resultado != 1 & resultado != 2 & resultado != 0)
                {
                    Console.WriteLine("Comando inválido");
                    Console.WriteLine("1)Realizar Pedido");
                    Console.WriteLine("2)Ver Pedidos");
                    Console.WriteLine("0)Salir");
                    int.TryParse(Console.ReadLine(), out resultado);
                }

                if (accion == 1)
                {
                    Console.WriteLine("metodo RealizarPedido");
                }
                else if (accion == 2)
                {
                    Console.WriteLine("metodo VerPedido");
                }
                else if (accion==0)
                {
                    
                }
            }
            else if (resultado == 2)
            {
                Console.WriteLine("Agregar metodo CrearUsuario");
            }

            else if(resultado == 0)
            {
                Console.WriteLine("Adiós y Gracias por preferir Uandes Eats");
            }
        }
    }
}
    
   
