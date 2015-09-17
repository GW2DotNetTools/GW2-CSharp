using GW2CSharp.Enums;
using Newtonsoft.Json;
using System;

namespace GW2CSharp.V2.Unauthenticated.Items.Skins
{
    /// <summary>
    /// Represents additional Skin details.
    /// </summary>
    public class SkinDetail
    {
        /// <summary>
        /// Initilization of a new skindetail object.
        /// </summary>
        /// <param name="type">Skin type.</param>
        /// <param name="weight">The armor weight.</param>
        /// <param name="damageType">The damage type.</param>
        public SkinDetail (string type, Weight weight, DamageType damageType)
	    {
            Armor armorResult = Armor.None;
            Weapon weaponResult = Weapon.None;

            if (Enum.TryParse<Armor>(type, out armorResult))
            {
                Armor = armorResult;
            }
            if (Enum.TryParse<Weapon>(type, out weaponResult))
            {
                Weapon = weaponResult;
            }

            Weight = weight;
            DamageType = damageType;
	    }

        /// <summary>
        /// The armor type (slot).
        /// </summary>
        public Armor Armor { get; private set; }

        /// <summary>
        ///  The weapon type.
        /// </summary>
        public Weapon Weapon { get; private set; }

        [JsonProperty(PropertyName = "weight_class")]
        public Weight Weight { get; private set; }

        /// <summary>
        /// The damage type.
        /// </summary>
        [JsonProperty(PropertyName = "damage_type")]
        public DamageType DamageType { get; private set; }

        internal string Type { get; private set; }
    }
}
