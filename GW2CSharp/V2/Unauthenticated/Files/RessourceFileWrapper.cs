using System.Collections.Generic;

namespace GW2CSharp.V2.Unauthenticated.Files
{
    /// <summary>
    /// Represents a wrapper for the v2/quaggans endpoint.
    /// </summary>
    /// <example><code source="Examples.cs" region="RessourceFile" /></example>
    public class RessourceFileWrapper : ApiBase
    {
        /// <summary>
        /// Returns a single RessourceFile that matches the id.
        /// </summary>
        /// <param name="id">The file identifier.</param>
        /// <returns>RessourceFile that matches the id.</returns>
        public RessourceFile Get(string id) 
        {
            return DeserializeObject<RessourceFile>(string.Format("https://api.guildwars2.com/v2/files?id={0}", id));
        }

        /// <summary>
        /// Returns all RessourceFiles that matches the id.
        /// </summary>
        /// <param name="ids">The file identifier.</param>
        /// <returns>RessourceFiles that matches the id.</returns>
        public IEnumerable<RessourceFile> GetMultiple(params string[] ids)
        {
            return GetMultiple(new List<string>(ids));
        }

        /// <summary>
        /// Returns all RessourceFiles that matches the id.
        /// </summary>
        /// <param name="ids">The file identifiers.</param>
        /// <returns>RessourceFiles that matches the id.</returns>
        public IEnumerable<RessourceFile> GetMultiple(IEnumerable<string> ids)
        {
            string url = "https://api.guildwars2.com/v2/files?ids=";
            foreach (var id in ids)
            {
                url += id + ",";
            }

            return DeserializeObject<IEnumerable<RessourceFile>>(url);
        }

        /// <summary>
        /// Returns all RessourceFiles.
        /// </summary>
        /// <returns>All RessourceFiles.</returns>
        public IEnumerable<RessourceFile> GetAll()
        {
            return DeserializeObject<IEnumerable<RessourceFile>>("https://api.guildwars2.com/v2/files?ids=all");
        }
    }
}
