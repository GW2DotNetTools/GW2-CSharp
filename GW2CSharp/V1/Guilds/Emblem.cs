using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GW2CSharp.V1.Guilds.Enum;

namespace GW2CSharp.V1.Guilds
{
	/// <summary>
	/// 
	/// </summary>
	public class Emblem
	{
		/// <summary>
		/// 
		/// </summary>
		public string BackgroundId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		public string ForegroundId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		public Flag Flags { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public int BackgroundColorId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		public int ForegroundPrimaryColorId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		public int ForegroundSecondaryColorId { get; set; }
	}
}
