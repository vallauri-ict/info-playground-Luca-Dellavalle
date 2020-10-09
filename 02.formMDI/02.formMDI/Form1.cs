using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02.formMDI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnApri1_Click(object sender, EventArgs e)
        {
            Figlia1 f = new Figlia1();
            f.Text = "Figlia 1";
            f.MdiParent = this; //serve a creare una form interna alla propria
            f.Size = new Size(210, 180);
            f.StartPosition = FormStartPosition.Manual; //Serve per far funzionare
            f.Location = new Point(0,20);
            f.Show();
        }

        private void btnApri2_Click(object sender, EventArgs e)
        {
            Figlia1 f = new Figlia1();
            f.Text = "Figlia 2";
            f.MdiParent = this; //serve a creare una form interna alla propria e 
            f.Size = new Size(210, 180);
            f.StartPosition = FormStartPosition.Manual; //Serve per far funzionare
            f.Location = new Point(215, 20);
            f.Show();
        }

        private void btnFAperte_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sono state aperte"+this.MdiChildren.Length+" finestre");
            foreach (Form f in this.MdiChildren)
            {
                MessageBox.Show("Finestra "+f.Text+" Aperta");
            }
        }

        private void esciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModalEsci f = new ModalEsci();
            f.Text = "uscire";
            if (f.ShowDialog() == DialogResult.OK) {
                Close();//chiusura finestra
            }
        }

        private void apri1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLbl.Text = "premuto Apri 1";
        }

        private void apri2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLbl.Text = "premuto Apri 2";

        }
    }
}
