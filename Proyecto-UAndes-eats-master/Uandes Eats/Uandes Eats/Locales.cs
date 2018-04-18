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

    }
}
