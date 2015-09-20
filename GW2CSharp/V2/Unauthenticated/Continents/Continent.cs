using System.Collections.Generic;

namespace GW2CSharp.V2.Unauthenticated.Continents
{
    /// <summary>
    /// Represents a continent of the v2/continents endpoint.
    /// </summary>
    public class Continent
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Continent"/> class.
        /// </summary>
        /// <param name="id">The id of the continent.</param>
        /// <param name="name">The name of the continent.</param>
        /// <param name="dimension">The width and height dimensions of the continent.</param>
        /// <param name="minZoom">The minimal zoom level for use with the map tile service.</param>
        /// <param name="maxZoom">The maximum zoom level for use with the map tile service.</param>
        /// <param name="floors">A list of floors available for this continent.</param>
        public Continent(int id, string name, List<int> dimension, int minZoom, int maxZoom, IEnumerable<Floor> floors)
        {
            Id = id;
            Name = name;
            Dimension = new Coordinate<int>(dimension[0], dimension[1]);
            MinZoom = minZoom;
            MaxZoom = maxZoom;
            Floors = floors;
        }

        /// <summary>
        /// The id of the continent.
        /// </summary>
        public int Id { get; private set; }

        /// <summary>
        /// The name of the continent.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// The width and height dimensions of the continent.
        /// </summary>
        public Coordinate<int> Dimension { get; private set; }

        /// <summary>
        /// The minimal zoom level for use with the map tile service.
        /// </summary>
        public int MinZoom { get; private set; }

        /// <summary>
        /// The maximum zoom level for use with the map tile service.
        /// </summary>
        public int MaxZoom { get; private set; }

        /// <summary>
        /// A list of floors available for this continent.
        /// </summary>
        public IEnumerable<Floor> Floors { get; private set; }
    }
}
