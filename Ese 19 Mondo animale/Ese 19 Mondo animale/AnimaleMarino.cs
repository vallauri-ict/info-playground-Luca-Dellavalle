using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ese_19_Mondo_animale
{
	public abstract class AnimaleMarino : AnimaleAcquatico
	{
	public AnimaleMarino(String s)
	{
		super(s);
	}

	public String vive()
	{
		return "in mare";
	}

	public String chi_sei()
	{
		return "un animale marino";
	}
}
}
