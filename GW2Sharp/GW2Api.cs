using GW2Sharp.v2.unauthenticated.miscellaneous;
using GW2Sharp.v2.unauthenticated.miscellaneous.worlds;
using System.Collections.Generic;

namespace GW2Sharp
{
    public static class GW2Api
    {
        public static int GetBuildId
        {
            get
            {
                return BuildWrapper.GetId();
            }
        }

        public static WorldWrapper Worlds 
        {
            get 
            {
                return new WorldWrapper();
            }
        }
    }
}
