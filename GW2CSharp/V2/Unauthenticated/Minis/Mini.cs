using GW2CSharp.Services;
using System.Drawing;

namespace GW2CSharp.V2.Unauthenticated.Minis
{
    /// <summary>
    /// Represents a single object of the v2/minis endpoint
    /// </summary>
    public class Mini
	{
		/// <summary>
		/// The mini id.
		/// </summary>
		public int Id { get; set; }

		/// <summary>
		/// The mini name.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// A description of how to unlock the mini (only present on a few entries).
		/// </summary>
		public string Unlock { get; set; }

		/// <summary>
		/// The mini icon URL.
		/// </summary>
		public string Icon { get; set; }

		/// <summary>
		/// The sort order that is used for displaying the mini in-game.
		/// </summary>
		public int Order { get; set; }

		/// <summary>
		/// The item which unlocks the mini and can be resolved against /v2/items.
		/// </summary>
		public int ItemId { get; set; }

		/// <summary>
		/// Initialize the new mini object
		/// </summary>
		/// <param name="id">The mini id.</param>
		/// <param name="name">The mini name.</param>
		/// <param name="unlock">A description of how to unlock the mini (only present on a few entries).</param>
		/// <param name="icon">The mini icon URL.</param>
		/// <param name="order">The sort order that is used for displaying the mini in-game.</param>
		/// <param name="item_id">The item which unlocks the mini and can be resolved against /v2/items.</param>
		public Mini(int id, string name, string unlock, string icon, int order, int item_id)
		{
			Id = id;
			Name = name;
			Unlock = unlock;
			Icon = icon;
			Order = order;
			ItemId = item_id;
		}

		/// <summary>
		/// Returns the icon for the mini as a Bitmap
		/// </summary>
		/// <returns>Mini icon as a Bitmap</returns>
		public Bitmap GetImage()
		{
			return RenderService.GetImage(Icon);
		}
	}
}
