namespace GW2CSharp.V2.Authenticated.Account
{
    /// <summary>
    /// Represents the access level of an account
    /// </summary>
    public enum AccountType
    {
        /// <summary>
        /// Should probably never happen.
        /// </summary>
        None,
        /// <summary>
        /// Has not yet purchased the game.
        /// </summary>
        PlayForFree,
        /// <summary>
        /// Has purchased base game, but no expansions.
        /// </summary>
        GuildWars2,
        /// <summary>
        /// Has purchased HoT
        /// </summary>
        HeartOfThorns
    }
}
