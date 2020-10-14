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
    public partial class FormFiglia : Form
    {
        public FormFiglia()
        {
            InitializeComponent();
        }

        private void btnFigliadiChi_Click(object sender, EventArgs e)
        {
            if (Owner != null) {
                MessageBox.Show("form figlia di = "+ Owner);
            }
        }
    }
}
