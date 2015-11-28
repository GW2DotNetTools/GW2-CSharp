using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GW2CSharp.V2.Unauthenticated.WvW
{
	/// <summary>
	/// An object containing the score of the three servers
	/// </summary>
	public class Scores
	{
		/// <summary>
		/// The constructor for this scores object
		/// </summary>
		/// <param name="red">The red score</param>
		/// <param name="blue">The blue score</param>
		/// <param name="green">The green score</param>
		public Scores(int red, int blue, int green)
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