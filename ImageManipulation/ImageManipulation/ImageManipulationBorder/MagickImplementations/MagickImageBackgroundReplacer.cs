using ImageMagick;
using ImageManipulation.ImageManipulationBorder.intefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageManipulation.ImageManipulationBorder.MagickImplementations
{
    class MagickImageBackgroundReplacer : ImageBackgroundReplacer
    {
        public Image ChangeBackgroundColor(Image oldImage, Color newBackgroundColor)
        {
            MagickImage magickImage = new MagickImage(oldImage.GetData());
            MagickColor magickColor = new MagickColor(newBackgroundColor.GetRed(), newBackgroundColor.GetGreen(), newBackgroundColor.GetBlue());

            magickImage.BackgroundColor = magickColor;
            magickImage.FloodFill(magickColor, new PointD(0));

            return new MagickImageImpl(magickImage);
        }
    }
}
