using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ese_17_Esercizio_calsse_astratta
{
    class ElencoStudenti : Report
    {
        List<Studente> lstStudenti = new List<Studente>();
        public string stampa = "";

        protected override void printBody()
        {
            foreach (var studente in lstStudenti)
            {
                stampa += studente.nomeCompleto()+"\n";
            }
        }

        protected override void printFooter()
        {
            stampa += "FOOTER STAMPA STUDENTI \n";
        }

        protected override void printHeader()
        {
            stampa += "INTESTAZIONE STAMPA STUDENTI \n";
        }

        public ElencoStudenti() {
            lstStudenti.Add(new Studente("Andrea","Giaccardi"));
            lstStudenti.Add(new Studente("Sergio", "Grosso"));

        }
    }
}
