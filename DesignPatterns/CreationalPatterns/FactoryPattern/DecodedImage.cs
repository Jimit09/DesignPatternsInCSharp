using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.FactoryPattern
{
    public class DecodedImage
    {
        string image;
        string decodedType;

        public DecodedImage(string image, string decodedType)
        {
            this.image = image;
            this.decodedType = decodedType;
        }

        public override string ToString()
        {
            return image + " : is decoded using type:" + decodedType;
        }
    }
}
