using GW2CSharp.V2.Unauthenticated.Miscellaneous;
using GW2CSharp.V2.Unauthenticated.Miscellaneous.Colors;
using GW2CSharp.V2.Unauthenticated.Miscellaneous.Currencies;
using GW2CSharp.V2.Unauthenticated.Miscellaneous.Worlds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GW2CSharp.V2
{
    /// <summary>
    /// Represents the V2 endpoint.
    /// </summary>
    public class V2Endpoint
    {
        /// <summary>
        /// Returns the current build id.
        /// </summary>
        public int GetBuildId
        {
            get
            {
                return BuildWrapper.GetId();
            }
        }

        /// <summary>
        /// Returns a wrapper for all world endpoint calls.
        /// </summary>
        public WorldWrapper Worlds
        {
            get
            {
                return new WorldWrapper();
            }
        }

        /// <summary>
        /// Returns a wrapper for all currency endpoint calls.
        /// </summary>
        public CurrencyWrapper Currencies
        {
            get
            {
                return new CurrencyWrapper();
            }
        }

        /// <summary>
        /// Returns a wrapper for all currency endpoint calls.
        /// </summary>
        public ColorWrapper Colors
        {
            get
            {
                return new ColorWrapper();
            }
        }
    }
}
