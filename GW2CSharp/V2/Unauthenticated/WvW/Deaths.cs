using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GW2CSharp.V2.Unauthenticated.WvW
{
	/// <summary>
	/// How many deaths occured
	/// </summary>
	public class Deaths
	{
		/// <summary>
		/// The constructor for this deaths object
		/// </summary>
		/// <param name="red">The number of red deaths</param>
		/// <param name="blue">The number of blue deaths</param>
		/// <param name="green">The number of green deaths</param>
		public Deaths(int red, int blue, int green)
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
