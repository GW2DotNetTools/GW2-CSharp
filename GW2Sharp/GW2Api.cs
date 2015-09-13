using GW2Sharp.V2.Unauthenticated.Miscellaneous;
using GW2Sharp.V2.Unauthenticated.Miscellaneous.Worlds;

namespace GW2Sharp
{
    /// <summary>
    /// Represents the Guild Wars 2 Api.
    /// </summary>
    public static class GW2Api
    {
        /// <summary>
        /// Returns the current build id.
        /// </summary>
        public static int GetBuildId
        {
            get
            {
                return BuildWrapper.GetId();
            }
        }

        /// <summary>
        /// Returns a wrapper for all world endpoint calls.
        /// </summary>
        public static WorldWrapper Worlds 
        {
            get 
            {
                return new WorldWrapper();
            }
        }
    }
}
