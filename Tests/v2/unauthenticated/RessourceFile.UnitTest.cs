using GW2CSharp;
using GW2CSharp.V2.Unauthenticated.Files;
using NUnit.Framework;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Tests.V2.Unauthenticated
{
    [TestFixture]
    public class RessourceFileUnitTest
    {
        [Test]
        public void ShouldReturnAllRessourceFiles() 
        {
            IEnumerable<RessourceFile> ressourceFiles = GW2Api.V2().RessourceFiles.GetAll();

            Assert.GreaterOrEqual(ressourceFiles.Count(), 84);
        }

        [Test]
        public void ShouldReturnMultipleRessourceFiles()
        {
            IEnumerable<RessourceFile> ressourceFiles = GW2Api.V2().RessourceFiles.GetMultiple("map_heropoint", "wvw_battles_hollow_green");

            Assert.AreEqual(2, ressourceFiles.Count());
        }

        [Test]
        public void ShouldReturnSingleRessourceFile()
        {
            RessourceFile ressourceFile = GW2Api.V2().RessourceFiles.Get("map_heropoint");

            Assert.AreEqual("https://render.guildwars2.com/file/B4EC6BB3FDBC42557C3CAE0CAA9E57EBF9E462E3/156626.png", ressourceFile.Icon);
        }

        [Test]
        public void ShouldReturnCorrectImage()
        {
            Bitmap image = GW2Api.V2().RessourceFiles.Get("map_heropoint").GetImage();

            Assert.NotNull(image);
        }
    }
}
