using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ese_21_primo_esercizio_interfacce
{
    class MyComponent : IDispAggiuntivo
    {
        private int _id;
        private bool _status;

        public int id { get => _id; set => _id = value; }

        public bool status => _status;

        public void connetti(string s)
        {
            _status = true;
            MessageBox.Show("Connesso a: " +s);
        }

        public void Stato() {
            if (status)
            {
                MessageBox.Show("Attualmente Connesso a: " + id);
            }
            else
            {
                MessageBox.Show("Non connesso");
            }
        }

        public void disconnetti(string s)
        {
            _status = false;
            MessageBox.Show("Connesso a: " + s);
        }
    }
}
