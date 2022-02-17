using ImageManipulation.ImageManipulationBorder.intefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageManipulation.ImageManipulationBorder.MagickImplementations
{
    public interface ImageFilePersistance
    {
        void SaveImage(Image image, string imageName);
        Image GetImage(string imageName);
    }
}
