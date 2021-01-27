using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ese_19_Mondo_animale
{
	public abstract class Quadrupede : Animale
	{
        public Quadrupede(String s) : base(s)
		{

		}

		public override String si_muove() {
			return "Cammina su 4 zampe";
		}
    }
}
