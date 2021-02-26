using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ese_25_Primo_esercizio_dispense_mana
{
    //dichiarazione delegato
    public delegate void salvataggioEseguitoEventHandler(int id);

    class GestoreSalvataggio
    {
        //dichiaro l'evento
        public event salvataggioEseguitoEventHandler salvataggioEseguito;
        
        public void salvaSuFile(int id) {

            MessageBox.Show("Sto eseguendo il salvataggio");

            salvataggioEseguito(id);
        }
    }
}
