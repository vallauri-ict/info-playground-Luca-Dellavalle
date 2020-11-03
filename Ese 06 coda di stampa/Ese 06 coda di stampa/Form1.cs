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
        public static DataGridView dataGV;
       

        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGV = dataGridStampa;
            string[] header = { "ID", "Titolo", "Autore"};
            dataGV.ColumnCount = 3;
            dataGV.RowHeadersVisible = false;
            dataGV.ReadOnly = true;
            for (int i = 0; i < header.Length; i++)
            {
                dataGV.Columns[i].HeaderText = header[i];
                dataGV.Columns[i].Width = dataGV.Width / 4;
            }
        }

        public struct libro
        {
            public string titolo;
            public string autore;
        }

        public int i = 0;
        Queue<libro> codaLibri = new Queue<libro>();

        private void btnCoda_Click(object sender, EventArgs e)
        {
            libro l;
            l.titolo = txtTitolo.Text;
            l.autore = txtAutore.Text;

            codaLibri.Enqueue(l);
            codaStampa.invia(l, dataGridStampa);
        }
    }
}
