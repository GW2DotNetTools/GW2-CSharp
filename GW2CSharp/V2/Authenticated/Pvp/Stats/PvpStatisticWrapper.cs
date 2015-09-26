namespace GW2CSharp.V2.Authenticated.Pvp.Stats
{
    /// <summary>
    /// Represents a wrapper for the v2/pvp/stats endpoint.
    /// </summary>
    public class PvpStatisticWrapper : ApiBase
    {
        /// <summary>
        /// Returns PvpStatistics about the given account.
        /// </summary>
        /// <param name="token">API key.</param>
        /// <returns>PvpStatistics about the account.</returns>
        public PvpStatistic Get(string token)
        {
            return DeserializeObject<PvpStatistic>("https://api.guildwars2.com/v2/pvp/stats?access_token=" + token);
        }
    }
}
