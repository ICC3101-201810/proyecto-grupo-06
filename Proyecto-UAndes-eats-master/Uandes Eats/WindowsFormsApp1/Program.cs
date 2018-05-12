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
            List<Platos> m1 = new List<Platos>();
            List<Platos> m2 = new List<Platos>();
            Platos p1 = new Platos("Sushi", "10 piezas de sushi con camarón, queso crema y pepino", 2490);
            Platos p2 = new Platos("Handroll", "Roll de sushi tempura con queso crema, cebollin y pollo", 1790);
            Platos p3 = new Platos("Fideos Bolognesa", "Fideos con salsa bolognesa", 1890);
            Platos p4 = new Platos("Media Luna con queso", "Media luna con jamón y queso", 2190);
            m1.Add(p1);
            m1.Add(p2);
            m1.Add(p3);
            m1.Add(p4);
            Platos p5 = new Platos("Ave Pimentón", "Sandwich de pasta de pollo con pimentón molido", 1590);
            Platos p6 = new Platos("Empanada napolitana", "Empanada con jamón, tomate y queso", 1190);
            Platos p7 = new Platos("Brownie", "Brownie de chocolate y nuez", 590);
            m2.Add(p5);
            m2.Add(p6);
            m2.Add(p7);
            Local l1 = new Local("Cafetería Biblioteca", "30 minutos", "Biblioteca", m1);
            Local l2 = new Local("Cafetería Humanidades", "25 minutos", "Edificio Humanidades", m2);
            locales.Add(l1);
            locales.Add(l2);

            List<Usuarios> usuarios = new List<Usuarios> {new Administradores("Pedro", "Naretto", "19689484-5a", "ppnaretto@miuandes.cl", "74290557", "p"), new Administradores("Joaquin", "Palominos", "19606210-6a", "japalominos@miuandes.cl", "65879598", "j"), new Administradores("Federico", "Gimenez", "18026089-7a","fjgimenez@miuandes.cl", "82341466", "f")};
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
