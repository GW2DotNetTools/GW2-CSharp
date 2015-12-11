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
        private RequestedLanguage language;
        /// <summary>
        /// Returns a wrapper for all the minis endpoint calls.
        /// </summary>
        /// <param name="language">Represents the language which the API should return.</param>
        public MinisWrapper(RequestedLanguage language)
        {
            this.language = language;
        }

        /// <summary>
        /// Returns a single mini that matches the id.
        /// </summary>
        /// <param name="id">The mini identifier.</param>
        /// <returns>Mini that matches the id.</returns>
        public Mini Get(int id)
		{
			return Get(id, language);
		}

        /// <summary>
        /// Returns a single mini that matches the id.
        /// </summary>
        /// <param name="id">The mini identifier.</param>
        /// <param name="requestedLanguage">Language in which the API should be called.</param>
        /// <returns>Mini that matches the id.</returns>
        public Mini Get(int id, RequestedLanguage requestedLanguage)
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
				minis.Add(miniId, new Lazy<Mini>(() => Get(miniId, language)));
			}
			return minis;
        }

        /// <summary>
        /// Returns all known minis.
        /// </summary>
        /// <param name="requestedLanguage">Language in which the API should be called.</param>
        /// <returns>All the known minis.</returns>
        public Dictionary<int, Lazy<Mini>> GetAll(RequestedLanguage requestedLanguage)
        {
            List<int> miniIds = DeserializeObject<List<int>>("https://api.guildwars2.com/v2/minis");

            var minis = new Dictionary<int, Lazy<Mini>>();
            foreach (var miniId in miniIds)
            {
                minis.Add(miniId, new Lazy<Mini>(() => Get(miniId, requestedLanguage)));
            }
            return minis;
        }
    }
}
