using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GW2CSharp.V2.Unauthenticated.Recipes
{
	/// <summary>
	/// The ingredient for the recipe
	/// </summary>
	public class Ingredient
	{
		/// <summary>
		/// The id of the item in the recipe
		/// </summary>
		public int ItemId { get; set; }

		/// <summary>
		/// The number of items for the recipe
		/// </summary>
		public int Count { get; set; }
	}
}
