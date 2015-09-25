using System.Collections.Generic;

namespace GW2CSharp.V2.Unauthenticated.Continents
{
    /// <summary>
    /// Represents a single objective.
    /// </summary>
    public class Objective
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Objective"/> class.
        /// </summary>
        /// <param name="objective">The objective or name of the heart.</param>
        /// <param name="level">The level of the heart.</param>
        /// <param name="coord">The coordinates where it takes place.</param>
        /// <param name="id">The renown heart id.</param>
        /// <param name="chat_link">The link that can be used ingame.</param>
        public Objective(string objective, int level, List<double> coord, int id, string chat_link)
        {
            Text = objective;
            Level = level;
            Coordinate = new Coordinate<double>(coord[0], coord[1]);
            Id = id;
            ChatLink = chat_link;
        }

        /// <summary>
        /// The objective or name of the heart.
        /// </summary>
        public string Text { get; private set; }

        /// <summary>
        /// The level of the heart.
        /// </summary>
        public int Level { get; private set; }

        /// <summary>
        /// The coordinates where it takes place.
        /// </summary>
        public Coordinate<double> Coordinate { get; private set; }

        /// <summary>
        /// The renown heart id.
        /// </summary>
        public int Id { get; private set; }

        /// <summary>
        /// The link that can be used ingame.
        /// </summary>
        public string ChatLink { get; private set; }
    }
}
