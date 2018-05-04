using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;


namespace Uandes_Eats
{
    [Serializable()]
    class Administradores : Usuarios
    {
        public Administradores(string nombre, string apellido, string rut, string mail, string telefono, string contraseña) : base(nombre, apellido, rut, mail, telefono, contraseña)
        {
        }

        public Local AgregarLocal()
        {
            Console.WriteLine("Agregando local:");
            Console.WriteLine("Nombre del local");
            string Nombre = Console.ReadLine();
            Console.WriteLine("Tiempo de espera aprox:");
            string TiempoEspera = Console.ReadLine();
            Console.WriteLine("Ubicacion del local:");
            string Ubicacion = Console.ReadLine();
            Console.WriteLine("Introduzca el menu del local:");
            Local local = new Local(Nombre, TiempoEspera, Ubicacion, new List<Platos> { });
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
                    local.AgregarPlato();
                }
                else
                {
                    break;
                }

            }
            return local;

        }

        public void AgregarPlatoLocal (Local local)
        {
            local.AgregarPlato();
        }
    }
}
