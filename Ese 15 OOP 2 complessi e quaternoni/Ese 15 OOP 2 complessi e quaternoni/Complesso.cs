using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ese_15_OOP_2_complessi_e_quaternoni
{
    class Complesso
    {
        private double reale = 0, immaginario = 0;

        public Complesso() : this(1)
        {

        }
        public Complesso(double immaginario) : this(1, immaginario)
        {

        }
        public Complesso(double reale, double immaginario)
        {
            Reale = reale;
            Immaginario = immaginario;
        }

        public double Reale { get => reale; set => reale = value; }

        public double Immaginario { get => immaginario; set => immaginario = value; }

        public double Modulo() {
            double somma = Math.Pow(Reale,2) + Math.Pow(Immaginario,2);
            return Math.Sqrt(somma);
        }
    }
}
