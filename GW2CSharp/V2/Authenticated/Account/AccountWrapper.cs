namespace GW2CSharp.V2.Authenticated.Account
{
    /// <summary>
    /// Represents the v2/account endpoint.
    /// </summary>
    public class AccountWrapper : ApiBase
    {
        private string accountToken;

        /// <summary>
        /// Returns a wrapper for all the account endpoint calls.
        /// </summary>
        /// <param name="accountToken">Accounttoken which all authenticated calls will automatically use.</param>
        public AccountWrapper(string accountToken)
        {
            this.accountToken = accountToken;
        }

        /// <summary>
        /// This resource returns information about player accounts.
        /// </summary>
        /// <returns>Informations about player accounts.</returns>
        public Account Get()
        {
            return Get(accountToken);
        }

        /// <summary>
        /// This resource returns information about player accounts.
        /// </summary>
        /// <param name="token">API key.</param>
        /// <returns>Informations about player accounts.</returns>
        public Account Get(string token)
        {
            return DeserializeObject<Account>("https://api.guildwars2.com/v2/account?access_token=" + token);
        }
    }
}
