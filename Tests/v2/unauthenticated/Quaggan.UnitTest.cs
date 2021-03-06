﻿using GW2CSharp;
using GW2CSharp.V2.Unauthenticated.Quaggans;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Tests.V2.Unauthenticated
{
    [TestFixture]
    public class QuagganUnitTest
    {
        [Test]
        public void ShouldReturnAllQuaggans()
        {
            Dictionary<string, Lazy<Quaggan>> quaggans = GW2Api.V2().Quaggans.GetAll();

            Assert.GreaterOrEqual(quaggans.Count(), 35);
        }

        [Test]
        public void ShouldReturnSpecificQuagganFromList()
        {
            Dictionary<string, Lazy<Quaggan>> quaggans = GW2Api.V2().Quaggans.GetAll();
            Quaggan cryQuaggan = quaggans["cry"].Value;

            Assert.AreEqual("https://static.staticwars.com/quaggans/cry.jpg", cryQuaggan.Url);
        }

        [Test]
        public void ShouldReturnSingleQuaggan()
        {
            Quaggan cakeQuaggan = GW2Api.V2().Quaggans.Get("cake");

            Assert.AreEqual("https://static.staticwars.com/quaggans/cake.jpg", cakeQuaggan.Url);
        }

        [Test]
        public void ShouldReturnCorrectBitmap()
        {
            Bitmap cakeQuaggan = GW2Api.V2().Quaggans.Get("cake").GetImage();
            Assert.NotNull(cakeQuaggan);
        }
    }
}
