using GW2CSharp.V2.Unauthenticated.WvW.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GW2CSharp.V2.Unauthenticated.WvW
{
	/// <summary>
	/// An object containing details about the four maps
	/// </summary>
	public class Map
	{
		/// <summary>
		/// The map constructor
		/// </summary>
		/// <param name="id">The map id</param>
		/// <param name="type">The identifier for the map.</param>
		/// <param name="scores">An object containing the score of the three servers for only the specified map</param>
		/// <param name="bonuses">A list of all bonuses being granted by this map. If no player team owns a bonus from the map, this list is empty.</param>
		/// <param name="deaths">An object containing the total deaths of the three servers for only the specified map</param>
		/// <param name="kills">An object containing the total kills of the three servers for only the specified map</param>
		/// <param name="objectives">A list of objective objects for this map</param>
		public Map(int id, MapType type, Scores scores, List<Bonus> bonuses, Deaths deaths, Kills kills, List<MatchObjective> objectives)
		{
			Id = id;
			Type = type;
			Scores = scores;
			Bonuses = bonuses;
			Deaths = deaths;
			Kills = kills;
			Objectives = objectives;
		}

		/// <summary>
		/// The map id
		/// </summary>
		public int Id { get; set; }

		/// <summary>
		/// The identifier for the map.
		/// </summary>
		public MapType Type { get; set; }

		/// <summary>
		/// An object containing the score of the three servers for only the specified map
		/// </summary>
		public Scores Scores { get; set; }

		/// <summary>
		/// A list of all bonuses being granted by this map. If no player team owns a bonus from the map, this list is empty. 
		/// </summary>
		public List<Bonus> Bonuses { get; set; }

		/// <summary>
		/// An object containing the total deaths of the three servers for only the specified map
		/// </summary>
		public Deaths Deaths { get; set; }

		/// <summary>
		/// An object containing the total kills of the three servers for only the specified map
		/// </summary>
		public Kills Kills { get; set; }

		/// <summary>
		/// A list of objective objects for this map
		/// </summary>
		public List<MatchObjective> Objectives { get; set; }
	}
}
