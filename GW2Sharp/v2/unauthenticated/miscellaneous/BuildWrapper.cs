using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GW2Sharp.v2.unauthenticated.miscellaneous
{
    internal class BuildWrapper : ApiBase
    {
        internal static int GetId()
        {
            var definition = new { Id = 0 };
            string jsonString = DownloadJsonString("https://api.guildwars2.com/v2/build");

            return JsonConvert.DeserializeAnonymousType(jsonString, definition).Id;
        }
    }
}
