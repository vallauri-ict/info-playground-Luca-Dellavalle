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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void apriForm2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(); //istanzio f2
            f2.MdiParent = this;
            f2.Size = new Size(300, 250);
            f2.StartPosition = FormStartPosition.Manual;
            f2.Location = new Point(0, 0);
            f2.Text = "Aperta form 2 da Design";
            f2.Show(); // visualizzo f2

            Form2 f2b = new Form2(10); //istanzio f2b
            f2b.MdiParent = this;
            f2b.Size = new Size(300, 250);
            f2b.StartPosition = FormStartPosition.Manual;
            f2b.Location = new Point(305, 0);
            f2b.Text = "Aperta form 2b da Design con parametro";
            f2b.Show(); // visualizzo f2
        }

        private void apriForm2bToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f2b = new Form(); //creazione dinamica form
            f2b.MdiParent = this;
            f2b.Size = new Size(210, 180);
            f2b.Text = "Aperta form 2b dinamica";
            f2b.Show();
        }

        private void passaTxtAF2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void inserireNomeEEtàToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void apriFormModaleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menùToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void esciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModalEsci f = new ModalEsci();
            f.MdiParent = this;
            f.Text = "uscire";
            if (f.ShowDialog() == DialogResult.OK)
            {
                Close();//chiusura finestra
            }
        }
    }
}
