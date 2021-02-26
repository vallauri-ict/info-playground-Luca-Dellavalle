﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ese_25_Primo_esercizio_dispense_mana
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            GestoreSalvataggio gest = new GestoreSalvataggio();
            gest.salvataggioEseguito += new salvataggioEseguitoEventHandler(miaFunzione);
            gest.salvataggioEseguito += new salvataggioEseguitoEventHandler(miaFunzione2);
            gest.salvaSuFile(5);
        }


        private void miaFunzione(int id) {
            MessageBox.Show("Elemento " + id + " salvato correttamente");
        }

        private void miaFunzione2(int id)
        {
            MessageBox.Show("Secondo gestore di evento");
        }
    }
}
