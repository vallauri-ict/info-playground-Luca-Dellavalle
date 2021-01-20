using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ese_18_Gioco_Ereditarietà_Carte_2
{
     class MazzoCarte
    {
        private int indice { get; set; }
        List<Carte> carte = new List<Carte>{};

        public void InserisciCarta() {
            if (carte.Count() == 0) {
                carte.Add();
            }
        
        }

    }
}
