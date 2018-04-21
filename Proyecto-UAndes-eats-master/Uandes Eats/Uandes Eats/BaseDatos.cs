using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Uandes_Eats
{

    class BaseDatos
    {

        List<Local> Locales;
        List<Usuarios> usuarios;

        public void GuardarUsuarios(FileStream TextUsuarios)
        {
            using (var writer = new StreamWriter(@"C:\programs\BaseDeDatosUsuarios.txt"))
            {
                foreach(Usuarios usuario in usuarios)
                {
                    if (usuario is Clientes)
                    {
                        writer.WriteLine($"Clientes,{usuario.Nombre},{usuario.Apellido},{usuario.Rut},{usuario.Mail},{usuario.Telefono},{usuario.Contraseña}");
                    }
                    else if (usuario is Repartidores)
                    {
                        writer.WriteLine($"Repartidores,{usuario.Nombre},{usuario.Apellido},{usuario.Rut},{usuario.Mail},{usuario.Telefono},{usuario.Contraseña}");
                    }
                    else if (usuario is Administradores)
                    {
                        writer.WriteLine($"Administradores,{usuario.Nombre},{usuario.Apellido},{usuario.Rut},{usuario.Mail},{usuario.Telefono},{usuario.Contraseña}");
                    }
                }
            }
        }

        public void ConseguirUsuarios(FileStream TextUsuarios)
        {
            using (StreamReader reader = new StreamReader("BaseDeDatosUsuarios.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (parts[0] == "Clientes")
                    {
                        usuarios.Add(new Clientes(parts[1], parts[2], parts[3], parts[4], parts[5], parts[6]));
                    }
                }
            }
        }

        public void GuardarLocales(FileStream TextLocales)
        {
            using (var writer = new StreamWriter(@"C:\programs\BaseDeDatosUsuarios.txt"))
            {
                foreach (Local local in Locales)
                {
                    string nombre = local.Nombre;
                    string tiempo = local.TiempoEspera;
                    string ubicacion = local.Ubicacion;
                    string menu = "";
                    foreach(Platos plato in local.Menu)
                    {
                        menu += $"{plato.Nombre}-{plato.Descripcion}-{plato.Precio}/";
                    }
                    writer.WriteLine($"{nombre},{tiempo},{ubicacion},{menu}");
                }
            }
        }

        public void ConseguirLocales(FileStream TextLocales)
        {
            using (StreamReader reader = new StreamReader("BaseDeDatosLocales.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    Local local = new Local(parts[0], parts[1], parts[2], new List<Platos> { });
                    string[] platos = parts[3].Split('/');
                    platos.Take(platos.Count() - 1);
                    foreach (string plato in platos)
                    {
                        int precio;
                        string[] datosPlato = plato.Split('-');
                        int.TryParse(datosPlato[2], out precio);
                        local.Menu.Add(new Platos(datosPlato[0], datosPlato[1], precio));
                    }

                }
            }
        }

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
