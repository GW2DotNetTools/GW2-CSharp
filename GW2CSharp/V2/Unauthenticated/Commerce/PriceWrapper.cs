using System;
using System.Collections.Generic;

namespace GW2CSharp.V2.Unauthenticated.Commerce
{
    /// <summary>
    /// Represents a wrapper for the v2/prices endpoint.
    /// </summary>
    public class PriceWrapper : ApiBase
    {
        /// <summary>
        /// Returns a buy and sell listings of a given item id from the trading post.
        /// </summary>
        /// <param name="id">Item id</param>
        /// <returns>Buy and sell listings of a given item id.</returns>
        public Price GetById(int id)
        {
            return DeserializeObject<Price>(string.Format("https://api.guildwars2.com/v2/commerce/prices/{0}", id));
        }

        /// <summary>
        /// Returns all aggregated buy and sell listing information from the trading post.
        /// </summary>
        /// <returns>All aggregated buy and sell listing informations.</returns>
        public Dictionary<int, Lazy<Price>> GetAll()
        {
            List<int> itemIds = DeserializeObject<List<int>>(string.Format("https://api.guildwars2.com/v2/commerce/prices"));

            var listings = new Dictionary<int, Lazy<Price>>();
            foreach (var itemId in itemIds)
            {
                listings.Add(itemId, new Lazy<Price>(() => GetById(itemId)));
            }

            return listings;
        }

        /// <summary>
        /// Returns multiple aggregated buy and sell listing information from the trading post.
        /// </summary>
        /// <param name="ids">Item id's</param>
        /// <returns>Multiple aggregated buy and sell listing informations.</returns>
        public IEnumerable<Price> GetMultiple(params int[] ids)
        {
            return GetMultiple(new List<int>(ids));
        }

        /// <summary>
        /// Returns multiple aggregated buy and sell listing information from the trading post.
        /// </summary>
        /// <param name="ids">Item id's</param>
        /// <returns>Multiple aggregated buy and sell listing informations.</returns>
        public IEnumerable<Price> GetMultiple(IEnumerable<int> ids)
        {
            string url = "https://api.guildwars2.com/v2/commerce/prices?ids=";
            foreach (var id in ids)
            {
                url += id + ",";
            }

            return DeserializeObject<List<Price>>(url);
        }
    }
}
