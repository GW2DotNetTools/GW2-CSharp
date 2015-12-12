using GW2CSharp.Entities;
using GW2CSharp.V2.Unauthenticated.Items;
using System;

namespace GW2CSharp.V2.Authenticated.Commerce
{
    /// <summary>
    /// Represents the v2/commerce/transactions endpoint.
    /// </summary>
    public class Transaction
    {
        /// <summary>
        /// Initilitation of a new Transaction object.
        /// </summary>
        /// <param name="id">Id of the transaction.</param>
        /// <param name="item_id">The item id.</param>
        /// <param name="price">The price in coins.</param>
        /// <param name="quantity">The quantity of the item.</param>
        /// <param name="created">The date of creation.</param>
        /// <param name="purchased">The date of purchase.</param>
        public Transaction(long id, int item_id, int price, int quantity, DateTime created, DateTime purchased)
        {
            Id = id;
            ItemId = item_id;
            Price = new Money(price);
            Quantity = quantity;
            Created = created;
            Purchased = purchased;
        }

        /// <summary>
        /// Id of the transaction.
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// The item id.
        /// </summary>
        public int ItemId { get; set; }

        /// <summary>
        /// The price in coins.
        /// </summary>
        public Money Price { get; set; }

        /// <summary>
        /// The quantity of the item.
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// The date of creation.
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// The date of purchase.
        /// </summary>
        public DateTime Purchased { get; set; }
    }
}
