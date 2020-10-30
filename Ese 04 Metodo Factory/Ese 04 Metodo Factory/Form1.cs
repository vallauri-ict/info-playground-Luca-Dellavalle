using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ese_04_Metodo_Factory
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

        private void btnCreaQuadrato_Click(object sender, EventArgs e)
        {
            Quadrato q;

            if (txtLatoQuadrato.Text != "")
            {
                try
                {
                    q = Quadrato.CreaQuadrato(Convert.ToInt32(txtLatoQuadrato.Text));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else {
                MessageBox.Show("compilare il campo");
            }
        }
    }
}
