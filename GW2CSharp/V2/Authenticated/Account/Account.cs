using GW2CSharp.V2.Unauthenticated.Worlds;
using System;
using System.Collections.Generic;

namespace GW2CSharp.V2.Authenticated.Account
{
    /// <summary>
    /// Represents the v2/account endpoint.
    /// </summary>
    public class Account
    {
        /// <summary>
        /// Initialization of a Account object.
        /// </summary>
        /// <param name="id">The unique persistent account GUID.</param>
        /// <param name="name">The unique account name with numerical suffix. It is possible that the name change. Do not rely on the name, use id instead.</param>
        /// <param name="world">The home world the account is assigned to.</param>
        /// <param name="guilds">A list of guilds assigned to the given account.</param>
        /// <param name="created">Timestamp of when the account was created.</param>
        /// <param name="access">Accesslevel of the account.</param>
        /// <param name="fractal_level">The account's personal fractal reward level. Requires the additional progression scope.</param>
        public Account(Guid id, string name, int world, IEnumerable<string> guilds, DateTime created, AccountType access, int fractal_level)
        {
            Id = id;
            Name = name;
            World = new WorldWrapper().GetById(world);
            Guilds = guilds;
            Created = created;
            Access = access;
            FractalLevel = fractal_level;
        }

        /// <summary>
        /// The unique persistent account GUID.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// The unique account name with numerical suffix. It is possible that the name change. Do not rely on the name, use id instead.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The home world the account is assigned to.
        /// </summary>
        public World World { get; set; }

        //Todo: Replace Guild with v1/guild endpoint
        /// <summary>
        /// A list of guilds assigned to the given account.
        /// </summary>
        public IEnumerable<string> Guilds { get; set; }

        /// <summary>
        /// Timestamp of when the account was created.
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// Accesslevel of the account.
        /// </summary>
        public AccountType Access { get; set; }

        /// <summary>
        /// The account's personal fractal reward level. Requires the additional progression scope.
        /// </summary>
        public int FractalLevel { get; set; }
    }
}
