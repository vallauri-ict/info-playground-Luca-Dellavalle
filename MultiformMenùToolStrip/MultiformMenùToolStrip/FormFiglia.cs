﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiformMenùToolStrip
{
    public partial class FormFiglia : Form
    {
        public FormFiglia()
        {
            InitializeComponent();
        }

        private void FormFiglia_Load(object sender, EventArgs e)
        {

        }

        private void btnFigliadiChi_Click(object sender, EventArgs e)
        {
            if (Owner != null)
            {
                MessageBox.Show("form figlia di = " + Owner);
            }
        }
    }
}
