using GW2CSharp;
using GW2CSharp.Enums;
using GW2CSharp.V2.Authenticated.Pvp.Stats;
using GW2CSharp.V2.Authenticated.Pvp.Stats.Enums;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.V2.Authenticated.Pvp
{
    [TestFixture]
    public class PvpStatisticUnitTest
    {
        [Test]
        public void ThrowsApiExceptionIfWrongRights()
        {
            string limitedToken = "B4E614FB-9877-1449-9E69-610ABA060370BCF5B253-816C-4EB0-969F-96618391E341";
            Assert.Throws<ApiException>(() => GW2Api.V2.PvpStatistics.GetPvpStatistic(limitedToken));
        }

        [Test]
        public void ShouldReturnTheCorrectStatistic() 
        {
            PvpStatistic statistic = GW2Api.V2.PvpStatistics.GetPvpStatistic("58751B23-07DA-AB49-A5DE-0DBC9BA6C79ECCDE107E-2785-4296-BAEF-64AD20580F8A");

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
