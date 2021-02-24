using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ese_24_Primo_esempio_Delegate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Dichiarazione del delegate che accetta 2 parametri interi
        //e restituisce un valore intero
        public delegate int Operazione(int a, int b);

        //dichiaro le 3 funzioni che utilizzerò con il delegate

        public int Somma(int x, int y) {
            return x + y;
        }

        public int Sottrazione(int x, int y) {
            return x - y;
        }

        public int Prodotto(int x, int y)
        {
            return x * y;
        }

        private void btnSomma_Click(object sender, EventArgs e)
        {
            //PRIMO METODO per usare un delegate
            //istanzio il delegate e come parametro passo il nome della funzione
            Operazione op = new Operazione(Somma);//somma è la funzione puntata dal delegate

            //richiamo il delegate che eseguirà la funzione somma
            MessageBox.Show("Somma="+op(10,15));
        }

        private void btnProdotto_Click(object sender, EventArgs e)
        {
            //SECONDO METODO istanzion il delegato
            Operazione op = Prodotto; //identica alla prima Operazione

            //richiamo il delegate che eseguirà la funzione prodotto
            MessageBox.Show("Prodotto=" + op(10, 15));
        }
    }
}
