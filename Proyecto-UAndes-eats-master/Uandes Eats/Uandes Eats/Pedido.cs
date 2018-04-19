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
            int o = 0;
            List<string> num = new List<string>();
            num.Add("0");
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
                PlatosCliente.Remove(PlatosCliente[resultado]);

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

    }
}
