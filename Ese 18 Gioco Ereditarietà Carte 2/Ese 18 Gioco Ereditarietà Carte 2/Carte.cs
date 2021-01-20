using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ese_18_Gioco_Ereditarietà_Carte_2
{
    class Carte
    {
        public string Valore { get; set; }

        public string Seme { get; set; }

        public Carte(string valore, string seme)
        {
            Valore = valore;
            Seme = seme;
        }

        public string[] val = {"Asso","2","3","4","5","6","7","Fante","Regina","Re" };
        public string[] semi = {"Cuore", "Picche", "Fiore", "Quadri"};

        public void Proponi() {
            
        }



    }
}
