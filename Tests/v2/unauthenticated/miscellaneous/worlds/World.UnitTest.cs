using GW2CSharp;
using GW2CSharp.V2.Unauthenticated.Miscellaneous.Worlds;
using GW2CSharp.V2.Unauthenticated.Miscellaneous.Worlds.Enums;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace Tests.V2.Unauthenticated.Miscellaneous.Worlds
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
        public void ReturnsSingleWorldById()
        {
            World world = GW2Api.Worlds.GetWorldById(2012);

            CompareWorlds(pikenSquare, world);
        }

        [Test]
        public void ReturnsMultipleWorldById()
        {
            List<World> world = GW2Api.Worlds.GetWorldById(RequestedLanguage.en, 1001, 2012).ToList();

            CompareWorlds(anvilRock, world[0]);
            CompareWorlds(pikenSquare, world[1]);
        }

        [Test]
        public void ReturnsAllWorlds()
        {
            List<World> world = GW2Api.Worlds.GetAllWorlds().ToList();

            Assert.AreEqual(51, world.Count());
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
