using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ese_04_preparazione_verifica
{

    public partial class FormSecondaria : Form
    {
        public string nome;
        public string eta;

        public FormSecondaria()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            nome = txtNome.Text;
            eta = txtEta.Text;
        }

        private void btnAnnulla_Click(object sender, EventArgs e)
        {
           
        }
    }
}
