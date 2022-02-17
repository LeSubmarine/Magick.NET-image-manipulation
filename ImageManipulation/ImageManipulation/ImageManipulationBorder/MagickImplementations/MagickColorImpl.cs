using ImageMagick;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageManipulation.ImageManipulationBorder.MagickImplementations
{
    class MagickColorImpl : Color
    {
        IMagickColor<ushort> _magickColor;
        public MagickColorImpl(IMagickColor<ushort> color)
        {
            _magickColor = new MagickColor(color);
        }
        public MagickColorImpl(ushort red, ushort green, ushort blue)
        {
            _magickColor = new MagickColor(red, green, blue);
        }

        public ushort GetRed()
        {
            return _magickColor.R;
        }

        public ushort GetGreen()
        {
            return _magickColor.G;
        }

        public ushort GetBlue()
        {
            return _magickColor.B;
        }
    }
}
