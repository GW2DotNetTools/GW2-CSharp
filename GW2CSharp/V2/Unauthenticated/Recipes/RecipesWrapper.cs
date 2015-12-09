using GW2CSharp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GW2CSharp.V2.Unauthenticated.Recipes
{
	/// <summary>
	/// Reqpresents a RecipesWrapper
	/// There are no language options because the recipes only appear in English
	/// </summary>
	public class RecipesWrapper : ApiBase
	{
		/// <summary>
		/// Returns all the recipes
		/// </summary>
		/// <returns>A lazy loaded list of recipes</returns>
		public IEnumerable<Lazy<Recipe>> GetAll()
		{
			List<int> recipeIds = DeserializeObject<List<int>>("https://api.guildwars2.com/v2/recipes");
			var recipes = new List<Lazy<Recipe>>();
			foreach (var recipe in recipeIds)
			{
				recipes.Add(new Lazy<Recipe>(() => GetById(recipe)));
			}
			return recipes;
		}

		/// <summary>
		/// Returns a specific recipe
		/// </summary>
		/// <param name="recipe">The id of the recipe to return</param>
		/// <returns>The recipe corresponding to the id</returns>
		public Recipe GetById(int recipe)
		{
			return DeserializeObject<Recipe>(string.Format("https://api.guildwars2.com/v2/recipes/{0}", recipe));
		}

		/// <summary>
		/// Provides the ability to search for a recipe by supplying the id of an ingredient in the recipe.
		/// </summary>
		/// <param name="ingredientId">The id of the item which is an ingredient for the recipe</param>
		/// <returns>A lazy loaded list of all the recipes where the specified ingredient occurs.</returns>
		public IEnumerable<Lazy<Recipe>> SearchByIngredient(int ingredientId)
		{
			List<int> recipeIds = DeserializeObject<List<int>>(string.Format("https://api.guildwars2.com/v2/recipes/search?input={0}", ingredientId));
			var recipes = new List<Lazy<Recipe>>();
			foreach (var recipe in recipeIds)
			{
				recipes.Add(new Lazy<Recipe>(() => GetById(recipe)));
			}
			return recipes;
		}

		/// <summary>
		/// Provides the ability to search for all the recipes which can be used to craft a specific item
		/// </summary>
		/// <param name="resultingItemId">The id of the item which the recipes should craft</param>
		/// <returns>A lazy loaded list of all the recipes which craft the specified item</returns>
		public IEnumerable<Lazy<Recipe>> SearchByResultingItem(int resultingItemId)
		{
			List<int> recipeIds = DeserializeObject<List<int>>(string.Format("https://api.guildwars2.com/v2/recipes/search?output={0}", resultingItemId));
			var recipes = new List<Lazy<Recipe>>();
			foreach (var recipe in recipeIds)
			{
				recipes.Add(new Lazy<Recipe>(() => GetById(recipe)));
			}
			return recipes;
		}
	}
}
