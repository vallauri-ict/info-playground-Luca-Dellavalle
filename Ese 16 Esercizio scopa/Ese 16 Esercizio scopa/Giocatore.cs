using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ese_16_Esercizio_scopa
{
    class Giocatore
    {
        private Mano mano;
        private string nome { get => nome; set => nome = value; }
        private Mano prese;

        public Giocatore(string nome) { 
        
        }

        public List<Carta> Lettura(List<Carta> carte) {

            return carte;
        }

        public List<Carta> Gioca(List<Carta> carte, int indice) {
            for (int i = 0; i < carte.Count - 1; i++)
            {
                if (carte[i] == carte[indice])
                {
                    return carte[i];
                }
            }
        }
    }
}
