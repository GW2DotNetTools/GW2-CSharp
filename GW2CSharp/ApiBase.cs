using System;
using System.Net;

namespace GW2CSharp
{
    /// <summary>
    /// Base class for all coming endpoint calls.
    /// </summary>
    public class ApiBase
    {
        /// <summary>
        /// Downloads a JsonString from a url.
        /// </summary>
        /// <param name="url">Url.</param>
        /// <returns>JsonString from url.</returns>
        public static string DownloadJsonString(string url)
        {
            string jsonString = string.Empty;
            
            try
            {
                using (WebClient wc = new WebClient())
                {
                    jsonString = wc.DownloadString(url);
                }
            }
            catch (Exception)
            {
                throw new ArgumentException(url + " does not return a valid object.");
            }

            return jsonString;
        }
    }
}
