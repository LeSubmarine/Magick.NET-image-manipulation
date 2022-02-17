using ImageMagick;
using ImageManipulation.ImageManipulationBorder.intefaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageManipulation.ImageManipulationBorder.MagickImplementations
{
    class MagickImageFilePersistanceImpl : ImageFilePersistance
    {
        private const string Root = @"..\..\";
        private const string ImageFolder = Root + @"Images\";

        public Image GetImage(string imageName)
        {
            string imagePath = Path.Combine(ImageFolder, imageName);
            MagickImage magickImage = new MagickImage(imagePath);
            return new MagickImageImpl(magickImage.ToByteArray());
        }

        public void SaveImage(Image image, string imageName)
        {
            MagickImage magickImage = new MagickImage(image.GetData());
            string imagePath = Path.Combine(ImageFolder, imageName);
            magickImage.Write(imagePath);
        }
    }
}
