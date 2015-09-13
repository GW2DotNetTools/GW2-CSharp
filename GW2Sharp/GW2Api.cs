using GW2Sharp.V2.Unauthenticated.Miscellaneous;
using GW2Sharp.V2.Unauthenticated.Miscellaneous.Colors;
using GW2Sharp.V2.Unauthenticated.Miscellaneous.Currencies;
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

        /// <summary>
        /// Returns a wrapper for all currency endpoint calls.
        /// </summary>
        public static CurrencyWrapper Currencies
        {
            get
            {
                return new CurrencyWrapper();
            }
        }

        /// <summary>
        /// Returns a wrapper for all currency endpoint calls.
        /// </summary>
        public static ColorWrapper Colors
        {
            get
            {
                return new ColorWrapper();
            }
        }
    }
}
