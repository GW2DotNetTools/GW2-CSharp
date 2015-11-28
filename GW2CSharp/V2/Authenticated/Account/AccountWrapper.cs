namespace GW2CSharp.V2.Authenticated.Account
{
    /// <summary>
    /// Represents the v2/account endpoint.
    /// </summary>
    public class AccountWrapper : ApiBase
    {
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
