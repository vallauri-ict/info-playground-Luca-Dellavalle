using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ese_19_Mondo_animale
{
	public abstract class Bipede : Animale
	{
		public Bipede(String s) : base(s)
		{

		}

		public override String si_muove()
		{
			return "Cammina su 2 zampe";
		}


	}
}
