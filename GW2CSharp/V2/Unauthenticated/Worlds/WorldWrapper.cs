using GW2CSharp.Enums;
using System.Collections.Generic;

namespace GW2CSharp.V2.Unauthenticated.Worlds
{
    /// <summary>
    /// Represents a wrapper for the v2/world endpoint.
    /// </summary>
    public class WorldWrapper : ApiBase
    {
        /// <summary>
        /// Returns worlds in pagesize.
        /// </summary>
        /// <param name="page">Page number.</param>
        /// <param name="pageSize">Size of worlds on one page.</param>
        /// <param name="requestedLanguage">Represents the language which the API should return. Default english.</param>
        /// <returns>World object on the given page.</returns>
        public IEnumerable<World> GetByPage(int page, int pageSize, RequestedLanguage requestedLanguage = RequestedLanguage.En)
        {
            return DeserializeObject<IEnumerable<World>>(string.Format("https://api.guildwars2.com/v2/worlds?page={0}&page_size={1}&lang={2}", page, pageSize, requestedLanguage));
        }

        /// <summary>
        /// Returns the world that matches the Id.
        /// </summary>
        /// <param name="id">The world id.</param>
        /// <param name="requestedLanguage">Represents the language which the API should return. Default english.</param>
        /// <returns>World object that matches the Id.</returns>
        public World GetById(int id, RequestedLanguage requestedLanguage = RequestedLanguage.En) 
        {
            return DeserializeObject<World>(string.Format("https://api.guildwars2.com/v2/worlds?id={0}&lang={1}", id, requestedLanguage));
        }

        /// <summary>
        /// Returns the worlds that matches the ids.
        /// </summary>
        /// <param name="requestedLanguage">Represents the language which the API should return. Default english.</param>
        /// <param name="ids">The world ids.</param>
        /// <returns>List of worlds that matches the ids.</returns>
        public IEnumerable<World> GetByIds(RequestedLanguage requestedLanguage = RequestedLanguage.En, params int[] ids)
        {
            return GetByIds(ids, requestedLanguage);
        }

        /// <summary>
        /// Returns the worlds that matches the ids.
        /// </summary>
        /// <param name="ids">The world ids.</param>
        /// <param name="requestedLanguage">Represents the language which the API should return. Default english.</param>
        /// <returns>List of worlds that matches the ids.</returns>
        public IEnumerable<World> GetByIds(IEnumerable<int> ids, RequestedLanguage requestedLanguage = RequestedLanguage.En)
        {
            string url = "https://api.guildwars2.com/v2/worlds?ids=";
            foreach (int id in ids)
            {
                url += id + ",";
            }

            url = string.Format("{0}&lang={1}", url, requestedLanguage); 

            return DeserializeObject<IEnumerable<World>>(url);
        }

        /// <summary>
        /// Returns all worlds.
        /// </summary>
        /// <param name="requestedLanguage">Represents the language which the API should return. Default english.</param>
        /// <returns>List of all worlds.</returns>
        public IEnumerable<World> GetAll(RequestedLanguage requestedLanguage = RequestedLanguage.En)
        {
            return DeserializeObject<IEnumerable<World>>("https://api.guildwars2.com/v2/worlds?ids=all&lang=" + requestedLanguage);
        }
    }
}
