using GW2CSharp.V1.Services;
using GW2CSharp.V1.Services.Enums;
using NUnit.Framework;
using System.Drawing;

namespace Tests.V1.Services
{
    [TestFixture]
    public class RenderServiceUnitTest
    {
        [Test]
        public void CanRenderBitmap()
        {
            Bitmap bitmap = RenderService.GetImage("943538394A94A491C8632FBEF6203C2013443555", "102478", FileFormat.png);

            Assert.NotNull(bitmap);
        }
    }
}
