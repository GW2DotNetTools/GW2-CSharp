using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GW2CSharp.V2.Unauthenticated.WvW
{
	/// <summary>
	/// An object containing the world IDs of the three servers
	/// </summary>
	public class Worlds
	{
		/// <summary>
		/// The constructor for this worlds object
		/// </summary>
		/// <param name="red">The red world id</param>
		/// <param name="blue">The blue world id</param>
		/// <param name="green">The green world id</param>
		public Worlds(int red, int blue, int green)
		{
			Red = red;
			Blue = blue;
			Green = green;
		}

		/// <summary>
		/// The id of the red server
		/// </summary>
		public int Red { get; set; }

		/// <summary>
		/// The id of the blue server
		/// </summary>
		public int Blue { get; set; }

		/// <summary>
		/// The id of the green server
		/// </summary>
		public int Green { get; set; }
	}
}
