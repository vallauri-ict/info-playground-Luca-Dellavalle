using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ese_13_Ereditarietà
{
    class Spettro : Mostro
    {
        private bool invisibile;
        public Spettro() : base (25) {
            invisibile = true;
        }

        public Spettro(int p) : base(p) {
            invisibile = true;
        }
    }
}
