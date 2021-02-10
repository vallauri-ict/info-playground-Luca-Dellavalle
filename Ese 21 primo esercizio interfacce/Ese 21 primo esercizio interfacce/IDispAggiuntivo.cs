using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ese_21_primo_esercizio_interfacce
{
    interface IDispAggiuntivo
    {
        int id { get; set; }
        bool status { get; }

        void connetti(string s);
        void disconnetti(string s);
    }
}
