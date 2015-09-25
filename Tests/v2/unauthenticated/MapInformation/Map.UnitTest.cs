using GW2CSharp;
using GW2CSharp.Enums;
using GW2CSharp.V2.Unauthenticated.Maps;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Tests.V2.Unauthenticated.MapInformation
{
    [TestFixture]
    public class MapUnitTest
    {
        [Test]
        public void ShouldReturnAllMaps()
        {
            IEnumerable<Lazy<Map>> maps = GW2Api.V2.Maps.GetAll();
            Assert.GreaterOrEqual(maps.Count(), 574);
        }

        [Test]
        public void ShouldReturnSpicificMapOutOfAll()
        {
            List<Lazy<Map>> maps = GW2Api.V2.Maps.GetAll().ToList();
            Map map = maps[10].Value;
            Assert.AreEqual("Tyria", map.ContinentName);
        }

        [TestCase("Lion's Arch", "Kryta", RequestedLanguage.En)]
        [TestCase("Löwenstein", "Kryta", RequestedLanguage.De)]
        [TestCase("L'Arche du Lion", "Kryte", RequestedLanguage.Fr)]
        [TestCase("Arco del León", "Kryta", RequestedLanguage.Es)]
        public void ShouldReturnSpicific(string mapName, string regionName, RequestedLanguage language)
        {
            Map map = GW2Api.V2.Maps.GetById(50, language);

            Assert.AreEqual(50, map.Id);
            Assert.AreEqual("Tyria", map.ContinentName);
            Assert.AreEqual(15232, map.ContinentRectangle.X.X);
            Assert.AreEqual(14336, map.ContinentRectangle.X.Y);
            Assert.AreEqual(17664, map.ContinentRectangle.Y.X);
            Assert.AreEqual(15872, map.ContinentRectangle.Y.Y);
            Assert.AreEqual(1, map.DefaultFloor);
            Assert.AreEqual(new List<int> { 0, 1, 2}, map.Floors);
            Assert.AreEqual(-27648, map.MapRectangle.X.X);
            Assert.AreEqual(-18432, map.MapRectangle.X.Y);
            Assert.AreEqual(30720, map.MapRectangle.Y.X);
            Assert.AreEqual(18432, map.MapRectangle.Y.Y);
            Assert.AreEqual(80, map.MaxLevel);
            Assert.AreEqual(0, map.MinLevel);
            Assert.AreEqual(mapName, map.Name);
            Assert.AreEqual(4, map.RegionId);
            Assert.AreEqual(regionName, map.RegionName);
        }
    }
}
