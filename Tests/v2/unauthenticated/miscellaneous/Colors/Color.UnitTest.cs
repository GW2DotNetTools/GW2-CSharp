using GW2CSharp;
using GW2CSharp.V2.Unauthenticated.Miscellaneous.Colors;
using NUnit.Framework;
using System.Linq;

namespace Tests.V2.Unauthenticated.Miscellaneous.Colors
{
    [TestFixture]
    public class ColorUnitTest
    {
        [Test]
        public void ReturnsSingleColor() 
        {
            Color expectedColor = new Color(10, "Sky", new int []{ 128,26,26}, null, null, null);
            Color actualColor = GW2Api.Colors.GetColorById(10);

            Assert.AreEqual(expectedColor.Id, actualColor.Id);
            Assert.AreEqual(expectedColor.Name, actualColor.Name);
            Assert.AreEqual(expectedColor.BaseRGB, actualColor.BaseRGB);
            Assert.NotNull(actualColor.Cloth);
            Assert.NotNull(actualColor.Leather);
            Assert.NotNull(actualColor.Metal);
        }

        [Test]
        public void ReturnsAllColors()
        {
            var allColors = GW2Api.Colors.GetAllColors();

            Color actualColor = allColors[1].Value;

            Assert.AreEqual("Dye Remover", actualColor.Name);
            Assert.AreEqual(480, allColors.Count());
        }
    }
}
