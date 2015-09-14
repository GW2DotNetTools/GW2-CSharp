using GW2CSharp.V2.Unauthenticated.Miscellaneous.Currencies.Enums;
using Newtonsoft.Json;

namespace GW2CSharp.V2.Unauthenticated.Miscellaneous.Currencies
{
    /// <summary>
    /// Represents a wrapper for the v2/currencies endpoint.
    /// </summary>
    public class CurrencyWrapper : ApiBase
    {
        /// <summary>
        /// Returns the currency that matches the CurrencyType.
        /// <para>Endpoint: https://api.guildwars2.com/v2/currencies/{0}?lang={1}</para>
        /// </summary>
        /// <param name="currencyType">Represents a known currencies in the wallet.</param>
        /// <param name="requestedLanguage">Represents the language which the API should return. Default english.</param>
        /// <returns>Currency object that matches the CurrencyType.</returns>
        public Currency GetCurrency(CurrencyType currencyType, RequestedLanguage requestedLanguage = RequestedLanguage.en) 
        {
            string jsonString = DownloadJsonString(string.Format("https://api.guildwars2.com/v2/currencies/{0}?lang={1}", (int)currencyType, requestedLanguage));
            return JsonConvert.DeserializeObject<Currency>(jsonString);
        }
    }
}
