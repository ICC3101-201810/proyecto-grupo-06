using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class WebPay
    {
        Usuarios Usuarios;
        int Total;
        public WebPay(Usuarios usuarios, int total)
        {
            Usuarios = usuarios;
            Total = total;
        }
        public void PagoWebpay()
        {
            Console.WriteLine("Escoja metodo de pago");
            Console.WriteLine("1.- Si es Débito, 2.- Si es Crédito, 3.- Si es Efectivo");
            string Pago = Console.ReadLine();
            while (true)
            {
                if (Pago == "1" || Pago == "2" || Pago == "3")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("1.- Si es en efectivo, 2.- Si es Crédito, 3.- Si es Efectivo");
                    Pago = Console.ReadLine();
                }
            }
            if (Pago == "1" || Pago == "3")
            {
                Console.WriteLine("Ahora tienes que tratar con el repartidor, exitoo");
            }
            else if (Pago == "2")
            {
                Console.WriteLine("Total: $" + Total);
                Console.WriteLine("Comercio: UandesEats");
                Console.WriteLine("Numero de tarjeta:");
                string NDT = Console.ReadLine();
                while (true)
                {
                    Console.WriteLine("¿Está seguro que el numero de la tarjeta es: "+NDT+" ?, 1.- Si esta seguro , 2.- No esta seguro");
                    string seguro = Console.ReadLine();
                    if (seguro== "1")
                    {
                        break;
                    }
                    else if (seguro == "2")
                    {
                        NDT = Console.ReadLine();
                    }                    
                }
                Console.WriteLine("Mes de vencimiento de la Tarjeta:");
                string MDV = Console.ReadLine();
                while (true)
                {
                    Console.WriteLine("¿Está seguro que el mes de vencimiento de la tarjeta es: " + MDV + " ?, 1.- Si esta seguro , 2.- No esta seguro");
                    string seguro = Console.ReadLine();
                    if (seguro == "1")
                    {
                        break;
                    }
                    else if (seguro == "2")
                    {
                        MDV = Console.ReadLine();
                    }
                }
                Console.WriteLine("Año de vencimiento de la tarjeta:");
                string ADV = Console.ReadLine();
                while (true)
                {
                    Console.WriteLine("¿Está seguro que el año de vencimiento de la tarjeta es: " + ADV + " ?, 1.- Si esta seguro , 2.- No esta seguro");
                    string seguro = Console.ReadLine();
                    if (seguro == "1")
                    {
                        break;
                    }
                    else if (seguro == "2")
                    {
                        MDV = Console.ReadLine();
                    }
                }
                Console.WriteLine("¿Cuotas?, 1.- Si, 2.- No");
                string Cuotas = Console.ReadLine();
                while (true)
                {
                    if (Cuotas == "1" || Cuotas == "2")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("¿Cuotas?, 1.- Si, 2.- No");
                        Pago = Console.ReadLine();
                    }
                }
                if (Cuotas == "1")
                {
                    Console.WriteLine("¿Cuántas?");
                    int numeroCuotas= Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Entonces cada cuota es de: $" + Total / numeroCuotas);
                }
                else
                {
                    Console.WriteLine("Entonces su total es:" + Total);
                }
                Console.WriteLine("Esperando Confirmación...");
                Console.WriteLine("...");
                Console.WriteLine("...");
                Console.WriteLine("...");
                Console.WriteLine("...");
                Console.WriteLine("...");
                Console.WriteLine("...");
                Console.WriteLine("...");
                Console.WriteLine("...");
                Console.WriteLine("...");
                Console.WriteLine("Felicidades su transaccion se realizo con exito");


            }
        }
    }


}
