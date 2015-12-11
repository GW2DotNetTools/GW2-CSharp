using GW2CSharp;
using GW2CSharp.V2.Unauthenticated.Minis;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Tests.V2.Unauthenticated
{
    [TestFixture]
    public class MinisUnitTest
    {
        [Test]
        public void ShouldLoadCorrectMini() 
        {
            Mini actualMini = GW2Api.V2().Minis.Get(355);

            Assert.AreEqual(355, actualMini.Id);
            Assert.AreEqual(76670, actualMini.ItemId);
            Assert.AreEqual("Mini Mister Mittens", actualMini.Name);
            Assert.AreEqual(0, actualMini.Order);
            Assert.AreEqual("Combine 3 Mini Professor Mews in the Mystic Forge with a pile of crystalline dust, an obsidian shard, and an amber quantic dipole (dropped by creatures in scale 1–20 fractals).", actualMini.Unlock);
        }

        [Test]
        public void ShouldReturnAllMinis()
        {
            Dictionary<int, Lazy<Mini>> allMinis = GW2Api.V2().Minis.GetAll();

            Mini actualMini = allMinis[15].Value;

            Assert.AreEqual("Mini Svanir Icebreaker", actualMini.Name);
        }
    }
}
