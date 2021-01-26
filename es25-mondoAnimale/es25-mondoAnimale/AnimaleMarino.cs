using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es25_mondoAnimale
{
    public abstract class AnimaleMarino: Animale
    {
		public AnimaleMarino(string s) : base(s)
		{
			
		}

		public override string vive()
		{
			return "in mare";
		}

		public override string chi_sei()
		{
			return "un animale marino";
		}
	}
}
