using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageManipulation.ImageManipulationBorder.intefaces
{
    public interface ImageResizer
    {
        Image ResizeImage(Image oldImage, int newWidth, int newHeight);
    }
}
