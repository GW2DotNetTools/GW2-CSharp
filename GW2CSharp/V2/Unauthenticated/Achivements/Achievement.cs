using GW2CSharp.Services;
using GW2CSharp.V2.Unauthenticated.Achievement.Enums;
using System.Collections.Generic;
using System.Drawing;

namespace GW2CSharp.V2.Unauthenticated.Achievement
{
    /// <summary>
    /// Represents a single achivement from the v2/achievement endpoint.
    /// </summary>
    public class Achievement : Imageable
    {
        /// <summary>
        /// Initialization of a new achievement object.
        /// </summary>
        /// <param name="id">The achievement id.</param>
        /// <param name="icon">(optional) The achievement icon.</param>
        /// <param name="name">The achievement name.</param>
        /// <param name="description">The achievement description.</param>
        /// <param name="requirement">The achievement requirement as listed in-game.</param>
        /// <param name="type">The achievement type.</param>
        /// <param name="flags">Achievement categories.</param>
        public Achievement(int id, string icon, string name, string description, string requirement, string type, IEnumerable<AchievementCategories> flags)
            : base(icon)
        {
            Id = id;
            Icon = icon;
            Name = name;
            Description = description;
            Requirement = requirement;
            Type = type;
            AchievementCategories = flags;
        }

        /// <summary>
        /// The achievement id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The achievement icon.
        /// </summary>
        public string Icon { get; set; }

        /// <summary>
        /// The achievement name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The achievement description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The achievement requirement as listed in-game.
        /// </summary>
        public string Requirement { get; set; }

        /// <summary>
        /// The achievement type. 
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Achievement categories.
        /// </summary>
        public IEnumerable<AchievementCategories> AchievementCategories { get; set; }
    }
}
