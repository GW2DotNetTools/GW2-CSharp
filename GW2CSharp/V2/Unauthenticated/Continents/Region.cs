using System.Collections.Generic;

namespace GW2CSharp.V2.Unauthenticated.Continents
{
    /// <summary>
    /// Represents a single Region.
    /// </summary>
    public class Region
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Region"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="coord">The coord.</param>
        /// <param name="maps">The maps.</param>
        public Region(string name, List<double> coord, IEnumerable<Map> maps)
        {
            Name = name;
            Coordinate = new Coordinate<double>(coord[0], coord[1]);
            Maps = maps;
        }

        /// <summary>
        /// Gets the name.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Gets the coordinate.
        /// </summary>
        public Coordinate<double> Coordinate { get; private set; }

        /// <summary>
        /// Gets the maps.
        /// </summary>
        public IEnumerable<Map> Maps { get; private set; }
    }
}
