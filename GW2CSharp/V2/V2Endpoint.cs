using GW2CSharp.V2.Authenticated.Pvp.Games;
using GW2CSharp.V2.Authenticated.Pvp.Stats;
using GW2CSharp.V2.Authenticated.TokenInfo;
using GW2CSharp.V2.Unauthenticated.Achievement;
using GW2CSharp.V2.Unauthenticated.Colors;
using GW2CSharp.V2.Unauthenticated.Commerce;
using GW2CSharp.V2.Unauthenticated.Commerce.Exchange;
using GW2CSharp.V2.Unauthenticated.Continents;
using GW2CSharp.V2.Unauthenticated.Currencies;
using GW2CSharp.V2.Unauthenticated.Files;
using GW2CSharp.V2.Unauthenticated.Items;
using GW2CSharp.V2.Unauthenticated.Items.Skins;
using GW2CSharp.V2.Unauthenticated.Maps;
using GW2CSharp.V2.Unauthenticated.Minis;
using GW2CSharp.V2.Unauthenticated.Miscellaneous;
using GW2CSharp.V2.Unauthenticated.Quaggans;
using GW2CSharp.V2.Unauthenticated.Worlds;

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

        /// <summary>
        /// Returns a wrapper for all continent endpoint calls.
        /// </summary>
        public ContinentWrapper Continents { get { return new ContinentWrapper(); } }

        /// <summary>
        /// Returns a wrapper for all map endpoint calls.
        /// </summary>
        public MapWrapper Maps { get { return new MapWrapper(); } }

        /// <summary>
        /// Returns a wrapper for all pvpgame endpoint calls.
        /// </summary>
        public PvpGameWrapper PvpGame { get { return new PvpGameWrapper(); } }

        /// <summary>
        /// Returns a wrapper for all achievements endpoint calls.
        /// </summary>
        public AchievementWrapper Achievements { get { return new AchievementWrapper(); } }

		/// <summary>
		/// Returns a wrapper for all the minis endpoint calls.
		/// </summary>
		public MinisWrapper Minis { get { return new MinisWrapper(); } }

        /// <summary>
        /// Returns a wrapper for all the item endpoint calls.
        /// </summary>
        public ItemWrapper Items { get { return new ItemWrapper(); } }

        /// <summary>
        /// Returns a wrapper for all the listing endpoint calls.
        /// </summary>
        public ListingWrapper Listings { get { return new ListingWrapper(); } }

        /// <summary>
        /// Returns a wrapper for all the price endpoint calls.
        /// </summary>
        public PriceWrapper Prices { get { return new PriceWrapper(); } }
    }
}
