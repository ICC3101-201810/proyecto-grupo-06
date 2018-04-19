using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uandes_Eats
{
    class Local
    {
        public string Nombre;
        public string TiempoEspera;
        public string Ubicacion;
        public List<Platos> Menu;

        public Local(string nombre, string tiempoEspera, string ubicacion, List<Platos> menu)
        {
            Nombre = nombre;
            TiempoEspera = tiempoEspera;
            Ubicacion = ubicacion;
            Menu = menu;
        }

        public void AgregarPlato()
        {
            int precio;
            Console.WriteLine("Agregando plato:");
            Console.WriteLine("Nombre del plato");
            string nombre = Console.ReadLine();
            Console.WriteLine("Descripción del plato:");
            string descripcion = Console.ReadLine();
            Console.WriteLine("Precio del plato:");
            int.TryParse(Console.ReadLine(), out precio);

            Menu.Add(new Platos(nombre, descripcion, precio));
            Console.WriteLine("Plato agregado al menu");
        }

        public void VerMenu()
        {
            int indice;
            while (true)
            {
                Console.WriteLine($"Menu de {Nombre}");
                int x = 1;
                foreach (Platos plato in Menu)
                {
                    Console.WriteLine($"{x}){plato.Nombre}");
                    x++;
                }
                Console.WriteLine($"{x})Volver a locales");

                //Metodo Try Catch para ver si introduce bien los indices
                try
                {
                    int.TryParse(Console.ReadLine(), out indice);
                }
                catch
                {
                    Console.WriteLine("Comando invalido");
                }
                finally
                {
                    if (indice < x && indice > 0)
                    {
                        break;
                    }
                }

                int.TryParse(Console.ReadLine(), out indice);

                if (indice != x)
                {
                    Platos PlatoIngresado = Menu[indice - 1];

                    Console.WriteLine($"{PlatoIngresado.Nombre}");
                    Console.WriteLine($"{PlatoIngresado.Descripcion}");
                    Console.WriteLine($"{PlatoIngresado.Precio}");
                    Console.WriteLine("1)Agregar al carro");
                    Console.WriteLine("2)Volver al menu");

                    //Metodo Try Catch para ver si introduce bien los indices
                    while (Console.ReadLine() != "1" & Console.ReadLine() != "2")
                    {
                        Console.WriteLine("Comando invalido");
                        Console.WriteLine($"{PlatoIngresado.Nombre}");
                        Console.WriteLine($"{PlatoIngresado.Descripcion}");
                        Console.WriteLine($"{PlatoIngresado.Precio}");
                        Console.WriteLine("1)Agregar al carro");
                        Console.WriteLine("2)Volver al menu");
                    }

                    if (Console.ReadLine() == "1")
                    {
                        //metodo para agregar prodicto al carro
                    }
                }
                else if(indice == x)
                {
                    break;
                }
            }
        }
    }
}
