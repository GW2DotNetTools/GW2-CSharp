using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GW2CSharp.V2.Unauthenticated.WvW
{
	/// <summary>
	/// How many players were killed
	/// </summary>
	public class Kills
	{
		/// <summary>
		/// The constructor for this kills object
		/// </summary>
		/// <param name="red">The number of red kills</param>
		/// <param name="blue">The number of blue kills</param>
		/// <param name="green">The number of green kills</param>
		public Kills(int red, int blue, int green)
		{
			Red = red;
			Blue = blue;
			Green = green;
		}

		/// <summary>
		/// For the red server
		/// </summary>
		public int Red { get; set; }

		/// <summary>
		/// For the blue server
		/// </summary>
		public int Blue { get; set; }

		/// <summary>
		/// For the green servers
		/// </summary>
		public int Green { get; set; }
	}
}
