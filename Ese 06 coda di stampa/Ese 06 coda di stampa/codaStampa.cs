using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ese_06_coda_di_stampa
{
    class codaStampa
    {

        public void invia(Form1.libro l, System.Windows.Forms.DataGridView dataGridStampa) {
            try
            {
                if (String.IsNullOrWhiteSpace(l.titolo) || (String.IsNullOrWhiteSpace(l.autore)))
                {
                    throw new Exception("Dati in input errati");
                }
                else
                {
                    
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}
