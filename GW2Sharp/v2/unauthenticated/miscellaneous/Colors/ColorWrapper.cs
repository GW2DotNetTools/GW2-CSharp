using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace GW2Sharp.V2.Unauthenticated.Miscellaneous.Colors
{
    /// <summary>
    /// Represents a wrapper for the v2/colors endpoint.
    /// </summary>
    public class ColorWrapper : ApiBase
    {
        /// <summary>
        /// Returns the color that matches the id.
        /// <para>Endpoint: https://api.guildwars2.com/v2/colors/{0}?lang={1}</para>
        /// </summary>
        /// <param name="id">The color id.</param>
        /// <param name="requestedLanguage">Represents the language which the API should return. Default english.</param>
        /// <returns>Color that matches the id.</returns>
        public Color GetColorById(int id, RequestedLanguage requestedLanguage = RequestedLanguage.en)
        {
            string jsonString = DownloadJsonString(string.Format("https://api.guildwars2.com/v2/colors/{0}?lang={1}", id, requestedLanguage));
            return JsonConvert.DeserializeObject<Color>(jsonString);
        }

        /// <summary>
        /// Returns the a Dictionary with all known colors.
        /// <para>Endpoint: https://api.guildwars2.com/v2/colors</para>
        /// </summary>
        /// <param name="requestedLanguage">Represents the language which the API should return. Default english.</param>
        /// <returns>Dictionary with all known colors.</returns>
        public Dictionary<int, Lazy<Color>> GetAllColors(RequestedLanguage requestedLanguage = RequestedLanguage.en) 
        {
            string jsonString = DownloadJsonString(string.Format("https://api.guildwars2.com/v2/colors"));

            List<int> colorIds = JsonConvert.DeserializeObject<List<int>>(jsonString);

            var colors = new Dictionary<int, Lazy<Color>>();
            foreach (var colorId in colorIds)
            {
                colors.Add(colorId, new Lazy<Color>(() => GetColorById(colorId, requestedLanguage)));
            }
            return colors;
        }
    }
}
