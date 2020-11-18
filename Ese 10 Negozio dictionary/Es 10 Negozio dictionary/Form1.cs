using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Es_10_Negozio_dictionary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public struct libro
        {
            public int Key;
            public string nomeArt;
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        Dictionary<int, libro> dizionarioLibri = new Dictionary<int, libro>();
        private void btnInserisci_Click(object sender, EventArgs e)
        {
            libro l;
            l.Key = Convert.ToInt32(txtKey.Text);
            l.nomeArt = txtValue.Text;
            dizionarioLibri.Add(Convert.ToInt32(txtKey.Text), l);
            txtKey.Text = "";
            txtValue.Text = "";
        }

        private void btnVisualizza_Click(object sender, EventArgs e)
        {
            lblVisualizza.Text = "Numero elementi: "+dizionarioLibri.Count;
        }

        private void btnRicerca_Click(object sender, EventArgs e)
        {
            foreach (int key in dizionarioLibri.Keys)
            {
                if (key.ToString() == txtRicerca.Text) {
                    lblVisualizzaRicerca.Text = "nome trovato: " + dizionarioLibri[key].nomeArt;
                    break;
                }
            }
            
        }
    }
}
