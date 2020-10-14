using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ese_04_preparazione_verifica
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

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLbl.Text = "Load File...";
            toolStripProgressBar.Value = 100;

        }

        private void formSecondariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSecondaria fSecondaria = new FormSecondaria();
            fSecondaria.Text = "Form secondaria";
            if (fSecondaria.ShowDialog() == DialogResult.OK) {
                MessageBox.Show(fSecondaria.nome + " - " + fSecondaria.eta);
                txtNomeParent.Text = fSecondaria.nome;
                txtEtaParent.Text = fSecondaria.eta;
            }
            else if (fSecondaria.ShowDialog() == DialogResult.Cancel) {
                MessageBox.Show("operazione annullata");
            }
          
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModalEsci fEsci = new ModalEsci();
            fEsci.Text = "sicuro di uscire ?";
            if (fEsci.ShowDialog() == DialogResult.OK)
            {
                Close();//chiusura finestra
            }
        }

        private void newFigliaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFiglia fFiglia = new FormFiglia();
            fFiglia.Text = "Form figlia";

        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            FormFiglia formFiglia;
        }
    }
}
