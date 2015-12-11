using GW2CSharp.Enums;
using System;
using System.Collections.Generic;

namespace GW2CSharp.V2.Unauthenticated.Items.Skins
{
    /// <summary>
    /// Represents the v2/skins endpoint
    /// </summary>
    public class SkinWrapper : ApiBase
    {
        private RequestedLanguage language;

        /// <summary>
        /// Returns a wrapper for all skin endpoint calls.
        /// </summary>
        public SkinWrapper()
        {
        }

        /// <summary>
        /// Returns a wrapper for all skin endpoint calls.
        /// </summary>
        /// <param name="language">Represents the language which the API should return.</param>
        public SkinWrapper(RequestedLanguage language)
        {
            this.language = language;
        }

        /// <summary>
        /// Returns the skin that matches with the id.
        /// </summary>
        /// <param name="id">The skin id.</param>
        /// <param name="requestedLanguage">(Optional) Request localized information.</param>
        /// <returns>Skin that matches with the id.</returns>
        public Skin GetById(int id, RequestedLanguage requestedLanguage = RequestedLanguage.En) 
        {
            return DeserializeObject<Skin>(string.Format("https://api.guildwars2.com/v2/skins/{0}?lang={1}", id, requestedLanguage));
        }

        /// <summary>
        /// Returns all known skins.
        /// </summary>
        /// <param name="requestedLanguage">(Optional) Request localized information.</param>
        /// <returns>All known skins.</returns>
        public Dictionary<int, Lazy<Skin>> GetAll(RequestedLanguage requestedLanguage = RequestedLanguage.En)
        {
            List<int> skinIds = DeserializeObject<List<int>>(string.Format("https://api.guildwars2.com/v2/skins"));

            var skins = new Dictionary<int, Lazy<Skin>>();
            foreach (var skinId in skinIds)
            {
                skins.Add(skinId, new Lazy<Skin>(() => GetById(skinId, requestedLanguage)));
            }

            return skins;
        }
    }
}
