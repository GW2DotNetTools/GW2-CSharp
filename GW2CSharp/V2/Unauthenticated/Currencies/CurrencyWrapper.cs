using GW2CSharp.Enums;
using GW2CSharp.V2.Unauthenticated.Currencies.Enums;
using System.Collections.Generic;

namespace GW2CSharp.V2.Unauthenticated.Currencies
{
    /// <summary>
    /// Represents a wrapper for the v2/currencies endpoint.
    /// </summary>
    /// <example><code source="Examples.cs" region="Currencies" /></example>
    public class CurrencyWrapper : ApiBase
    {
        private RequestedLanguage language;

        /// <summary>
        /// Returns a wrapper for all currency endpoint calls.
        /// </summary>
        /// <param name="language">Represents the language which the API should return.</param>
        public CurrencyWrapper(RequestedLanguage language)
        {
            this.language = language;
        }

        /// <summary>
        /// Returns the currency that matches the CurrencyType.
        /// </summary>
        /// <param name="currencyType">Represents a known currencies in the wallet.</param>
        /// <returns>Currency object that matches the CurrencyType.</returns>
        public Currency Get(CurrencyType currencyType) 
        {
            return DeserializeObject<Currency>(string.Format("https://api.guildwars2.com/v2/currencies/{0}?lang={1}", (int)currencyType, language));
        }

        /// <summary>
        /// Returns the currency that matches the CurrencyType.
        /// </summary>
        /// <param name="currencyType">Represents a known currencies in the wallet.</param>
        /// <param name="requestedLanguage">Represents the language which the API should return.</param>
        /// <returns>Currency object that matches the CurrencyType.</returns>
        public Currency Get(CurrencyType currencyType, RequestedLanguage requestedLanguage)
        {
            return DeserializeObject<Currency>(string.Format("https://api.guildwars2.com/v2/currencies/{0}?lang={1}", (int)currencyType, requestedLanguage));
        }

        /// <summary>
        /// Returns all currencies.
        /// </summary>
        /// <returns>All currencies.</returns>
        public IEnumerable<Currency> GetAll()
        {
            return GetAll(language);
        }

        /// <summary>
        /// Returns all currencies.
        /// </summary>
        /// <param name="requestedLanguage">Represents the language which the API should return. Default english.</param>
        /// <returns>All currencies.</returns>
        public IEnumerable<Currency> GetAll(RequestedLanguage requestedLanguage)
        {
            return DeserializeObject<IEnumerable<Currency>>(string.Format("https://api.guildwars2.com/v2/currencies?ids=all&lang={0}", requestedLanguage));
        }
    }
}
