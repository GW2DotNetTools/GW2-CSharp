using GW2CSharp.V2.Unauthenticated.WvW.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GW2CSharp.V2.Unauthenticated.WvW
{
	/// <summary>
	/// The bonus being granted by a map.
	/// </summary>
	public class Bonus
	{
		/// <summary>
		/// A constructor for this bonus
		/// </summary>
		/// <param name="type">A shorthand name for the bonus.</param>
		/// <param name="owner">The current owner of the bonus</param>
		public Bonus(string type, Owner owner)
		{
			Type = type;
			Owner = owner;
		}

		/// <summary>
		/// A shorthand name for the bonus.
		/// </summary>
		public string Type { get; set; }

		/// <summary>
		/// The current owner of the bonus
		/// </summary>
		public Owner Owner { get; set; }
	}
}
