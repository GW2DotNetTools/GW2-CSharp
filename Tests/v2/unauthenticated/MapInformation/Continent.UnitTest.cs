using GW2CSharp;
using GW2CSharp.V2.Unauthenticated.Continents;
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
        //todo: fix language passing through
        //cleanup useless tests

        //https://api.guildwars2.com/v2/continents?ids=all
        //https://api.guildwars2.com/v2/continents/1
        //https://api.guildwars2.com/v2/continents/1/floors
        //https://api.guildwars2.com/v2/continents/1/floors/1
        //https://api.guildwars2.com/v2/continents/1/floors/1/regions
        //https://api.guildwars2.com/v2/continents/1/floors/1/regions/1
        //https://api.guildwars2.com/v2/continents/1/floors/1/regions/1/maps
        //https://api.guildwars2.com/v2/continents/1/floors/1/regions/1/maps/26
        //https://api.guildwars2.com/v2/continents/1/floors/1/regions/1/maps/26/sectors
        //https://api.guildwars2.com/v2/continents/1/floors/1/regions/1/maps/26/pois
        //https://api.guildwars2.com/v2/continents/1/floors/1/regions/1/maps/26/tasks/1 

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
            var a = continent.Floors[2].Value;
        }

        [Test]
        public void ShouldReturnMap()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            Map map = ApiBase.DeserializeObject<Map>("https://api.guildwars2.com/v2/continents/1/floors/1/regions/1/maps/26");
            sw.Stop();
            var a = sw.Elapsed;
        }

        [Test]
        public void ShouldReturnObjective() 
        {
            Objective objective = ApiBase.DeserializeObject<Objective>("https://api.guildwars2.com/v2/continents/1/floors/1/regions/1/maps/26/tasks/1");
            
            Assert.AreEqual(1, objective.Id);
            Assert.AreEqual(40, objective.Level);
            Assert.AreEqual("Assist Daphne in halting the encroaching corruption.", objective.Text);
            Assert.AreEqual(19644.7d, objective.Coordinate.X);
            Assert.AreEqual(16604.2d, objective.Coordinate.Y);
        }

        [Test]
        public void ShouldReturnPoi() 
        {
            Poi poi = ApiBase.DeserializeObject<Poi>("https://api.guildwars2.com/v2/continents/1/floors/1/regions/1/maps/26/pois/555");

            Assert.AreEqual("Fridgardr Lodge", poi.Name);
            Assert.AreEqual("landmark", poi.Type);
            Assert.AreEqual(20839.2d, poi.Coordinate.X);
            Assert.AreEqual(17357.9, poi.Coordinate.Y);
            Assert.AreEqual(555, poi.Id);
        }
    }
}
