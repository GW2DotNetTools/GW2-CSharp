using GW2CSharp;
using GW2CSharp.Enums;
using GW2CSharp.V2.Authenticated.Pvp.Stats;
using GW2CSharp.V2.Authenticated.Pvp.Stats.Enums;
using NUnit.Framework;

namespace Tests.V2.Authenticated.Pvp
{
    [TestFixture]
    public class PvpStatisticUnitTest
    {
        [Test]
        public void ThrowsApiExceptionIfWrongRights()
        {
            Assert.Throws<ApiException>(() => GW2Api.V2().PvpStatistics.Get(TestData.LimitedAccessToken));
        }

        [Test]
        public void ShouldReturnTheCorrectStatistic() 
        {
            PvpStatistic statistic = GW2Api.V2().PvpStatistics.Get(TestData.FullAccessAccountToken);

            Assert.That(statistic.Ladders.ContainsKey(Ladder.Unranked));
            Assert.That(statistic.Ladders.ContainsKey(Ladder.Ranked));
            Assert.That(!statistic.Ladders.ContainsKey(Ladder.SoloArenaRated));

            Assert.NotNull(statistic.Overview);

            Assert.That(statistic.Professions.ContainsKey(Profession.Guardian));
            Assert.That(statistic.Professions.ContainsKey(Profession.Mesmer));
            Assert.That(statistic.Professions.ContainsKey(Profession.Elementalist));
            Assert.That(statistic.Professions.ContainsKey(Profession.Warrior));
            Assert.That(!statistic.Professions.ContainsKey(Profession.Revenant));

            Assert.Greater(statistic.Rank, 25);
        }
    }
}
