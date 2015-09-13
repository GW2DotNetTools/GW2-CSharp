using Newtonsoft.Json;
using System.Net;

namespace GW2Sharp.V2
{
    /// <summary>
    /// Base class for all coming endpoint calls.
    /// </summary>
    public class ApiBase
    {
        internal static string DownloadJsonString(string url)
        {
            string jsonString = string.Empty;
            using (WebClient wc = new WebClient())
            {
                jsonString = wc.DownloadString(url);
            }

            return jsonString;
        }
    }
}
