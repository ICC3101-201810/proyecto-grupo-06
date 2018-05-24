using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace WindowsFormsApp1
{

    class BaseDatos
    {

        List<Local> locales;
        List<Usuarios> usuarios;
        List<Pedido> pedidos;

        public List<Local> DesLocales()
        {
            try
            {
                using (Stream stream = File.Open("../../ArchivosData/DatosLocales.bin", FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();

                    locales = (List<Local>)bin.Deserialize(stream);
                }
            }
            catch (IOException)
            {
            }
            return locales;
        }

        public List<Usuarios> DesUsuarios()
        {
            try
            {
                using (Stream stream = File.Open("../../ArchivosData/DatosUsuarios.bin", FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();

                    usuarios = (List<Usuarios>)bin.Deserialize(stream);
                }
            }
            catch (IOException)
            {
            }
            return usuarios;
        }

        public List<Pedido> DesPedidos()
        {
            try
            {
                using (Stream stream = File.Open("../../ArchivosData/DatosPedidos.bin", FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();

                    pedidos = (List<Pedido>)bin.Deserialize(stream);
                }
            }
            catch (IOException)
            {
            }
            return pedidos;
        }

        public void SerLocales()
        {
            try
            {
                using (Stream stream = File.Open("../../ArchivosData/DatosLocales.bin", FileMode.OpenOrCreate))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, locales);
                }
            }
            catch (IOException)
            {
            }
        }

        public void SerUsuarios()
        {
            try
            {
                using (Stream stream = File.Open("../../ArchivosData/DatosUsuarios.bin", FileMode.OpenOrCreate))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, usuarios);
                }
            }
            catch (IOException)
            {
            }
        }

        public void SerPedidos()
        {
            try
            {
                using (Stream stream = File.Open("../../ArchivosData/DatosPedidos.bin", FileMode.OpenOrCreate))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, pedidos);
                }
            }
            catch (IOException)
            {
            }
        }
    }
}
