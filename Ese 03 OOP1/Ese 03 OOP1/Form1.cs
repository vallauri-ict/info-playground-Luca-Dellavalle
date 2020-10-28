using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ese_03_OOP1
{
    public partial class Form1 : Form
    {
        Rectangle r;

        public Form1()
        {
            InitializeComponent();
            //r = new Rectangle();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCreaRettangolo_Click(object sender, EventArgs e)
        {
            /* r.side1 = Convert.ToInt32(txtBase.Text);
             r.side2 = Convert.ToInt32(txtAltezza.Text);
             Rectangle t;
             t = r;
             MessageBox.Show("Base: " + r.side1 + " - Altezza:" + r.side2);
             MessageBox.Show("per l' oggetto t\nBase: " + t.side1 + " - Altezza:" + t.side2);
             t.side1 = 10;
             MessageBox.Show("oggetto r dopo modifiche su t\nBase: " + t.side1 + " - Altezza:" + t.side2);
             */
           
            r = new Rectangle(Convert.ToInt32(txtBase.Text), Convert.ToInt32(txtAltezza.Text));
            r.color = Color.White;
            MessageBox.Show(r.getSide());

            r = new Rectangle(5);
            r.color = Color.White;
            MessageBox.Show(r.getSide());
        }

        private void btnFattura_Click(object sender, EventArgs e)
        {
            Fatture.visualizza();
        }

        private void btnCreaFattura_Click(object sender, EventArgs e)
        {
            Fatture f = new Fatture();
            MessageBox.Show("Fattura creata!");
        }

        private void btnClasseStatica_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pgreco "+MiaMath.pi+"\n 3*4 = "+MiaMath.prodotto(3,4));
        }
    }
}
