using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ese_16_Esercizio_scopa
{
    class Mazzo : Carta
    {
        public struct Carte {
            public int attrCarta;
        }
        public List<Carte> carte ;
        

        public Mazzo() {
            for (int i = 0; i < 40; i++)
            {
                Carte card;
                card.attrCarta = i;
                carte.Add(card);
            }
        }

        public void Mescola()
        {

        }

        public void Estrai()
        {

        }
    }
}
