using System.Collections.Generic;

namespace GW2CSharp.V2.Unauthenticated.Continents
{
    /// <summary>
    /// Represents a single SkillChallenge.
    /// </summary>
    public class SkillChallenge
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SkillChallenge"/> class.
        /// </summary>
        /// <param name="coord">The coordinates of this skill challenge.</param>
        public SkillChallenge(List<double> coord)
        {
            Coordinate = new Coordinate<double>(coord[0], coord[1]);
        }

        /// <summary>
        /// The coordinates of this skill challenge.
        /// </summary>
        public Coordinate<double> Coordinate { get; private set; }
    }
}
