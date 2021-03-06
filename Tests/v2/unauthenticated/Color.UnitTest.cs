﻿using GW2CSharp;
using GW2CSharp.V2.Unauthenticated.Colors;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Tests.V2.Unauthenticated
{
    [TestFixture]
    public class ColorUnitTest
    {
        private Color skyColor;

        [SetUp]
        public void SetUp() 
        {
            skyColor = new Color(10, "Sky", new int[] { 128, 26, 26 }, null, null, null);
        }

        [Test]
        public void ShouldReturnSingleColor() 
        {
            Color actualColor = GW2Api.V2().Colors.GetById(10);

            Assert.AreEqual(skyColor.Id, actualColor.Id);
            Assert.AreEqual(skyColor.Name, actualColor.Name);
            Assert.AreEqual(skyColor.BaseRGB, actualColor.BaseRGB);
            Assert.NotNull(actualColor.Cloth);
            Assert.NotNull(actualColor.Leather);
            Assert.NotNull(actualColor.Metal);
        }

        [Test]
        public void ShouldReturnAllColors()
        {
            Dictionary<int, Lazy<Color>> allColors = GW2Api.V2().Colors.GetAll();

            Color actualColor = allColors[1].Value;

            Assert.AreEqual("Dye Remover", actualColor.Name);
            Assert.GreaterOrEqual(allColors.Count(), 480);
        }

        [Test]
        public void ShouldReturnCorrectColorsOnPage()
        {
            Color actualColor = GW2Api.V2().Colors.GetByPage(9, 1).ToList()[0];

            Assert.AreEqual(skyColor.Id, actualColor.Id);
            Assert.AreEqual(skyColor.Name, actualColor.Name);
            Assert.AreEqual(skyColor.BaseRGB, actualColor.BaseRGB);
            Assert.NotNull(actualColor.Cloth);
            Assert.NotNull(actualColor.Leather);
            Assert.NotNull(actualColor.Metal);
        }
    }
}
