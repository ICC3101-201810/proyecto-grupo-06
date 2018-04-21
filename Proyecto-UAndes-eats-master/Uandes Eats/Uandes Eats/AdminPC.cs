using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uandes_Eats
{
    
    class AdminPC
    {
        public Repartidores Repartidor;
        public Pedido Pedido;

        public AdminPC(Repartidores repartidor,Pedido pedido)
        {
            Repartidor = repartidor;
            Pedido = pedido;
        }
    }
}
