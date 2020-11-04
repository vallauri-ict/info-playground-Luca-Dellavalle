using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ese_06_coda_di_stampa
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

        public struct libro
        {
            public string titolo;
            public string autore;
        }

        string[] libri = new string[10];
        string msg = "";
        Queue<libro> codaLibri = new Queue<libro>();
        private void btnCoda_Click(object sender, EventArgs e)
        {
            libro l;
            l.titolo = txtTitolo.Text;
            l.autore = txtAutore.Text;

            codaLibri.Enqueue(l);
            MessageBox.Show("inserimento in coda di stampa");
            msg += " "+ l.titolo+" "+l.autore+" \n";
            MessageBox.Show("coda: " + msg);
        }

        private void btnStampa_Click(object sender, EventArgs e)
        {
            libro libroDaTogliere = codaLibri.Peek();

        }
    }
}
