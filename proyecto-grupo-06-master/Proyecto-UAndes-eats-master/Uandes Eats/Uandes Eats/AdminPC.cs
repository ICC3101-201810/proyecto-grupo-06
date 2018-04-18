using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uandes_Eats
{
    class AdminPC
    {
        Repartidores Repartidor;
        Pedido Pedido;
        Local Local;

        public AdminPC(Repartidores repartidor,Pedido pedido, Local local)
        {
            Repartidor = repartidor;
            Pedido = pedido;
            Local=local;
        }

        public AdminPC AgregarLocal(Local local)
        {
            Console.WriteLine("Por favor ingresar los siguientes datos:");
            Console.WriteLine("Nombre del local");
            string nombre = Console.ReadLine();
            Console.WriteLine("Tiempo de Espera Promedio");
            string tiempoespera = Console.ReadLine();
            Console.WriteLine("Dirección");
            string direccion = Console.ReadLine();

            Local l = new Local(nombre,tiempoespera,direccion);
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
