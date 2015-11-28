using GW2CSharp.Services;
using System.Drawing;

namespace GW2CSharp
{
    /// <summary>
    /// Returns Images.
    /// </summary>
    public class Imageable
    {
        private string icon;

        /// <summary>
        /// Initialization of a new Imageable object.
        /// </summary>
        /// <param name="icon">The icon path.</param>
        public Imageable(string icon)
        {
            this.icon = icon;
        }

        /// <summary>
        /// Returns the icon as a Bitmap
        /// </summary>
        /// <returns>Icon as a Bitmap</returns>
        public Bitmap GetImage()
        {
            return RenderService.GetImage(icon);
        }
    }
}
