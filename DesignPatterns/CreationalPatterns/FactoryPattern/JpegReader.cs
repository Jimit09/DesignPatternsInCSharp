using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.FactoryPattern
{
    public class JpegReader : ImageReader
    {
        private string decodedImageType;
        public JpegReader()
        {
            decodedImageType = "jpeg";
        }
        public DecodedImage GetDecodedImage(string image)
        {
            return new DecodedImage(image, decodedImageType); ;
        }
    }
}
