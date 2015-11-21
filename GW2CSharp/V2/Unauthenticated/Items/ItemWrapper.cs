using GW2CSharp.Enums;
using System;
using System.Collections.Generic;

namespace GW2CSharp.V2.Unauthenticated.Items
{
    /// <summary>
    /// Represents the v2/items endpoint
    /// </summary>
    public class ItemWrapper : ApiBase
    {
        /// <summary>
        /// Returns the item that matches with the id.
        /// </summary>
        /// <param name="id">The item id.</param>
        /// <param name="requestedLanguage">(Optional) Request localized information.</param>
        /// <returns>Item that matches with the id.</returns>
        public Item GetById(int id, RequestedLanguage requestedLanguage = RequestedLanguage.En)
        {
            return DeserializeObject<Item>(string.Format("https://api.guildwars2.com/v2/items/{0}?lang={1}", id, requestedLanguage));
        }

        /// <summary>
        /// Returns all known items.
        /// </summary>
        /// <param name="requestedLanguage">(Optional) Request localized information.</param>
        /// <returns>All known items.</returns>
        public Dictionary<int, Lazy<Item>> GetAll(RequestedLanguage requestedLanguage = RequestedLanguage.En)
        {
            List<int> itemIds = DeserializeObject<List<int>>(string.Format("https://api.guildwars2.com/v2/items/"));

            var items = new Dictionary<int, Lazy<Item>>();
            foreach (var itemId in itemIds)
            {
                items.Add(itemId, new Lazy<Item>(() => GetById(itemId, requestedLanguage)));
            }

            return items;
        }
    }
}
