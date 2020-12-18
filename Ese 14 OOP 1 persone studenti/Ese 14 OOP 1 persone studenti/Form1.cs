using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ese_14_OOP_1_persone_studenti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Studente> lstStudenti = new List<Studente>();
        private void btnCaricaLista_Click(object sender, EventArgs e)
        {
            Studente s = new Studente();
            s.SetAttributs(txtNome.Text, txtCognome.Text, txtSesso.Text, Convert.ToInt32(txtEta.Text));
            lstStudenti.Add(s);
            listView.Items.Add(s.GetCognome());
        }

        private void btnInserisciVoto_Click(object sender, EventArgs e)
        {
            string cognome = listView.SelectedItems[0].Text;
            foreach (Studente item in lstStudenti)
            {
                if (item.GetCognome() == cognome)
                {
                    item.voti.Add(Convert.ToInt32(txtVoto.Text));
                }
            }
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnVisualizza_Click(object sender, EventArgs e)
        {
            Studente s = new Studente();
            //s = lstStudenti.Find();
        }
    }
}
