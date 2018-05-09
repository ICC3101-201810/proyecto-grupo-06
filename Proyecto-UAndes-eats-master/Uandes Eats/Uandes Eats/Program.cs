using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


//namespace WindowsFormsApp1
////{
    //class Program
    //{

    //    static void Main(string[] args)
    //    {
    //        //FileStream TextUsuarios = new FileStream("BaseDeDatosUsuarios.txt", FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
    //        //FileStream TextLocales = new FileStream("BaseDeDatosLocales.txt", FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);

    //        //BaseDatos BaseDeDatos = new BaseDatos();
    //        //BaseDeDatos.ConseguirLocales(TextLocales);
    //        //BaseDeDatos.ConseguirUsuarios(TextUsuarios);

    //        //Todavia no nos enseñan a ocupar textos

    //        DateTime iuew = new DateTime();
    //        DateTime iuew1 = new DateTime();
    //        int resultado;
    //        int accion;

    //        List<Repartidores> repartidores = new List<Repartidores>();
    //        Repartidores rep1 = new Repartidores("2", "2", "2", "2", "2", "2");
    //        Repartidores rep2 = new Repartidores("3", "3", "3", "3", "3", "3");
    //        List<RepartidoresActivos> repartidoresActivos = new List<RepartidoresActivos>();
    //        repartidores.Add(rep1);
    //        repartidores.Add(rep2);
    //        repartidoresActivos.Add(new RepartidoresActivos(rep1, iuew));
    //        repartidoresActivos.Add(new RepartidoresActivos(rep2, iuew1));
    //        //List<Local> Locales = new List<Local>();
    //        //List<Platos> m1 = new List<Platos>();
    //        //List<Platos> m2 = new List<Platos>();
    //        //List<RepartidoresActivos> Repartidorese1 = new List<RepartidoresActivos> { };
    //        //Platos p1 = new Platos("Sushi", "10 piezas de sushi con camarón, queso crema y pepino", 2490);
    //        //Platos p2 = new Platos("Handroll", "Roll de sushi tempura con queso crema, cebollin y pollo", 1790);
    //        //Platos p3 = new Platos("Fideos Bolognesa", "Fideos con salsa bolognesa", 1890);
    //        //Platos p4 = new Platos("Media Luna con queso", "Media luna con jamón y queso", 2190);
    //        //m1.Add(p1);
    //        //m1.Add(p2);
    //        //m1.Add(p3);
    //        //m1.Add(p4);
    //        //Platos p5 = new Platos("Ave Pimentón", "Sandwich de pasta de pollo con pimentón molido", 1590);
    //        //Platos p6 = new Platos("Empanada napolitana", "Empanada con jamón, tomate y queso", 1190);
    //        //Platos p7 = new Platos("Brownie", "Brownie de chocolate y nuez", 590);
    //        //m2.Add(p5);
    //        //m2.Add(p6);
    //        //m2.Add(p7);
    //        //Local l1 = new Local("Cafetería Biblioteca", "30 minutos", "Biblioteca", m1);
    //        //Local l2 = new Local("Cafetería Humanidades", "25 minutos", "Edificio Humanidades", m2);
    //        //Locales.Add(l1);
    //        //Locales.Add(l2);
    //        List<Local> Locales = new List<Local> { };
    //        try
    //        {
    //            using (Stream stream = File.Open("DatosLocales.bin", FileMode.Open))
    //            {
    //                BinaryFormatter bin = new BinaryFormatter();

    //                Locales = (List<Local>)bin.Deserialize(stream);
    //            }
    //        }
    //        catch (IOException)
    //        {
    //        }

    //        List<Usuarios> usuarios = new List<Usuarios>();
    //        try
    //        {
    //            using (Stream stream = File.Open("DatosUsuarios.bin", FileMode.Open))
    //            {
    //                BinaryFormatter bin = new BinaryFormatter();

    //                usuarios = (List<Usuarios>)bin.Deserialize(stream);
    //            }
    //        }
    //        catch (IOException)
    //        {
    //        }


    //        //BaseDatos BaseDeDatos = new BaseDatos();
    //        //Administradores adm11 = new Administradores("Pedro", "Naretto", "19689484-5", "ppnaretto@miuandes.cl", "74290557", "p");
    //        //usuarios.Add(adm11);
    //        LogIn LogIn = new LogIn(usuarios);
    //        //El LogIn deberia ir con BaseDeDatos.ConseguirUsuarios(text.txt) pero no se pudo ocupar textos por lo que lo dejamos de ejemplo


    //        while (true)
    //        {
    //            Console.ForegroundColor = ConsoleColor.Red;
    //            Console.WriteLine("Hola, bienvenido a Uandes Eats");
    //            Console.WriteLine("1) Login");
    //            Console.WriteLine("2) Registrarse");
    //            Console.WriteLine("0) Salir");
    //            string resultadoS = Console.ReadLine();

    //            while (resultadoS != "1" & resultadoS != "2" & resultadoS != "0")
    //            {
    //                Console.WriteLine("Comando inválido");
    //                Console.WriteLine("1) Login");
    //                Console.WriteLine("2) Registrarse");
    //                Console.WriteLine("0) Salir");
                    
    //            }
    //            int.TryParse(resultadoS, out resultado);

    //            if (resultado == 1)
    //            {
    //                Console.Write("Ingrese RUT: ");
    //                string RUT = Console.ReadLine();
    //                Console.Write("Ingrese Contraseña: ");
    //                string Contraseña = Console.ReadLine();
    //                //
    //                bool Ingresa = LogIn.IngresarACuenta(RUT, Contraseña);//Con este comando vemos si existe el usuario, si existe nos devuelve true y guarda al usuario en la variable LogIn.Usuario
    //                //
    //                if (Ingresa && LogIn.UsuarioIniciado is Clientes)// Programa para clientes
    //                {
    //                    Pedido pedido = new Pedido(new List<Platos>(), LogIn.UsuarioIniciado);
    //                    Console.WriteLine("Bienvenido");
    //                    while (true) {
    //                        Console.WriteLine("1)Ver Locales");
    //                        Console.WriteLine("2)Ver Pedidos");
    //                        Console.WriteLine("3)Terminar Pedido");
    //                        Console.WriteLine("0)Salir");
    //                        string accionS = Console.ReadLine();

    //                        while (accionS != "1" & accionS != "2" & accionS != "0" & accionS != "3")
    //                        {
    //                            Console.WriteLine("Comando inválido");
    //                            Console.WriteLine("1)Ver Locales");
    //                            Console.WriteLine("2)Ver Pedidos");
    //                            Console.WriteLine("3)Terminar Pedido");
    //                            Console.WriteLine("0)Salir");
    //                            accionS = Console.ReadLine();
    //                        }
    //                        int.TryParse(accionS, out accion);

    //                        if (accion == 1)
    //                        {
    //                            int resultadoi;
    //                            int o = 1;
    //                            int Plato1;
    //                            int o1 = 1;

    //                            List<string> num = new List<string>();
    //                            num.Add("0");
    //                            List<string> num1 = new List<string>();
    //                            num1.Add("0");
    //                            Console.WriteLine("0.- Para regresar al menu ");
    //                            foreach (Local i in Locales)
    //                            {
    //                                Console.WriteLine(o + ".- " + i.Nombre);
    //                                num.Add(o.ToString());
    //                                o++;

    //                            }
    //                            string resultadoSi = Console.ReadLine();
    //                            while (num.Contains(resultadoSi) == false)
    //                            {
    //                                int opciones = 1;
    //                                Console.WriteLine("Comando inválido");
    //                                Console.WriteLine("0.- Para regresar al menu ");
    //                                foreach (Local i in Locales)
    //                                {
    //                                    Console.WriteLine(opciones + ".- " + i.Nombre);
    //                                    opciones++;
    //                                }
    //                                resultadoSi = Console.ReadLine();
    //                            }
    //                            int.TryParse(resultadoSi, out resultadoi);
    //                            // Ahora vienen los platos
    //                            if (resultadoi == 0)
    //                            {

    //                            }
    //                            else
    //                            {
    //                                Console.WriteLine("0.- Para regresar al menu ");
    //                                foreach (Platos k in Locales[resultadoi-1].Menu)
    //                                {
    //                                    Console.WriteLine(o1 + ".- " + k.Nombre);
    //                                    num1.Add(o1.ToString());
    //                                    o1++;
    //                                }
    //                                string plato1 = Console.ReadLine();

    //                                while (num1.Contains(plato1) == false)
    //                                {
    //                                    int opciones = 1;
    //                                    Console.WriteLine("Comando inválido");
    //                                    Console.WriteLine("0.- Para regresar al menu ");
    //                                    foreach (Platos i in Locales[resultadoi-1].Menu)
    //                                    {
    //                                        Console.WriteLine(opciones + ".- " + i.Nombre);
    //                                        opciones++;
    //                                    }
    //                                    plato1 = Console.ReadLine();

    //                                }

    //                                int.TryParse(plato1, out Plato1);
    //                                if (Plato1 == 0)
    //                                {

    //                                }
    //                                else
    //                                {
    //                                    Console.WriteLine(Locales[resultadoi-1].Menu[Plato1-1].Nombre);
    //                                    Console.WriteLine(Locales[resultadoi-1].Menu[Plato1-1].Descripcion);
    //                                    Console.WriteLine(Locales[resultadoi-1].Menu[Plato1-1].Precio);
    //                                    Console.WriteLine("Si lo quiere añadir al pedido ingrese 1, si quiere volver al menu, ingrese 0:");
    //                                    string ult = Console.ReadLine();
    //                                    while (true)
    //                                    {
    //                                        if (ult=="1"|| ult == "0")
    //                                        {
    //                                            break;
    //                                        }
    //                                        else
    //                                        {
    //                                            Console.WriteLine("Intente Nuevamente");
    //                                            ult = Console.ReadLine();

    //                                        }
    //                                    }
    //                                    if (ult == "1")
    //                                    {
    //                                        pedido.AgregarAlPedido(Locales[resultadoi-1].Menu[Plato1-1]);
    //                                    }

                                        
    //                                }
    //                            }

    //                        }


    //                        else if (accion == 2)
    //                        {
    //                            pedido.VerPedido();
    //                        }
    //                        else if (accion == 3)
    //                        {
    //                           bool ter= pedido.TerminarPedido();
    //                            if (ter == true)
    //                            {
                                     
    //                                AdminPC adminPC1 = pedido.VincularRepPed( repartidoresActivos, pedido);
    //                                WebPay paguito = new WebPay(LogIn.UsuarioIniciado, pedido.CalcularTotal());
    //                                paguito.PagoWebpay();
    //                            }

    //                        }
    //                        else if (accion == 0)
    //                        {
                                
    //                            break;
    //                        }

    //                    }
                        
                       
    //                }

    //                else if (Ingresa && LogIn.UsuarioIniciado is Administradores)// Programa para admin
    //                {
    //                    while (true)
    //                    {
    //                        Console.WriteLine("Bienvenido Administrador");
    //                        Console.WriteLine("0.- Salir");
    //                        Console.WriteLine("1.- Agregar Local");
    //                        Console.WriteLine("2.- Agregar plato a local");
    //                        string decadm = Console.ReadLine();
    //                        while (true)
    //                        {
    //                            if (decadm == "1" || decadm == "0" || decadm == "2")
    //                            {
    //                                break;
    //                            }
    //                            else
    //                            {
    //                                Console.WriteLine("Error , intente otra vez");
    //                                decadm = Console.ReadLine();
    //                            }
    //                        }
    //                        if (decadm == "1")
    //                        {
    //                            Administradores Admin = new Administradores(LogIn.UsuarioIniciado.Rut, LogIn.UsuarioIniciado.Contraseña, LogIn.UsuarioIniciado.Telefono, LogIn.UsuarioIniciado.Mail, LogIn.UsuarioIniciado.Apellido, LogIn.UsuarioIniciado.Nombre);
    //                            Locales.Add(Admin.AgregarLocal());
    //                        }
    //                        else if( decadm == "2")
    //                        {
    //                            while (true)
    //                            {
    //                                int resultadoi;
    //                                int o = 1;

    //                                List<string> num = new List<string>();
    //                                num.Add("0");
    //                                List<string> num1 = new List<string>();
    //                                num1.Add("0");
    //                                Console.WriteLine("0.- Para regresar al menu ");
    //                                foreach (Local i in Locales)
    //                                {
    //                                    Console.WriteLine(o + ".- " + i.Nombre);
    //                                    num.Add(o.ToString());
    //                                    o++;

    //                                }
    //                                string resultadoSi = Console.ReadLine();
    //                                while (num.Contains(resultadoSi) == false)
    //                                {
    //                                    int opciones = 1;
    //                                    Console.WriteLine("Comando inválido");
    //                                    Console.WriteLine("0.- Para regresar al menu ");
    //                                    foreach (Local i in Locales)
    //                                    {
    //                                        Console.WriteLine(opciones + ".- " + i.Nombre);
    //                                        opciones++;
    //                                    }
    //                                    resultadoSi = Console.ReadLine();
    //                                }
    //                                int.TryParse(resultadoSi, out resultadoi);
    //                                if (resultadoi == 0)
    //                                {
    //                                    break;
    //                                }
    //                                Locales[resultadoi - 1].AgregarPlato();
    //                            }
    //                        }
    //                        else if (decadm == "0")
    //                        {
    //                            break;
    //                        }
    //                    }
    //                }

    //                else if (Ingresa && LogIn.UsuarioIniciado is Repartidores)// Programa para Repartidores
    //                {
    //                    Console.WriteLine("Por ahora los repartidores no son necesarios");
    //                    Console.WriteLine("Asi que shao.");
    //                }

    //                else
    //                {
    //                    Console.WriteLine("RUT o Contraseña no validos");
    //                }
    //            }

    //            else if (resultado == 2)
    //            {
    //                LogIn.RegistrarUsuario();
    //            }

    //            else if (resultado == 0)
    //            {
                    
    //                break;
    //            }
    //        }
    //        Console.WriteLine("Adiós y Gracias por preferir Uandes Eats");

            
    //        try
    //        {
    //            using (Stream stream = File.Open("DatosLocales.bin", FileMode.Create))
    //            {
    //                BinaryFormatter bin = new BinaryFormatter();
    //                bin.Serialize(stream, Locales);
    //            }
    //        }
    //        catch (IOException)
    //        {
    //        }

    //        try
    //        {
    //            using (Stream stream = File.Open("DatosUsuarios.bin", FileMode.Create))
    //            {
    //                BinaryFormatter bin = new BinaryFormatter();
    //                bin.Serialize(stream, usuarios);
    //            }
    //        }
    //        catch (IOException)
    //        {
    //        }

    //        Console.ReadKey();
    //    }
    //}
//}
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




