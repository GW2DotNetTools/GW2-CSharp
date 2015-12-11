using GW2CSharp.Enums;
using GW2CSharp.V1;
using GW2CSharp.V2;

namespace GW2CSharp
{
    /// <summary>
    /// Represents the Guild Wars 2 Api.
    /// <para>All calls will throw a <see cref="ApiException"/> if an error occurs.</para>
    /// <para>
    /// Full documentation under: http://gw2dotnettools.github.io/GW2-CSharp-Documentation
    /// </para>
    /// </summary>
    public static class GW2Api
    {
        /// <summary>
        /// Returns the V1 endpoint.
        /// </summary>
        public static V1Endpoint V1
        {
            get
            {
                return new V1Endpoint();
            }
        }

        /// <summary>
        /// Returns the V2 endpoint.
        /// </summary>
        /// <returns>V2Endpoint.</returns>
        public static V2Endpoint V2()
        {
            return new V2Endpoint(string.Empty, RequestedLanguage.En);
        }

        /// <summary>
        /// Returns the V2 endpoint.
        /// </summary>
        /// <param name="accountToken">Accounttoken which all authenticated calls will automatically use.</param>
        /// <returns>V2Endpoint.</returns>
        public static V2Endpoint V2(string accountToken)
        {
            return V2(accountToken, RequestedLanguage.En);
        }

        /// <summary>
        /// Returns the V2 endpoint.
        /// </summary>
        /// <param name="language">Language in which all calls should be made.</param>
        /// <returns>V2Endpoint.</returns>
        public static V2Endpoint V2(RequestedLanguage language)
        {
            return V2(string.Empty, language);
        }

        /// <summary>
        /// Returns the V2 endpoint.
        /// </summary>
        /// <param name="accountToken">Accounttoken which all authenticated calls will automatically use.</param>
        /// <param name="language">Language in which all calls should be made.</param>
        /// <returns>V2Endpoint.</returns>
        public static V2Endpoint V2(string accountToken, RequestedLanguage language)
        {
            return new V2Endpoint(accountToken, language);
        }
    }
}
