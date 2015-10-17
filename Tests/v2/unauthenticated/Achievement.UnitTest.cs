using GW2CSharp;
using GW2CSharp.Enums;
using GW2CSharp.V2.Unauthenticated.Achievement;
using NUnit.Framework;
using System.Linq;

namespace Tests.V2.Unauthenticated
{
    [TestFixture]
    public class AchievementUnitTest
    {
        [Test]
        public void ShouldReturnAllAchievements()
        {
            var achievements = GW2Api.V2.Achievements.GetAll();
            int id = achievements.Keys.Last();

            Achievement achievement = achievements[id].Value;

            AssertThatAchievementIsCorrectlyFilled(achievement, id);
        }

        [Test]
        public void ShouldReturnMultiple()
        {
            var keys = GW2Api.V2.Achievements.GetAll().Keys.ToList();

            var achievements = GW2Api.V2.Achievements.GetMultiple(RequestedLanguage.En, keys[0], keys[1]);

            AssertThatAchievementIsCorrectlyFilled(achievements[keys[0]].Value, keys[0]);
            AssertThatAchievementIsCorrectlyFilled(achievements[keys[1]].Value, keys[1]);
        }

        [Test]
        public void ShouldReturnSpecificAchievement()
        {
            var achievements = GW2Api.V2.Achievements.GetAll();
            int id = achievements.Keys.First();

            var achievement = GW2Api.V2.Achievements.Get(id);

            AssertThatAchievementIsCorrectlyFilled(achievement, id);
        }

        [Test]
        public void ShouldReturnSpecificAchievementInLanguage()
        {
            var achievements = GW2Api.V2.Achievements.GetAll();
            int id = achievements.Keys.First();

            var achievementEn = GW2Api.V2.Achievements.Get(id);
            var achievementDe = GW2Api.V2.Achievements.Get(id, RequestedLanguage.De);

            Assert.That(achievementEn.Name, Is.Not.EqualTo(achievementDe.Name));
        }

        private void AssertThatAchievementIsCorrectlyFilled(Achievement achievement, int id)
        {
            Assert.That(achievement.Name, Is.Not.Null.Or.Empty);
            Assert.That(achievement.Id, Is.EqualTo(id));
            Assert.That(achievement.Requirement, Is.Not.Null.Or.Empty);
            Assert.That(achievement.Type, Is.Not.Null.Or.Empty);
            Assert.GreaterOrEqual(achievement.AchievementCategories.Count(), 1);
        }

        [Test]
        public void ShouldReturnCorrectBitmap()
        {
            var achievements = GW2Api.V2.Achievements.GetAll();

            Achievement achievement = achievements.Values.First().Value;
            Assert.NotNull(achievement.GetImage());
        }
    }
}
