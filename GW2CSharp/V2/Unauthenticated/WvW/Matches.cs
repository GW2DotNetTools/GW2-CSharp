using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GW2CSharp.V2.Unauthenticated.WvW
{
	/// <summary>
	/// This resource returns further details about the specified match, including the total score, kills and deaths, and further details for each map.
	/// </summary>
	public class Matches
	{
		/// <summary>
		/// The resource constructor
		/// </summary>
		/// <param name="id">The WvW match id.</param>
		/// <param name="start_time">The starting time of the matchup. (ISO-8601 Standard)</param>
		/// <param name="end_time">The ending time of the matchup. (ISO-8601 Standard)</param>
		/// <param name="scores">An object containing the score of the three servers</param>
		/// <param name="worlds">An object containing the world IDs of the three servers</param>
		/// <param name="kills">An object containing the total kills of the three servers</param>
		/// <param name="deaths">An object containing the total deaths of the three servers</param>
		/// <param name="maps">A list of objects containing detailed information about each of the four maps.</param>
		public Matches(string id, DateTime start_time, DateTime end_time, Scores scores, Worlds worlds, Kills kills, Deaths deaths, List<Map> maps)
		{
			Id = id;
			StartTime = start_time;
			EndTime = end_time;
			Scores = scores;
			Worlds = worlds;
			Deaths = deaths;
			Kills = kills;
			Maps = maps;
		}

		/// <summary>
		/// The WvW match id.
		/// </summary>
		public string Id { get; set; }

		/// <summary>
		/// The starting time of the matchup. (ISO-8601 Standard)
		/// </summary>
		public DateTime StartTime { get; set; }

		/// <summary>
		/// The ending time of the matchup. (ISO-8601 Standard)
		/// </summary>
		public DateTime EndTime { get; set; }

		/// <summary>
		/// An object containing the score of the three servers
		/// </summary>
		public Scores Scores { get; set; }

		/// <summary>
		/// An object containing the world IDs of the three servers
		/// </summary>
		public Worlds Worlds { get; set; }

		/// <summary>
		/// An object containing the total deaths of the three servers
		/// </summary>
		public Deaths Deaths { get; set; }

		/// <summary>
		/// An object containing the total kills of the three servers
		/// </summary>
		public Kills Kills { get; set; }

		/// <summary>
		/// A list of objects containing detailed information about each of the four maps.
		/// </summary>
		public List<Map> Maps { get; set; }
	}
}
