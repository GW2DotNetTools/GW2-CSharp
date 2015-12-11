using GW2CSharp;
using GW2CSharp.Enums;
using GW2CSharp.V2.Authenticated.Pvp.Games;
using GW2CSharp.V2.Authenticated.Pvp.Games.Enums;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Tests.V2.Authenticated
{
    [TestFixture]
    public class PvpGameUnitTest
    {
        [Test]
        public void ShouldGetRecentPvpGames()
        {
            IEnumerable<PvpGame> games = GW2Api.V2().PvpGame.GetRecent(TestData.FullAccessAccountToken);

            PvpGame game = games.First();
            Assert.IsNotNullOrEmpty(game.Id);
            Assert.Greater(game.Started, DateTime.MinValue);
            Assert.Greater(game.Started, DateTime.MinValue);
            Assert.IsNotNullOrEmpty(game.Result);
            Assert.AreNotEqual(Team.Undefined, game.Team);
            Assert.AreNotEqual(Profession.Undefined, game.Profession);
            Assert.That(game.Score.Blue > 0 || game.Score.Red > 0);
        }
    }
}
