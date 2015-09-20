using System.Collections.Generic;

namespace GW2CSharp.V2.Unauthenticated.Continents
{
    /// <summary>
    /// Represents a floor.
    /// </summary>
    public class Floor
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Floor"/> class.
        /// </summary>
        /// <param name="dimension">The dimension.</param>
        /// <param name="regions">The regions.</param>
        public Floor(List<int> dimension, IEnumerable<Region> regions)
        {
            Dimension = new Coordinate<int>(dimension[0], dimension[1]);
            Regions = regions;
        }

        /// <summary>
        /// Gets the dimension.
        /// </summary>
        public Coordinate<int> Dimension { get; private set; }

        /// <summary>
        /// Gets the regions.
        /// </summary>
        public IEnumerable<Region> Regions { get; private set; }
    }
}
