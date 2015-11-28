using GW2CSharp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GW2CSharp.V2.Unauthenticated.Commerce
{
    /// <summary>
    /// Represents a wrapper for the v2/listings endpoint.
    /// </summary>
    public class ListingWrapper : ApiBase
    {
        /// <summary>
        /// Returns a buy and sell listings of a given item id from the trading post.
        /// </summary>
        /// <param name="id">Item id</param>
        /// <returns>Buy and sell listings of a given item id.</returns>
        public Listing GetById(int id)
        {
            return DeserializeObject<Listing>(string.Format("https://api.guildwars2.com/v2/commerce/listings/{0}", id));
        }

        /// <summary>
        /// Returns all buy and sell listing information from the trading post.
        /// </summary>
        /// <returns>All buy and sell listing informations.</returns>
        public Dictionary<int, Lazy<Listing>> GetAll()
        {
            List<int> itemIds = DeserializeObject<List<int>>(string.Format("https://api.guildwars2.com/v2/commerce/listings"));

            var listings = new Dictionary<int, Lazy<Listing>>();
            foreach (var itemId in itemIds)
            {
                listings.Add(itemId, new Lazy<Listing>(() => GetById(itemId)));
            }

            return listings;
        }

        /// <summary>
        /// Returns multiple buy and sell listing information from the trading post.
        /// </summary>
        /// <param name="ids">Item id's</param>
        /// <returns>Multiple buy and sell listing informations.</returns>
        public IEnumerable<Listing> GetMultiple(params int[] ids)
        {
            return GetMultiple(new List<int>(ids));
        }

        /// <summary>
        /// Returns multiple buy and sell listing information from the trading post.
        /// </summary>
        /// <param name="ids">Item id's</param>
        /// <returns>Multiple buy and sell listing informations.</returns>
        public IEnumerable<Listing> GetMultiple(IEnumerable<int> ids)
        {
            string url = "https://api.guildwars2.com/v2/commerce/listings?ids=";
            foreach (var id in ids)
            {
                url += id + ",";
            }

            return DeserializeObject<IEnumerable<Listing>>(url);
        }
    }
}
