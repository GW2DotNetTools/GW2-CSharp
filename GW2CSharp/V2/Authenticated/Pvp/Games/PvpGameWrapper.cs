using System.Collections.Generic;

namespace GW2CSharp.V2.Authenticated.Pvp.Games
{
    /// <summary>
    /// Represents a wrapper for the v2/pvp/games endpoint.
    /// </summary>
    public class PvpGameWrapper : ApiBase
    {
        /// <summary>
        /// Returns all recent matches.
        /// </summary>
        /// <param name="token">Access token</param>
        /// <returns>Recent matches.</returns>
        public IEnumerable<PvpGame> GetRecent(string token)
        {
            List<string> gameIds = DeserializeObject<List<string>>("https://api.guildwars2.com/v2/pvp/games?access_token=" + token);

            string url = string.Format("https://api.guildwars2.com/v2/pvp/games?access_token={0}&ids=", token);
            foreach (var gameId in gameIds)
            {
                url += gameId + ",";
            }

            return DeserializeObject<List<PvpGame>>(url);
        }
    }
}
