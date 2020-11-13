﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ese_09_Lista
{
    public partial class Form1 : Form
    {
        public struct Libro
        {
            public int ID;
            public string Titolo;
            public string Autore;
        }
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        List<Libro> miaLista = new List<Libro>();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Libro l;
            l.ID = Convert.ToInt32(txtId.Text);
            l.Titolo = txtTitolo.Text;
            l.Autore = txtAutore.Text;

            miaLista.Add(l);
        }

        private void btnVisualizza_Click(object sender, EventArgs e)
        {
            string s = "";
            foreach (var elemento in miaLista)
            {
                s += elemento.Titolo+"\n";
                
            }
            MessageBox.Show(s);
        }
    }
}
