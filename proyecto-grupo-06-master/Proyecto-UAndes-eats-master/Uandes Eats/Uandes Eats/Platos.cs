using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uandes_Eats
{
    class Platos
    {
        public string Nombre;
        public string Descripcion;
        public int Precio;

        public Platos(string nombre, string descripcion, int precio)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            Precio = precio;
        }

        public void CrearPlatos() {
            Plato p1 = new Plato("Sushi","10 piezas de sushi con camarón, queso crema y pepino","2490");
            Plato p2 = new Plato("Handroll", "Roll de sushi tempura con queso crema, cebollin y pollo", "1790");
            Plato p3 = new Plato("Fideos Bolognesa", "Fideos con salsa bolognesa", "1890");
            Plato p4 = new Plato("Media Luna con queso", "Media luna con jamón y queso", "2190");
            Plato p5 = new Plato("Ave Pimentón", "Sandwich de pasta de pollo con pimentón molido", "1590");
            Plato p6 = new Plato("Empanada napolitana", "Empanada con jamón, tomate y queso", "1190");
            Plato p7 = new Plato("Brownie", "Brownie de chocolate y nuez", "590");
            Plato p8 = new Plato("Galletón", "Galletón de avena con chips de chocolate", "790");
            Plato p9 = new Plato("Cheeseburger", "Hamburguesa con queso", "1690");
            Plato p10 = new Plato("Lomito Italiano", "Lomito con palta, tomate y mayonesa", "1590");
            Plato p11 = new Plato("Puré con Cerdo", "Chuleta de cerdo con puré de papas", "1890");
            Plato p12 = new Plato("Café Grande", "Café de 500 ml", "1390");
            Plato p13 = new Plato("Café Chico", "Café de 250 ml", "990");
            Plato p14 = new Plato("Ensalada Mixta", "Ensalada con lechuga, acelga, palta, tomate, palmito y pollo", "2490");
            Plato p15 = new Plato("Fideos Alfredo", "Fideos con salsa alfredo", "1790");
            Plato p16 = new Plato("Arroz con Pollo", "Arroz Blanco con tuto de pollo", "1890");
            Plato p17 = new Plato("Coca-Cola", "Coca-Cola de 350 ml", "590");
            Plato p18 = new Plato("Agua Mineral", "Agua Mineral", "790");
            Plato p19 = new Plato("Chaparrita", "Chaparrita con queso y vienesa", "1190");
            Plato p20 = new Plato("Hot Dog Italiano", "Hot Dog de 20 cm con tomate, palta y mayonesa", "1590");
            Plato p21 = new Plato("Gohan Mixto", "Gohan con palta, salmón y queso crema", "3490");
            Plato p22 = new Plato("Atún", "Sub a base de atún con lechuga, tomate y mozarella", "2990");
            Plato p23 = new Plato("Teriyaki", "Sub con pollo teriyaki con queso chedar, tomate y jalapeños", "3990");
            Plato p24 = new Plato("Albondigas", "Sub con albondigas, salsa, chipotle y queso chedar", "2690");
            Plato p25 = new Plato("Margarita", "Pizza con queso y tomate", "6990");
            Plato p26 = new Plato("3 Carnes", "Pizza con tocino, chorizillo y carne", "8990");
            Plato p27 = new Plato("Peperonni", "Pizza con peperonni y doble queso", "7990");
            Plato p28 = new Plato("Full", "Hamburguesa con lechuga, cebolla, tomate, pepinillos, mayonesa y doble carne", "5990");
            Plato p29 = new Plato("Veggie", "Hamburguesa de porotos y zanahoria con cebolla, lechuga, mayonesa y tomate", "4490");
            Plato p30 = new Plato("Bacon", "Hamburguesa con carne, queso chedar, tocino y salsa BBQ", "4990");
         //platos de cada local
        }

    }
}
