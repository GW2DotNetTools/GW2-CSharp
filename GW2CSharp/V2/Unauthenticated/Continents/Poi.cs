using GW2CSharp.V2.Unauthenticated.Continents.Enums;
using System.Collections.Generic;

namespace GW2CSharp.V2.Unauthenticated.Continents
{
    /// <summary>
    /// Represents a single poi.
    /// </summary>
    public class Poi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Poi"/> class.
        /// </summary>
        /// <param name="name">The name of the point of interest.</param>
        /// <param name="type">The type. <see cref="PoiType"/> </param>
        /// <param name="coord">The coordinates of this object.</param>
        /// <param name="id">The point of interest id.</param>
        /// <param name="chat_link">The link that can be used ingame.</param>
        public Poi(string name, PoiType type, List<double> coord, int id, string chat_link)
        {
            Name = name;
            Type = type;
            Coordinate = new Coordinate<double>(coord[0], coord[1]);
            Id = id;
            ChatLink = chat_link;
        }

        /// <summary>
        /// The name of the point of interest.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// >The type. <see cref="PoiType"/>
        /// </summary>
        public PoiType Type { get; private set; }

        /// <summary>
        /// The coordinates of this object.
        /// </summary>
        public Coordinate<double> Coordinate { get; private set; }

        /// <summary>
        /// The point of interest id.
        /// </summary>
        public int Id { get; private set; }

        /// <summary>
        /// The link that can be used ingame.
        /// </summary>
        public string ChatLink { get; private set; }
    }
}
