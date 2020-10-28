using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ese_03_OOP1
{
     class Fatture
    {
        private static int cntFatture = 0;
        public readonly int nFattura;

        public Fatture() {
            cntFatture++;
            this.nFattura = cntFatture;
        }

        public static void visualizza() {
            System.Windows.Forms.MessageBox.Show("Numero fatture eseguite: "+cntFatture); //OK
            //funziona solo senza static
            //System.Windows.Forms.MessageBox.Show("Numero fatture corrente: " + this.nFatture); //NONOK ()
        }
    }
}
