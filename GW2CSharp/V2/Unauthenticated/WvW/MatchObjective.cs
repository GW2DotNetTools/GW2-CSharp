using GW2CSharp.V2.Unauthenticated.WvW.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GW2CSharp.V2.Unauthenticated.WvW
{
	/// <summary>
	/// The current objectives in this match
	/// </summary>
	public class MatchObjective
	{
		/// <summary>
		/// The objective id.
		/// </summary>
		public string Id { get; set; }

		/// <summary>
		/// 
		/// </summary>
		public string Type { get; set; }

		/// <summary>
		/// The current owner of the objective.
		/// </summary>
		public Owner Owner { get; set; }

		/// <summary>
		/// The time at which this objective was last captured by a server. (ISO-8601 Standard)
		/// </summary>
		public DateTime LastFlipped { get; set; }

		/// <summary>
		/// The guild id of the guild currently claiming the objective, or null if not claimed.
		/// </summary>
		public string ClaimedBy { get; set; }

		/// <summary>
		/// The time the objective was claimed by the claimed_by guild (ISO-8601 Standard), or null if not claimed.
		/// </summary>
		public DateTime? ClaimedAt { get; set; }
	}
}
