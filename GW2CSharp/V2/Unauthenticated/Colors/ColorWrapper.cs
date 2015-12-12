using GW2CSharp.Enums;
using System;
using System.Collections.Generic;

namespace GW2CSharp.V2.Unauthenticated.Colors
{
    /// <summary>
    /// Represents a wrapper for the v2/colors endpoint.
    /// </summary>
    /// <example><code source="Examples.cs" region="Color" /></example>
    public class ColorWrapper : ApiBase
    {
        private RequestedLanguage language;

        /// <summary>
        /// A wrapper for all color endpoint calls.
        /// </summary>
        /// <param name="language">Represents the language which the API should return.</param>
        public ColorWrapper(RequestedLanguage language)
        {
            this.language = language;
        }

        /// <summary>
        /// Returns the color that matches the id.
        /// </summary>
        /// <param name="id">The color id.</param>
        /// <returns>Color that matches the id.</returns>
        public Color GetById(int id)
        {
            return GetById(id, language);
        }

        /// <summary>
        /// Returns the color that matches the id.
        /// </summary>
        /// <param name="id">The color id.</param>
        /// <param name="requestedLanguage">Represents the language which the API should return. Default english.</param>
        /// <returns>Color that matches the id.</returns>
        public Color GetById(int id, RequestedLanguage requestedLanguage)
        {
            return DeserializeObject<Color>(string.Format("https://api.guildwars2.com/v2/colors/{0}?lang={1}", id, requestedLanguage));
        }

        /// <summary>
        /// Returns the a Dictionary with all known colors.
        /// </summary>
        /// <returns>Dictionary with all known colors.</returns>
        public Dictionary<int, Lazy<Color>> GetAll()
        {
            return GetAll(language);
        }

        /// <summary>
        /// Returns the a Dictionary with all known colors.
        /// </summary>
        /// <param name="requestedLanguage">Represents the language which the API should return. Default english.</param>
        /// <returns>Dictionary with all known colors.</returns>
        public Dictionary<int, Lazy<Color>> GetAll(RequestedLanguage requestedLanguage = RequestedLanguage.En)
        {
            List<int> colorIds = DeserializeObject<List<int>>("https://api.guildwars2.com/v2/colors");

            var colors = new Dictionary<int, Lazy<Color>>();
            foreach (var colorId in colorIds)
            {
                colors.Add(colorId, new Lazy<Color>(() => GetById(colorId, requestedLanguage)));
            }
            return colors;
        }

        /// <summary>
        /// Returns colors in pagesize.
        /// </summary>
        /// <param name="page">Page number.</param>
        /// <param name="pageSize">Size of colors on one page.</param>
        /// <returns>Color object on the given page.</returns>
        public IEnumerable<Color> GetByPage(int page, int pageSize)
        {
            return GetByPage(page, pageSize, language);
        }

        /// <summary>
        /// Returns colors in pagesize.
        /// </summary>
        /// <param name="page">Page number.</param>
        /// <param name="pageSize">Size of colors on one page.</param>
        /// <param name="requestedLanguage">Represents the language which the API should return. Default english.</param>
        /// <returns>Color object on the given page.</returns>
        public IEnumerable<Color> GetByPage(int page, int pageSize, RequestedLanguage requestedLanguage)
        {
            return DeserializeObject<IEnumerable<Color>>(string.Format("https://api.guildwars2.com/v2/colors?page={0}&page_size={1}&lang={2}", page, pageSize, requestedLanguage));
        }
    }
}
