using GW2CSharp.Enums;
using GW2CSharp.V2.Authenticated.Pvp.Stats.Enums;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace GW2CSharp.V2.Authenticated.Pvp.Stats
{
    /// <summary>
    /// Represents the v2/pvp/stats endpoint.
    /// </summary>
    public class PvpStatistic
    {
        /// <summary>
        /// Initilization of a new pvpstatistic object.
        /// </summary>
        /// <param name="pvp_rank">The player's PvP rank.</param>
        /// <param name="aggregate">A win/loss object containing stats from all matches ever played.</param>
        /// <param name="professions">Collection for each profession played in PvP.</param>
        /// <param name="ladders">Collection for each type of the ladder.</param>
        public PvpStatistic(int pvp_rank, Statistic aggregate, Dictionary<Profession, Statistic> professions, Dictionary<Ladder, Statistic> ladders)
        {
            Rank = pvp_rank;
            Overview = aggregate;
            Professions = professions;
            Ladders = ladders;
        }

        /// <summary>
        /// The player's PvP rank.
        /// </summary>
        public int Rank { get; private set; }

        /// <summary>
        /// A win/loss object containing stats from all matches ever played.
        /// </summary>
        public Statistic Overview { get; private set; }

        /// <summary>
        /// Collection for each profession played in PvP.
        /// </summary>
        public Dictionary<Profession, Statistic> Professions { get; private set; } 

        /// <summary>
        /// Collection for each type of the ladder.
        /// </summary>
        public Dictionary<Ladder, Statistic> Ladders { get; private set; }
    }
}
