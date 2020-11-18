using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ese_11_coda_gestione_pronto_soccorso
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public struct Paziente 
        {
            public string nome;
            public int età;
            public string colore;
        }
        Queue<Paziente> codRosso = new Queue<Paziente>();
        Queue<Paziente> codGiallo = new Queue<Paziente>();
        Queue<Paziente> codVerde = new Queue<Paziente>();
        Queue<Paziente> codBianco = new Queue<Paziente>();
        // gestione : rosso giallo verde bianco 

        private void btnRegistra_Click(object sender, EventArgs e)
        {
            Paziente p;
            p.nome = txtNome.Text;
            p.età = Convert.ToInt32(txtEtà.Text);
            p.colore = txtCodice.Text;

            switch (txtCodice.Text)
            {
                case "rosso":
                    codRosso.Enqueue(p);
                    break;
                case "giallo":
                    codGiallo.Enqueue(p);
                    break;
                case "verde":
                    codVerde.Enqueue(p);
                    break;
                case "bianco":
                    codBianco.Enqueue(p);
                    break;
            }
            MessageBox.Show("paziente aggiunto ");
            txtNome.Text = "";
            txtEtà.Text = "";
            txtCodice.Text = "";
        }

        private void btnDaVisitare_Click(object sender, EventArgs e)
        {
            lblPaziente.Text = "";
            if (codRosso.Count != 0)
            {
                lblPaziente.Text = codRosso.Peek().nome +" "+ codRosso.Peek().età + " - codice: " + codRosso.Peek().colore;
                codRosso.Dequeue();
            }
            else if (codGiallo.Count != 0)
            {
                lblPaziente.Text = codGiallo.Peek().nome + " " + codGiallo.Peek().età + " - codice: " + codGiallo.Peek().colore;
                codGiallo.Dequeue();
            }
            else if (codVerde.Count != 0)
            {
                lblPaziente.Text = codVerde.Peek().nome + " " + codVerde.Peek().età + " - codice: " + codVerde.Peek().colore;
                codVerde.Dequeue();
            }
            else 
            {
                if (codBianco.Count != 0) {
                    lblPaziente.Text = codBianco.Peek().nome + " " + codBianco.Peek().età + " - codice: " + codBianco.Peek().colore;
                    codBianco.Dequeue();
                }
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

       
    }
}
