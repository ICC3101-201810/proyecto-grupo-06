using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            List<Local> locales = new List<Local> { };
            try
            {
                using (Stream stream = File.Open("../../archivos/DatosLocales.bin", FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();

                    locales = (List<Local>)bin.Deserialize(stream);
                }
            }
            catch (IOException)
            {
            }

            List<Usuarios> usuarios = new List<Usuarios> { };
            try
            {
                using (Stream stream = File.Open("../../archivos/DatosUsuarios.bin", FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();

                    usuarios = (List<Usuarios>)bin.Deserialize(stream);
                }
            }
            catch (IOException)
            {
            }

            List<Pedido> pedidos = new List<Pedido> { };

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(usuarios, locales, pedidos));

            try
            {
                using (Stream stream = File.Open("../../archivos/DatosLocales.bin", FileMode.OpenOrCreate))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, locales);
                }
            }
            catch (IOException)
            {
            }

            try
            {
                using (Stream stream = File.Open("../../archivos/DatosUsuarios.bin", FileMode.OpenOrCreate))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, usuarios);
                }
            }
            catch (IOException)
            {
            }
        }
    }
}
