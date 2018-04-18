using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uandes_Eats
{
    class Pedido
    {
        Clientes Cliente;
        List<Platos> Platos;

        public Pedido(List<Platos> platos, Clientes cliente)
        {
            Cliente = cliente;
            Platos = platos;
        }

        

        public void RealizarPedido()
        {
            Console.WriteLine("Elija uno de nuestros locales:");
            Console.WriteLine("Dentro de la Universidad: ");
            Console.WriteLine("1) Foodtruck Futbolito ");
            Console.WriteLine("2) Cafetería Reloj");
            Console.WriteLine("3) Cafetería Biblioteca ");
            Console.WriteLine("4) Cafetería Humanidades ");
            Console.WriteLine("5) Kiosko Reloj ");
            Console.WriteLine("6) Foodtruck Ingeniería ");
            Console.WriteLine("7) Kiosko Ciruelos ");
            Console.WriteLine("Fuera de la Universidad:");
            Console.WriteLine("8) Papa Johns ");
            Console.WriteLine("9) Subway ");
            Console.WriteLine("10) Wallys ");
            Console.WriteLine("0) Salir ");
            
            RealizarPedido.Add(new Pedido(Nombre, Apellido, Telefono));
        }

        public void VerPedido()
        {

        }
        public Pedido(string telefono, string apellido, string nombre)
        {

        }
    }
}
