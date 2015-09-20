using System.Collections.Generic;

namespace GW2CSharp.V2.Unauthenticated.Continents
{
    /// <summary>
    /// Represents the v2/maps endpoint.
    /// </summary>
    public class Map
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Map"/> class.
        /// </summary>
        /// <param name="name">The map name.</param>
        /// <param name="minLevel">The minimum level.</param>
        /// <param name="maxLevel">The maximum level.</param>
        /// <param name="defaultFloor">The default floor.</param>
        /// <param name="mapRectangle">The dimensions of the map, given as the coordinates of the lower-left (SW) and upper-right (NE) corners.</param>
        /// <param name="continentRectangle">The dimensions of the map within the continent coordinate system, given as the coordinates of the upper-left (NW) and lower-right (SE) corners.</param>
        /// <param name="pois">The pois.</param>
        /// <param name="objectives">The objectives.</param>
        /// <param name="skillChallenges">The skill challenges.</param>
        /// <param name="sectors">The sectors.</param>
        public Map(string name, int minLevel, int maxLevel, int defaultFloor, Rectangle mapRectangle, Rectangle continentRectangle, IEnumerable<Poi> pois, IEnumerable<Objective> objectives, 
            IEnumerable<SkillChallenge> skillChallenges, IEnumerable<Sector> sectors)
        {
            Name = name;
            MinLevel = minLevel;
            MaxLevel = maxLevel;
            DefaultFloor = defaultFloor;
            MapRectangle = mapRectangle;
            ContinentRectangle = continentRectangle;
            PointsOfInterest = pois;
            Objectives = objectives;
            SkillChallenges = skillChallenges;
            Sectors = sectors;
        }

        /// <summary>
        /// The map name.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Gets the minimum level.
        /// </summary>
        public int MinLevel { get; private set; }

        /// <summary>
        /// Gets the maximum level.
        /// </summary>
        public int MaxLevel { get; private set; }

        /// <summary>
        /// Gets the default floor.
        /// </summary>
        public int DefaultFloor { get; private set; }

        /// <summary>
        /// The dimensions of the map, given as the coordinates of the lower-left (SW) and upper-right (NE) corners.
        /// </summary>
        public Rectangle MapRectangle { get; private set; }

        /// <summary>
        /// Gets the continent rectangle.
        /// </summary>
        public Rectangle ContinentRectangle { get; private set; }

        /// <summary>
        /// Gets the points of interest.
        /// </summary>
        public IEnumerable<Poi> PointsOfInterest { get; private set; }

        /// <summary>
        /// Gets the objectives.
        /// </summary>
        public IEnumerable<Objective> Objectives { get; private set; }

        /// <summary>
        /// Gets the skill challenges.
        /// </summary>
        public IEnumerable<SkillChallenge> SkillChallenges { get; private set; }

        /// <summary>
        /// Gets the sectors.
        /// </summary>
        public IEnumerable<Sector> Sectors { get; private set; }
    }
}
