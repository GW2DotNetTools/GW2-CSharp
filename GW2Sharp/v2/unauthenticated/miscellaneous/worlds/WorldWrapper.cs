using Newtonsoft.Json;
using System.Collections.Generic;

namespace GW2Sharp.V2.Unauthenticated.Miscellaneous.Worlds
{
    /// <summary>
    /// Represents a wrapper for the v2/world endpoint.
    /// </summary>
    public class WorldWrapper : ApiBase
    {
        /// <summary>
        /// Returns the world that matches the Id.
        /// <para>Endpoint: https://api.guildwars2.com/v2/worlds?id=</para>
        /// </summary>
        /// <param name="id">The world id.</param>
        /// <param name="requestedLanguage">Represents the language which the API should return. Default english.</param>
        /// <returns>World object that matches the Id.</returns>
        public World GetWorldById(int id, RequestedLanguage requestedLanguage = RequestedLanguage.en) 
        {
            string jsonString = DownloadJsonString(string.Format("https://api.guildwars2.com/v2/worlds?id={0}&lang={1}", id, requestedLanguage));
            return JsonConvert.DeserializeObject<World>(jsonString);
        }

        /// <summary>
        /// Returns the worlds that matches the ids.
        /// <para>Endpoint: https://api.guildwars2.com/v2/worlds?ids=</para>
        /// </summary>
        /// <param name="requestedLanguage">Represents the language which the API should return. Default english.</param>
        /// <param name="ids">The world ids.</param>
        /// <returns>List of worlds that matches the ids.</returns>
        public IEnumerable<World> GetWorldById(RequestedLanguage requestedLanguage = RequestedLanguage.en, params int[] ids)
        {
            return GetWorldByIds(ids, requestedLanguage);
        }

        /// <summary>
        /// Returns the worlds that matches the ids.
        /// <para>Endpoint: https://api.guildwars2.com/v2/worlds?ids=</para>
        /// </summary>
        /// <param name="ids">The world ids.</param>
        /// <param name="requestedLanguage">Represents the language which the API should return. Default english.</param>
        /// <returns>List of worlds that matches the ids.</returns>
        public IEnumerable<World> GetWorldByIds(IEnumerable<int> ids, RequestedLanguage requestedLanguage = RequestedLanguage.en)
        {
            string url = "https://api.guildwars2.com/v2/worlds?ids=";
            foreach (int id in ids)
            {
                url += id + ",";
            }
            url = string.Format("{0}&lang={1}", url, requestedLanguage); 

            string jsonString = DownloadJsonString(url);
            return JsonConvert.DeserializeObject<List<World>>(jsonString);
        }

        /// <summary>
        /// Returns all worlds.
        /// <para>Endpoint: https://api.guildwars2.com/v2/worlds?ids=all</para>
        /// </summary>
        /// <param name="requestedLanguage">Represents the language which the API should return. Default english.</param>
        /// <returns>List of all worlds.</returns>
        public IEnumerable<World> GetAllWorlds(RequestedLanguage requestedLanguage = RequestedLanguage.en)
        {
            string jsonString = DownloadJsonString("https://api.guildwars2.com/v2/worlds?ids=all&lang=" + requestedLanguage);
            return JsonConvert.DeserializeObject<List<World>>(jsonString);
        }
    }
}
