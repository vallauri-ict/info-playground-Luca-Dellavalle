using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.IO;

namespace Ese_08_Form_di_registrazione_regex
{
    class registrazione
    {
        internal static void controllo(string cognome, string nome, string indirizzo, string città, string cap, string mail, string codFisc, string user, string pwd)
        {
            StreamWriter sw = new StreamWriter("Clienti.txt", false);
            string x = "";
            x += cognome + " - " + nome + " - " + indirizzo + " - " + città + " - " + cap + " - " + mail + " - " + codFisc + " - " + user + " - " + pwd;
            sw.WriteLine(x);
            sw.Close();
        }
    }

}
