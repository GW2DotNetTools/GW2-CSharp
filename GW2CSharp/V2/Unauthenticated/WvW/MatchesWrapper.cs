﻿using GW2CSharp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GW2CSharp.V2.Unauthenticated.WvW
{
	/// <summary>
	/// A wrapper for accessing the wvw matches
	/// </summary>
	public class MatchesWrapper : ApiBase
	{
        private RequestedLanguage language;

        /// <summary>
        /// Returns a wrapper for all the wvw matches endpoint calls.
        /// </summary>
        /// <param name="language">Represents the language which the API should return.</param>
        public MatchesWrapper(RequestedLanguage language)
        {
            this.language = language;
        }

        /// <summary>
        /// Get a match using its id
        /// </summary>
        /// <param name="id">The id of the match</param>
        /// <returns>A match containing the results</returns>
        public Matches GetById(string id)
		{
			return GetById(id, language);
		}

        /// <summary>
        /// Get a match using its id
        /// </summary>
        /// <param name="id">The id of the match</param>
        /// <param name="requestedLanguage">The language to display the results in</param>
        /// <returns>A match containing the results</returns>
        public Matches GetById(string id, RequestedLanguage requestedLanguage)
        {
            return DeserializeObject<Matches>(string.Format("https://api.guildwars2.com/v2/wvw/matches?id={0}&lang={1}", id, requestedLanguage));
        }

        /// <summary>
        /// Get an match using its id
        /// </summary>
        /// <param name="worldId">The id of the match</param>
        /// <returns>An match containing the results</returns>
        public Matches GetByWorldId(int worldId)
		{
            return GetByWorldId(worldId, language);
		}

        /// <summary>
        /// Get an match using its id
        /// </summary>
        /// <param name="worldId">The id of the match</param>
        /// <param name="requestedLanguage">The language to display the results in</param>
        /// <returns>An match containing the results</returns>
        public Matches GetByWorldId(int worldId, RequestedLanguage requestedLanguage)
        {
            return DeserializeObject<Matches>(string.Format("https://api.guildwars2.com/v2/wvw/matches?world={0}&lang={1}", worldId, requestedLanguage));
        }

        /// <summary>
        /// Returns all the matches
        /// </summary>
        /// <returns>A list of lazy initialised matches</returns>
        public IEnumerable<Lazy<Matches>> GetAll()
		{
            return GetAll(language);
		}

        /// <summary>
        /// Returns all the matches
        /// </summary>
        /// <param name="requestedLanguage">The language to display the results in</param>
        /// <returns>A list of lazy initialised matches</returns>
        public IEnumerable<Lazy<Matches>> GetAll(RequestedLanguage requestedLanguage)
        {
            List<string> matchIds = DeserializeObject<List<string>>("https://api.guildwars2.com/v2/wvw/matches");

            var matches = new List<Lazy<Matches>>();
            foreach (var matchesId in matchIds)
            {
                matches.Add(new Lazy<Matches>(() => GetById(matchesId, requestedLanguage)));
            }
            return matches;
        }

        /// <summary>
        /// Fetch multiple matches
        /// </summary>
        /// <param name="ids">The ids to fetch</param>
        /// <returns>A list of lazy initialised matches</returns>
        public IEnumerable<Lazy<Matches>> GetMultipleById(params string[] ids)
        {
            return GetMultipleById(ids.ToList());
        }

        /// <summary>
        /// Returns all the matches
        /// </summary>
        /// <param name="ids">The ids to return</param>
        /// <returns>A list of lazy initialised matches</returns>
        public IEnumerable<Lazy<Matches>> GetMultipleById(List<string> ids)
		{
            return GetMultipleById(ids, language);
		}

        /// <summary>
        /// Returns all the matches
        /// </summary>
        /// <param name="ids">The ids to return</param>
        /// <param name="requestedLanguage">The language to display the results in</param>
        /// <returns>A list of lazy initialised matches</returns>
        public IEnumerable<Lazy<Matches>> GetMultipleById(List<string> ids, RequestedLanguage requestedLanguage)
        {
            string url = "https://api.guildwars2.com/v2/wvw/matches?ids=";
            foreach (var id in ids)
            {
                url += id + ",";
            }
            return DeserializeObject<List<Lazy<Matches>>>(url);
        }
	}
}
