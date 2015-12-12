using GW2CSharp.Enums;
using System;
using System.Collections.Generic;

namespace GW2CSharp.V2.Unauthenticated.Achievement
{
    /// <summary>
    /// Represents a wrapper for the v2/achievements endpoint.
    /// </summary>
    /// <example><code source="Examples.cs" region="Achievement" /></example>
    public class AchievementWrapper : ApiBase
    {
        private RequestedLanguage language;

        /// <summary>
        /// Returns a wrapper for all achievements endpoint calls.
        /// </summary>
        /// <param name="language">Represents the language which the API should return.</param>
        public AchievementWrapper(RequestedLanguage language)
        {
            this.language = language;
        }

        /// <summary>
        /// Returns achievement that matches the id.
        /// </summary>
        /// <param name="id">The achievement id.</param>
        /// <returns>Achievment that matches the id.</returns>
        public Achievement Get(int id)
        {
            return Get(id, language);
        }

        /// <summary>
        /// Returns achievement that matches the id.
        /// </summary>
        /// <param name="id">The achievement id.</param>
        /// <param name="requestedLanguage">Language in which the object should be.</param>
        /// <returns>Achievment that matches the id.</returns>
        public Achievement Get(int id, RequestedLanguage requestedLanguage)
        {
            return DeserializeObject<Achievement>(string.Format("https://api.guildwars2.com/v2/achievements?id={0}&lang={1}", id, requestedLanguage));
        }

        /// <summary>
        /// Returns all achievements.
        /// </summary>
        /// <returns>All Achievments.</returns>
        public Dictionary<int, Lazy<Achievement>> GetAll()
        {
            return GetAll(language);
        }

        /// <summary>
        /// Returns all achievements.
        /// </summary>
        /// <param name="requestedLanguage">Language in which the object should be.</param>
        /// <returns>All Achievments.</returns>
        public Dictionary<int, Lazy<Achievement>> GetAll(RequestedLanguage requestedLanguage)
        {
            List<int> ids = DeserializeObject<List<int>>("https://api.guildwars2.com/v2/achievements");
            return InitLazyAchievements(requestedLanguage, ids);
        }

        /// <summary>
        /// Returns all achievements that match the ids.
        /// </summary>
        /// <param name="ids">The achievement ids.</param>
        /// <returns>Achievements that match the ids.</returns>
        public Dictionary<int, Lazy<Achievement>> GetMultiple(params int[] ids)
        {
            return InitLazyAchievements(language, ids);
        }

        /// <summary>
        /// Returns all achievements that match the ids.
        /// </summary>
        /// <param name="requestedLanguage">Language in which the object should be.</param>
        /// <param name="ids">The achievement ids.</param>
        /// <returns>Achievements that match the ids.</returns>
        public Dictionary<int, Lazy<Achievement>> GetMultiple(RequestedLanguage requestedLanguage, params int[] ids)
        {
            return InitLazyAchievements(requestedLanguage, ids);
        }

        private Dictionary<int, Lazy<Achievement>> InitLazyAchievements(RequestedLanguage requestedLanguage, IEnumerable<int> ids)
        {
            Dictionary<int, Lazy<Achievement>> achievements = new Dictionary<int, Lazy<Achievement>>();
            foreach (var id in ids)
            {
                achievements.Add(id, new Lazy<Achievement>(() => Get(id, requestedLanguage)));
            }

            return achievements;
        }
    }
}
