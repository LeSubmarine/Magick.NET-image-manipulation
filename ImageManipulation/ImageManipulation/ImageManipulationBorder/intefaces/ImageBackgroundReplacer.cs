using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageManipulation.ImageManipulationBorder.intefaces
{
    public interface ImageBackgroundReplacer
    {
        Image ChangeBackgroundColor(Image oldImage, Color newBackgroundColor);
    }
}
