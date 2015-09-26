using GW2CSharp;
using GW2CSharp.Enums;
using GW2CSharp.V2.Unauthenticated.Items.Skins;
using GW2CSharp.V2.Unauthenticated.Items.Skins.Enums;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace Tests.V2.Unauthenticated
{
    [TestFixture]
    public class SkinUnitTest
    {
        [Test]
        public void ShouldReturnAllSkins() 
        {
            var skins = GW2Api.V2.Skins.GetAllSkins();
            Assert.GreaterOrEqual(skins.Count(), 3532);
        }

        [Test]
        public void ShouldReturnAllSkinsAndLoadOnlyOne()
        {
            var skins = GW2Api.V2.Skins.GetAllSkins();
            Assert.AreEqual("Adept Helm", skins[263].Value.Name);
        }

        [TestCase(RequestedLanguage.De, "Kettenpanzer-Beinkleid")]
        [TestCase(RequestedLanguage.En, "Chainmail Leggings")]
        [TestCase(RequestedLanguage.Es, "Calzas de malla de cadena")]
        [TestCase(RequestedLanguage.Fr, "Jambières à chaînes")]
        public void ShouldReturnSpecificSkinInLanguage(RequestedLanguage requestedLanguage, string expectedName)
        {
            Skin skin = GW2Api.V2.Skins.GetById(1, requestedLanguage);
            Assert.AreEqual(expectedName, skin.Name);
        }

        [Test]
        public void ShouldReturnSpecificSkinWithDescription()
        {
            const string expectedDescription = "<c=@flavor>After spending so much time cultivating this powerful vine through the generations, it's hard to not feel an attachment to it. Your beloved pet almost cuddles you in its tendrils. Clearly it feels a similar attachment.</c>";
            Skin skin = GW2Api.V2.Skins.GetById(5544);
            Assert.AreEqual(expectedDescription, skin.Description);
        }

        [Test]
        public void ShouldReturnItemWithRestrictions() 
        {
            Skin skin = GW2Api.V2.Skins.GetById(263);
            Assert.AreEqual(new List<Restriction> { Restriction.Asura }, skin.Restrictions);
        }

        [Test]
        public void ShouldReturnArmorSlot()
        {
            Skin skin = GW2Api.V2.Skins.GetById(263);
            Assert.AreEqual(Armor.Helm, skin.Details.Armor);
        }

        [Test]
        public void ShouldReturnFlag()
        {
            Skin skin = GW2Api.V2.Skins.GetById(5000);
            Assert.AreEqual(new List<SkinFlag> { SkinFlag.ShowInWardrobe }, skin.Flags);
        }

        [Test]
        public void ShouldReturnWeightClass()
        {
            Skin skin = GW2Api.V2.Skins.GetById(263);
            Assert.AreEqual(Weight.Light, skin.Details.Weight);
        }

        [Test]
        public void ShouldReturnWeapon()
        {
            Skin skin = GW2Api.V2.Skins.GetById(5000);
            Assert.AreEqual(Weapon.ShortBow, skin.Details.Weapon);
        }

        [Test]
        public void ShouldReturnDamageType()
        {
            Skin skin = GW2Api.V2.Skins.GetById(5000);
            Assert.AreEqual(DamageType.Physical, skin.Details.DamageType);
        }

        [Test]
        public void CanRenderBitmap()
        {
            Skin skin = GW2Api.V2.Skins.GetById(5000);
            Assert.NotNull(skin.GetIcon());
        }
    }
}
