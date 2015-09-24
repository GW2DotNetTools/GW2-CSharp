using GW2CSharp;
using GW2CSharp.Enums;
using GW2CSharp.V2.Unauthenticated.Continents;
using GW2CSharp.V2.Unauthenticated.Continents.Enums;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.V2.Unauthenticated.Continents
{
    [TestFixture]
    public class ContinentUnitTest
    {
        [Test]
        public void ShouldGetAllContinents()
        {
            IEnumerable<Continent> continents = GW2Api.V2.Continents.GetAll();
            Assert.GreaterOrEqual(2, continents.Count());
        }

        [Test]
        public void ShouldGetSpecificContinent() 
        {
            Continent continent = GW2Api.V2.Continents.GetById(1);
            Assert.AreEqual("Tyria", continent.Name);
            Assert.AreEqual(32768, continent.Dimension.X);
            Assert.AreEqual(32768, continent.Dimension.Y);
            Assert.AreEqual(0, continent.MinZoom);
            Assert.AreEqual(7, continent.MaxZoom);
            Assert.AreEqual(1, continent.Id);
        }
    
        [Test]
        public void ShouldGetSpecificFloor() 
        {
            Continent continent = GW2Api.V2.Continents.GetById(1);
            Floor floor = continent.Floors[2].Value;
            Assert.AreEqual(32768, floor.Dimension.X);
            Assert.AreEqual(32768, floor.Dimension.Y);
            Assert.GreaterOrEqual(7, floor.Regions.Count());
        }

        [Test]
        public void ShouldGetSpecificRegion()
        {
            Continent continent = GW2Api.V2.Continents.GetById(1);
            Floor floor = continent.Floors[2].Value;
            Region region = floor.Regions["1"];

            Assert.GreaterOrEqual(10, region.Maps.Count());
            Assert.AreEqual("Shiverpeak Mountains", region.Name);
            Assert.AreEqual(19840, region.Coordinate.X);
            Assert.AreEqual(13568, region.Coordinate.Y);
        }

        [Test]
        public void ShouldGetSpecificMap()
        {
            Continent continent = GW2Api.V2.Continents.GetById(1);
            Floor floor = continent.Floors[2].Value;
            Region region = floor.Regions["1"];
            Map map = region.Maps["26"];

            Assert.AreEqual(19456, map.ContinentRectangle.X.X);
            Assert.AreEqual(14976, map.ContinentRectangle.X.Y);
            Assert.AreEqual(21760, map.ContinentRectangle.Y.X);
            Assert.AreEqual(18176, map.ContinentRectangle.Y.Y);
            Assert.AreEqual(50, map.MaxLevel);
            Assert.AreEqual(40, map.MinLevel);
            Assert.AreEqual("Dredgehaunt Cliffs", map.Name);
            Assert.GreaterOrEqual(11, map.Objectives.Count());
            Assert.GreaterOrEqual(52, map.PointsOfInterest.Count());
            Assert.GreaterOrEqual(28, map.Sectors.Count());
            Assert.GreaterOrEqual(6, map.SkillChallenges.Count());
        }

        [Test]
        public void ShouldGetSpecificObjective()
        {
            Continent continent = GW2Api.V2.Continents.GetById(1);
            Floor floor = continent.Floors[2].Value;
            Region region = floor.Regions["1"];
            Map map = region.Maps["26"];
            Objective objective = map.Objectives["1"];

            Assert.AreEqual(19644.7m, objective.Coordinate.X);
            Assert.AreEqual(16604.2m, objective.Coordinate.Y);
            Assert.AreEqual(1, objective.Id);
            Assert.AreEqual(40, objective.Level);
            Assert.AreEqual("Assist Daphne in halting the encroaching corruption.", objective.Text);
        }

        [Test]
        public void ShouldGetSpecificPoi()
        {
            Continent continent = GW2Api.V2.Continents.GetById(1);
            Floor floor = continent.Floors[2].Value;
            Region region = floor.Regions["1"];
            Map map = region.Maps["26"];
            Poi poi = map.PointsOfInterest["554"];

            Assert.AreEqual(19889.7m, poi.Coordinate.X);
            Assert.AreEqual(16594.8m, poi.Coordinate.Y);
            Assert.AreEqual(554, poi.Id);
            Assert.AreEqual(PoiType.Landmark, poi.Type);
            Assert.AreEqual("Leaning Grade", poi.Name);
        }

        [Test]
        public void ShouldGetSpecificSector()
        {
            Continent continent = GW2Api.V2.Continents.GetById(1);
            Floor floor = continent.Floors[2].Value;
            Region region = floor.Regions["1"];
            Map map = region.Maps["26"];
            Sector sector = map.Sectors["513"];

            Assert.AreEqual(19816.0m, sector.Coordinate.X);
            Assert.AreEqual(17914.8m, sector.Coordinate.Y);
            Assert.AreEqual(513, sector.Id);
            Assert.AreEqual(50, sector.Level);
            Assert.AreEqual("Tribulation Rift", sector.Name);
        }

        [Test]
        public void ShouldGetSpecificSkillChallenge()
        {
            Continent continent = GW2Api.V2.Continents.GetById(1);
            Floor floor = continent.Floors[2].Value;
            Region region = floor.Regions["1"];
            Map map = region.Maps["26"];
            SkillChallenge skillChallange = map.SkillChallenges.First();

            Assert.AreEqual(20381.6m, skillChallange.Coordinate.X);
            Assert.AreEqual(16613.8m, skillChallange.Coordinate.Y);
        }

        [Test]
        public void ShouldGetAllTextInDifferentLanguage() 
        {
            Continent continent = GW2Api.V2.Continents.GetById(1, RequestedLanguage.De);
            Floor floor = continent.Floors[2].Value;
            Region region = floor.Regions["1"];
            Map map = region.Maps["26"];
            Sector sector = map.Sectors["513"];
            Poi poi = map.PointsOfInterest["554"];
            Objective objective = map.Objectives["1"];

            Assert.AreEqual("Zittergipfelgebirge", region.Name);
            Assert.AreEqual("Schauflerschreck-Klippen", map.Name);
            Assert.AreEqual("Helft Daphne, die sich ausbreitende Verderbnis aufzuhalten.", objective.Text);
            Assert.AreEqual("Neigungsgrad", poi.Name);
            Assert.AreEqual("Trübsalriss", sector.Name);
        }
    }
}
