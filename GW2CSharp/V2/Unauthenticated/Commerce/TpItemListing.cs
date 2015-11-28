namespace GW2CSharp.V2.Unauthenticated.Commerce
{
    /// <summary>
    /// Represents a single item on the tp
    /// </summary>
    public class TpItemListing : TpItem
    {
        /// <summary>
        /// Initialization of a TpItemListing object.
        /// </summary>
        /// <param name="listings">The number of individual listings this object refers to (e.g. two players selling at the same price will end up in the same listing)</param>
        /// <param name="quantity">The amount of items being sold/bought.</param>
        /// <param name="unit_price">The sell offer or buy order price in coins.</param>
        public TpItemListing(int listings, int unit_price, int quantity)
            : base(quantity, unit_price)
        {
            Listings = listings;
        }

        /// <summary>
        /// The number of individual listings this object refers to (e.g. two players selling at the same price will end up in the same listing)
        /// </summary>
        public int Listings { get; set; }
    }
}
