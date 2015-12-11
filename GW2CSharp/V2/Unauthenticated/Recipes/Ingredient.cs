namespace GW2CSharp.V2.Unauthenticated.Recipes
{
    /// <summary>
    /// The ingredient for the recipe
    /// </summary>
    public class Ingredient
	{
		/// <summary>
		/// The Ingredient constructor
		/// </summary>
		/// <param name="item_id">The id of the item in the recipe</param>
		/// <param name="count">The number of items for the recipe</param>
		public Ingredient(int item_id, int count)
		{
			ItemId = item_id;
			Count = count;
		}

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
