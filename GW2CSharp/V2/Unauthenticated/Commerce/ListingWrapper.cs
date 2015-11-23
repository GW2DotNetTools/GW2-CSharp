using GW2CSharp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GW2CSharp.V2.Unauthenticated.Commerce
{
    /// <summary>
    /// 
    /// </summary>
    public class ListingWrapper : ApiBase
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Listing GetById(int id)
        {
            return DeserializeObject<Listing>(string.Format("https://api.guildwars2.com/v2/commerce/listings/{0}", id));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
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
        /// 
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public Dictionary<int, Lazy<Listing>> GetMultiple(params int[] ids)
        {
            return GetMultiple(new List<int>(ids));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public Dictionary<int, Lazy<Listing>> GetMultiple(IEnumerable<int> ids)
        {
            string url = "https://api.guildwars2.com/v2/commerce/listings?ids=";
            foreach (var id in ids)
            {
                url += id + ",";
            }

            return DeserializeObject<Dictionary<int, Lazy<Listing>>>(url);
        }
    }
}
