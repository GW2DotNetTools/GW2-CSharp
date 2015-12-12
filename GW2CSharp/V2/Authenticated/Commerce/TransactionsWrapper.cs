using System.Collections.Generic;

namespace GW2CSharp.V2.Authenticated.Commerce
{
    /// <summary>
    /// Represents a wrapper for the v2/commerce/transactions endpoint. Results are cached for five minutes.
    /// </summary>
    public class TransactionsWrapper : ApiBase
    {
        private string accountToken;

        /// <summary>
        /// Returns a wrapper for all transactions endpoint calls. Results are cached for five minutes.
        /// </summary>
        /// <param name="accountToken">Accounttoken which all authenticated calls will automatically use.</param>
        public TransactionsWrapper(string accountToken)
        {
            this.accountToken = accountToken;
        }

        /// <summary>
        /// Currently unfulfilled buy transactions.
        /// </summary>
        /// <returns>List of buy transactions.</returns>
        public IEnumerable<Transaction> GetCurrentBuys()
        {
            return GetCurrentBuys(accountToken);
        }

        /// <summary>
        /// Currently unfulfilled buy transactions.
        /// </summary>
        /// <param name="token">API key.</param>
        /// <returns>List of buy transactions.</returns>
        public IEnumerable<Transaction> GetCurrentBuys(string token)
        {
            return DeserializeObject<IEnumerable<Transaction>>("https://api.guildwars2.com/v2/commerce/transactions/current/buys?access_token=" + token);
        }

        /// <summary>
        /// Currently unfulfilled sell transactions.
        /// </summary>
        /// <returns>List of sell transactions.</returns>
        public IEnumerable<Transaction> GetCurrentSells()
        {
            return GetCurrentSells(accountToken);
        }

        /// <summary>
        /// Currently unfulfilled sell transactions.
        /// </summary>
        /// <param name="token">API key.</param>
        /// <returns>List of sell transactions.</returns>
        public IEnumerable<Transaction> GetCurrentSells(string token)
        {
            return DeserializeObject<IEnumerable<Transaction>>("https://api.guildwars2.com/v2/commerce/transactions/current/sells?access_token=" + token);
        }

        /// <summary>
        /// Fulfilled buy transactions of the past 90 days.
        /// </summary>
        /// <returns>History of buy transactions.</returns>
        public IEnumerable<Transaction> GetHistoryBuys()
        {
            return GetHistoryBuys(accountToken);
        }

        /// <summary>
        /// Fulfilled buy transactions of the past 90 days.
        /// </summary>
        /// <param name="token">API key.</param>
        /// <returns>History of buy transactions.</returns>
        public IEnumerable<Transaction> GetHistoryBuys(string token)
        {
            return DeserializeObject<IEnumerable<Transaction>>("https://api.guildwars2.com/v2/commerce/transactions/history/sells?access_token=" + token);
        }
        
        /// <summary>
        /// Fulfilled sell transactions of the past 90 days.
        /// </summary>
        /// <returns>History of sell transactions.</returns>
        public IEnumerable<Transaction> GetHistorySells()
        {
            return GetHistorySells(accountToken);
        }
        
        /// <summary>
        /// Fulfilled sell transactions of the past 90 days.
        /// </summary>
        /// <param name="token">API key.</param>
        /// <returns>History of sell transactions.</returns>
        public IEnumerable<Transaction> GetHistorySells(string token)
        {
            return DeserializeObject<IEnumerable<Transaction>>("https://api.guildwars2.com/v2/commerce/transactions/history/buys?access_token=" + token);
        }
    }
}