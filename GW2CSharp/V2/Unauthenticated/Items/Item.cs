using GW2CSharp.Enums;
using GW2CSharp.Services;
using GW2CSharp.V2.Unauthenticated.Items.Enums;
using GW2CSharp.V2.Unauthenticated.Items.Skins;
using System.Collections.Generic;
using System.Drawing;

namespace GW2CSharp.V2.Unauthenticated.Items
{
    /// <summary>
    /// Represents a single map from the v2/items endpoint
    /// </summary>
    public class Item : Imageable
    {
        /// <summary>
        /// Represents a single skin.
        /// </summary>
        /// <param name="id">The item id.</param>
        /// <param name="chat_link">The chat link.</param>
        /// <param name="name">The item name.</param>
        /// <param name="icon">The full icon URL.</param>
        /// <param name="description">The item description.</param>
        /// <param name="type">The item type.</param>
        /// <param name="rarity">The item rarity.</param>
        /// <param name="level">The required level.</param>
        /// <param name="vendor_value">The value in coins when selling to a vendor. (Can be non-zero even when the item has the NoSell flag.)</param>
        /// <param name="default_skin">The default skin id.</param>
        /// <param name="flags">Flags applying to the item.</param>
        /// <param name="game_types">The game types in which the item is usable. At least one game type is specified.</param>
        /// <param name="restrictions">Restrictions applied to the item.</param>
        /// <param name="details">Additional item details if applicable, depending on the item type.</param>
        public Item(int id, string chat_link, string name, string icon, string description, ItemType type, Rarity rarity, int level, int vendor_value, 
            int default_skin, IEnumerable<ItemFlag> flags, IEnumerable<GameMode> game_types, IEnumerable<Restriction> restrictions, object details)
            : base(icon)
        {
            Id = id;
            ChatLink = chat_link;
            Name = name;
            Icon = icon;
            Description = description;
            Type = type;
            Rarity = rarity;
            Level = level;
            VendorValue = vendor_value;
            Skin = new SkinWrapper().GetById(default_skin);
            Flags = flags;
            GameTypes = game_types;
            Restrictions = restrictions;
            Details = details;
        }

        /// <summary>
        /// The item id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The chat link.
        /// </summary>
        public string ChatLink { get; set; }

        /// <summary>
        /// The item name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The full icon URL.
        /// </summary>
        public string Icon { get; set; }

        /// <summary>
        /// The item description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The item type.
        /// </summary>
        public ItemType Type { get; set; }

        /// <summary>
        /// The item rarity.
        /// </summary>
        public Rarity Rarity { get; set; }

        /// <summary>
        /// The required level.
        /// </summary>
        public int Level { get; set; }

        /// <summary>
        /// The value in coins when selling to a vendor. (Can be non-zero even when the item has the NoSell flag.)
        /// </summary>
        public int VendorValue { get; set; }

        /// <summary>
        /// The default skin id.
        /// </summary>
        public Skin Skin { get; set; }

        /// <summary>
        /// Flags applying to the item.
        /// </summary>
        public IEnumerable<ItemFlag> Flags { get; set; }

        /// <summary>
        /// The game types in which the item is usable. At least one game type is specified.
        /// </summary>
        public IEnumerable<GameMode> GameTypes { get; set; }

        /// <summary>
        /// Restrictions applied to the item.
        /// </summary>
        public IEnumerable<Restriction> Restrictions { get; set; }

        /// <summary>
        /// Additional item details if applicable, depending on the item type.
        /// </summary>
        public object Details { get; set; } //todo: Seems to be a problem right now to cast it to something usefull need better way to deal with it.
    }
}
