using GW2CSharp;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class GW2ApiUnitTest
    {
        [Test]
        public void ReturnsCorrectBuildId() 
        {
            int id = GW2Api.V2.GetBuildId;
            Assert.Greater(id, 0);
        }
    }
}
