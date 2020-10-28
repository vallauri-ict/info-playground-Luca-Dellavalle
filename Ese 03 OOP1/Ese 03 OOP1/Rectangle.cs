using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ese_03_OOP1
{
    class Rectangle
    {
        //lati del triangolo
        private int side1, side2;
        private string descrizione;
        public Color color;
        //il costruttore torna un istanza della classe e non tiene void, int
        public Rectangle(): this(1) //1
        {
            descrizione = "sono un rettangolo";
        }

        public Rectangle(int l) : this(l,l)//2
        {
           
        }

        public Rectangle(int baseRettangolo, int altezzaRettangolo)//3
        {
            side1 = baseRettangolo;
            side2 = altezzaRettangolo;
        }

        public string getSide() {
            return "Base: "+side1.ToString() + " Altezza: " + side2.ToString();
        }
    }
}
