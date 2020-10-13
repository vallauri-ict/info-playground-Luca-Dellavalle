using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiformMenùToolStrip
{
    public partial class Form2 : Form
    {
        private int n;
        private TextBox txt1;

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(int n)
        {
            InitializeComponent();
            //this.n è la variabile dell'oggetto
            this.n = n;
        }

        public Form2(TextBox txt1)
        {
            InitializeComponent();
            this.txt1 = txt1;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }


        private void btnLeggiValore_Click(object sender, EventArgs e)
        {
        }

        private void btnInviaF1_Click(object sender, EventArgs e)
        {
            txt1.Text = txtForm2.Text;
        }

        private void btnFormFiglia_Click(object sender, EventArgs e)
        {
        }

        private void btnLeggiValore_Click_1(object sender, EventArgs e)
        {

        }

        private void btnInviaF1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void btnFormFiglia_Click_1(object sender, EventArgs e)
        {
            
        }

        private void apriFormFigliaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFiglia f = new FormFiglia();
            f.MdiParent = this;
            this.AddOwnedForm(f);
            f.Show();
        }

        private void inviaTxtForm1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtForm2.Text == null)
            {
                MessageBox.Show("inserire il testo nella textbox");
            }
            else
            {
                txt1.Text = txtForm2.Text;
            }
        }

        private void leggiValoreToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MessageBox.Show("valore = " + n);
        }
    }
}
