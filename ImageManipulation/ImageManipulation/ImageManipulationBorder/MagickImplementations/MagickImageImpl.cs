using ImageMagick;
using ImageManipulation.ImageManipulationBorder.intefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageManipulation.ImageManipulationBorder.MagickImplementations
{
    class MagickImageImpl : Image
    {
        MagickImage _magickImage;

        public MagickImageImpl(byte[] data)
        {
            _magickImage = new MagickImage(data);
            _magickImage.Format = MagickFormat.Jpg;
        }

        public MagickImageImpl(IMagickImage<ushort> data)
        {
            _magickImage = new MagickImage(data);
            _magickImage.Format = MagickFormat.Jpg;
        }

        public int GetWidth()
        {
            return _magickImage.Width;
        }
        public int GetHeight()
        {
            return _magickImage.Height;
        }
        public byte[] GetData()
        {
            return _magickImage.ToByteArray();
        }
    }
}
