using GW2CSharp.Enums;
using System;
using System.Collections.Generic;

namespace GW2CSharp.V2.Unauthenticated.Achievement
{
    /// <summary>
    /// Represents a wrapper for the v2/achievements endpoint.
    /// </summary>
    public class AchievementWrapper : ApiBase
    {
        /// <summary>
        /// Returns achievement that matches the id.
        /// </summary>
        /// <param name="id">The achievement id.</param>
        /// <param name="requestedLanguage">Language in which the object should be.</param>
        /// <returns>Achievment that matches the id.</returns>
        public Achievement Get(int id, RequestedLanguage requestedLanguage = RequestedLanguage.En)
        {
            return DeserializeObject<Achievement>(string.Format("https://api.guildwars2.com/v2/achievements?id={0}&lang={1}", id, requestedLanguage));
        }

        /// <summary>
        /// Returns all achievements.
        /// </summary>
        /// <param name="requestedLanguage">Language in which the object should be.</param>
        /// <returns>All Achievments.</returns>
        public Dictionary<int, Lazy<Achievement>> GetAll(RequestedLanguage requestedLanguage = RequestedLanguage.En)
        {
            List<int> ids = DeserializeObject<List<int>>("https://api.guildwars2.com/v2/achievements");
            return InitLazyAchievements(requestedLanguage, ids);
        }

        /// <summary>
        /// Returns all achievements that match the ids.
        /// </summary>
        /// <param name="requestedLanguage">Language in which the object should be.</param>
        /// <param name="ids">The achievement ids.</param>
        /// <returns>Achievements that match the ids.</returns>
        public Dictionary<int, Lazy<Achievement>> GetMultiple(RequestedLanguage requestedLanguage = RequestedLanguage.En, params int[] ids)
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
