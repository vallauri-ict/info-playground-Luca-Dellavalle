using System;
{
}
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ese_13_Ereditarietà
{
    class Mostro
    {
        protected double punti;
        protected string verso;
        public Mostro() {
            punti = 25;
            verso = "grugnito";
        }

        public double Valore()
        {
            return punti;
        }

        public string Verso() 
        {
            return verso;
        }

        public Mostro() : this(0){

        }
        public Mostro(int q) {
            this.punti = q;
        }
    }
}
