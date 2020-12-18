using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ese_14_OOP_1_persone_studenti
{
    class Studente : Persona
    {
       public List<int> voti = new List<int>();

        public double Media()
        {
            int sommaVoti = 0;
            foreach (var item in voti) {
                sommaVoti += item;
            }
            return (double)sommaVoti/voti.Count;
        }
    }
}
