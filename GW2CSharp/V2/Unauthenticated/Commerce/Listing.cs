using GW2CSharp.V2.Unauthenticated.Items;
using System.Collections.Generic;

namespace GW2CSharp.V2.Unauthenticated.Commerce
{
    /// <summary>
    /// 
    /// </summary>
    public class Listing
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="buys"></param>
        /// <param name="sells"></param>
        public Listing(int id, IEnumerable<TpItemListing> buys, IEnumerable<TpItemListing> sells)
        {
            Item = new ItemWrapper().GetById(id);
            Buys = buys;
            Sells = sells;
        }

        /// <summary>
        /// The item.
        /// </summary>
        public Item Item { get; set; }

        /// <summary>
        /// A list of all buy listings, ascending from lowest buy order.
        /// </summary>
        public IEnumerable<TpItemListing> Buys { get; set; }

        /// <summary>
        /// A list of all sell listings, ascending from lowest sell offer.
        /// </summary>
        public IEnumerable<TpItemListing> Sells { get; set; }
    }
}
