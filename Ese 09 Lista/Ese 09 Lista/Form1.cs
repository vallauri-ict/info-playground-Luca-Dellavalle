using System;
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

        public class Book
        {
            public int id;
            public string Titolo;
            public string Autore;
            public Book(int a, string b, string c)
            {
                this.id = a;
                this.Titolo = b;
                this.Autore = c;
            }
        }

        public struct Libro2
        {
            public string Titolo;
            public string Autore;
        }
        public int i = 0;

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
            //caricamento di l (libro) nella lista di libri
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

        List<Book> collezioneLibriObj = new List<Book>();
        private void btnAggiungiObj_Click(object sender, EventArgs e)
        {  
            //caricamento libro come obj nella lista di obj
            
            Book lObj = new Book(Convert.ToInt32(txtId.Text), txtTitolo.Text, txtAutore.Text);
            collezioneLibriObj.Add(lObj);
        }
    
        private void btnVisualizzaobj_Click(object sender, EventArgs e)
        {
            string s = "";
            foreach (var elemento in collezioneLibriObj)
            {
                s += elemento.Titolo + "\n";
            }
            MessageBox.Show(s);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            Book ris = collezioneLibriObj.Find(bf => bf.Titolo == txtFind.Text);
            MessageBox.Show(ris.Titolo);
        }

        private void tnFindAll_Click(object sender, EventArgs e)
        {
            //filtrare bf.Autore e caricarli in collectionBookAppogio cercandoli in collezioneLibriObj
            List<Book> collectionBookAppogio = new List<Book>();
            collectionBookAppogio = collezioneLibriObj.FindAll(bf => bf.Autore == "Rossi");
        }

        //dichiarazione dizionario collegamento a coppie chiave-valore
        Dictionary<int, Libro2> dizionarioLibri = new Dictionary<int, Libro2>();
        
        private void btnDizionario_Click(object sender, EventArgs e)
        {
            Libro2 l2;
            l2.Titolo = txtTitolo.Text;
            l2.Autore = txtAutore.Text;
            dizionarioLibri.Add(i, l2);
            i++;
        }

        private void btnVisDizionario_Click(object sender, EventArgs e)
        {
            foreach (int key in dizionarioLibri.Keys)
                MessageBox.Show(Convert.ToString(key));
            foreach (Libro2 book in dizionarioLibri.Values)
                MessageBox.Show(book.Titolo + " " + book.Autore);
        }
    }
}

