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
        /// <returns>World object that matches the Id.</returns>
        public World GetWorldById(int id)
        {
            string jsonString = DownloadJsonString("https://api.guildwars2.com/v2/worlds?id=" + id);
            return JsonConvert.DeserializeObject<World>(jsonString);
        }

        /// <summary>
        /// Returns the worlds that matches the ids.
        /// <para>Endpoint: https://api.guildwars2.com/v2/worlds?ids=</para>
        /// </summary>
        /// <param name="ids">The world ids.</param>
        /// <returns>List of worlds that matches the ids.</returns>
        public IEnumerable<World> GetWorldById(params int[] ids)
        {
            return GetWorldByIds(ids);
        }

        /// <summary>
        /// Returns the worlds that matches the ids.
        /// <para>Endpoint: https://api.guildwars2.com/v2/worlds?ids=</para>
        /// </summary>
        /// <param name="ids">The world ids.</param>
        /// <returns>List of worlds that matches the ids.</returns>
        public IEnumerable<World> GetWorldByIds(IEnumerable<int> ids)
        {
            string url = "https://api.guildwars2.com/v2/worlds?ids=";
            foreach (int id in ids)
            {
                url += id + ",";
            }

            string jsonString = DownloadJsonString(url);
            return JsonConvert.DeserializeObject<List<World>>(jsonString);
        }

        /// <summary>
        /// Returns all worlds.
        /// <para>Endpoint: https://api.guildwars2.com/v2/worlds?ids=all</para>
        /// </summary>
        /// <returns>List of all worlds.</returns>
        public IEnumerable<World> GetAllWorlds()
        {
            string jsonString = DownloadJsonString("https://api.guildwars2.com/v2/worlds?ids=all");
            return JsonConvert.DeserializeObject<List<World>>(jsonString);
        }
    }
}
