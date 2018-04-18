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

            List<Usuarios> Usuarios = new List<Usuarios> { };
            LogIn LogIn = new LogIn(new List<Usuarios> { new Administradores("p", "p", "p", "p", "p", "p")});

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Hola, bienvenido a Uandes Eats");
                Console.WriteLine("1) Login");
                Console.WriteLine("2) Registrarse");
                Console.WriteLine("0) Salir");
                string resultadoS = Console.ReadLine();

                while (resultadoS != "1" & resultadoS != "2" & resultadoS != "0")
                {
                    Console.WriteLine("Comando inválido");
                    Console.WriteLine("1) Login");
                    Console.WriteLine("2) Registrarse");
                    Console.WriteLine("0) Salir");
                    
                }
                int.TryParse(resultadoS, out resultado);

                if (resultado == 1)
                {
                    Console.Write("Ingrese RUT: ");
                    string RUT = Console.ReadLine();
                    Console.Write("Ingrese Contraseña: ");
                    string Contraseña = Console.ReadLine();
                    //
                    bool Ingresa = LogIn.IngresarACuenta(RUT, Contraseña);//Con este comando vemos si existe el usuario, si existe nos devuelve true y guarda al usuario en la variable LogIn.Usuario
                    //
                    if (Ingresa && LogIn.UsuarioIniciado is Clientes)// Programa para clientes
                    {
                        Console.WriteLine("Bienvenido");
                        Console.WriteLine("1)Realizar Pedido");
                        Console.WriteLine("2)Ver Pedidos");
                        Console.WriteLine("0)Salir");
                        string accionS = Console.ReadLine();

                        while (accionS != "1" & accionS != "2" & accionS != "0")
                        {
                            Console.WriteLine("Comando inválido");
                            Console.WriteLine("1)Realizar Pedido");
                            Console.WriteLine("2)Ver Pedidos");
                            Console.WriteLine("0)Salir");
                            accionS = Console.ReadLine();
                        }
                        int.TryParse(accionS, out accion);

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
                            Console.WriteLine("Adiós y Gracias por preferir Uandes Eats");
                        }
                    }

                    else if (Ingresa && LogIn.UsuarioIniciado is Administradores)// Programa para admin
                    {
                        Console.WriteLine("Programa para admin");
                    }

                    else if (Ingresa && LogIn.UsuarioIniciado is Repartidores)// Programa para Repartidores
                    {
                        Console.WriteLine("Programa para admin");
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
    
   
