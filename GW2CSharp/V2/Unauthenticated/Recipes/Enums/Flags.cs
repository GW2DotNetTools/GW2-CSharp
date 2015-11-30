using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GW2CSharp.V2.Unauthenticated.Recipes.Enums
{
	/// <summary>
	/// Flags to apply to a recipe
	/// </summary>
	public enum Flags
	{
		/// <summary>
		/// Indicates that a recipe automatically unlocks upon reaching the required discipline rating.
		/// </summary>
		AutoLearned,

		/// <summary>
		/// Indicates that a recipe is unlocked by consuming a recipe sheet.
		/// </summary>
		LearnedFromItem
	}
}
