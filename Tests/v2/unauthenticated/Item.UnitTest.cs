using GW2CSharp;
using GW2CSharp.Enums;
using GW2CSharp.V2.Unauthenticated.Items;
using GW2CSharp.V2.Unauthenticated.Items.Enums;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Tests.V2.Unauthenticated
{
    [TestFixture]
    public class ItemUnitTest
    {
        [Test]
        public void ShouldLoadCorrectItem() 
        {
            Item actualItem = GW2Api.V2.Items.GetById(28864);
            Assert.That(actualItem.Skin != null);
            Assert.AreEqual("Berserker's Greatsword", actualItem.Name);
            Assert.AreEqual(ItemType.Weapon, actualItem.Type);
            Assert.AreEqual(64, actualItem.Level);
            Assert.AreEqual(Rarity.Basic, actualItem.Rarity);
            Assert.AreEqual(41, actualItem.VendorValue);
            Assert.GreaterOrEqual(actualItem.GameTypes.Count(), 1);
            Assert.AreEqual(28864, actualItem.Id);
            Assert.AreEqual("[&AgHAcAAA]", actualItem.ChatLink);
        }
        
        [Test]
        public void ShouldReturnAllItems()
        {
            Dictionary<int, Lazy<Item>> allItems = GW2Api.V2.Items.GetAll();

            Item actualItem = allItems[15].Value;

            Assert.AreEqual("Abomination Hammer", actualItem.Name);
            Assert.GreaterOrEqual(allItems.Count(), 40000);
        }
    }
}
