using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multifomr01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnForm2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(); //istanzio f2
            f2.Show(); // visualizzo f2
        }

        private void btnApriForm2b_Click(object sender, EventArgs e)
        {
            Form f2b = new Form(); //creazione dinamica form 
            f2b.Text = "Aperta form dinamica";
            f2b.Show();
        }
    }
}
