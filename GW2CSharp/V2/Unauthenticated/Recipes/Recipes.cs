using GW2CSharp.Enums;
using GW2CSharp.V2.Unauthenticated.Recipes.Enums;
using System.Collections.Generic;

namespace GW2CSharp.V2.Unauthenticated.Recipes
{
    /// <summary>
    /// This resource returns information about recipes that were discovered by players in the game.
    /// </summary>
    public class Recipe
	{
		/// <summary>
		/// Constructor for this resource
		/// </summary>
		/// <param name="id">The recipe id.</param>
		/// <param name="type">The recipe type.</param>
		/// <param name="output_item_id">The item id of the produced item.</param>
		/// <param name="output_item_count">The amount of items produced.</param>
		/// <param name="time_to_craft_ms">The time in milliseconds it takes to craft the item.</param>
		/// <param name="disciplines">The crafting disciplines that can use the recipe.</param>
		/// <param name="min_rating">The required rating to craft the recipe.</param>
		/// <param name="flags">Flags applying to the recipe.</param>
		/// <param name="ingredients">List of recipe ingredients.</param>
		/// <param name="chat_link">The chat code for the recipe.</param>
		public Recipe(int id, RecipeType type, int output_item_id, int output_item_count, int time_to_craft_ms, List<Discipline> disciplines, int min_rating, List<Flags> flags, List<Ingredient> ingredients, string chat_link)
		{
			Id = id;
			Type = type;
			OutputItemId = output_item_id;
			OutputItemCount = output_item_count;
			MinRating = min_rating;
			TimeToCraftMS = time_to_craft_ms;
			Disciplines = disciplines;
			Flags = flags;
			Ingredients = ingredients;
			ChatLink = chat_link;
		}

		/// <summary>
		/// The recipe id.
		/// </summary>
		public int Id { get; set; }

		/// <summary>
		/// The recipe type.
		/// </summary>
		public RecipeType Type { get; set; }

		/// <summary>
		/// The item id of the produced item.
		/// </summary>
		public int OutputItemId { get; set; }

		/// <summary>
		/// The amount of items produced.
		/// </summary>
		public int OutputItemCount { get; set; }

		/// <summary>
		/// The required rating to craft the recipe.
		/// </summary>
		public int MinRating { get; set; }

		/// <summary>
		/// The time in milliseconds it takes to craft the item.
		/// </summary>
		public int TimeToCraftMS { get; set; }

		/// <summary>
		/// The crafting disciplines that can use the recipe.
		/// </summary>
		public List<Discipline> Disciplines { get; set; }

		/// <summary>
		/// Flags applying to the recipe.
		/// </summary>
		public List<Flags> Flags { get; set; }

		/// <summary>
		/// List of recipe ingredients.
		/// </summary>
		public List<Ingredient> Ingredients { get; set; }

		/// <summary>
		/// The chat code for the recipe.
		/// </summary>
		public string ChatLink { get; set; }
	}
}
