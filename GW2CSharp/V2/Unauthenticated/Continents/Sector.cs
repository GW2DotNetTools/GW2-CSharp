using System.Collections.Generic;

namespace GW2CSharp.V2.Unauthenticated.Continents
{
    /// <summary>
    /// Represents a single Sector.
    /// </summary>
    public class Sector
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Sector"/> class.
        /// </summary>
        /// <param name="id">The area id.</param>
        /// <param name="name">The name of the area.</param>
        /// <param name="level">The level of the area.</param>
        /// <param name="coord">The coordinates of this area (this is usually the center position).</param>
        /// <param name="chat_link">The link that can be used ingame.</param>
        public Sector(int id, string name, int level, List<double> coord, string chat_link)
        {
            Id = id;
            Name = name;
            Level = level;
            Coordinate = new Coordinate<double>(coord[0], coord[1]);
            ChatLink = chat_link;
        }

        /// <summary>
        /// The area id.
        /// </summary>
        public int Id { get; private set; }

        /// <summary>
        /// The name of the area.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// The level of the area.
        /// </summary>
        public int Level { get; private set; }

        /// <summary>
        /// The coordinates of this area (this is usually the center position).
        /// </summary>
        public Coordinate<double> Coordinate { get; private set; }

        /// <summary>
        /// The link that can be used ingame.
        /// </summary>
        public string ChatLink { get; private set; }
    }
}
