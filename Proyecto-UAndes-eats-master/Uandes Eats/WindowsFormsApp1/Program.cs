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
                using (Stream stream = File.Open("DatosLocales.bin", FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();

                    locales = (List<Local>)bin.Deserialize(stream);
                }
            }
            catch (IOException)
            {
            }

            List<Usuarios> usuarios = new List<Usuarios> { new Administradores("Pedro", "Naretto", "19689484-5a", "ppnaretto@miuandes.cl", "74290557", "p"), new Administradores("Joaquin", "Palominos", "19606210-6a", "japalominos@miuandes.cl", "65879598","j")};
            try
            {
                using (Stream stream = File.Open("DatosUsuarios.bin", FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();

                    usuarios = (List<Usuarios>)bin.Deserialize(stream);
                }
            }
            catch (IOException)
            {
            }


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(usuarios, locales));

            try
            {
                using (Stream stream = File.Open("DatosLocales.bin", FileMode.Create))
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
                using (Stream stream = File.Open("DatosUsuarios.bin", FileMode.Create))
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
