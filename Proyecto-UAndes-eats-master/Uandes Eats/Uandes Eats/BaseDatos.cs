using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uandes_Eats
{
    class BaseDatos
    {
        List<Local> Locales;
        List<Usuarios> usuarios;

        public void VerLocales()
        {
            int indice;
            int x = 1;
            while (true)
            {
                foreach (Local local in Locales)
                {
                    Console.WriteLine($"{x}){local.Nombre}");
                    x++;
                }
                Console.WriteLine($"{x})Volver al menu inicial");
                do
                {
                    try
                    {
                        int.TryParse(Console.ReadLine(), out indice);
                    }
                    catch
                    {
                        Console.WriteLine("Comando invalido");
                        x = 1;
                        foreach (Local local in Locales)
                        {
                            Console.WriteLine($"{x}){local.Nombre}");
                            x++;
                        }
                        Console.WriteLine($"{x})Volver al menu inicial");
                        indice = -1;
                    }

                } while (indice < 0 & indice > x);

                if (indice != x)
                {
                    Locales[indice - 1].VerMenu();

                }
                else if (indice == x)
                {
                    break;
                }
            }
        }
    }
}
