using GW2CSharp.Entities;

namespace GW2CSharp.V2.Unauthenticated.Commerce
{
    /// <summary>
    /// Represents a single item on the tp
    /// </summary>
    public class TpItem
    {
        /// <summary>
        /// Initialization of a tpitem object.
        /// </summary>
        /// <param name="quantity">The amount of items being sold/bought.</param>
        /// <param name="unit_price">The sell offer or buy order price in coins.</param>
        public TpItem(int quantity, int unit_price)
        {
            Quantity = quantity;
            UnitPrice = new Money(unit_price);
        }

        /// <summary>
        /// The amount of items being sold/bought.
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// The sell offer or buy order price in coins.
        /// </summary>
        public Money UnitPrice { get; set; }
    }
}
