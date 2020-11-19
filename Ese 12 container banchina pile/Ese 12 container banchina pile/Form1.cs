using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ese_12_container_banchina_pile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public struct ContainerStruct
        {
            public string codice;
            public string peso;
            public string tara;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        Stack<ContainerStruct> cont = new Stack<ContainerStruct>();
        private void btnCarica_Click(object sender, EventArgs e)
        {
            ContainerStruct c;
            c.codice = txtCodice.Text;
            c.peso = txtPeso.Text;
            c.tara = txtTara.Text;

            cont.Push(c);
            MessageBox.Show("caricamento container nella pila");
            txtCodice.Text = "";
            txtPeso.Text = "";
            txtTara.Text = "";
        }

        private void btnDaScaricare_Click(object sender, EventArgs e)
        { 
            lblContainer.Text = "";
            if (cont.Count != 0)
            {
                lblContainer.Text = "codice: " + cont.Peek().codice + "  peso: " + cont.Peek().peso + "  tara: " + cont.Peek().tara;
                cont.Pop();
            }
            else {
                lblContainer.Text = "Scaricamento completato";
            }
        }
    }
}
