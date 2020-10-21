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
        public FormFiglia ff ;

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
            //toolStripProgressBar.Value = 100;

        }

        FormSecondaria fSecondaria = new FormSecondaria();
        private void formSecondariaToolStripMenuItem_Click(object sender, EventArgs e)
        {  
            fSecondaria.Text = "Form secondaria";
            if (fSecondaria.ShowDialog() == DialogResult.OK) {
                MessageBox.Show(fSecondaria.nome + " - " + fSecondaria.eta);
                txtNomeParent.Text = fSecondaria.nome;
                txtEtaParent.Text = fSecondaria.eta;
            }
            else if (fSecondaria.ShowDialog() == DialogResult.Cancel) {
                MessageBox.Show("operazione annullata");
            }

            toolStripStatusLbl.Text = "New secondaria";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLbl.Text = "USCITA!!!!";
            ModalEsci fEsci = new ModalEsci();
            fEsci.Text = "sicuro di uscire ?";
            if (fEsci.ShowDialog() == DialogResult.OK)
            {
                Close();//chiusura finestra
            }
        }
        
        private void newFigliaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLbl.Text = "New Figlia";
            //passo la textbox alla form figlia
            ff = new FormFiglia(txtModifica);
            ff.Text = "Form figlia";
            ff.Show();
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            ff.TxtValue = txtModifica.Text; //dovrebbe richiamare il set di txtValue
        }

        private void newMDIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLbl.Text = "New MDI";
            fMdi MDI = new fMdi();
            MDI.MdiParent = this;
            MDI.StartPosition = FormStartPosition.Manual;
            MDI.Location = new Point(10, 100);
            MDI.Show();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLbl.Text = "New";
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLbl.Text = "Save";
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Produttore: Luca Dellavalle \n 16/10/2020");
        }
    }
}


