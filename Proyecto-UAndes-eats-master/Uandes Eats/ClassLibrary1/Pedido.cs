using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;

namespace WindowsFormsApp1
{
    [Serializable()]
    public class Pedido
    {
        public Usuarios Usuario;
        public List<Platos> PlatosCliente;
        public string hora;
        public string minuto;
        public string estado;
        public string repartidor;

        public Pedido(List<Platos> platos, Usuarios usuario, string hora, string minuto, string estado, string repartidor)
        {
            Usuario = usuario;
            PlatosCliente = platos;
            this.hora = hora;
            this.minuto = minuto;
            this.estado = estado;
            this.repartidor = repartidor;

        }

        public void CambiarEstado(string nuevoEstado)
        {
            estado = nuevoEstado;           
        }
        public void CambiarRepartidor(string nuevorepartidor)
        {
            repartidor = nuevorepartidor;
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
                total += i.Precio;
            }
            Console.WriteLine("El total de su pedido es: " + total);
            if (total != 0)
            {
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
            else
            {
                Console.WriteLine("No hay nada que pagar");
                return false;
            }
        }
        public AdminPC VincularRepPed(List<RepartidoresActivos> RepartidoresActivos, Pedido pedido)
        {
            List<RepartidoresActivos> RepartidoresPorTiempo = RepartidoresActivos.OrderBy(rep => rep.Time1).ToList();
            RepartidoresActivos activo1 = RepartidoresPorTiempo[0];
            AdminPC vinculado = new AdminPC(activo1.Repartidores1, pedido);
            Console.WriteLine("Su repartidor ya fue vinculado");
            Console.WriteLine("Su nombre es: " + vinculado.Repartidor.Nombre + " " + vinculado.Repartidor.Apellido);
            Console.WriteLine("Su telefono es: " + vinculado.Repartidor.Telefono);
            return vinculado;
        }

        public int CalcularTotal()
        {
            int total = 0;
            foreach (Platos i in PlatosCliente)
            {
                total=total + i.Precio;
                
            }
            return total;
        }
    }
}
