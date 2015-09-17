using GW2CSharp.V2.Authenticated.Pvp.Stats;
using GW2CSharp.V2.Authenticated.TokenInfo;
using GW2CSharp.V2.Unauthenticated.Items.Skins;
using GW2CSharp.V2.Unauthenticated.Miscellaneous;
using GW2CSharp.V2.Unauthenticated.Miscellaneous.Colors;
using GW2CSharp.V2.Unauthenticated.Miscellaneous.Currencies;
using GW2CSharp.V2.Unauthenticated.Miscellaneous.Files;
using GW2CSharp.V2.Unauthenticated.Miscellaneous.Quaggans;
using GW2CSharp.V2.Unauthenticated.Miscellaneous.Worlds;
using GW2CSharp.V2.Unauthenticated.TradingPost.Commerce.Exchanges;

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
        public int GetBuildId { get { return BuildWrapper.GetId(); } }

        /// <summary>
        /// Returns a wrapper for all world endpoint calls.
        /// </summary>
        public WorldWrapper Worlds { get { return new WorldWrapper(); } }

        /// <summary>
        /// Returns a wrapper for all currency endpoint calls.
        /// </summary>
        public CurrencyWrapper Currencies { get { return new CurrencyWrapper(); } }

        /// <summary>
        /// Returns a wrapper for all color endpoint calls.
        /// </summary>
        public ColorWrapper Colors { get { return new ColorWrapper(); } }

        /// <summary>
        /// Returns a wrapper for all quaggan endpoint calls.
        /// </summary>
        public QuagganWrapper Quaggans { get { return new QuagganWrapper(); } }

        /// <summary>
        /// Returns a wrapper for all RessourceFile endpoint calls.
        /// </summary>
        public RessourceFileWrapper RessourceFiles { get { return new RessourceFileWrapper(); } }

        /// <summary>
        /// Returns a wrapper for all exchange endpoint calls.
        /// </summary>
        public ExchangeWrapper Exchanges { get { return new ExchangeWrapper(); } }

        /// <summary>
        /// Returns a wrapper for all tokeninfo endpoint calls.
        /// </summary>
        public TokeninfoWrapper TokenInfo { get { return new TokeninfoWrapper(); } }

        /// <summary>
        /// Returns a wrapper for all pvpstats endpoint calls.
        /// </summary>
        public PvpStatisticWrapper PvpStatistics { get { return new PvpStatisticWrapper(); } }

        /// <summary>
        /// Returns a wrapper for all skin endpoint calls.
        /// </summary>
        public SkinWrapper Skins { get { return new SkinWrapper(); } }
    }
}
