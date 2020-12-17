using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ese_15_OOP_2_complessi_e_quaternoni
{
    class Complesso
    {
        private double reale, immaginario;

        public double NumeroComplesso() {
            double x = 0;
            return x;
        }
        public double NumeroComplesso(double a)
        {
            double x = 0;
            return x;
        }
        public double NumeroComplesso(double a, double b)
        {
            double x = 0;
            return x;
        }
        public string get() {

            string strNumeri = reale + " " + immaginario;
            return strNumeri;
        }
        public double modulo() {
            reale = Math.Pow(2, reale);
            immaginario = Math.Pow(2,immaginario);
            return Math.Sqrt(reale + immaginario);
        }
        public double coniugato()
        {

        }
}
