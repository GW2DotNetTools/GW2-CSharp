using GW2CSharp.Entities;

namespace GW2CSharp.V2.Unauthenticated.Commerce
{
    /// <summary>
    /// 
    /// </summary>
    public class TpItemListing : TpItem
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="listings"></param>
        /// <param name="unit_price"></param>
        /// <param name="quantity"></param>
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
