using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ese_08_Form_di_registrazione_regex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistra_Click(object sender, EventArgs e)
        {
            bool valido = true;

            Regex regCognomeNome = new Regex(@"^[A-Z]{1}[a-z]+$");
            //Cognome
            if (txtCognome.Text == "")
            {
                MessageBox.Show("Cognome non inserito");
                valido = false;
                txtCognome.BackColor = Color.Salmon;
            }
            else if (!regCognomeNome.IsMatch(txtCognome.Text))
            {
                MessageBox.Show("Cognome inserito non valido");
                valido = false;
                txtCognome.BackColor = Color.Salmon;
            }
            //Nome
            if (txtNome.Text == "")
            {
                MessageBox.Show("Nome non inserito");
                valido = false;
                txtNome.BackColor = Color.Salmon;
            }
            else if (!regCognomeNome.IsMatch(txtNome.Text))
            {
                MessageBox.Show("Nome inserito non valido");
                valido = false;
                txtNome.BackColor = Color.Salmon;
            }
            //Indirizzo
            txtIndirizzo.Text = "null";
            /*Regex regIndirizzo = new Regex(@"^[A-Z]{1}[a-z]+$");
            if (txtIndirizzo.Text == "")
            {
                MessageBox.Show("Indirizzo non inserito");
                valido = false;
                txtIndirizzo.BackColor = Color.Salmon;
            }
            else if (!regIndirizzo.IsMatch(txtIndirizzo.Text))
            {
                MessageBox.Show("Indirizzo inserito non valido");
                valido = false;
                txtIndirizzo.BackColor = Color.Salmon;
            }*/
            //Città
            Regex regCittà = new Regex(@"[\w-]"); // accetta caratteri maiuscoli e minuscoli
            if (txtCittà.Text == "")
            {
                MessageBox.Show("Città non inserita");
                valido = false;
                txtCittà.BackColor = Color.Salmon;
            }
            else if (!regCittà.IsMatch(txtCittà.Text))
            {
                MessageBox.Show("Città inserita non valido");
                valido = false;
                txtCittà.BackColor = Color.Salmon;
            }
            //CAP
            Regex regCap = new Regex(@"^\d{5}$");
            if (txtCap.Text == "")
            {
                MessageBox.Show("Cap non inserito");
                valido = false;
                txtCap.BackColor = Color.Salmon;
            }
            else if (!regCap.IsMatch(txtCap.Text))
            {
                MessageBox.Show("Cap inserito non valido");
                valido = false;
                txtCap.BackColor = Color.Salmon;
            }
            //Mail
            Regex regMail = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
            if (txtMail.Text == "")
            {
                MessageBox.Show("Mail non inserito");
                valido = false;
                txtMail.BackColor = Color.Salmon;
            }
            else if (!regMail.IsMatch(txtMail.Text))
            {
                MessageBox.Show("Mail inserito non valido");
                valido = false;
                txtMail.BackColor = Color.Salmon;
            }
            //cod fiscale
            Regex regCodFisc = new Regex(@"^[A-Z]{6}\d{2}[A-Z]\d{2}[A-Z]\d{3}[A-Z]$");
            if (txtCodFisc.Text == "")
            {
                MessageBox.Show("codice fiscale non inserito");
                valido = false;
                txtCodFisc.BackColor = Color.Salmon;
            }
            else if (!regCodFisc.IsMatch(txtCodFisc.Text))
            {
                MessageBox.Show("Codice fiscale inserito non valido");
                valido = false;
                txtCodFisc.BackColor = Color.Salmon;
            }
            //User
            Regex regUser = new Regex(@"[\w-]");
            if (txtUser.Text == "")
            {
                MessageBox.Show("User non inserito");
                valido = false;
                txtUser.BackColor = Color.Salmon;
            }
            else if (!regUser.IsMatch(txtUser.Text))
            {
                MessageBox.Show("User inserito non valido");
                valido = false;
                txtUser.BackColor = Color.Salmon;
            }
            //Password
            Regex regPwd = new Regex(@"^(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]{8,}$");
            if (txtPwd.Text == "")
            {
                MessageBox.Show("Password non inserita");
                valido = false;
                txtPwd.BackColor = Color.Salmon;
            }
            else if (!regPwd.IsMatch(txtPwd.Text))
            {
                MessageBox.Show("Password inserito non valida");
                valido = false;
                txtPwd.BackColor = Color.Salmon;
            }

            if (valido == true)
            {
                registrazione.controllo(txtCognome.Text, txtNome.Text,txtIndirizzo.Text,
                    txtCittà.Text,txtCap.Text,txtMail.Text,txtCodFisc.Text,txtUser.Text,txtPwd.Text);
            }
        }
    }
}
