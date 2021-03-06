﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;

namespace WindowsFormsApp1
{
    [Serializable()]
    public abstract class Usuarios
    {
        public string Nombre;
        public string Apellido;
        public string Rut;
        public string Mail;
        public string Telefono;
        public string Contraseña;

        protected Usuarios(string nombre, string apellido, string rut, string mail, string telefono, string contraseña)
        {
            Nombre = nombre;
            Apellido = apellido;
            Rut = rut;
            Mail = mail;
            Telefono = telefono;
            Contraseña = contraseña;
        }
    }
}
