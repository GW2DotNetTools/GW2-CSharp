namespace GW2CSharp.V2.Unauthenticated.Achievement.Enums
{
    /// <summary>
    /// Achievement categories.
    /// </summary>
    public enum AchievementCategories
    {
        /// <summary>
        /// Undefined.
        /// </summary>
        Undefined,
        /// <summary>
        /// Can only get progress in PvP or WvW.
        /// </summary>
        Pvp,
        /// <summary>
        ///  Is a meta achievement.
        /// </summary>
        CategoryDisplay,
        /// <summary>
        /// Affects in-game UI collation.
        /// </summary>
        MoveToTop,
        /// <summary>
        /// Doesn't appear in the "nearly complete" UI.
        /// </summary>
        IgnoreNearlyComplete
    }
}
