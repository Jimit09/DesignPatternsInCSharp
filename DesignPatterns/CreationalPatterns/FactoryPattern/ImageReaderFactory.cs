using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.FactoryPattern
{
    public class ImageReaderFactory
    {
        public static ImageReader GetImageReader(ImageReaderType imageReaderType)
        {
            switch (imageReaderType)
            {
                case ImageReaderType.GifReader:
                    return new GifImageReader();
                case ImageReaderType.JpegReader:
                    return new JpegReader();
                default:
                    return null;
            }
        }
    }
}
