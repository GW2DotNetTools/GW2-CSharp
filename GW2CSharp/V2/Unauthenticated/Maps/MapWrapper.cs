using GW2CSharp.Enums;
using System;
using System.Collections.Generic;

namespace GW2CSharp.V2.Unauthenticated.Maps
{
    /// <summary>
    /// Represents a single MapWrapper.
    /// </summary>
    public class MapWrapper : ApiBase
    {
        /// <summary>
        /// Returns all maps.
        /// </summary>
        /// <param name="requestedLanguage">Language in which the API should be called.</param>
        /// <returns>Returns all maps.</returns>
        public IEnumerable<Lazy<Map>> GetAll(RequestedLanguage requestedLanguage = RequestedLanguage.En)
        {
            List<int> mapIds = DeserializeObject<List<int>>("https://api.guildwars2.com/v2/maps");

            var maps = new List<Lazy<Map>>();
            foreach (var mapId in mapIds)
            {
                maps.Add(new Lazy<Map>(() => GetById(mapId, requestedLanguage)));
            }
            return maps;
        }

        /// <summary>
        /// Returns one map that matches the id.
        /// </summary>
        /// <param name="mapId">The id of the map.</param>
        /// <param name="requestedLanguage">Language in which the API should be called.</param>
        /// <returns>Returns map that matches the id.</returns>
        public Map GetById(int mapId, RequestedLanguage requestedLanguage = RequestedLanguage.En)
        {
            return DeserializeObject<Map>(string.Format("https://api.guildwars2.com/v2/maps/{0}?lang={1}", mapId, requestedLanguage));
        }
    }
}
