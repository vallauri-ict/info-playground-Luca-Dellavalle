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
    
    public partial class FormFiglia : Form
    {
        private TextBox txtPadre;
        public string txtValue;//cacciavite incapsula il campo per il costruttore

        public string TxtValue
        {
            get => txtValue;
            set
            {
                txtValue = value;
                txtCampo.Text = txtValue;
            }
        }
       
        public FormFiglia()
        {
            InitializeComponent();
        }

        public FormFiglia(TextBox txtPadre)
        {
            InitializeComponent();
            this.txtPadre = txtPadre;
        }

        private void FormFiglia_Load(object sender, EventArgs e)
        {
            
        }

        private void btnFigliaModifica_Click(object sender, EventArgs e)
        {
            txtPadre.Text = txtCampo.Text;
        }
    }
}
