using System;
using System.Collections.Generic;

namespace GW2CSharp.V2.Unauthenticated.Commerce
{
    /// <summary>
    /// 
    /// </summary>
    public class PriceWrapper : ApiBase
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Price GetById(int id)
        {
            return DeserializeObject<Price>(string.Format("https://api.guildwars2.com/v2/commerce/prices/{0}", id));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
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
        /// 
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public Dictionary<int, Lazy<Price>> GetMultiple(params int[] ids)
        {
            return GetMultiple(new List<int>(ids));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public Dictionary<int, Lazy<Price>> GetMultiple(IEnumerable<int> ids)
        {
            string url = "https://api.guildwars2.com/v2/commerce/prices?ids=";
            foreach (var id in ids)
            {
                url += id + ",";
            }

            return DeserializeObject<Dictionary<int, Lazy<Price>>>(url);
        }
    }
}
