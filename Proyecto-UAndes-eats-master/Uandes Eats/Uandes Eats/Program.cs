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
//Platos p1 = new Platos("Sushi", "10 piezas de sushi con camarón, queso crema y pepino", "2490");
//Platos p2 = new Platos("Handroll", "Roll de sushi tempura con queso crema, cebollin y pollo", "1790");
//Platos p3 = new Platos("Fideos Bolognesa", "Fideos con salsa bolognesa", "1890");
//Platos p4 = new Platos("Media Luna con queso", "Media luna con jamón y queso", "2190");
//Platos p5 = new Platos("Ave Pimentón", "Sandwich de pasta de pollo con pimentón molido", "1590");
//Platos p6 = new Platos("Empanada napolitana", "Empanada con jamón, tomate y queso", "1190");
//Platos p7 = new Platos("Brownie", "Brownie de chocolate y nuez", "590");
//Platos p8 = new Platos("Galletón", "Galletón de avena con chips de chocolate", "790");
//Platos p9 = new Platos("Cheeseburger", "Hamburguesa con queso", "1690");
//Platos p10 = new Platos("Lomito Italiano", "Lomito con palta, tomate y mayonesa", "1590");
//Platos p11 = new Platos("Puré con Cerdo", "Chuleta de cerdo con puré de papas", "1890");
//Platos p12 = new Platos("Café Grande", "Café de 500 ml", "1390");
//Platos p13 = new Platos("Café Chico", "Café de 250 ml", "990");
//Platos p14 = new Platos("Ensalada Mixta", "Ensalada con lechuga, acelga, palta, tomate, palmito y pollo", "2490");
//Platos p15 = new Platos("Fideos Alfredo", "Fideos con salsa alfredo", "1790");
//Platos p16 = new Platos("Arroz con Pollo", "Arroz Blanco con tuto de pollo", "1890");
//Platos p17 = new Platos("Coca-Cola", "Coca-Cola de 350 ml", "590");
//Platos p18 = new Platos("Agua Mineral", "Agua Mineral", "790");
//Platos p19 = new Platos("Chaparrita", "Chaparrita con queso y vienesa", "1190");
//Platos p20 = new Platos("Hot Dog Italiano", "Hot Dog de 20 cm con tomate, palta y mayonesa", "1590");
//Platos p21 = new Platos("Gohan Mixto", "Gohan con palta, salmón y queso crema", "3490");
//Platos p22 = new Platos("Atún", "Sub a base de atún con lechuga, tomate y mozarella", "2990");
//Platos p23 = new Platos("Teriyaki", "Sub con pollo teriyaki con queso chedar, tomate y jalapeños", "3990");
//Platos p24 = new Platos("Albondigas", "Sub con albondigas, salsa, chipotle y queso chedar", "2690");
//Platos p25 = new Platos("Margarita", "Pizza con queso y tomate", "6990");
//Platos p26 = new Platos("3 Carnes", "Pizza con tocino, chorizillo y carne", "8990");
//Platos p27 = new Platos("Peperonni", "Pizza con peperonni y doble queso", "7990");
//Platos p28 = new Platos("Full", "Hamburguesa con lechuga, cebolla, tomate, pepinillos, mayonesa y doble carne", "5990");
//Platos p29 = new Platos("Veggie", "Hamburguesa de porotos y zanahoria con cebolla, lechuga, mayonesa y tomate", "4490");
//Platos p30 = new Platos("Bacon", "Hamburguesa con carne, queso chedar, tocino y salsa BBQ", "4990");

//Local l1 = new Local("Cafetería Biblioteca", "30 minutos", "Biblioteca");
//Local l2 = new Local("Cafetería Humanidades", "25 minutos", "Edificio Humanidades");
//Local l3 = new Local("FoodTruck", "5 minutos", "Al frente entrada a Ingeniería");
//Local l4 = new Local("Kiosko Reloj", "10 minutos", "Primer Piso Edificio Reloj");
//Local l5 = new Local("Kiosko Ciruelos", "10 minutos", "Patio los Ciruelos");
//Local l6 = new Local("Subway", "20 minutos", "Camino el Alba 12620");
//Local l7 = new Local("Papa Johns", "40 minutos", "Camino el Alba 12620");
//Local l8 = new Local("Wally´s", "30 minutos", "Camino el Alba 12620");


