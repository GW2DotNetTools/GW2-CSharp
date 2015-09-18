using GW2CSharp;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class GW2ApiUnitTest
    {
        [Test]
        public void ShouldReturnV1Endpoint()
        {
            Assert.NotNull(GW2Api.V1);
        }

        [Test]
        public void ShouldReturnV2Endpoint()
        {
            Assert.NotNull(GW2Api.V2);
        }

        [Test]
        public void ShouldReturnCorrectBuildId() 
        {
            int id = GW2Api.V2.GetBuildId;
            Assert.Greater(id, 0);
        }
    }
}
