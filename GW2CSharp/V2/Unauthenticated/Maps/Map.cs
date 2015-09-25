using System.Collections.Generic;

namespace GW2CSharp.V2.Unauthenticated.Maps
{
    /// <summary>
    /// Represents a single map from the v2/map endpoint
    /// </summary>
    public class Map
    {
        /// <summary>
        /// Initializes a new map object.
        /// </summary>
        /// <param name="id">The map id.</param>
        /// <param name="name">The map name.</param>
        /// <param name="min_level">The minimal level of this map.</param>
        /// <param name="max_level">The maximum level of this map.</param>
        /// <param name="default_floor">The default floor of this map.</param>
        /// <param name="floors">A list of available floors for this map.</param>
        /// <param name="region_id">The id of the region this map belongs to.</param>
        /// <param name="region_name">The name of the region this map belongs to.</param>
        /// <param name="continent_id">The id of the continent this map belongs to.</param>
        /// <param name="continent_name">The name of the continent this map belongs to.</param>
        /// <param name="map_rect">The dimensions of the map, given as the coordinates of the lower-left (SW) and upper-right (NE) corners.</param>
        /// <param name="continent_rect">The dimensions of the map within the continent coordinate system, given as the coordinates of the upper-left (NW) and lower-right (SE) corners.</param>
        public Map(int id, string name, int min_level, int max_level, int default_floor, IEnumerable<int> floors, int region_id, string region_name, int continent_id, string continent_name,
            List<List<int>> map_rect, List<List<int>> continent_rect)
        {
            Id = id;
            Name = name;
            MinLevel = min_level;
            MaxLevel = max_level;
            DefaultFloor = default_floor;
            Floors = floors;
            RegionId = region_id;
            RegionName = region_name;
            ContinentId = continent_id;
            ContinentName = continent_name;
            MapRectangle = new Rectangle(map_rect[0], map_rect[1]);
            ContinentRectangle = new Rectangle(continent_rect[0], continent_rect[1]);
        }
        
        /// <summary>
        /// The map id.
        /// </summary>
        public int Id { get; private set; }

        /// <summary>
        /// The map name.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// The minimal level of this map.
        /// </summary>
        public int MinLevel { get; private set; }

        /// <summary>
        /// The maximum level of this map.
        /// </summary>
        public int MaxLevel { get; private set; }

        /// <summary>
        /// The default floor of this map.
        /// </summary>
        public int DefaultFloor { get; private set; }

        /// <summary>
        /// A list of available floors for this map.
        /// </summary>
        public IEnumerable<int> Floors { get; private set; }

        /// <summary>
        /// The id of the region this map belongs to.
        /// </summary>
        public int RegionId { get; private set; }

        /// <summary>
        /// The name of the region this map belongs to.
        /// </summary>
        public string RegionName { get; private set; }

        /// <summary>
        /// The id of the continent this map belongs to.
        /// </summary>
        public int ContinentId { get; private set; }

        /// <summary>
        /// The name of the continent this map belongs to.
        /// </summary>
        public string ContinentName { get; private set; }

        /// <summary>
        /// The dimensions of the map, given as the coordinates of the lower-left (SW) and upper-right (NE) corners.
        /// </summary>
        public Rectangle MapRectangle { get; private set; }

        /// <summary>
        /// The dimensions of the map within the continent coordinate system, given as the coordinates of the upper-left (NW) and lower-right (SE) corners.
        /// </summary>
        public Rectangle ContinentRectangle { get; private set; }

    }
}
