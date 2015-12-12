namespace GW2CSharp.V2.Authenticated.Pvp.Stats
{
    /// <summary>
    /// Represents a wrapper for the v2/pvp/stats endpoint.
    /// </summary>
    /// <example><code source="Examples.cs" region="PvpStatistics" /></example>
    public class PvpStatisticWrapper : ApiBase
    {
        private string accountToken;

        /// <summary>
        /// Returns a wrapper for all pvpstats endpoint calls.
        /// </summary>
        /// <param name="accountToken">Accounttoken which all authenticated calls will automatically use.</param>
        public PvpStatisticWrapper(string accountToken)
        {
            this.accountToken = accountToken;
        }

        /// <summary>
        /// Returns PvpStatistics about the given account.
        /// </summary>
        /// <returns>PvpStatistics about the account.</returns>
        public PvpStatistic Get()
        {
            return Get(accountToken);
        }

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
