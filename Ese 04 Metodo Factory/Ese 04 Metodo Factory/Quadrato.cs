using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ese_04_Metodo_Factory
{
    class Quadrato
    {
        private int lato;

        public Quadrato(int lato) {
            this.lato = lato;
        }

        public static Quadrato CreaQuadrato(int lato) {
            if (lato <= 0)
            {
                throw new Exception("Il lato deve essere maggiore di zero");
            }
            else {
                return new Quadrato(lato);
            }
        }
    }
}
