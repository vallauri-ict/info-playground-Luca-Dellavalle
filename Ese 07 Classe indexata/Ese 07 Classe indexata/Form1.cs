using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ese_07_Classe_indexata
{
    public partial class Form1 : Form
    {
        MyIndexClasse indexVect;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreaClasse_Click(object sender, EventArgs e)
        {
            indexVect = new MyIndexClasse(Convert.ToInt32(txtElementi.Text));
            for (int i = 0; i < Convert.ToInt32(txtElementi.Text) - 1; i++)
            {
                indexVect[i] = i.ToString();
            }
        }

        private void btnVisualizza_Click(object sender, EventArgs e)
        {
            string s = "";
            for (int i = 0; i < indexVect.length(); i++)
            {
                s += indexVect[i]+" - ";
            }
            MessageBox.Show("Element "+s);
        }
    }
}
