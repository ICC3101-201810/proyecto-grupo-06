using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uandes_Eats
{
    class Pedido
    {
        Usuarios Usuario;
        List<Platos> PlatosCliente;
        public Pedido(List<Platos> platos, Usuarios usuario)
        {
            Usuario = usuario;
            PlatosCliente = platos;

        }


        public void VerPedido()
        {
            int resultado;
            int o = 1;
            List<string> num = new List<string>();
            num.Add("0");

            Console.WriteLine("Ingrese el numero de un plato si lo quiere quitar del pedido:");
            Console.WriteLine("Ingrese 0 si quiere volver al menu");
            foreach (Platos i in PlatosCliente)
            {
                Console.WriteLine(o + ".- " + i.Nombre);
                num.Add(o.ToString());
                o++;

            }
            string resultadoS = Console.ReadLine();
            while (num.Contains(resultadoS) == false)
            {
                int o1 = 1;
                Console.WriteLine("Comando inválido");

                Console.WriteLine("Ingrese el numero de un plato si lo quiere quitar del pedido:");
                foreach (Platos i in PlatosCliente)
                {
                    Console.WriteLine(o1 + ".- " + i.Nombre);
                    o1++;
                }
                resultadoS = Console.ReadLine();
            }
            int.TryParse(resultadoS, out resultado);
            if (resultado == 0)
            {
                
            }
            else
            {
                PlatosCliente.Remove(PlatosCliente[resultado-1]);

            }

        }
        public void AgregarAlPedido(Platos plato)
        {
            PlatosCliente.Add(plato);

        }
        public void EliminarDelPedido(Platos plato)
        {
            PlatosCliente.Remove(plato);
        }
        public bool TerminarPedido()
        {
            int total = 0;
            foreach (Platos i in PlatosCliente)
            {
                total = +i.Precio;
            }
            Console.WriteLine("El total de su pedido es: " + total);
            Console.WriteLine("Ingrese 1 si quire empezar busqueda de repartidor, y 0 si quiere volver al menu");
            string ya = Console.ReadLine();
            while (true)
            {
                if (ya == "1" || ya == "0")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Intente Nuevamente");
                    ya = Console.ReadLine();

                }
            }
            if (ya == "1")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public AdminPC VincularRepPed(List<RepartidoresActivos> RepartidoresActivos, Pedido pedido)
        {
            List<RepartidoresActivos> RepartidoresPorTiempo = RepartidoresActivos.OrderBy(rep => rep.Time1).ToList();
            RepartidoresActivos activo1 = RepartidoresPorTiempo[0];
            AdminPC vinculado = new AdminPC(activo1.Repartidores1, pedido);
            return vinculado;
        }
    }
}
