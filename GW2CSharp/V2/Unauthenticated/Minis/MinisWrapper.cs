using GW2CSharp.Enums;
using System;
using System.Collections.Generic;

namespace GW2CSharp.V2.Unauthenticated.Minis
{
	/// <summary>
	/// Represents a wrapper for the v2/minis endpoint.
	/// </summary>
	public class MinisWrapper : ApiBase
	{
		/// <summary>
		/// Returns a single mini that matches the id.
		/// </summary>
		/// <param name="id">The mini identifier.</param>
		/// <param name="requestedLanguage"></param>
		/// <returns>Mini that matches the id.</returns>
		public Mini Get(int id, RequestedLanguage requestedLanguage = RequestedLanguage.En)
		{
			return DeserializeObject<Mini>(string.Format("https://api.guildwars2.com/v2/minis/{0}", id));
		}

		/// <summary>
		/// Returns all known minis.
		/// </summary>
		/// <returns>All the known minis.</returns>
		public Dictionary<int, Lazy<Mini>> GetAll()
		{
			List<int> miniIds = DeserializeObject<List<int>>("https://api.guildwars2.com/v2/minis");

			var minis = new Dictionary<int, Lazy<Mini>>();
			foreach (var miniId in miniIds)
			{
				minis.Add(miniId, new Lazy<Mini>(() => Get(miniId)));
			}
			return minis
        }
	}
}
