using GW2CSharp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GW2CSharp.V2.Unauthenticated.WvW
{
	/// <summary>
	/// A wrapper for accessing the wvw objectives
	/// </summary>
	public class ObjectivesWrapper : ApiBase
	{
        private RequestedLanguage language;

        /// <summary>
        /// Returns a wrapper for all the wvw objectives endpoint calls.
        /// </summary>
        /// <param name="language">Represents the language which the API should return.</param>
        public ObjectivesWrapper(RequestedLanguage language)
        {
            this.language = language;
        }

        /// <summary>
        /// Get an objective using its id
        /// </summary>
        /// <param name="id">The id of the objective</param>
        /// <returns>An objective containing the results</returns>
        public Objectives GetById(string id)
		{
            return GetById(id, language);
		}

        /// <summary>
        /// Get an objective using its id
        /// </summary>
        /// <param name="id">The id of the objective</param>
        /// <param name="requestedLanguage">The language to display the results in</param>
        /// <returns>An objective containing the results</returns>
        public Objectives GetById(string id, RequestedLanguage requestedLanguage)
        {
            return DeserializeObject<Objectives>(string.Format("https://api.guildwars2.com/v2/wvw/objectives?id={0}&lang={1}", id, requestedLanguage));
        }

        /// <summary>
        /// Returns all the objectives
        /// </summary>
        /// <returns>A list of lazy initialised objects</returns>
        public IEnumerable<Lazy<Objectives>> GetAll()
		{
            return GetAll(language);
		}

        /// <summary>
        /// Returns all the objectives
        /// </summary>
        /// <param name="requestedLanguage">The language to display the results in</param>
        /// <returns>A list of lazy initialised objects</returns>
        public IEnumerable<Lazy<Objectives>> GetAll(RequestedLanguage requestedLanguage)
        {
            List<string> ObjectivesIds = DeserializeObject<List<string>>("https://api.guildwars2.com/v2/wvw/objectives");

            var objectives = new List<Lazy<Objectives>>();
            foreach (var objectivesId in ObjectivesIds)
            {
                objectives.Add(new Lazy<Objectives>(() => GetById(objectivesId, requestedLanguage)));
            }
            return objectives;
        }

        /// <summary>
        /// Fetch multiple objectives
        /// </summary>
        /// <param name="ids">The ids to fetch</param>
        /// <returns>A list of lazy initialised objectives</returns>
        public IEnumerable<Lazy<Objectives>> GetMultiple(params string[] ids)
        {
            return GetMultiple(ids.ToList());
        }

        /// <summary>
        /// Returns all the objectives
        /// </summary>
        /// <param name="ids">The ids to return</param>
        /// <returns>A list of lazy initialised objectives</returns>
        public IEnumerable<Lazy<Objectives>> GetMultiple(List<string> ids)
		{
            return GetMultiple(ids, language);
		}

        /// <summary>
        /// Returns all the objectives
        /// </summary>
        /// <param name="ids">The ids to return</param>
        /// <param name="requestedLanguage">The language to display the results in</param>
        /// <returns>A list of lazy initialised objectives</returns>
        public IEnumerable<Lazy<Objectives>> GetMultiple(List<string> ids, RequestedLanguage requestedLanguage = RequestedLanguage.En)
        {
            string url = "https://api.guildwars2.com/v2/wvw/objectives?ids=";
            foreach (var id in ids)
            {
                url += id + ",";
            }
            return DeserializeObject<List<Lazy<Objectives>>>(url);
        }
	}
}
