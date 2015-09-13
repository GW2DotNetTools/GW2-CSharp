using GW2Sharp.V2.Unauthenticated.Miscellaneous.Currencies.Enums;
using Newtonsoft.Json;

namespace GW2Sharp.V2.Unauthenticated.Miscellaneous.Currencies
{
    /// <summary>
    /// Represtents a wrapper for the v2/currencies endpoint.
    /// </summary>
    public class CurrencyWrapper : ApiBase
    {
        /// <summary>
        /// Returns the currency that matches the CurrencyArt.
        /// </summary>
        /// <param name="currencyArt">Represents a known currencies in the wallet.</param>
        /// <returns>Currency object that matches the CurrencyArt.</returns>
        public Currency GetCurrency(CurrencyArt currencyArt) 
        {
            string jsonString = DownloadJsonString("https://api.guildwars2.com/v2/currencies/" + (int)currencyArt);
            return JsonConvert.DeserializeObject<Currency>(jsonString);
        }
    }
}
