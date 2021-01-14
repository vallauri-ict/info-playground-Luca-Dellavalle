using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ese_15_OOP_2_complessi_e_quaternoni
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnModuloComplesso_Click(object sender, EventArgs e)
        {
            if (txtReale.Text == "" && txtImmaginario.Text != "") {
                Complesso complesso = new Complesso(Convert.ToDouble(txtImmaginario.Text));
                MessageBox.Show(complesso.Modulo().ToString());
            }
            else if (txtReale.Text != "" && txtImmaginario.Text != "") {
                Complesso complesso = new Complesso(Convert.ToDouble(txtImmaginario.Text), Convert.ToDouble(txtReale.Text));
                MessageBox.Show(complesso.Modulo().ToString());
            }

        }

        private void btnModuloQuaternione_Click(object sender, EventArgs e)
        {
            Quaternione quaternione = new Quaternione();
            MessageBox.Show(quaternione.Modulo().ToString());
        }
    }
}
