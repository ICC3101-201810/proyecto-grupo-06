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
            int accion;

            List<Usuario> Usuarios = new List<Usuario> { };
            LogIn LogIn = new LogIn(new List<Usuario> { });

            while (true)
            {
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
                    Console.Write("Ingrese RUT: ");
                    string RUT = Console.ReadLine();
                    Console.Write("Ingrese Contraseña: ");
                    string Contraseña = Console.ReadLine();
                    bool Ingresa = LogIn.IngresarACuenta(RUT, Contraseña);
                    //Con este comando vemos si existe el usuario, si existe nos devuelve true y guarda al usuario en la variable LogIn.Usuario//
                    if (Ingresa)
                    {
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
                            Console.WriteLine("Metodo realizar Pedido");
                        }
                        else if (accion == 2)
                        {
                            Console.WriteLine("metodo VerPedido");
                        }
                        else if (accion == 0)
                        {

                        }
                    }
                    else
                    {
                        Console.WriteLine("RUT o Contraseña no validos");
                    }
                }
                else if (resultado == 2)
                {
                    LogIn.RegistrarUsuario();
                }

                else if (resultado == 0)
                {
                    Console.WriteLine("Adiós y Gracias por preferir Uandes Eats");
                    break;
                }
            }

            Console.ReadKey();
        }
    }
}
    
   
