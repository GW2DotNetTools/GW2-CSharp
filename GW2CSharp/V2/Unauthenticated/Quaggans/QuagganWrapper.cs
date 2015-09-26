using System;
using System.Collections.Generic;

namespace GW2CSharp.V2.Unauthenticated.Quaggans
{
    /// <summary>
    /// Represents a wrapper for the v2/quaggans endpoint.
    /// </summary>
    public class QuagganWrapper : ApiBase
    {
        /// <summary>
        /// Returns all known quaggans.
        /// </summary>
        /// <returns>All known quaggans</returns>
        public Dictionary<string, Lazy<Quaggan>> GetAll()
        {
            List<string> quagganIds = DeserializeObject<List<string>>("https://api.guildwars2.com/v2/quaggans");

            var quaggans = new Dictionary<string, Lazy<Quaggan>>();
            foreach (var quagganId in quagganIds)
            {
                quaggans.Add(quagganId, new Lazy<Quaggan>(() => Get(quagganId)));
            }

            return quaggans;
        }

        /// <summary>
        /// Returns a single quaggan that matches the id.
        /// </summary>
        /// <param name="id">The quaggan identifier.</param>
        /// <returns>Quaggan that matches the id.</returns>
        public Quaggan Get(string id)
        {
            return DeserializeObject<Quaggan>(string.Format("https://api.guildwars2.com/v2/quaggans/{0}", id));
        }
    }
}
