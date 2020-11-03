using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ese_05_Classe_Singleton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreaClasse_Click(object sender, EventArgs e)
        {
            EsSingleton s = EsSingleton.GetEsSingleton(Convert.ToInt32(txtValore.Text));
            MessageBox.Show("valore : " +s.val);
            EsSingleton s1 = EsSingleton.GetEsSingleton(0);
            MessageBox.Show("valore di s1 : "+s1.val);
            MessageBox.Show("valore di s : "+s.val);
        }
    }
}
