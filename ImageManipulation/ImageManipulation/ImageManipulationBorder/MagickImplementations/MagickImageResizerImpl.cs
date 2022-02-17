using ImageMagick;
using ImageManipulation.ImageManipulationBorder.intefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageManipulation.ImageManipulationBorder.MagickImplementations
{
    class MagickImageResizerImpl : ImageResizer
    {
        public Image ResizeImage(Image oldImage, int newWidth, int newHeight)
        {
            MagickImageCollection totalImage = new MagickImageCollection();
            IMagickImage<ushort> magickImage = new MagickImage(oldImage.GetData());
            IMagickImage<ushort> backGround = new MagickImage(new MagickColor(magickImage.BorderColor), newWidth, newHeight);
            magickImage.Resize(newWidth, newHeight);

            totalImage.Add(backGround);
            totalImage.Add(magickImage);
            IMagickImage<ushort> combinedImage = totalImage.Flatten();

            return new MagickImageImpl(combinedImage);
        }
    }
}
