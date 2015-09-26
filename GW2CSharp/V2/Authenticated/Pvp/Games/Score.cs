namespace GW2CSharp.V2.Authenticated.Pvp.Games
{
    /// <summary>
    /// Represents a Score of a PvP match.
    /// </summary>
    public class Score
    {
        /// <summary>
        /// Initilitation of a new score object.
        /// </summary>
        /// <param name="red">The red team.</param>
        /// <param name="blue">The blue team.</param>
        public Score(int red, int blue)
        {
            Red = red;
            Blue = blue;
        }

        /// <summary>
        /// The red team.
        /// </summary>
        public int Red { get; private set; }

        /// <summary>
        /// The blue team.
        /// </summary>
        public int Blue { get; private set; }
    }
}
