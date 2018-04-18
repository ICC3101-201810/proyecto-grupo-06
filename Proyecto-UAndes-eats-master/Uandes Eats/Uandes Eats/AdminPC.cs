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
        public AdminPC(Repartidores repartidor,Pedido pedido)
        {
            Repartidor = repartidor;
            Pedido = pedido;
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
}
