using GW2CSharp.V2.Unauthenticated.Items;

namespace GW2CSharp.V2.Unauthenticated.Commerce
{
    /// <summary>
    /// Represents a single Price object.
    /// </summary>
    public class Price
    {
        /// <summary>
        /// Initialization of the Price object. 
        /// </summary>
        /// <param name="id">The item id.</param>
        /// <param name="buys">A list of all buy listings, ascending from lowest buy order.</param>
        /// <param name="sells">A list of all sell listings, ascending from lowest sell offer.</param>
        /// <param name="whitelisted">Currently unkown usage.</param>
        public Price(int id, bool whitelisted, TpItemListing buys, TpItemListing sells)
        {
            Item = new ItemWrapper().GetById(id);
            Buys = buys;
            Sells = sells;
            Whitelisted = whitelisted;
        }

        /// <summary>
        /// The item.
        /// </summary>
        public Item Item { get; set; }

        /// <summary>
        /// Currently unkown usage.
        /// </summary>
        public bool Whitelisted { get; set; }

        /// <summary>
        /// A list of all buy listings, ascending from lowest buy order.
        /// </summary>
        public TpItem Buys { get; set; }

        /// <summary>
        /// A list of all sell listings, ascending from lowest sell offer.
        /// </summary>
        public TpItem Sells { get; set; }
    }
}
