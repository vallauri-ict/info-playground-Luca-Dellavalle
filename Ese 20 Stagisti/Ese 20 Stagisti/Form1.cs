using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ese_20_Stagisti
{
    public partial class Form1 : Form
    {
        clsElenco elencoStudenti;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            elencoStudenti = new clsElenco();
        }

        private void btnInserisci_Click(object sender, EventArgs e)
        {
            clsAlunno stu;
            //trim toglie gli spazi
            if (txtOreStage.Text.Trim() == "")
            {
                stu = new clsAlunno(txtNome.Text, txtCognome.Text, txtCittà.Text, cmbClasse.SelectedItem.ToString(), cmbSezione.SelectedItem.ToString(), cmbSpec.SelectedItem.ToString());
            }
            else {
                stu = new clsStagista(txtNome.Text, txtCognome.Text, txtCittà.Text, cmbClasse.SelectedItem.ToString(), cmbSezione.SelectedItem.ToString(), cmbSpec.SelectedItem.ToString()
                    ,cmbAzienda.SelectedItem.ToString(),txtOreStage.Text);
                btnRicerca.Enabled = true;
            }
            elencoStudenti.inserisci(stu);
            elencoStudenti.visualizzaDGV(dgvStagisti);
            pulisciCampi();
        }

        private void pulisciCampi()
        {
            foreach (Control c in Controls)
            {
                //tutti elementi della form
                if (c is TextBox) {
                    ((TextBox)c).Text = "";
                    TextBox txt = (TextBox)c;
                    txt.Text = "";
                }
                if (c is ComboBox) {
                    ((ComboBox)c).SelectedIndex = -1;
                }

            }
        }

        private void btnRicerca_Click(object sender, EventArgs e)
        {
            string azienda = cmbAzienda.SelectedIndex.ToString();
            int ore = elencoStudenti.OreAzienda(azienda);

            if (ore != 0) {
                MessageBox.Show("Gli stagisti hanno effettuato " + ore + " ore in " + azienda, "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                MessageBox.Show("Non è stata effettuata alcuna ora in " + azienda, "information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }
    }
}
