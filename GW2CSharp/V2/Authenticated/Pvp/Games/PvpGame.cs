using GW2CSharp.Enums;
using GW2CSharp.V2.Authenticated.Pvp.Games.Enums;
using System;

namespace GW2CSharp.V2.Authenticated.Pvp.Games
{
    /// <summary>
    /// Represents the v2/pvp/games endpoint.
    /// </summary>
    public class PvpGame
    {
        /// <summary>
        /// Initilitation of a new pvpgame object.
        /// </summary>
        /// <param name="id">The game's UUID.</param>
        /// <param name="map_id">The map the match was played on, cross-referenced from /v2/maps.</param>
        /// <param name="started">A timestamp of when the match started.</param>
        /// <param name="ended">A timestamp of when the match ended.</param>
        /// <param name="result">The result of the match.</param>
        /// <param name="team">The team the player was on during the match.</param>
        /// <param name="profession">The profession the player was playing during the match.</param>
        /// <param name="scores">The ending score of the teams.</param>
        public PvpGame(string id, int map_id, DateTime started, DateTime ended, string result, Team team, Profession profession, Score scores)
        {
            Id = id;
            MapId = map_id;
            Started = started;
            Ended = ended;
            Result = result;
            Team = team;
            Profession = profession;
            Score = scores;
        }

        /// <summary>
        /// The game's UUID.
        /// </summary>
        public string Id { get; private set; }

        /// <summary>
        /// The map the match was played on, cross-referenced from /v2/maps.
        /// </summary>
        public int MapId { get; private set; }

        /// <summary>
        /// A timestamp of when the match started.
        /// </summary>
        public DateTime Started { get; private set; }

        /// <summary>
        /// A timestamp of when the match ended.
        /// </summary>
        public DateTime Ended { get; private set; }

        /// <summary>
        /// The result of the match.
        /// </summary>
        public string Result { get; private set; }

        /// <summary>
        /// The team the player was on during the match.
        /// </summary>
        public Team Team { get; private set; }

        /// <summary>
        /// The profession the player was playing during the match.
        /// </summary>
        public Profession Profession { get; private set; }

        /// <summary>
        /// The ending score of the teams.
        /// </summary>
        public Score Score { get; private set; }
    }
}
