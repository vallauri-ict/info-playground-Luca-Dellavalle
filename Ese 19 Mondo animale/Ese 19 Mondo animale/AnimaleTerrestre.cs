using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ese_19_Mondo_animale
{
	public abstract class AnimaleTerrestre : Animale
	{

		public AnimaleTerrestre(String s) : base(s)
		{

		}

		public override String vive()
		{
			return "sulla terra";
		}

		public override String chi_sei()
		{
			return "un animale terrestre";
		}
	}
	
}
