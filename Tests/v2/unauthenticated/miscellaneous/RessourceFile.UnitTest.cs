using GW2CSharp;
using GW2CSharp.V2.Unauthenticated.Miscellaneous.Files;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.V2.Unauthenticated.Miscellaneous
{
    [TestFixture]
    public class RessourceFileUnitTest
    {
        [Test]
        public void ShouldReturnAllRessourceFiles() 
        {
            IEnumerable<RessourceFile> ressourceFiles = GW2Api.V2.RessourceFiles.GetAllRessourceFiles();

            Assert.GreaterOrEqual(84, ressourceFiles.Count());
        }

        [Test]
        public void ShouldReturnMultipleRessourceFiles()
        {
            IEnumerable<RessourceFile> ressourceFiles = GW2Api.V2.RessourceFiles.GetMultipleRessourceFiles("map_heropoint", "wvw_battles_hollow_green");

            Assert.AreEqual(2, ressourceFiles.Count());
        }

        [Test]
        public void ShouldReturnSingleRessourceFile()
        {
            RessourceFile ressourceFile = GW2Api.V2.RessourceFiles.GetRessourceFile("map_heropoint");

            Assert.AreEqual("https://render.guildwars2.com/file/B4EC6BB3FDBC42557C3CAE0CAA9E57EBF9E462E3/156626.png", ressourceFile.Icon);
        }

        [Test]
        public void ShouldReturnCorrectImage()
        {
            Bitmap image = GW2Api.V2.RessourceFiles.GetRessourceFile("map_heropoint").GetImage();

            Assert.NotNull(image);
        }
    }
}
