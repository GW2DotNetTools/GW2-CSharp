using GW2CSharp.V2.Unauthenticated.Recipes.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GW2CSharp.V2.Unauthenticated.Recipes
{
	/// <summary>
	/// 
	/// </summary>
	public class Recipe
	{
		/// <summary>
		/// 
		/// </summary>
		public RecipeType Type { get; set; }

		/// <summary>
		/// 
		/// </summary>
		public int OutputItemId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		public int OutputItemCount { get; set; }

		/// <summary>
		/// 
		/// </summary>
		public int MinRating { get; set; }

		/// <summary>
		/// 
		/// </summary>
		public int TimeToCraftMS { get; set; }

		/// <summary>
		/// 
		/// </summary>
		public List<Disciplines> Disciplines { get; set; }

		/// <summary>
		/// 
		/// </summary>
		public List<Flags> Flags { get; set; }

		/// <summary>
		/// 
		/// </summary>
		public List<Ingredient> Ingredients { get; set; }

		/// <summary>
		/// 
		/// </summary>
		public int Id { get; set; }
		
		/// <summary>
		/// 
		/// </summary>
		public string ChatLink { get; set; }
	}
}
