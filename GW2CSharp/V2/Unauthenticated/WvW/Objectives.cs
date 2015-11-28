using GW2CSharp.V2.Unauthenticated.WvW.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GW2CSharp.V2.Unauthenticated.WvW
{
	/// <summary>
	/// This resource returns details about World vs. World objectives such as camps, towers, and keeps.
	/// </summary>
	public class Objectives
	{
		/// <summary>
		/// This resource returns details about World vs. World objectives such as camps, towers, and keeps. 
		/// </summary>
		/// <param name="id">The objective id.</param>
		/// <param name="name">The name of the objective.</param>
		/// <param name="sector_id">The map sector the objective can be found in. (See /v2/continents.)</param>
		/// <param name="type">The type of the objective</param>
		/// <param name="map_type">The map that this objective can be found on</param>
		/// <param name="map_id">The ID of the map that this objective can be found on.</param>
		/// <param name="coord">An array of three numbers representing the X, Y and Z coordinates of the objectives marker on the map.</param>
		/// <param name="label_coord">An array of two numbers representing the X and Y coordinates of the sector centroid.</param>
		/// <param name="marker">The icon link</param>
		public Objectives(string id, string name, int sector_id, ObjectiveType type, MapType map_type, int map_id, float[] coord, float[] label_coord, string marker)
		{
			Id = id;
			Name = name;
			SectorId = sector_id;
			Type = type;
			MapType = map_type;
			MapId = map_id;
			Coord = coord;
			LabelCoord = label_coord;
			Marker = marker;
		}

		/// <summary>
		/// The objective id.
		/// </summary>
		public string Id { get; set; }

		/// <summary>
		/// The name of the objective.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		///  The map sector the objective can be found in. (See /v2/continents.)
		/// </summary>
		public int SectorId { get; set; }

		/// <summary>
		/// The type of the objective
		/// </summary>
		public ObjectiveType Type { get; set; }

		/// <summary>
		/// The map that this objective can be found on
		/// </summary>
		public MapType MapType { get; set; }

		/// <summary>
		/// The ID of the map that this objective can be found on.
		/// </summary>
		public int MapId { get; set; }

		/// <summary>
		/// An array of three numbers representing the X, Y and Z coordinates of the objectives marker on the map.
		/// </summary>
		public float[] Coord { get; set; }

		/// <summary>
		/// An array of two numbers representing the X and Y coordinates of the sector centroid.
		/// </summary>
		public float[] LabelCoord { get; set; }

		/// <summary>
		/// The icon link
		/// </summary>
		public string Marker { get; set; }
	}
}
