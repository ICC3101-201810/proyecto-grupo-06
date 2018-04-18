using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uandes_Eats
{
    class Local
    {
        public string nombre;
        public string tiempodeespera;
        public string ubicacion;
        public List<Platos> Menu;


        public Local(string nombre, string tiempodeespera, string ubicacion, List<Platos> menu)
        {
            this.nombre = nombre;
            this.tiempodeespera = espera;
            this.ubicacion = ubicacion;
            this.Menu = menu;
        }

        public void DatosLocal()
        {
          
        }

        public Platos AgregarPlato()
        {
            int precio;
            Console.WriteLine("Agregando plato:");
            Console.WriteLine("Nombre del plato");
            string nombre = Console.ReadLine();
            Console.WriteLine("Descripción del plato:");
            string descripcion = Console.ReadLine();
            Console.WriteLine("Precio del plato:");
            int.TryParse(Console.ReadLine(), out precio);

            return new Platos(nombre, descripcion, precio);
        }

        public Local AgregarLocal()
        {
            Console.WriteLine("Agregando local:");
            Console.WriteLine("Nombre del local");
            string Nombre = Console.ReadLine();
            Console.WriteLine("Tiempo de espera aprox:");
            string TiempoEspera = Console.ReadLine();
            Console.WriteLine("Ubicacion del local:");
            List<Platos> Menu = new List<Platos> { };
            Console.WriteLine("Introdusca el menu del local:");
            while (true)
            {
                Console.WriteLine("Agregar plato?");
                Console.WriteLine("1)Si");
                Console.WriteLine("2)No");
                string agregar = Console.ReadLine();
                if (agregar != "1" & agregar != "2")
                {
                    Console.WriteLine("Comando invalido");
                    Console.WriteLine("Agregar plato?");
                    Console.WriteLine("1)Si");
                    Console.WriteLine("2)No");
                    agregar = Console.ReadLine();
                }

                if (agregar == "1")
                {
                    Platos plato = CrearPlatos();
                    Menu.Add(plato);
                }
                else
                {
                    break;
                }

            }
            return new Local(Nombre, TiempoEspera, ubicacion, Menu);

        }

    }
}
