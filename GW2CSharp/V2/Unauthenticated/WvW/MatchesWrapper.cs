using GW2CSharp.Enums;
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
		/// <summary>
		/// Get a match using its id
		/// </summary>
		/// <param name="id">The id of the match</param>
		/// <param name="requestedLanguage">The language to display the results in</param>
		/// <returns>A match containing the results</returns>
		public Matches GetById(string id, RequestedLanguage requestedLanguage = RequestedLanguage.En)
		{
			return DeserializeObject<Matches>($"https://api.guildwars2.com/v2/wvw/matches?id={id}&lang={requestedLanguage}");
		}

		/// <summary>
		/// Get an match using its id
		/// </summary>
		/// <param name="worldId">The id of the match</param>
		/// <param name="requestedLanguage">The language to display the results in</param>
		/// <returns>An match containing the results</returns>
		public Matches GetByWorldId(int worldId, RequestedLanguage requestedLanguage = RequestedLanguage.En)
		{
			return DeserializeObject<Matches>($"https://api.guildwars2.com/v2/wvw/matches?world={worldId}&lang={requestedLanguage}");
		}

		/// <summary>
		/// Returns all the matches
		/// </summary>
		/// <param name="requestedLanguage">The language to display the results in</param>
		/// <returns>A list of lazy initialised matches</returns>
		public IEnumerable<Lazy<Matches>> GetAll(RequestedLanguage requestedLanguage = RequestedLanguage.En)
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
		/// Returns all the matches
		/// </summary>
		/// <param name="ids">The ids to return</param>
		/// <param name="requestedLanguage">The language to display the results in</param>
		/// <returns>A list of lazy initialised matches</returns>
		public IEnumerable<Lazy<Matches>> GetMultipleById(List<string> ids, RequestedLanguage requestedLanguage = RequestedLanguage.En)
		{
			string url = "https://api.guildwars2.com/v2/wvw/matches?ids=";
			foreach (var id in ids)
			{
				url += id + ",";
			}
			return DeserializeObject<List<Lazy<Matches>>>(url);
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
	}
}
