using GW2CSharp;
using GW2CSharp.Enums;
using GW2CSharp.V2.Unauthenticated.Worlds;
using GW2CSharp.V2.Unauthenticated.Worlds.Enums;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace Tests.V2.Unauthenticated.Miscellaneous
{
    [TestFixture]
    public class WorldUnitTest
    {
        private World anvilRock;
        private World pikenSquare;

        [SetUp]
        public void SetUp() 
        {
            anvilRock = new World(1001, "Anvil Rock", Population.Medium);
            pikenSquare = new World(2012, "Piken Square", Population.VeryHigh);
        }

        [Test]
        public void ThrowsExceptionIfNotExisting()
        {
            Assert.Throws<ApiException>(() => GW2Api.V2.Worlds.GetWorldById(23456));
        }

        [Test]
        public void ShouldReturnCorrectWorldsOnPage()
        {
            List<World> worlds = GW2Api.V2.Worlds.GetWorldByPage(35, 1).ToList();

            CompareWorlds(pikenSquare, worlds[0]);
        }

        [Test]
        public void ShouldReturnSingleWorldById()
        {
            World world = GW2Api.V2.Worlds.GetWorldById(2012);

            CompareWorlds(pikenSquare, world);
        }

        [Test]
        public void ShoudlReturnMultipleWorldsById()
        {
            List<World> world = GW2Api.V2.Worlds.GetWorldByIds(RequestedLanguage.En, 1001, 2012).ToList();

            CompareWorlds(anvilRock, world[0]);
            CompareWorlds(pikenSquare, world[1]);
        }

        [Test]
        public void ShouldReturnAllWorlds()
        {
            List<World> world = GW2Api.V2.Worlds.GetAllWorlds().ToList();

            Assert.GreaterOrEqual(51, world.Count());
        }

        private void CompareWorlds(World expectedWorld, World actualWorld) 
        {
            //Population won't be checked since it will change over time.
            Assert.AreEqual(expectedWorld.Id, actualWorld.Id);
            Assert.AreEqual(expectedWorld.Language, actualWorld.Language);
            Assert.AreEqual(expectedWorld.Name, actualWorld.Name);
            Assert.AreEqual(expectedWorld.Region, actualWorld.Region);
        }
    }
}
