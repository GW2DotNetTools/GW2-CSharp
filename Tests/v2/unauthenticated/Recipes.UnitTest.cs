using GW2CSharp;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.V2.Unauthenticated
{
	[TestFixture]
	public class Recipes
	{
		[Test]
		public void ShouldReturnSingleRecipe()
		{
			var recipe = GW2Api.V2.RecipeWrapper.GetById(7319);
			Assert.IsNotNull(recipe.Id);
			Assert.IsNotNull(recipe.Type);
			Assert.IsNotNull(recipe.OutputItemId);
			Assert.Greater(recipe.OutputItemCount, 0);
			Assert.IsNotNull(recipe.MinRating);
			Assert.Greater(recipe.TimeToCraftMS, 0);
			Assert.IsNotNull(recipe.Disciplines);
			Assert.IsNotNull(recipe.Flags);
			Assert.IsNotNull(recipe.Ingredients);
			var ingredient = recipe.Ingredients.First();
			Assert.Greater(ingredient.ItemId, 0);
			Assert.Greater(ingredient.Count, 0);
			Assert.IsNotNullOrEmpty(recipe.ChatLink);
		}

		[Test]
		public void ShouldReturnAllRecipes()
		{
			var recipes = GW2Api.V2.RecipeWrapper.GetAll();
			Assert.IsNotNull(recipes);
			Assert.Greater(recipes.Count(), 0);
			var singleRecipe = recipes.First().Value;
			Assert.IsNotNull(singleRecipe.Id);
			Assert.IsNotNull(singleRecipe.Type);
			Assert.IsNotNull(singleRecipe.OutputItemId);
			Assert.Greater(singleRecipe.OutputItemCount, 0);
			Assert.IsNotNull(singleRecipe.MinRating);
			Assert.Greater(singleRecipe.TimeToCraftMS, 0);
			Assert.IsNotNull(singleRecipe.Disciplines);
			Assert.IsNotNull(singleRecipe.Flags);
			Assert.IsNotNull(singleRecipe.Ingredients);
			Assert.IsNotNullOrEmpty(singleRecipe.ChatLink);
		}

		[Test]
		public void ShouldReturnRecipesForIngredient()
		{
			var recipes = GW2Api.V2.RecipeWrapper.SearchByIngredient(46731);
			Assert.IsNotNull(recipes);
			Assert.Greater(recipes.Count(), 0);
			var singleRecipe = recipes.First().Value;
			Assert.IsNotNull(singleRecipe.Id);
			Assert.IsNotNull(singleRecipe.Type);
			Assert.IsNotNull(singleRecipe.OutputItemId);
			Assert.Greater(singleRecipe.OutputItemCount, 0);
			Assert.IsNotNull(singleRecipe.MinRating);
			Assert.Greater(singleRecipe.TimeToCraftMS, 0);
			Assert.IsNotNull(singleRecipe.Disciplines);
			Assert.IsNotNull(singleRecipe.Flags);
			Assert.IsNotNull(singleRecipe.Ingredients);
			Assert.IsNotNullOrEmpty(singleRecipe.ChatLink);
		}

		[Test]
		public void ShouldReturnRecipesForEndProduct()
		{
			var recipes = GW2Api.V2.RecipeWrapper.SearchByResultingItem(50065);
			Assert.IsNotNull(recipes);
			Assert.Greater(recipes.Count(), 0);
			var singleRecipe = recipes.First().Value;
			Assert.IsNotNull(singleRecipe.Id);
			Assert.IsNotNull(singleRecipe.Type);
			Assert.IsNotNull(singleRecipe.OutputItemId);
			Assert.Greater(singleRecipe.OutputItemCount, 0);
			Assert.IsNotNull(singleRecipe.MinRating);
			Assert.Greater(singleRecipe.TimeToCraftMS, 0);
			Assert.IsNotNull(singleRecipe.Disciplines);
			Assert.IsNotNull(singleRecipe.Flags);
			Assert.IsNotNull(singleRecipe.Ingredients);
			Assert.IsNotNullOrEmpty(singleRecipe.ChatLink);
		}
	}
}
