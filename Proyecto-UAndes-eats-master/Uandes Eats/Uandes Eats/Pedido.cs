using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uandes_Eats
{
    class Pedido
    {
        public List<Pedido> Pedidos;

        public void RealizarPedido()
        {
            Console.WriteLine("Elija uno de nuestros locales:");
            Console.WriteLine("Dentro de la Universidad: ");
            Console.WriteLine("1) Local 1 ");
            Console.WriteLine("2) Local 2 ");
            Console.WriteLine("3) Local 3 ");
            Console.WriteLine("4) Local 4 ");
            Console.WriteLine("5) Local 5 ");
            Console.WriteLine("6) Local 6 ");
            Console.WriteLine("7) Local 7 ");
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
