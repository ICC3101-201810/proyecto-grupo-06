﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uandes_Eats
{
    class Local
    {
        public string nombre;
        public string tiempodeespera;
        public string ubicacion;
        public List<Platos> Menu;

        List<Local> locales = new List<Local>
        {
        Local l1 = new Local("Cafetería Biblioteca", "30 minutos", "Biblioteca");
        Local l2 = new Local("Cafetería Humanidades", "25 minutos", "Edificio Humanidades");
        Local l3 = new Local("FoodTruck", "5 minutos", "Al frente entrada a Ingeniería");
        Local l4 = new Local("Kiosko Reloj", "10 minutos", "Primer Piso Edificio Reloj");
        Local l5 = new Local("Kiosko Ciruelos", "10 minutos", "Patio los Ciruelos");
        Local l6 = new Local("Subway", "20 minutos", "Camino el Alba 12620");
        Local l7 = new Local("Papa Johns", "40 minutos", "Camino el Alba 12620");
        Local l8 = new Local("Wally´s", "30 minutos", "Camino el Alba 12620");
        }   

        public Local(string nombre, int tiempodeespera, string ubicacion, List<Platos> menu)
        {
            this.nombre = nombre;
            this.tiempodeespera = espera;
            this.ubicacion = ubicacion;
            this.Menu = menu;
        }

        public void DatosLocal()
        {
            IEnumerable<Local> ordenar =
                 from locales in locales
                 orderby locales.tiempodeespera
                 select locales;
            //linq locales con tiempo de espera ascendente
        }
    }
}
