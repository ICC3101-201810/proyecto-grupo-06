using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uandes_Eats
{
    class Menu
    {
        public List<Menu> Menus;

        public void VerMenu()
        {
            Console.WriteLine("Escriba el local que le interesa:");
            string local = Console.ReadLine();

            IEnumerable<Local> elegir =
                from locales in locales
                where locales.Nombre == local
                select locales;
            //linq para elegir menu de un local

        }

        public bool OrdenarMenu()
        {
            Console.WriteLine("Desea ordenar el menú por menor precio?");
            Console.WriteLine("Si");
            Console.WriteLine("No");
            int respuesta = Console.ReadLine();

            if (respuesta==true) {
                IEnumerable<Plato> ordenar =
                from plato in platos
                orderby plato.Precio
                select plato;
                //ordenar menu por precio ascendente
            }
            else
            {
                Menu.VerMenu;
            }
        }

        public Menu()
        {
            Menu cb = new Menu(p1, p2, p3, p4, p5, p6);
            Menu ch = new Menu(p7, p8, p9, p10, p11);
            Menu ft = new Menu(p12, p13, p14);
            Menu kr = new Menu(p15, p16, p17, p18);
            Menu kc = new Menu(p19, p20, p21, p22);
            Menu sw = new Menu(p23, p24, p25);
            Menu pj = new Menu(p25, p26, p27);
            Menu wa = new Menu(p28, p29, p30);
        }
    }
}