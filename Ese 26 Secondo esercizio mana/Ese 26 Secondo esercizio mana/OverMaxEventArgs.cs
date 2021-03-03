using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ese_26_Secondo_esercizio_mana
{
    public class OverMaxEventArgs : EventArgs
    {
        public int ValoreSoglia { get;}

        public OverMaxEventArgs(int valoreSoglia) {
            ValoreSoglia = valoreSoglia;
        }
    }
}
