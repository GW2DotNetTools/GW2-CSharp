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
        private RequestedLanguage language;

        /// <summary>
        /// Returns a wrapper for all the item endpoint calls.
        /// </summary>
        public ItemWrapper()
        {
        }

        /// <summary>
        /// Returns a wrapper for all the item endpoint calls.
        /// </summary>
        /// <param name="language">Represents the language which the API should return.</param>
        public ItemWrapper(RequestedLanguage language)
        {
            this.language = language;
        }

        /// <summary>
        /// Returns the item that matches with the id.
        /// </summary>
        /// <param name="id">The item id.</param>
        /// <returns>Item that matches with the id.</returns>
        public Item GetById(int id)
        {
            return GetById(id, language);
        }

        /// <summary>
        /// Returns the item that matches with the id.
        /// </summary>
        /// <param name="id">The item id.</param>
        /// <param name="requestedLanguage">Request localized information.</param>
        /// <returns>Item that matches with the id.</returns>
        public Item GetById(int id, RequestedLanguage requestedLanguage)
        {
            return DeserializeObject<Item>(string.Format("https://api.guildwars2.com/v2/items/{0}?lang={1}", id, requestedLanguage));
        }

        /// <summary>
        /// Returns all known items.
        /// </summary>
        /// <returns>All known items.</returns>
        public Dictionary<int, Lazy<Item>> GetAll()
        {
            return GetAll(language);
        }

        /// <summary>
        /// Returns all known items.
        /// </summary>
        /// <param name="requestedLanguage">Request localized information.</param>
        /// <returns>All known items.</returns>
        public Dictionary<int, Lazy<Item>> GetAll(RequestedLanguage requestedLanguage)
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
